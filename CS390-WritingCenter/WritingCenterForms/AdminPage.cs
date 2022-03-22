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

        scheduleView sView;
        AcctManagePage AcctManagePage1 = new AcctManagePage();
        SettingsPage settingPage;
        public AdminPage(scheduleView sView)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, viewSchedule.Size.Height);
            panelMenu.Controls.Add(leftBorderBtn);

            this.sView = sView;
            this.settingPage = new SettingsPage(sView);
            this.Controls.Add(sView);
            this.Controls.Add(AcctManagePage1);
            this.Controls.Add(settingPage);
            sView.Hide();
            AcctManagePage1.Hide();
            settingPage.Hide();
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(171, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
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
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconLogo.IconChar = currentBtn.IconChar;
                iconLogo.IconColor = color;
                labelTitle.Text = currentBtn.Text;
            }
        }

        private void disableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = panelMenu.BackColor;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = panelMenu.ForeColor;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void viewSchedule_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color1);
        }

        private void editSchedule_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color2);
        }

        private void manageAccounts_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color3);
        }

        private void editRequests_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color4);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBColors.color5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            disableButton();
            leftBorderBtn.Visible = false;
            labelTitle.Text = "Home";
        }
    }
}
