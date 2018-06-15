using System;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace RouteFormatCreator
{
    public partial class RouteFormatCreator : Form
    {
        public RouteFormatCreator()
        {
            InitializeComponent();

            var rangeTypes = Enum.GetNames(typeof(RangeType));

            cbRangeType.Items.AddRange(rangeTypes.ToArray());
            cbRangeType.SelectedIndex = 0;

            var directions = Enum.GetNames(typeof(Direction));

            cbDirection.Items.AddRange(directions.ToArray());
            cbDirection.SelectedIndex = 0;
        }

        public bool CheckValues()
        {
            bool isValid = true;

            bool emptyName = String.IsNullOrWhiteSpace(tbStreetname.Text);
            lblNameWarning.Text = !emptyName ? "Valid" : "Fill in a name";
            lblNameWarning.ForeColor = !emptyName ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            isValid &= !emptyName;
            RangeType rangeType = (RangeType)Enum.Parse(typeof(RangeType), cbRangeType.SelectedItem.ToString());
            
            var evenLowerbound = (nudLowerbound.Value % 2 == 0);
            var evenUpperbound = (nudUpperbound.Value % 2 == 0);
            switch (rangeType)
            {
                case RangeType.All:
                    // ranges are valid
                    lblLowerboundWarning.Text = "Valid";
                    lblLowerboundWarning.ForeColor = System.Drawing.Color.Green;
                    lblUpperboundWarning.Text = "Valid";
                    lblUpperboundWarning.ForeColor = System.Drawing.Color.Green;
                    isValid &= true;
                    break;
                case RangeType.Even:
                    lblLowerboundWarning.Text = evenLowerbound ? "Valid" : "Invalid";
                    lblLowerboundWarning.ForeColor = evenLowerbound ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                    lblUpperboundWarning.Text = evenUpperbound ? "Valid" : "Invalid";
                    lblUpperboundWarning.ForeColor = evenUpperbound ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                    isValid &= (evenLowerbound && evenLowerbound);
                    break;
                case RangeType.Uneven:
                    lblLowerboundWarning.Text = !evenLowerbound ? "Valid" : "Invalid";
                    lblLowerboundWarning.ForeColor = !evenLowerbound ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                    lblUpperboundWarning.Text = !evenUpperbound ? "Valid" : "Invalid";
                    lblUpperboundWarning.ForeColor = !evenUpperbound ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                    isValid &= (!evenLowerbound && !evenLowerbound);
                    break;
            }

            if (nudLowerbound.Value > nudUpperbound.Value)
            {
                lblLowerboundWarning.Text = "Value must be smaller than or equal to the upper bound value";
                lblLowerboundWarning.ForeColor = System.Drawing.Color.Red;
                isValid = false;
            }


            return isValid;
        }

        private void cbRangeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void nudUpperbound_ValueChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void nudLowerbound_ValueChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void btnAddStreet_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                RangeType rangeType = (RangeType)Enum.Parse(typeof(RangeType), cbRangeType.SelectedItem.ToString());
                int lowerbound = Convert.ToInt32(nudLowerbound.Value);
                int upperbound = Convert.ToInt32(nudUpperbound.Value);
                Direction direction = (Direction)Enum.Parse(typeof(Direction), cbDirection.SelectedItem.ToString());
                var street = new Street(tbStreetname.Text, new Range(lowerbound, upperbound, rangeType), direction);
                // TODO: better check if items is already in list, contains checks only reference equality instead of value equality
                if (!lbStreets.Items.Contains(street))
                {
                    lbStreets.Items.Add(street);
                }
            }
            else
            {
                MessageBox.Show("Cannot add invalid street");
            }
        }

        private void tbStreetname_TextChanged(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = "Select a location to store the route format";
            dialog.Filter = "csv file|*.csv";
            DialogResult result = dialog.ShowDialog();
            if (dialog.FileName == "" || result != DialogResult.OK)
            {
                return;
            }

            System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

            foreach (var street in lbStreets.Items)
            {
                byte[] bytes = Encoding.UTF8.GetBytes(street.ToString() + "\n");
                fs.Write(bytes, 0, bytes.Length);
            }

            fs.Close();
        }
    }


}
