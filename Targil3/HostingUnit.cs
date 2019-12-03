using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil3
{
    public class HostingUnit
    {
        public string UnitName { get; set; }
        public int NumRooms { get; set; }
        public bool IsPool { get; set; }
        public List<DateTime> AllOrders { get; set; }
        public List<string> Uris { get; set; }

        /*public HostingUnit(string name, int rooms, bool pool, List<string> uris)//recieves values and list of picture links and puts them in
        {
            AllOrders = new List<DateTime>();
            UnitName = name;
            NumRooms = rooms;
            IsPool = pool;
            Uris = uris;
        }*/
    }
}
