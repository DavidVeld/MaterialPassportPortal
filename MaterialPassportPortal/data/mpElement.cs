using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialPassportPortal
{
    [Serializable]
    public class mpElement
    {
        public int Id { get; set; }
        public string GUID { get; set; }
        //Element GUID
        public string Name { get; set; }
        //Element GUID
        List<mpProperty> PropertyList{get; set;}
        public mpElement()
        {
            Id = -999; //Unassigned
            GUID = "";
            Name = "";
            PropertyList = new List<mpProperty>();
        }

    }
}
