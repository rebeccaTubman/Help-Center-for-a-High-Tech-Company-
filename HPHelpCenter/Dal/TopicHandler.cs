using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HPHelpCenter.Models;
using Dal;
using System.Data.Common;

namespace HPHelpCenter.Dal
{
    /// <summary>
    /// The topic DO  handler implementation.
    public class TopicHandler : BusinessObjectHandler<Topic>
    {
        public TopicHandler(DBHelper dbHelper) : base(dbHelper) { }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override String GetFields()
        {
            return "[ID], [TopicName], [IsDeleted] ";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override String GetTableName()
        {
            return " [Topic] ";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override Topic BuildEntity(DbDataReader reader)
        {
            Topic topic = new Topic(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetBoolean(2)
                );
            return topic;
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetCreateQuery(Topic entity)
        {
            return "INSERT INTO [Topic] (" +
                GetFields() +
                ") VALUES (@ID, @TopicName, @IsDeleted)";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetUpdateQuery(Topic entity)
        {
            return "UPDATE [Topic] SET [ID]=@ID, [TopicName]=@TopicName, [IsDeleted]=@IsDeleted WHERE [ID]=@ID";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetDeleteQuery(Topic entity)
        {
            return "DELETE [Topic] WHERE [ID] = @ID ";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetSelectByIdQuery()
        {
            return "SELECT " + GetFields() + " FROM [Topic] WHERE [ID] = @ID ";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        ///       /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override DbParameter[] CreateDbParameter(Topic topic)
        {
            //UserData user = (UserData)entity;
            DbParameter[] parameters = new DbParameter[3];
            parameters[0] = DBHelper.GetParameter("@ID", topic.ID);
            parameters[1] = DBHelper.GetParameter("@TopicName", topic.TopicName);
            parameters[2] = DBHelper.GetParameter("@IsDeleted", topic.IsDeleted);
            return parameters;
        }

        internal List<Topic> GetAllTopics()
        {
            string query = "select "+ GetFields()+" from [TOPIC] WHERE [IsDeleted] = 0";
            DbParameter[] parameters = new DbParameter[0];
            List<Topic> datas = GetBusinessEntitiesByCriteria(query, parameters);
            return datas;
        }

        internal List<Topic> GetTopics(string keyWord)
        {
            String query = "SELECT " + GetFields() + " FROM [Topic] WHERE [TopicName] like '%" + keyWord + "%' AND [IsDeleted] = 0";
            DbParameter[] parameters = new DbParameter[0];
            List<Topic> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }
    }
}