using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        //call searchfunction for stations
        private void txtStartSearch_TextUpdate(object sender, EventArgs e)
        {
            SearchStation searchstation = new SearchStation();
            searchstation.SearchStations((ComboBox)sender);
        }

        private void txtDestinationSearch_TextUpdate(object sender, EventArgs e)
        {
            SearchStation searchstation = new SearchStation();
            searchstation.SearchStations((ComboBox)sender);
        }

        private void txtDepartureSearch_TextUpdate(object sender, EventArgs e)
        {
            SearchStation searchstation = new SearchStation();
            searchstation.SearchStations((ComboBox)sender);
        }

        //bring back default cursor when dropdown opens
        private void txtStartSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void txtDestinationSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void txtDepartureSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }


        //call searchfunction for connections and fill ListView
        private void cmdSearchConnection_Click(object sender, EventArgs e)
        {
            //clear items befor new search
            listConnectionSearch.Items.Clear(); ;

            SearchConnection searchconnection = new SearchConnection();
            var connection = searchconnection.SearchConnections(txtStartSearch.Text, txtDestinationSearch.Text);


            //fill ListView with result
            foreach (var i in connection.ConnectionList)
            {
                string[] sItems = new string[] { i.From.Station.Name, ConvertTimestamp(i.From.Departure), i.From.Platform, i.To.Station.Name, ConvertTimestamp(i.To.Arrival), i.To.Platform, ConvertTimeDuration(i.Duration) };

                listConnectionSearch.Items.Add(new ListViewItem(sItems));
            }
        }

        //call searchfunction for departureboard and fill ListView
        private void cmdSearchTable_Click(object sender, EventArgs e)
        {
            //clear items befor new search
            listDepartureSearch.Items.Clear();

            SearchDeparture searchdeparture = new SearchDeparture();
            var departureboard = searchdeparture.SearchDepartures(txtDepartureSearch.Text);

            //fill ListView with result
            foreach (var i in departureboard.Entries)
            {
                string[] sItems = new string[] { departureboard.Station.Name, ConvertTimestamp(i.Stop.Departure.ToString()), i.To, i.Name };

                listDepartureSearch.Items.Add(new ListViewItem(sItems));
            };
        }

        //format timestamp
        public string ConvertTimestamp(string ts)
        {
            DateTime timestamp = DateTime.Parse(ts);
            return timestamp.ToString("HH:mm");
        }

        //format timeduration
        public string ConvertTimeDuration(string td)
        {
            TimeSpan timeduration = TimeSpan.ParseExact(td, "dd'd'hh':'mm':'ss", null);
            return timeduration.ToString(@"hh\:mm");
        }
    }
}
