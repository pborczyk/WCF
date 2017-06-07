using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainsClient.TrainsServiceReference;

namespace TrainsClient
{
    public partial class Form1 : Form
    {
        private TrainsServiceClient client;
        private bool isArrivalTimeSet = false;
        private bool isLeavingTimeSet = false;
        public Form1()
        {
            InitializeComponent();
            client = new TrainsServiceClient(); 
        }

        private void leavingTimeCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            leavingTimePicker.Enabled = leavingTimeCheckbox.Checked;
            isLeavingTimeSet = leavingTimeCheckbox.Checked;
        }

        private void arrivalTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            arrivalTimePicker.Enabled = arrivalTimeCheckBox.Checked;
            isArrivalTimeSet = arrivalTimeCheckBox.Checked;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            pathsTextBox.Text = "";
            PathsQuery pathsQuery = new PathsQuery();

            pathsQuery.SourceCity = sourceCityTextBox.Text;
            pathsQuery.TargetCity = targetCityTextBox.Text;

            if (isLeavingTimeSet)
            {
                pathsQuery.LeavingTime = leavingTimePicker.Value.ToString(CultureInfo.InvariantCulture);
            }

            if (isArrivalTimeSet)
            {
                pathsQuery.ArrivalTime = arrivalTimePicker.Value.ToString(CultureInfo.InvariantCulture);
            }

            try
            {
                 Path[] paths = client.GetPaths(pathsQuery);

                foreach (var path in paths)
                {
                    pathsTextBox.AppendText("-------------------");
                    pathsTextBox.AppendText(Environment.NewLine);
                    foreach (var pathStep in path.Value)
                    {
                        pathsTextBox.AppendText(pathStep);
                        pathsTextBox.AppendText(Environment.NewLine);
                    }
                    pathsTextBox.AppendText("-------------------");
                    pathsTextBox.AppendText(Environment.NewLine);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
