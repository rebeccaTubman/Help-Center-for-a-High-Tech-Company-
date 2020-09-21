using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;


namespace Dal
{
    public interface IBusinesEntity
    {

    }


    /// <summary>
    /// Business entity contains only ID member
    /// </summary>
    [Serializable]
    //[XmlInclude(typeof(UserData))]
    //[XmlInclude(typeof(HistoryData))]
    public abstract class BusinesEntity : IBusinesEntity
    {

        public BusinesEntity()
        {
            // TODO remove
        }

        /// <summary>
        /// Business entity ID
        /// </summary>
        /// <param name="id"></param>
        public BusinesEntity(int id)
        {
            ID = id;
        }

        public int ID { set; get; }

    }


}
