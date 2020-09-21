using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;


namespace Dal
{
    /// <summary>
    /// IBusinessObjectHandler intrerface
    /// </summary>
    public interface IBusinessObjectHandler<T>
    {
        /// <summary>
        /// Get BusinessEntity By Id
        /// </summary>
        /// <param name="id">BusinessEntity Id</param>
        /// <returns>BusinessEntity</returns>
        T GetBusinessEntityById(int id);

        /// <summary>
        /// Create BusinessEntity data
        /// </summary>
        /// <param name="entity">BusinessEntity</param>
        /// <returns>BusinessEntity</returns>
        T CreateBusinessEntity(T entity);

        /// <summary>
        /// Update BusinessEntity data
        /// </summary>
        /// <param name="entity">BusinessEntity</param>
        /// <returns>BusinessEntity</returns>
        T UpdateBusinessEntity(T entity);

        /// <summary>
        /// Delete BusinessEntity data
        /// </summary>
        /// <param name="entity">BusinessEntity</param>
        /// <returns>BusinessEntityes deleted : basicaly 0 or 1</returns>
        int DeleteBusinessEntity(T entity);
    }

    /// <summary>
    /// Common implementation for DataObject handler. Uses Controller pattern.
    /// This class used in order to enclose DB specific functionality and allow
    /// the user to manipulate with DataObject while it manages it persistent state.
    /// </summary>
    public abstract class BusinessObjectHandler<T> : IBusinessObjectHandler<T>
    {
        /// <summary>
        /// DBHelper member for DataObject<->DB manipulation
        /// </summary>
        protected DBHelper DBHelper {private set; get;}

        /// <summary>
        /// Constructor allways uses the DBHelper initialized by the business layer
        /// </summary>
        /// <param name="dbHelper">dbHelper</param>
        public BusinessObjectHandler(DBHelper dbHelper)
        {
            DBHelper = dbHelper;
        }

        /// <summary>
        /// Get BusinessEntity By Id. 
        /// Executes the given query. Convert DB result to single data object.
        /// </summary>
        /// <param name="id">BusinessEntity Id</param>
        /// <returns>BusinessEntity</returns>
        public T GetBusinessEntityById(int id)
        {
           DbDataReader reader = null;
           try
            {
                DbParameter[] parameters = CreateDbParameter(id);
                String query = GetSelectByIdQuery();
                reader = DBHelper.ExecuteReader(query, parameters);
                T entity = BuildEntitySingle(reader);
                return entity;

            }
            finally
            {
               // after Business object created close reader. 
               DBHelper.Close(reader);
            }
        }

        /// <summary>
        /// Get BusinessEntity By Ids
        /// Executes the given query. Convert DB result to data objects.
        /// </summary>
        /// <param name="id">BusinessEntity Id</param>
        /// <returns>BusinessEntity</returns>
        public List<T> GetBusinessEntitiesByIDs(List<int> ids)
        {

            DbDataReader reader = null;
            try
            {
                DbParameter[] parameters = new DbParameter[0];
                String query = GetSelectByIdsQuery(ids);
                reader = DBHelper.ExecuteReader(query, parameters);
                List<T> entities = BuildEntitiesList(reader);
                return entities;
            }
            finally
            {
                // after Business object created close reader. 
                DBHelper.Close(reader);
            }
        }

        /// <summary>
        /// Build Select DO by ID query.
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        protected virtual string GetSelectByIdsQuery(List<int> ids)
        {
            StringBuilder sb = new StringBuilder("SELECT ");
            sb.Append(GetFields());
            sb.Append(" FROM ");
            sb.Append(GetTableName());
            sb.Append(" WHERE [ID] in (");

            foreach (int item in ids)
            {
                sb.Append(item.ToString());
                sb.Append(",");
            }
            
            sb.Append("0) ; ");

            return sb.ToString();
        }

        /// <summary>
        /// Build single Data object from DB query result 
        /// </summary>
        /// <param name="reader">reader</param>
        /// <returns>BusinesEntity</returns>
        private T BuildEntitySingle(DbDataReader reader)
        {
            T entity = default(T);
            if (reader.Read())
            {
                entity = BuildEntity(reader);
            }
            return entity;
        }

        /// <summary>
        /// Get BusinessEntity By some sql query , provided by the user.
        /// Executes the given query. Convert DB result to data objects.
        /// </summary>
        /// <param name="query">query</param>
        /// <param name="parameters">parameters</param>
        /// <returns>BusinessEntity list</returns>
        public List<T> GetBusinessEntitiesByCriteria(String query, DbParameter[] parameters)
        {
            DbDataReader reader = null;
            try
            {
                reader = DBHelper.ExecuteReader(query, parameters);
                List<T> entities = BuildEntitiesList(reader);
                return entities;

            }
            finally
            {
                // after Business object created close reader. 
                DBHelper.Close(reader);
            }
        }

