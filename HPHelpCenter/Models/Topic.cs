using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal;

namespace HPHelpCenter.Models
{
    public class Topic : BusinesEntity
    {
        private string topicName;
        private bool isDeleted = false;

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

        public Topic(int p1, string p2, bool p3)
        {
            // TODO: Complete member initialization
            this.ID = p1;
            this.TopicName = p2;
            this.IsDeleted = p3;
        }

        public Topic()
        {
            // TODO: Complete member initialization
        }

        public string TopicName
        {
            get { return topicName; }
            set { topicName = value; }
        }
        
    }
}
