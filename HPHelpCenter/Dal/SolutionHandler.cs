using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using HPHelpCenter;
using HPHelpCenter.Models;

namespace Dal
{
        public class SolutionHandler : BusinessObjectHandler<Solution>
        {
            public SolutionHandler(DBHelper dbHelper) : base(dbHelper) { }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override String GetFields()
            {
                return "[ID], [SubDate], [Content], [UserID], [Status], [IssueID], [IsDeleted]";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override String GetTableName()
            {
                return " [Solution] ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override Solution BuildEntity(DbDataReader reader)
            {
                Solution solution = new Solution();
                solution.ID = reader.GetInt32(0);
                solution.SubDate = reader.GetDateTime(1);
                solution.Content = reader.GetString(2);
                solution.UserID = reader.GetInt32(3);
                solution.Status = reader.GetBoolean(4);
                solution.IsuueID = reader.GetInt32(5);
                solution.IsDeleted = reader.GetBoolean(6);
                return solution;
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetCreateQuery(Solution entity)
            {
                return "INSERT INTO [Solution] (" +
                    GetFields() +
                    ") VALUES (@ID, @SubDate, @Content, @UserID, @Status, @IssueID, @IsDeleted)";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetUpdateQuery(Solution entity)
            {
                return "UPDATE [Solution] SET  [ID]=@ID , [SubDate]=@SubDate, [Content]=@Content, [UserID]=@UserID, [Status]=@Status, [IssueID]=@IssueID, [IsDeleted] = @IsDeleted WHERE [ID]=@ID";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetDeleteQuery(Solution entity)
            {
                return "DELETE [Solution] WHERE [ID] = @ID ";
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// @ID, @SubDate, @Content, @UserID, @Status, @IssueID
            /// </summary>
            protected override DbParameter[] CreateDbParameter(Solution solution)
            {
                //UserData user = (UserData)entity;
                DbParameter[] parameters = new DbParameter[7];
                parameters[0] = DBHelper.GetParameter("@ID", solution.ID);
                parameters[1] = DBHelper.GetParameter("@SubDate", TruncateDateTime(solution.SubDate));
                parameters[2] = DBHelper.GetParameter("@Content", solution.Content);
                parameters[3] = DBHelper.GetParameter("@UserID", solution.UserID);
                parameters[4] = DBHelper.GetParameter("@Status", solution.Status);
                parameters[5] = DBHelper.GetParameter("@IssueID", solution.IsuueID);
                parameters[6] = DBHelper.GetParameter("@IsDeleted", solution.IsDeleted);
                return parameters;
            }

            /// <summary>
            /// see BusinessObjectHandler handler comments
            /// </summary>
            protected override string GetSelectByIdQuery()
            {
                return "SELECT " + GetFields() + " FROM [Solution] WHERE [ID] = @ID";
            }

            internal List<Solution> GetSolutionsById(int issueID)
            {
                String query = "SELECT * FROM [Solution] WHERE [IssueID] = " + issueID + " order by [Status] asc, [SubDate] desc";
                DbParameter[] parameters = new DbParameter[0];
                List<Solution> data = GetBusinessEntitiesByCriteria(query, parameters);
                return data;
            }
        }
    
}