        /// <summary>
        /// Get single BusinessEntity By some sql query , provided by the user.
        /// Executes the given query. Convert DB result to data objects.
        /// </summary>
        /// <param name="query">query</param>
        /// <param name="parameters">parameters</param>
        /// <returns>BusinessEntity</returns>
        public T GetSingleBusinessEntityByCriteria(String query, DbParameter[] parameters)
        {

            DbDataReader reader = null;
            try
            {
                reader = DBHelper.ExecuteReader(query, parameters);
                List<T> entities = BuildEntitiesList(reader);
                if (entities.Count > 0)
                    return entities[0];
                else
                    return default(T);

            }
            finally
            {
                // after Business object created close reader. 
                DBHelper.Close(reader);
            }
        }

        /// <summary>
        /// Build Data object from DB query result 
        /// </summary>
        /// <param name="reader">reader</param>
        /// <returns>BusinesEntity</returns>
        private List<T> BuildEntitiesList(DbDataReader reader)
        {

            List<T> entities = new List<T>();
            while (reader.Read())
            {
                T entity = BuildEntity(reader);
                entities.Add(entity);
            }

            return entities;
        }

        /// <summary>
        /// Update BusinessEntity data
        /// </summary>
        /// <param name="entity">BusinessEntity</param>
        /// <returns>BusinessEntity</returns>
        public T UpdateBusinessEntity(T entity)
        {
            DbParameter[] parameters = CreateDbParameter(entity);
            String query = GetUpdateQuery(entity);
            int result = DBHelper.ExecuteNonQuery(query, parameters);
            
            return entity;
        }

        /// <summary>
        /// Delete BusinessEntity data from DB. This functionality 
        /// does not used but in some specific cases. There is no real delete
        /// in IT systems.
        /// </summary>
        /// <param name="entity">BusinessEntity</param>
        /// <returns>BusinessEntityes deleted : basicaly 0 or 1</returns>
        public int DeleteBusinessEntityReal(T entity)
        {
            DbParameter[] parameters = CreateDbParameter((entity as BusinesEntity).ID);
            String query = GetDeleteQuery(entity);
            int result = DBHelper.ExecuteNonQuery(query, parameters);
            return result;
        }

        /// <summary>
        /// Delete BusinessEntity data.  Baicly it uses logical delete where 
        /// status field of Business object is set to delete value insteed delete it from DB. 
        /// </summary>
        /// <param name="entity">BusinessEntity</param>
        /// <returns>BusinessEntityes deleted : basicaly 0 or 1</returns>
        public int DeleteBusinessEntity(T entity)
        {
            /*if (entity is StatusBusinesEntity)
            {
                StatusBusinesEntity dataObject = (StatusBusinesEntity)entity;
                dataObject.Status = BEStatus.Deleted;
                UpdateBusinessEntity(dataObject);
            }
            else
            {*/
                DeleteBusinessEntityReal(entity);
            //}
            return 1;
        }

        /// <summary>
        /// Create BusinessEntity data
        /// </summary>
        /// <param name="entity">BusinessEntity</param>
        /// <returns>BusinessEntity</returns>
        public T CreateBusinessEntity(T entity)
        {
            DbParameter[] parameters = CreateDbParameter(entity);
            String query = GetCreateQuery(entity);
            int result = DBHelper.ExecuteNonQuery(query, parameters);
            return entity;
        }

        /// <summary>
        /// Create common used id parameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        protected DbParameter[] CreateDbParameter(int id)
        {
            DbParameter[] parameters = new DbParameter[1];
            parameters[0] = DBHelper.GetParameter("@ID", id);
            return parameters;
        }

        /// <summary>
        /// Get dataobject DB fields
        /// </summary>
        /// <returns>dataobject DB fields</returns>
        protected abstract String GetFields();

        /// <summary>
        /// Get table name associated with DO.
        /// </summary>
        /// <returns></returns>
        protected abstract String GetTableName();

        /// <summary>
        /// Build BuildEntity from DB result
        /// </summary>
        /// <param name="reader">DB result</param>
        /// <returns>BuildEntity</returns>
        protected abstract T BuildEntity(DbDataReader reader);

        /// <summary>
        /// get creation query for DO.
        /// </summary>
        /// <param name="entity">DO</param>
        /// <returns>query string</returns>
        protected abstract string GetCreateQuery(T entity);

        /// <summary>
        /// get update query for DO.
        /// </summary>
        /// <param name="entity">DO</param>
        /// <returns>query string</returns>
        protected abstract string GetUpdateQuery(T entity);

        /// <summary>
        /// get delete query for DO.
        /// </summary>
        /// <param name="entity">DO</param>
        /// <returns>query string</returns>
        protected abstract string GetDeleteQuery(T entity);

        /// <summary>
        /// get select by ID query for DO.
        /// </summary>
        /// <returns>query string</returns>
        protected abstract string GetSelectByIdQuery();

        /// <summary>
        /// convert BusinesEntity to parameters
        /// </summary>
        /// <param name="entity">entity</param>
        /// <returns>parameter list</returns>
        protected abstract DbParameter[] CreateDbParameter(T entity);

        /// <summary>
        /// Truncate millisecond field in DateTime.
        /// </summary>
        /// <param name="time">time</param>
        /// <returns>truncated time</returns>
        public DateTime TruncateDateTime(DateTime time)
        {
            DateTime outTime = new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second);
            return outTime;
        }


     }

}
