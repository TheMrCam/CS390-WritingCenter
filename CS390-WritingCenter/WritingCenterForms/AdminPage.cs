using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace WritingCenterForms
{
    public partial class AdminPage : UserControl
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private UserControl currentChildUC;
        private bool maximize;

        scheduleView sView;
        AcctManagePage AcctManagePage1;
        SettingsPage settingPage;
        EditAcctInfoPage EditAcctInfoPage1;

        public AdminPage(scheduleView sView, Boolean isAdmin)
        {
            InitializeComponent();
            if (isAdmin)
            {
                AcctManagePage1 = new AcctManagePage();
                this.settingPage = new SettingsPage(sView);
                this.Controls.Add(AcctManagePage1);
                this.Controls.Add(settingPage);
                AcctManagePage1.Hide();
                settingPage.Hide();
                settings.Hide();
        
            }
            else
            {
                manageAccounts.Hide();
                editSchedule.Hide();
                editRequests.Hide();
                EditAcctInfoPage1 = new EditAcctInfoPage();
                this.Controls.Add(EditAcctInfoPage1);
                EditAcctInfoPage1.Hide();
            }
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, viewSchedule.Size.Height);
            panelMenu.Controls.Add(leftBorderBtn);
            this.sView = sView;
            this.Controls.Add(sView);
            collapseMenu();
            sView.Hide();
            this.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(171, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(255, 204, 204);
            public static Color color5 = Color.FromArgb(204, 204, 0);
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

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

        private void editRequests_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color4);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color5);
            openChildUserControl(EditAcctInfoPage1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            disableButton();
            leftBorderBtn.Visible = false;
            labelTitle.Text = "Home";
            iconLogo.IconChar = IconChar.Home;
            if (currentChildUC != null)
                currentChildUC.Hide();
        }

        private void openChildUserControl(UserControl uc)
        {
            if (currentChildUC != null) 
                currentChildUC.Hide();
            currentChildUC = uc;
            currentChildUC.BorderStyle = BorderStyle.None;
            currentChildUC.Dock = DockStyle.Fill;
            userControlPanel.Controls.Add(currentChildUC);
            userControlPanel.Tag = currentChildUC;
            currentChildUC.AutoScroll = true;
            currentChildUC.BringToFront();
            currentChildUC.Show();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            WCSchedulerForm.currentAccount = null;
            this.Hide();
        }

        private void panelTitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            collapseMenu();
        }

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
                panelMenu.Width = 250;
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

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MAXIMIZE = 0xF030;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MAXIMIZE)
                    {
                        this.maximize = true;
                        this.MaximumSize = new System.Drawing.Size(0, 0);
                    }
                    break;
            }

            base.WndProc(ref message);
        }

        private void userControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
