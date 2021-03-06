﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dal;

namespace HPHelpCenter.Models
{
    class Item : BusinesEntity
    {
        private int id;
        private string itemName;
        private string company;
        private string type;
        private int amount;
        private int minAmount;
        private DateTime releaseDate;

        public Item(
            int id,
            string itemName,
            string company,
            string type,
            int amount,
            int minAmount,
            DateTime releaseDate
            )
        {

        }

        public Item()
        {
            // TODO: Complete member initialization
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }       
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }        
        public int MinAmount
        {
            get { return minAmount; }
            set { minAmount = value; }
        }
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        
    }
}
                                                                                                                                                                                                                      ssObjectHandler handler comments
        /// </summary>
        protected override string GetCreateQuery(HistoryData entity)
        {
            return "INSERT INTO [History] (" + 
       