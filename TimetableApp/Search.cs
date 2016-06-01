using SwissTransport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableApp
{
    public class Search
    {
        /// <summary>
        ///searchfunction for stations
        /// </summary>
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
                    ErrorNoConnection();
                }
                else
                {
                    //fill dropdown
                    foreach (var i in station.StationList)
                    {
                        combo.Items.Add(i.Name);
                    }
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

        /// <summary>
        ///searchfunction for connections
        /// </summary>
        public void SearchConnections(ComboBox from, ComboBox to, ListView list, DateTimePicker date, DateTimePicker time, RadioButton isArrivalTime)
        {
            //clear items befor new search
            list.Items.Clear();

            //set cursor to wait
            Cursor.Current = Cursors.WaitCursor;

            //check if radiobutton Arrival is set
            string isArrival = "0";

            if (isArrivalTime.Checked)
            {
                isArrival = "1";
            }
            else
            {
                isArrival = "0";
            }

            //get connections
            Transport transport = new Transport();
            Connections connection = new Connections();

            connection = transport.GetConnections(from.Text, to.Text, ConvertDate(date.Value.ToString()), ConvertTimestamp(time.Value.ToString()), isArrival);

            //check if Error is set
            if (transport.Error)
            {
                ErrorNoConnection();
            }
            //check if result has more than 0 items
            else if (connection.ConnectionList.Count() <= 0)
            {
                ErrorNoConnection();
            }
            else
            {
                //fill ListView with result
                foreach (var i in connection.ConnectionList)
                {
                    string[] sItems = new string[] { i.From.Station.Name, ConvertTimestamp(i.From.Departure), i.From.Platform, i.To.Station.Name, ConvertTimestamp(i.To.Arrival), i.To.Platform, ConvertTimeDuration(i.Duration) };

                    list.Items.Add(new ListViewItem(sItems));
                }
            }

            //set cursor back to default
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        ///searchfunction for departureboard
        /// </summary>
        public void SearchDepartures(ComboBox station, ListView list)
        {
            //clear items befor new search
            list.Items.Clear();

            //set cursor to wait
            Cursor.Current = Cursors.WaitCursor;

            //check if input is not void
            if (station.Text.Length != 0)
            {
                //get departureboard
                Transport transport = new Transport();
                StationBoardRoot stationboardroot = new StationBoardRoot();

                string stationid = transport.GetStations(station.Text).StationList.First().Id;
                stationboardroot = transport.GetStationBoard(station.Text, stationid);

                //check if Error is set
                if (transport.Error)
                {
                    ErrorNoConnection();
                }
                //check if result has more than 0 items
                else if (stationboardroot.Entries.Count() <= 0)
                {
                    ErrorNoConnection();
                }
                else
                {
                    //fill ListView with result
                    foreach (var i in stationboardroot.Entries)
                    {
                        string[] sItems = new string[] { stationboardroot.Station.Name, ConvertTimestamp(i.Stop.Departure.ToString()), i.To, i.Name };

                        list.Items.Add(new ListViewItem(sItems));
                    }
                }

            }
            else
            {
                ErrorNoConnection();
            }

            //set cursor back to default
            Cursor.Current = Cursors.Default;
        }


        /// <summary>
        ///format timestamp into HH:mm
        /// </summary>
        private string ConvertTimestamp(string ts)
        {
            DateTime timestamp = DateTime.Parse(ts);
            return timestamp.ToString("HH:mm");
        }

        /// <summary>
        ///format timeduration into HH:mm
        /// </summary>
        private string ConvertTimeDuration(string td)
        {
            TimeSpan timeduration = TimeSpan.ParseExact(td, "dd'd'hh':'mm':'ss", null);
            return timeduration.ToString(@"hh\:mm");
        }

        /// <summary>
        ///format date into yyyy-MM-dd
        /// </summary>
        private string ConvertDate(string d)
        {
            DateTime Date = DateTime.Parse(d);
            return Date.ToString("yyyy-MM-dd");
        }

        /// <summary>
        ///errormessage no respone/result
        /// </summary>
        private void ErrorNoConnection()
        {
            MessageBox.Show("No connections found or couldn't be loaded.\n\nPlease try again or check your input.", "An error has occured!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
