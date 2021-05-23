using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
/*using AForge;
using AForge.Video;
using System.Media;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using System.IO;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Media;
using System.IO.Ports;*/

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlformloaderr.Controls.Clear();
            frmDashboard frm3 = new frmDashboard();
            frm3.TopLevel = false;
            frm3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm3.Dock = DockStyle.Bottom;
            pnlformloaderr.Controls.Add(frm3);
            frm3.Show();

        }
        /*private VideoCaptureDevice Cerceve;  //camera
        private FilterInfoCollection Yakala; //shoot
        public int i;*/
        /*private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch
            {

            }

        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-FVNOOO9\\SQLEXPRESS; Initial Catalog=maku; Integrated Security=true ");
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            /*timer3.Start();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = ("Data Source=WINDOWS81SL\\SQLEXPRESS; Initial Catalog=maku; Integrated Security=true ");
            SqlCommand komutcu = new SqlCommand();
            komutcu.CommandText = "select * from employs";
            komutcu.Connection = baglanti;
            komutcu.CommandType = CommandType.Text;
            SqlDataReader rd;
            baglanti.Open();
            rd = komutcu.ExecuteReader();
            while (rd.Read())
            {
                listBox1.Items.Add(rd["TC"]);
            }
            baglanti.Close();

            if (listBox1.Items.Contains(label1))
            {
               b = true;
            }
            else
                b = false;
            
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\BATUHAN\Desktop\M.BatuhanTUR\QRKod_Okuyucu_Güvenlik_Sistemi\Track2 (online-audio-converter.com).wav";
            player.Play();
            comboBox1.Visible = false;
            button4.Visible = false;
            //textBox1.Focus();
            label1.Visible = false;

            Yakala = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in Yakala)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            Cerceve = new VideoCaptureDevice(Yakala[comboBox1.SelectedIndex].MonikerString);
            Cerceve.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            Cerceve.Start();

            pictureBox1.Focus();
            timer2.Start();*/
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Dashboard";
            this.pnlformloaderr.Controls.Clear();
            frmDashboard frm3 = new frmDashboard();
            frm3.TopLevel = false;
            frm3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm3.Dock = DockStyle.Bottom;
            pnlformloaderr.Controls.Add(frm3);
            frm3.Show();

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            pnlNav.Left = btnAnalytics.Left;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Analytics";
            this.pnlformloaderr.Controls.Clear();
            FrmAnalytics frm_Analytics = new FrmAnalytics();
            frm_Analytics.TopLevel = false;
            frm_Analytics.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_Analytics.Dock = DockStyle.Fill;
            pnlformloaderr.Controls.Add(frm_Analytics);
            frm_Analytics.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Calendar";
            this.pnlformloaderr.Controls.Clear();
            frmcalendar frm_Calendar = new frmcalendar();
            frm_Calendar.TopLevel = false;
            frm_Calendar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_Calendar.Dock = DockStyle.Bottom;
            pnlformloaderr.Controls.Add(frm_Calendar);
            frm_Calendar.Show();
        }

        private void btnMeet_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMeet.Height;
            pnlNav.Top = btnMeet.Top;
            btnMeet.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Meeting Rooms";
            this.pnlformloaderr.Controls.Clear();
            frmMeeting frm_Meet = new frmMeeting();
            frm_Meet.TopLevel = false;
            frm_Meet.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm_Meet.Dock = DockStyle.Fill;
            pnlformloaderr.Controls.Add(frm_Meet);
            frm_Meet.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            btnSettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMeet_Leave(object sender, EventArgs e)
        {
            btnMeet.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVR frm_VR = new frmVR();
            frm_VR.Show();
            this.Hide();
        }
    }
}
