using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal;

namespace HPHelpCenter.Models
{
    public class Picture : BusinesEntity
    {
        private byte[] img;
        private bool isDeleted = false;

        public bool IsDeleted
        {
            get { return isDeleted; }
            set { isDeleted = value; }
        }

         public byte[] Img
        {
            get { return img; }
            set { img = value; }
        }

        public Picture(int id, byte[] img, bool isDeleted)
        {
            // TODO: Complete member initialization
            this.ID = id;
            this.Img = img;
            this.IsDeleted = isDeleted;
        }

        public Picture()
        {
            // TODO: Complete member initialization
        }

        public Picture(int id, byte[] bytes)
        {
            this.ID = id;
            this.Img = bytes;
        }
        
    }
}
