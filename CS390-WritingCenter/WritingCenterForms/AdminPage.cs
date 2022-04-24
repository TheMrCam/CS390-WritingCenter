using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WritingCenterForms
{
    public partial class AdminPage : UserControl
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private UserControl currentChildUC;
        scheduleView sView;
        AcctManagePage AcctManagePage1;
        SettingsPage settingPage;
        EditAcctInfoPage EditAcctInfoPage1;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(171, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(255, 204, 204);
            public static Color color5 = Color.FromArgb(204, 204, 0);
        }

        //
        //*********************************************************************************************************
        // Main Constructor
        //*********************************************************************************************************
        //

        public AdminPage(scheduleView sView)
        {
            InitializeComponent();
            AcctManagePage1 = new AcctManagePage();
            this.settingPage = new SettingsPage(sView);

            this.Controls.Add(AcctManagePage1);
            this.Controls.Add(settingPage);

            AcctManagePage1.Hide();
            settingPage.Hide();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, viewSchedule.Size.Height);
            panelMenu.Controls.Add(leftBorderBtn);

            this.sView = sView;
            this.Controls.Add(sView);
            this.sView.BringToFront();
            this.sView.Show();

            collapseMenu();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        //
        //*********************************************************************************************************
        // User Controls
        //*********************************************************************************************************
        //

        //
        // When a button is clicked, changes visual appearance
        //
        private void activateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                disableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(0, 115, 230);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconLogo.IconChar = currentBtn.IconChar;
                iconLogo.IconColor = color;
                labelTitle.Text = currentBtn.Tag.ToString();
            }
        }

        // 
        // When a button is clicked if activated, revert it to normal appearance
        //
        private void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = panelMenu.BackColor;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //
        // opens pages associated with buttons and activates button
        //
        private void viewSchedule_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color1);
            openChildUserControl(sView);
        }
        private void editSchedule_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
            openChildUserControl(settingPage);
        }
        private void manageAccounts_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
            openChildUserControl(AcctManagePage1);
        }
        private void editRequests_Click(object sender, EventArgs e) { activateButton(sender, RGBColors.color4); }
        private void pictureBox1_Click(object sender, EventArgs e) { disableButton(); }


        //
        // Used to open a user control panel
        //
        private void openChildUserControl(UserControl uc)
        {
            if (currentChildUC != null)
                currentChildUC.Hide();
            if (uc != null)
            {
                currentChildUC = uc;
                currentChildUC.BorderStyle = BorderStyle.None;
                currentChildUC.Dock = DockStyle.Fill;
                userControlPanel.Controls.Add(currentChildUC);
                userControlPanel.Tag = currentChildUC;
                currentChildUC.AutoScroll = true;
                currentChildUC.BringToFront();
                currentChildUC.Show();
            }

        }

        //
        // When log out button is clicked, logs user out
        //
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            WCSchedulerForm.currentAccount = null;
            this.Hide();
        }

        //
        // returns user to main menu screen
        //
        private void menuButton_Click(object sender, EventArgs e) { collapseMenu(); }

        //
        // collapses menu on left of app
        //
        private void collapseMenu()
        {
            if (this.panelMenu.Width > 200) //Collapse menu
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                menuButton.Dock = DockStyle.Top;
                menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                menuButton.Padding = new Padding(15, 20, 0, 0);
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = "";
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(15);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 310;
                pictureBox1.Visible = true;
                menuButton.Dock = DockStyle.None;
                foreach (Button btn in panelMenu.Controls.OfType<Button>())
                {
                    btn.Text = "   " + btn.Tag.ToString();
                    btn.ImageAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        //
        //*********************************************************************************************************
        // Other
        //*********************************************************************************************************
        //

        //
        // When admin page loads, initalizes clock
        //
        private void AdminPage_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;//1s
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        //
        // hides componenets if user is not admin
        //
        public void isNotAdmin()
        {
            manageAccounts.Hide();
            editSchedule.Hide();
            editRequests.Hide();

            EditAcctInfoPage1 = new EditAcctInfoPage();
            this.Controls.Add(EditAcctInfoPage1);
            EditAcctInfoPage1.Hide();

            this.Controls.Remove(AcctManagePage1);
            this.Controls.Remove(settingPage);
        }

        //
        // Updates clock on main page
        //
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            //Invoke an anonymous method on the thread of the form.
            circularProgressBar1.Invoke((MethodInvoker)delegate
            {
                //Set time to circular progressbar
                circularProgressBar1.Text = DateTime.Now.ToString("hh:mm:ss");
                circularProgressBar1.SubscriptText = DateTime.Now.ToString("tt");//AM or PM
            });
        }

    }
}
