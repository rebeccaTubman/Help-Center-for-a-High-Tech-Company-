using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HPHelpCenter.Models;
using Dal;

namespace HPHelpCenter.Models
{
    public class Issue : BusinesEntity
    {
        public enum IssueType
        {
            Tecnical,
            Programing
        };

        private string title;
        private string content;
        private DateTime subDate;
        private bool status;
        private IssueType tecOrProg;
        private int userID;
        private int topicID;
        private bool isDeleted;

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        public Issue()
        {
            // TODO: Complete member initialization
        }
     
        public string Title
        {
            get { return title; }
            set { title = value; }
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
        public IssueType TecOrProg
        {
            get { return tecOrProg; }
            set { tecOrProg = value; }
        }
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public int TopicID
        {
            get { return topicID; }
            set { topicID = value; }
        }     
       
             
    }
}
