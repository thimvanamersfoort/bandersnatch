using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Bandersnatch
{
    public partial class FrmNotif : Form
    {
        public FrmNotif()
        {
            InitializeComponent();
        }

        #region variables

        #region algemene variables

        int counter = 0;

        #endregion
        #region Sound variables

        string soundURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Click1.wav");
        MediaPlayer ButtonClickSound = new MediaPlayer();

        #endregion

        #endregion


        #region Methods buttonclicks

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            #region sound

            ButtonClickSound.Open(new Uri(soundURI));
            ButtonClickSound.Play();

            #endregion

            if (counter == 0)
            {
                LblText1.Text = "Please watch the film Bandersnatch before playing. \r\n" +
                                "This game is based on the story of the film Bandersnatch. \r\n \r\n \r\n" +
                                "WARNING: This game contains violence and profanity. \r\n \r\n \r\n" +
                                "Please click Play to continue.";
                counter += 1;
            }
            else if(counter == 1)
            {
                FrmHome FrmHome = new FrmHome();
                this.Hide();
                FrmHome.Show();
            }
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            #region sound

            ButtonClickSound.Open(new Uri(soundURI));
            ButtonClickSound.Play();

            #endregion

            Application.Exit();
        }

        #endregion


        #region Form movement

        // variables for form movement
        private bool mouseDown;
        private Point lastLocation;

        // form movement
        private void FrmNotif_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void FrmNotif_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void FrmNotif_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion
    }
}
