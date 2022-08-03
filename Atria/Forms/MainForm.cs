using System.Linq;

namespace Atria.Forms
{
    public partial class MainForm : Infrastructure.BaseForm
    {

        //public MainForm()
        //{
        //    InitializeComponent();
        //}
        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region FormLoad
        private void MainForm_Load(object sender, System.EventArgs e)
        {
            //this.SettingRibbonForm();

            this.PersianDateTime();
        }
        #endregion

        #region Reset Form
        public void ResetForm()
        {
            //// **************************************************
            ////if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
            ////{
            ////	adminToolStripMenuItem.Visible = true;
            ////}
            ////else
            ////{
            ////	adminToolStripMenuItem.Visible = false;
            ////}

            ////adminToolStripMenuItem.Visible =
            ////	Infrastructure.Utility.AuthenticatedUser.IsAdmin;

            //// **************************************************

            //// **************************************************
            //// **************************************************
            //// **************************************************
            ////welcomeToolStripStatusLabel.Text =
            ////	"Welcome " + Infrastructure.Utility.AuthenticatedUser.Username + "!";
            //// **************************************************

            //// **************************************************
            ////welcomeToolStripStatusLabel.Text =
            ////	string.Format("Welcome {0}!", Infrastructure.Utility.AuthenticatedUser.Username);
            //// **************************************************

            //// **************************************************
            ////welcomeToolStripStatusLabel.Text =
            ////	$"Welcome {Infrastructure.Utility.AuthenticatedUser.Username}!";
            //// **************************************************

            //// **************************************************
            ////welcomeToolStripStatusLabel.Text =
            ////	$"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
            //// **************************************************
            //// **************************************************
            //// **************************************************

            //// **************************************************
            //// سر کلاس دستور فوق کفایت می‌کند
            //// **************************************************

            //// **************************************************
            //// **************************************************
            //// **************************************************
            ////if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
            ////{
            ////	welcomeToolStripStatusLabel.Text =
            ////		$"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }!";
            ////}
            ////else
            ////{
            ////	welcomeToolStripStatusLabel.Text =
            ////		$"Welcome { Infrastructure.Utility.AuthenticatedUser.FullName }!";
            ////}
            //// **************************************************

            //// **************************************************
            //string userDisplayName =
            //	Infrastructure.Utility.AuthenticatedUser.Username;

            //if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName) == false)
            //{
            //	userDisplayName =
            //		Infrastructure.Utility.AuthenticatedUser.FullName;
            //}

            //welcomeToolStripStatusLabel.Text = $"کاربر » {userDisplayName}!";
            //// **************************************************
            //// **************************************************
            //// **************************************************
        }
        #endregion Reset Form

        #region Setting Main Form
        private void SettingRibbonForm()
        {
            //this.RightToLeft =
            //	System.Windows.Forms.RightToLeft.Yes;

            //this.Font =
            //	new System.Drawing.Font("B Mitra", 12F);

            //this.ShowIcon =
            //	false;

            //this.StartPosition =
            //	System.Windows.Forms.FormStartPosition.CenterScreen;

            this.WindowState =
                System.Windows.Forms.FormWindowState.Maximized;
        }
        #endregion Setting Main Form

        #region Menu
        //private void AboutAtriaMenuItem_Click(object sender, System.EventArgs e)
        //{
        //    //Forms.AboutAtriaForm Form =
        //    //	new Forms.AboutAtriaForm();

        //    //Form.ShowDialog();

        //    // **************************************************
        //    //روش lazy loading
        //    //Hide();

        //    //Infrastructure.Utility.AboutAtriaForm.ResetForm();

        //    Infrastructure.Utility.AboutAtriaForm.Show();
        //    // **************************************************

        //    //private UpdateProfileForm updateProfileForm;

        //    //if (updateProfileForm == null || updateProfileForm.IsDisposed)
        //    //{
        //    //	updateProfileForm = new UpdateProfileForm
        //    //	{
        //    //		MdiParent = this,
        //    //	};
        //    //}

        //    //updateProfileForm.Show();
        //}
        //private void LogoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        //{
        //    Hide();
        //    //Infrastructure.Utility.MainForm.Hide();

        //    Infrastructure.Utility.LoginForm.Show();

        //    Infrastructure.Utility.LoginForm.ResetForm();
        //}
        //private void ExitMenuItem_Click(object sender, System.EventArgs e)
        //{
        //    //------------------------------------------------------------
        //    System.Windows.Forms.DialogResult enmResult =
        //        System.Windows.Forms.MessageBox.Show(
        //            this,
        //            text: "آیا به خروج از سامانه کوارک اطمینان دارید؟",
        //            caption: "سوال :: خروج",
        //            buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
        //            icon: System.Windows.Forms.MessageBoxIcon.Question,
        //            defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button3,
        //            options: System.Windows.Forms.MessageBoxOptions.RtlReading
        //            );

        //    if (enmResult == System.Windows.Forms.DialogResult.Yes)
        //    {
        //        System.Windows.Forms.Application.Exit();
        //    }
        //    //------------------------------------------------------------
        //}
        //private void PhonebookMenuItem_Click(object sender, System.EventArgs e)
        //{
        //    // **************************************************
        //    //روش lazy loading
        //    //Hide();

        //    Infrastructure.Utility.PhonebookForm.Show();
        //    // **************************************************
        //}


        #endregion

        #region DateTimeToStringAndFormatters
        #endregion DateTimeToStringAndFormatters

        #region Fields_PersianDateTime

        //private readonly FarsiLibrary.Utils.PersianDate pd =
        //	FarsiLibrary.Utils.PersianDate.Now;

        #endregion

        #region EventHandlers_PersianDateTime

        public void PersianDateTime()
        {
            //dateToolStripStatusLabel.Text = pd.ToString("d");


            //toStringDD.Text = pd.ToString("D");
            //toStringF.Text = pd.ToString("f");
            //toStringFF.Text = pd.ToString("F");
            //toStringG.Text = pd.ToString("g");
            //toStringGG.Text = pd.ToString("G");
            //toStringM.Text = pd.ToString("m");
            //toStringMM.Text = pd.ToString("M");
            //toStringS.Text = pd.ToString("s");
            //toStringT.Text = pd.ToString("t");
            //toStringTT.Text = pd.ToString("T");
        }


        #endregion

        

        #region EventSystem
        private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
		#endregion

		#region
		#endregion

		#region
		#endregion

		private void MainForm_FormClosed_1(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
            System.Windows.Forms.Application.Exit();
        }
	}
}
