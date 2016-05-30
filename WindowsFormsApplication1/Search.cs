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
        //searchfunction for stations
        public void SearchStations(ComboBox combo)
        {
            //search starts when length of input is over 4
            if (combo.Text.Length >= 4)
            {
                //open dropdown
                combo.DroppedDown = true;

                //position cursor at the last position after clearing the items of dropdown
                int Textposition = combo.SelectionStart;
                combo.Items.Clear();
                combo.SelectionStart = Textposition;

                
                //set cursor to wait
                Cursor.Current = Cursors.WaitCursor;

                //get stations
                Transport transport = new Transport();
                Stations station = new Stations();

                station = transport.GetStations(combo.Text);
                

                //fill dropdown
                foreach (var i in station.StationList)
                {
                    combo.Items.Add(i.Name);
                }

                //set cursor back to default
                Cursor.Current = Cursors.Default;
            }
            else
            {
                //position cursor at the last position after clearing the items of dropdown
                int Textposition = combo.SelectionStart;
                combo.Items.Clear();
                combo.SelectionStart = Textposition;

                //add void item to dropdown, because a minimum of 1 item is needed to close the dropdown 
                combo.Items.Add("");
                //close dropdown
                combo.DroppedDown = false;
            }
        }
    }

    //searchfunction for connections
    public class SearchConnection
    {
        public Connections SearchConnections(string from, string to)
        {
            //get connections
            Transport transport = new Transport();
            Connections connection = new Connections();

            connection = transport.GetConnections(from, to);

            return connection;
        }
    }

    //searchfunction for departureboard 
    public class SearchDeparture
    {
        public StationBoardRoot SearchDepartures(string station)
        {
            //get departureboard
            Transport transport = new Transport();
            StationBoardRoot stationboardroot = new StationBoardRoot();

            string stationid = transport.GetStations(station).StationList.First().Id;
            stationboardroot = transport.GetStationBoard(station, stationid);

            return stationboardroot;
        }
    }
    
}
