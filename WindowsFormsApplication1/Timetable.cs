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
            var box = sender as ComboBox;

            if (txtStartSearch.Text.Length >= 4)
            {
                box.DroppedDown = true;

                int Textposition = txtStartSearch.SelectionStart;
                txtStartSearch.Items.Clear();
                txtStartSearch.SelectionStart = Textposition;

                SearchStation searchstation = new SearchStation();
                var station = searchstation.SearchStations(txtStartSearch.Text);

                foreach (var i in station.StationList)
                {
                    txtStartSearch.Items.Add(i.Name);
                }
            }
            else
            {
                int Textposition = txtStartSearch.SelectionStart;
                txtStartSearch.Items.Clear();
                txtStartSearch.SelectionStart = Textposition;

                txtStartSearch.Items.Add("");
                box.DroppedDown = false;
            }
        }

        private void txtDestinationSearch_TextUpdate(object sender, EventArgs e)
        {
            var box = sender as ComboBox;

            if (txtDestinationSearch.Text.Length >= 4)
            {
                box.DroppedDown = true;

                int Textposition = txtDestinationSearch.SelectionStart;
                txtDestinationSearch.Items.Clear();
                txtDestinationSearch.SelectionStart = Textposition;

                SearchStation searchstation = new SearchStation();
                var station = searchstation.SearchStations(txtDestinationSearch.Text);

                foreach (var i in station.StationList)
                {
                    txtDestinationSearch.Items.Add(i.Name);
                }
            }
            else
            {
                int Textposition = txtDestinationSearch.SelectionStart;
                txtDestinationSearch.Items.Clear();
                txtDestinationSearch.SelectionStart = Textposition;

                txtDestinationSearch.Items.Add("");
                box.DroppedDown = false;
            }
        }
    }
}
