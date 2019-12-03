using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil3
{
    public class Host
    {
        public string HostName { get; set; }
        public List<HostingUnit> Units { get; set; }
        /*public Host(List<HostingUnit> hostingUnits, string hostName)
        {
            Units = hostingUnits;
            HostName = hostName;
        }*/
    }
}
