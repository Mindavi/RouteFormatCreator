using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteFormatCreator
{
    public partial class RouteFormatCreator : Form
    {
        public RouteFormatCreator()
        {
            InitializeComponent();

            var rangeTypes = new List<string>()
            {
                "All",
                "Even",
                "Uneven"
            };

            cbRangeType.Items.AddRange(rangeTypes.ToArray());
            cbRangeType.SelectedItem = rangeTypes[0];
        }
    }
}
