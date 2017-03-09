using PT_Camping.Properties;

namespace PT_Camping.Views.UserControls
{
    /// <summary>
    /// The ClientUserControl inherits from ManagementHomeControl.
    /// It is used to manage the camping's clients.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 08/02/17
    public partial class ClientsUserControl : ManagementUserControl
    {
        public ClientsUserControl(HomeUserControl homeUserControl) : base(homeUserControl)
        {
            InitializeComponent();
            appBarTitle.Text = Resources.clients_management;
            HandleResize();
        }
    }
}
