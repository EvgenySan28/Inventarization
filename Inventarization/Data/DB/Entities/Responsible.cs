using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventarization.Data.DB.entities
{
    public class Responsible
    {
        public int ResponsibleID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        List<Room> Rooms { get; set; }
        public Responsible()
        {
            Rooms = new List<Room>();
        }

    }
}
