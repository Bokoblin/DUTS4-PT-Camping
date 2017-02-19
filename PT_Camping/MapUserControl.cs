using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping
{
    /// <summary>
    /// The MapUserControl is a UserControl handling the campground's map.
    /// It allows visualizing the map with the infrastrures,
    /// adding, removing, modifying a camping accommodation.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 09/02/17
    public partial class MapUserControl : UserControl
    {
        private HomeUserControl mHomeUserControl;


        public MapUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            mHomeUserControl = homeUserControl;
            handleResize();
        }


        internal void handleResize()
        {
            Size = mHomeUserControl.Size;
        }
    }
}
