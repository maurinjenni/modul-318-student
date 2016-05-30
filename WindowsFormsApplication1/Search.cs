using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Search
    {
        //
        //searchfunction for stations
        //
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

                //errormessage if no response
                if (transport.Error)
                {
                    MessageBox.Show(transport.ThrowedException.Message, "An error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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




        //
        //searchfunction for connections
        //
        public void SearchConnections(ComboBox from, ComboBox to, ListView list)
        {
            //clear items befor new search
            list.Items.Clear();

            //set cursor to wait
            Cursor.Current = Cursors.WaitCursor;

            //get connections
            Transport transport = new Transport();
            Connections connection = new Connections();

            connection = transport.GetConnections(from.Text, to.Text);

            if (transport.Error)
            {
                //errormessage if no response
                MessageBox.Show(transport.ThrowedException.Message, "An error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (connection.ConnectionList.Count() <= 0)
            {
                ErrorNoConnection();
            }

            //fill ListView with result
            foreach (var i in connection.ConnectionList)
            {
                string[] sItems = new string[] { i.From.Station.Name, ConvertTimestamp(i.From.Departure), i.From.Platform, i.To.Station.Name, ConvertTimestamp(i.To.Arrival), i.To.Platform, ConvertTimeDuration(i.Duration) };

                list.Items.Add(new ListViewItem(sItems));
            }

            //set cursor back to default
            Cursor.Current = Cursors.Default;
        }




        //
        //searchfunction for departureboard
        //
        public void SearchDepartures(ComboBox station, ListView list)
        {
            //clear items befor new search
            list.Items.Clear();

            //set cursor to wait
            Cursor.Current = Cursors.WaitCursor;

            //get departureboard
            Transport transport = new Transport();
            StationBoardRoot stationboardroot = new StationBoardRoot();

            if (station.Text.Length != 0)
            {
                string stationid = transport.GetStations(station.Text).StationList.First().Id;
                stationboardroot = transport.GetStationBoard(station.Text, stationid);

                if (transport.Error)
                {
                    //errormessage if no response
                    MessageBox.Show(transport.ThrowedException.Message, "An error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (stationboardroot.Entries.Count() <= 0)
                {
                    ErrorNoConnection();
                }

                //fill ListView with result
                foreach (var i in stationboardroot.Entries)
                {
                    string[] sItems = new string[] { stationboardroot.Station.Name, ConvertTimestamp(i.Stop.Departure.ToString()), i.To, i.Name };

                    list.Items.Add(new ListViewItem(sItems));
                }
            }
            else
            {
                ErrorNoConnection();
            }

            //set cursor back to default
            Cursor.Current = Cursors.Default;
        }


        //format timestamp
        private string ConvertTimestamp(string ts)
        {
            DateTime timestamp = DateTime.Parse(ts);
            return timestamp.ToString("HH:mm");
        }

        //format timeduration
        private string ConvertTimeDuration(string td)
        {
            TimeSpan timeduration = TimeSpan.ParseExact(td, "dd'd'hh':'mm':'ss", null);
            return timeduration.ToString(@"hh\:mm");
        }

        //errormessage: no connection
        private void ErrorNoConnection()
        {
            MessageBox.Show("no connections found, please check your input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
