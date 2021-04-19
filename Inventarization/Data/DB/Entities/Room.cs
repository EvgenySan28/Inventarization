using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventarization.Data.DB.entities
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public int? ResponsibleID { get; set; }
        public Responsible Responsible { get; set; }
        List<Nomenclature> Nomenclatures { get; set; }
        public Room()
        {
            Nomenclatures = new List<Nomenclature>();
        }
    }
}
