using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SearchStation
    {
        public Stations SearchStations(string Searchtext)
        {
            Transport transport = new Transport();
            Stations station = new Stations();

            station = transport.GetStations(Searchtext);

            return station;
        }
    }

    public class SearchConnection
    {
        public Connections SearchConnections(string from, string to)
        {
            return null;
        }
    }
}
