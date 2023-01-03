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
using System.Runtime.InteropServices;

namespace AirLineSystem
{
    public partial class AdminForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public AdminForm()
        {
            InitializeComponent();
            //WindowState = FormWindowState.Normal;

            leftBorderBtn = new Panel();
           leftBorderBtn.Size = new Size(7, 60);
           sidemenupanel.Controls.Add(leftBorderBtn);
            //Form
          //  this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241)  ;
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(95, 77, 221);
            public static Color color4 = Color.FromArgb(253, 138, 114);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                CurrentIcon.IconChar = currentBtn.IconChar;
                CurrentIcon.IconColor = color;
                shadowpannel.BackColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            CurrentIcon.IconChar = IconChar.Home;
            CurrentIcon.IconColor = Color.MediumPurple;
            CurrentIcon.Text = "Home";
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void home_btn_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

        }

        private void routes_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }

        private void flights_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new TripPannel());
        }

        private void aircrafts_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void pilots_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

        }

        private void discount_btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void tasker_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void goback_btn_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }
    }

}
