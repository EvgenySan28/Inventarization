using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventarization.Data.DB.entities
{
    public class Nomenclature
    {
        public int NomenclatureID { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string Сondition { get; set; }
        public int? RoomID { get; set; }
        public Room Room { get; set; }

    }
}
