using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class SearchStation
    {
        public void SearchStations(ComboBox combo)
        {
            if (combo.Text.Length >= 4)
            {
                combo.DroppedDown = true;

                int Textposition = combo.SelectionStart;
                combo.Items.Clear();
                combo.SelectionStart = Textposition;

                Transport transport = new Transport();
                Stations station = new Stations();

                station = transport.GetStations(combo.Text);

                foreach (var i in station.StationList)
                {
                    combo.Items.Add(i.Name);
                }
            }
            else
            {
                int Textposition = combo.SelectionStart;
                combo.Items.Clear();
                combo.SelectionStart = Textposition;

                combo.Items.Add("");
                combo.DroppedDown = false;
            }
        }
    }

    public class SearchConnection
    {
        public Connections SearchConnections(string from, string to)
        {
            Transport transport = new Transport();
            Connections connection = new Connections();

            connection = transport.GetConnections(from, to);

            return connection;
        }
    }
}
