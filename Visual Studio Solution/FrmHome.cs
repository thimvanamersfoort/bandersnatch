using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using System.IO;
using System.Reflection;

namespace Bandersnatch
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }


        #region variables

        #region General variables

        public static string UsernameHome;

        #endregion
        #region Sound variables

        string backgroundURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "BackgroundMusicMixHome.wav");
        string soundURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Click1.wav");

        public static MediaPlayer BgMusicMixHome = new MediaPlayer();
        public static MediaPlayer ButtonClickSound = new MediaPlayer();

        public static bool SoundOn = true;
        public static bool MusicOn = true;
        public static bool FormFirstTimeLoaded = true;

        #endregion

        #endregion


        #region FrmHome_Load + sound checks

        private void FrmHome_Load(object sender, EventArgs e)
        {
            SoundCheck();

            BgMusicMixHome.MediaEnded += BgMusicMixHome_MediaEnded;
        }
        private void SoundCheck()
        {
            if(FormFirstTimeLoaded == true && MusicOn == true)
            {
                CbxSettingsMusic.Checked = true;

                BgMusicMixHome.Open(new Uri(backgroundURI));
                BgMusicMixHome.Play();

                FormFirstTimeLoaded = false;
            }
            if(FormFirstTimeLoaded == false && MusicOn == true)
            {
                CbxSettingsMusic.Checked = true;
                BgMusicMixHome.Play();

                FormFirstTimeLoaded = false;
            }
            if(FormFirstTimeLoaded == false && MusicOn == false)
            {
                CbxSettingsMusic.Checked = false;

                FormFirstTimeLoaded = false;
            }

            if(SoundOn == true)
            {
                CbxSettingsSounds.Checked = true;
            }
        } // gets called when form loads. only for home and how-to-play forms
        private void BgMusicMixHome_MediaEnded(object sender, EventArgs e)
        {
            if(MusicOn == true)
            {
                BgMusicMixHome.Position = TimeSpan.Zero;
                BgMusicMixHome.Play();
            }
        } // gets called when backgroundmusic has ended. takes care of refresh.
        #endregion


        #region buttons

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            #region sound

            if(SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            if (TbUsername.Text == "" || TbUsername.ForeColor == System.Drawing.Color.Gray)
            {
            MessageBox.Show("Please fill in a username.", "Warning:");
            }
            else
            {                
                FrmGame FrmGame = new FrmGame(); // "nieuwe" frmgame om andere form te openen

                // resets van eventuele oudere games
                FrmGame.UsernameGame = null;
                FrmGame.ActiveLevel = "Level1_1";
                FrmGame.Gamestate = 0;
                FrmGame.FirstTimeLoading = true;

                // nieuwe username instellen
                FrmGame.UsernameGame = TbUsername.Text;

                // muziek laten stoppen
                BgMusicMixHome.Stop();

                this.Hide();
                FrmGame.Show();
            }
        }
        private void BtnHowToPlay_Click(object sender, EventArgs e)
        {
            #region sound

            if(SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }
            if(MusicOn == true)
            {
                BgMusicMixHome.Pause();
            }

            #endregion

            FrmHowTo FrmHowTo = new FrmHowTo(); // nieuwe frmhowto om andere form te openen
            this.Hide();
            FrmHowTo.Show();


        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            Application.Exit();
        }
        private void PbMinimize_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            this.WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region Settings

        private void PbSettings_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            if (LblSettings.Visible == false)
            {
                PbAccessory.Image = Properties.Resources.BackgroundClearBlack;
                PbAccessory.SizeMode = PictureBoxSizeMode.StretchImage;

                LblSettings.Visible = true;
                LblSettings.BringToFront();
                CbxSettingsMusic.Visible = true;
                CbxSettingsMusic.BringToFront();
                CbxSettingsSounds.Visible = true;
                CbxSettingsSounds.BringToFront();

                BtnSettingsClose.Visible = true;
                BtnSettingsClose.BringToFront();
            }
            else if(LblSettings.Visible == true)
            {
                PbAccessory.BorderStyle = BorderStyle.None;
                PbAccessory.Image = Properties.Resources.choice1;
                PbAccessory.SizeMode = PictureBoxSizeMode.Zoom;

                LblSettings.Visible = false;
                CbxSettingsMusic.Visible = false;
                CbxSettingsSounds.Visible = false;

                BtnSettingsClose.Visible = false;
            }
        }
        private void BtnSettingsClose_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            PbAccessory.BorderStyle = BorderStyle.None;
            PbAccessory.Image = Properties.Resources.choice1;
            PbAccessory.SizeMode = PictureBoxSizeMode.Zoom;

            LblSettings.Visible = false;
            CbxSettingsMusic.Visible = false;
            CbxSettingsSounds.Visible = false;

            BtnSettingsClose.Visible = false;

        }
        private void CbxSettingsSounds_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxSettingsSounds.Checked == true)
            {
                SoundOn = true;
            }
            else if(CbxSettingsSounds.Checked == false)
            {
                SoundOn = false;
            }
        }
        private void CbxSettingsMusic_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxSettingsMusic.Checked == true)
            {
                BgMusicMixHome.Play();
                MusicOn = true;
            }
            else if(CbxSettingsMusic.Checked == false)
            {
                BgMusicMixHome.Pause();
                MusicOn = false;
            }
        }

        #endregion


        #region Characterpicker + usernames

        // changing text color to input username
        private void TbUsername_Click(object sender, EventArgs e)
        {
            if(TbUsername.ForeColor == System.Drawing.Color.Gray)
            {
                TbUsername.Text = "";
                TbUsername.Font = new Font("Consolas", 11, FontStyle.Italic);
                TbUsername.ForeColor = System.Drawing.Color.White;
            }
        }

        // variables for cycling in character models
        int counternext = 1;
        int counterprev = 1;

        // cycling between different character models
        private void BtnPrevChar_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            counternext = (8 - counterprev);

            if(counterprev == 1)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom7_animated;
                PbCharacter.Refresh();
                counterprev += 1;
            }
            else if (counterprev == 2)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom6_animated;
                PbCharacter.Refresh();
                counterprev += 1;
            }
            else if (counterprev == 3)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom5_animated;
                PbCharacter.Refresh();
                counterprev += 1;
            }
            else if (counterprev == 4)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom4_animated;
                PbCharacter.Refresh();
                counterprev += 1;
            }
            else if (counterprev == 5)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom3_animated;
                PbCharacter.Refresh();
                counterprev += 1;
            }
            else if (counterprev == 6)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom2_animated;
                PbCharacter.Refresh();
                counterprev += 1;
            }
            else if (counterprev == 7)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom1_animated;
                PbCharacter.Refresh();
                counterprev = 1;
            }
        }
        private void BtnNextChar_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            counterprev = (8 - counternext);

            if (counternext == 1)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom2_animated;
                PbCharacter.Refresh();
                counternext += 1;
            }
            else if (counternext == 2)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom3_animated;
                PbCharacter.Refresh();
                counternext += 1;
            }
            else if (counternext == 3)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom4_animated;
                PbCharacter.Refresh();
                counternext += 1;
            }
            else if (counternext == 4)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom5_animated;
                PbCharacter.Refresh();
                counternext += 1;
            }
            else if (counternext == 5)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom6_animated;
                PbCharacter.Refresh();
                counternext += 1;
            }
            else if (counternext == 6)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom7_animated;
                PbCharacter.Refresh();
                counternext += 1;
            }
            else if (counternext == 7)
            {
                PbCharacter.Image = Properties.Resources.AgentCustom1_animated;
                PbCharacter.Refresh();
                counternext = 1;
            }
        }

        #endregion


        #region form movement

        // variables for form movement
        private bool mouseDown;
        private Point lastLocation;

        // form movement
        private void FrmHome_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void FrmHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void FrmHome_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion
    }
}
