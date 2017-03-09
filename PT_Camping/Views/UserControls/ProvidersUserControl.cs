using PT_Camping.Properties;

namespace PT_Camping.Views.UserControls
{
    /// <summary>
    /// The ProvidersUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's stocks providers.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class ProvidersUserControl : ManagementUserControl
    {
        public ProvidersUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = Resources.provider_management;
            HandleResize();
        }
    }
}
