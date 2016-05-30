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
            Search searchstation = new Search();
            searchstation.SearchStations((ComboBox)sender);
        }

        private void txtDestinationSearch_TextUpdate(object sender, EventArgs e)
        {
            Search searchstation = new Search();
            searchstation.SearchStations((ComboBox)sender);
        }

        private void txtDepartureSearch_TextUpdate(object sender, EventArgs e)
        {
            Search searchstation = new Search();
            searchstation.SearchStations((ComboBox)sender);
        }

        //call searchfunction for connections
        private void cmdSearchConnection_Click(object sender, EventArgs e)
        {
            Search SearchConnection = new Search();
            SearchConnection.SearchConnections(txtStartSearch, txtDestinationSearch, listConnectionSearch);
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

        private void txtDestinationSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void txtDepartureSearch_DropDown(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

    }
}
