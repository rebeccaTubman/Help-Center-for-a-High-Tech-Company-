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
    public class IssueHandler: BusinessObjectHandler<Issue>
    {
        
        public IssueHandler(DBHelper dbHelper) : base(dbHelper) { }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override String GetFields()
        {
            return "[ID], [Title], [Content], [SubDate], [Status], [UserID], [TopicID], [TecOrProg], [IsDeleted]";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override String GetTableName()
        {
            return " [Issue] ";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// [ID], [Title], [Content], [SubDate], [Status], [UserID], [TopicID], [TecOrProg]
        /// </summary>
        protected override Issue BuildEntity(DbDataReader reader)
        {
            Issue issue = new Issue();
            issue.ID = reader.GetInt32(0);
            issue.Title = reader.GetString(1);
            issue.Content = reader.GetString(2);
            issue.SubDate = TruncateDateTime(reader.GetDateTime(3));
            issue.Status = reader.GetBoolean(4);
            issue.UserID = reader.GetInt32(5);
            issue.TopicID = reader.GetInt32(6);
            issue.TecOrProg = reader.GetBoolean(7) ? Issue.IssueType.Programing : Issue.IssueType.Tecnical;
            //(Issue.IssueType)Enum.Parse(typeof(Issue.IssueType), reader.GetString(8), true);
            issue.IsDeleted = reader.GetBoolean(8);

            return issue;
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// [ID], [Title], [Content], [SubDate], [Status], [UserID], [TopicID], [TecOrProg], IsDeleted
        /// </summary>
        protected override string GetCreateQuery(Issue entity)
        {
            return "INSERT INTO [Issue] (" +
                GetFields() +
                ") VALUES (@ID, @Title, @Content, @SubDate, @Status, @UserID, @TopicID, @TecOrProg, @IsDeleted)";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetUpdateQuery(Issue entity)
        {
            return "UPDATE [Issue] SET  [ID]=@ID, [Title] = @Title, [Content] = @Content, [SubDate] = @SubDate, [Status] = @Status, [UserID] = @UserID, [TopicID] = @TopicID, [TecOrProg] = @TecOrProg, [IsDeleted] = @IsDeleted WHERE [ID]=@ID";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetDeleteQuery(Issue entity)
        {
            return "DELETE [Issue] WHERE [ID] = @ID";
        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// [ID], [Title], [Content], [SubDate], [Status], [UserID], [TopicID], [TecOrProg]
        /// </summary>
        protected override DbParameter[] CreateDbParameter(Issue issue)
        {
            //UserData user = (UserData)entity;
            DbParameter[] parameters = new DbParameter[9];
            parameters[0] = DBHelper.GetParameter("@ID", issue.ID);
            parameters[1] = DBHelper.GetParameter("@Title", issue.Title);
            parameters[2] = DBHelper.GetParameter("@Content", issue.Content);
            parameters[3] = DBHelper.GetParameter("@SubDate", TruncateDateTime(issue.SubDate));
            parameters[4] = DBHelper.GetParameter("@Status", issue.Status);
            parameters[5] = DBHelper.GetParameter("@UserID", issue.UserID);
            parameters[6] = DBHelper.GetParameter("@TopicID", issue.TopicID);
            parameters[7] = DBHelper.GetParameter("@TecOrProg", (issue.TecOrProg == Issue.IssueType.Tecnical ? true : false));
            parameters[8] = DBHelper.GetParameter("@IsDeleted", issue.IsDeleted);
            return parameters;

        }

        /// <summary>
        /// see BusinessObjectHandler handler comments
        /// </summary>
        protected override string GetSelectByIdQuery()
        {
            return "SELECT " + GetFields() + " FROM [Issue] WHERE [ID] = @ID";
        }

        internal List<Issue> GetIssues(string keyWord, int id)
        {
            String query = "SELECT " + GetFields() + " FROM [Issue] WHERE [Title] like '%" + keyWord + "%' AND [TopicID] = @TopicID";
            //String query = "SELECT UserName FROM User ";
            DbParameter[] parameters = new DbParameter[1];
            parameters[0] = DBHelper.GetParameter("@TopicID", id);
            List<Issue> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }


        internal List<Issue> GetIssues(string keyWord)
        {
            String query = "SELECT " + GetFields() + " FROM [Issue] WHERE [Title] like '%" + keyWord + "%'";
            //String query = "SELECT UserName FROM User ";
            DbParameter[] parameters = new DbParameter[0];
            List<Issue> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }
/*
        internal List<Issue> GetIssues()
        {
            String query = "SELECT " + GetFields() + " FROM [Issue] WHERE *";
            //String query = "SELECT UserName FROM User ";
            DbParameter[] parameters = new DbParameter[0];
            List<Issue> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }*/

        internal List<Issue> GetAllIssues(bool b)
        {
            String query = "SELECT " + GetFields() +" FROM [Issue] WHERE [Status] = " + b + " order by [SubDate] desc ";
            DbParameter[] parameters = new DbParameter[0];
            List<Issue> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }

        internal List<Issue> GetIssueByUserId(int userId, bool b)
        {
            String query = "SELECT " + GetFields() + " FROM [Issue] WHERE [ID] = " + userId + "AND [Status] = " + b + " order by [SubDate] desc ";
            DbParameter[] parameters = new DbParameter[0];
            List<Issue> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }
       
        internal List<Issue> GetAllIssuesByContry(bool b)
        {
            String query = "SELECT " + GetFields() + " FROM [Issue] WHERE [Status] = " + b + " order by [SubDate] desc ";
            DbParameter[] parameters = new DbParameter[0];
            List<Issue> data = GetBusinessEntitiesByCriteria(query, parameters);
            return data;
        }
    }
}

