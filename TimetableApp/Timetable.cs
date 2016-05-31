using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableApp
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
            Search searchstation = new Search();
            searchstation.SearchStations((ComboBox)sender);
        }

        //call searchfunction for stations
        private void txtDestinationSearch_TextUpdate(object sender, EventArgs e)
        {
            Search searchstation = new Search();
            searchstation.SearchStations((ComboBox)sender);
        }

        //call searchfunction for stations
        private void txtDepartureSearch_TextUpdate(object sender, EventArgs e)
        {
            Search searchstation = new Search();
            searchstation.SearchStations((ComboBox)sender);
        }

        //call searchfunction for connections
        private void cmdSearchConnection_Click(object sender, EventArgs e)
        {
            Search SearchConnection = new Search();
            SearchConnection.SearchConnections(txtStartSearch, txtDestinationSearch, listConnectionSearch, DatePickerConnection, TimePickerConnection, radioArrivalConnection);
        }

        //call searchfunction for departureboard
        private void cmdSearchTable_Click(object sender, EventArgs e)
        {
            Search SearchDepartureBoard = new Search();
            SearchDepartureBoard.SearchDepartures(txtDepartureSearch, listDepartureSearch);
        }

        //bring back default cursor when dropdown opens
        private void txtStartSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        //bring back default cursor when dropdown opens
        private void txtDestinationSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        //bring back default cursor when dropdown opens
        private void txtDepartureSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        //update date and time once a minute, only when field isn't edited
        private void timer1min_Tick(object sender, EventArgs e)
        {
            if (TimePickerConnection.Value.Minute == DateTime.Now.AddMinutes(-1).Minute && TimePickerConnection.Value.Hour == DateTime.Now.Hour)
            {
                DatePickerConnection.Value = DateTime.Now;
                TimePickerConnection.Value = DateTime.Now;
            }
        }
    }
}
