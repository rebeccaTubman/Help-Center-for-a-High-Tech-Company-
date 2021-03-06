﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HPHelpCenter.Models;
using Dal;

namespace HPHelpCenter.Models
{
    public class Solution : BusinesEntity
    {
        private string content;
        private DateTime subDate;
        private bool status;
        private int userID;
        private int issueID;
        private bool isDeleted;
        [NonSerialized]
        private string userName;

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
           
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public DateTime SubDate
        {
            get { return subDate; }
            set { subDate = value; }
        }        
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }        
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public int IsuueID
        {
            get { return issueID; }
            set { issueID = value; }
        }
        
        
        
        
    }
}
                                                                                                                                                                                                                                                                                                                                 while it manages it persistent state.
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
                DbParameter[] parame