using System.Windows.Forms;

namespace PT_Camping.Views.UserControls
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
        private readonly HomeUserControl _homeUserControl;


        public MapUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            _homeUserControl = homeUserControl;
            HandleResize();
        }


        internal void HandleResize()
        {
            Size = _homeUserControl.Size;
        }
    }
}
