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

        private void cmdSearchConnection_Click(object sender, EventArgs e)
        {
            SearchConnection searchconnection = new SearchConnection();
            var connecion = searchconnection.SearchConnections(txtStartSearch.Text, txtDestinationSearch.Text);


            foreach (var i in connecion.ConnectionList)
            {
                string[] sItems = new string[] { i.From.Station.Name, ConvertTimestamp(i.From.Departure), i.From.Platform, i.To.Station.Name, ConvertTimestamp(i.To.Arrival), i.To.Platform, i.Duration };

                listConnectionSearch.Items.Add(new ListViewItem(sItems));
            }
        }

        public string ConvertTimestamp(string ts)
        {
            DateTime timestamp = DateTime.Parse(ts);

            return timestamp.ToString("HH:mm");
        }
    }
}
