using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Media;
using System.Collections;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Media;

namespace Bandersnatch
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
        }


        #region Variables

        #region General variables

        public static int Gamestate = 0;
        public static string ActiveLevel = "Level1_1";
        public static bool FirstTimeLoading = true;
        public static string UsernameGame = FrmHome.UsernameHome;

        #endregion
        #region Sound variables

        string backgroundURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "BackgroundAmbientDungeons.wav");
        string soundURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Click1.wav");
        string typewriterURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Text1.wav");

        public static MediaPlayer BgMusicMixGame = new MediaPlayer();
        public static MediaPlayer ButtonClickSound = new MediaPlayer();
        public static MediaPlayer TypewriterSound = new MediaPlayer();

        public static bool MusicOn = true;
        public static bool SoundOn = true;

        #endregion
        #region Form variables

        FrmHome FrmHome = new FrmHome();

        #endregion
        #region Form movement

        public bool mouseDown;
        public Point lastLocation;

        #endregion
        #region Typewriter variables

        public string FullTextBottom;
        private string CurrentTextBottom = "";
        public int i;
        public bool IsActive = false;
        public int LoopDelay = 30;

        #endregion

        #endregion


        #region FormGame_Load + sound refresh

        private void FrmGame_Load(object sender, EventArgs e)
        {
            #region sound

            if(FrmHome.MusicOn == true)
            {
                CbxSettingsMusic.Checked = true;
                BgMusicMixGame.Open(new Uri(backgroundURI));
                BgMusicMixGame.Play();
            }
            else if(FrmHome.MusicOn == false)
            {
                CbxSettingsMusic.Checked = false;
                BgMusicMixGame.Open(new Uri(backgroundURI));
            }

            if(FrmHome.SoundOn == true)
            {
                SoundOn = true;
                CbxSettingsSounds.Checked = true;
            }
            else if(FrmHome.SoundOn == false)
            {
                SoundOn = false;
                CbxSettingsSounds.Checked = false;
            }

            #endregion

            Level1_1();

            BgMusicMixGame.MediaEnded += BgMusicMixGame_MediaEnded;
        }
        private void BgMusicMixGame_MediaEnded(object sender, EventArgs e)
        {
            BgMusicMixGame.Position = TimeSpan.Zero;
            BgMusicMixGame.Play();
        } // gets called when music stops playing. restarts music.

        #endregion


        #region doorcyclen naar nieuwe gamestates

        private void Gamestate_Cycle()
        {
            #region Level 1

            if (ActiveLevel == "Level1_1")
            {
                if(Gamestate == 0)
                {
                    Level1_1();
                }
                else if(Gamestate == 1)
                {
                    Level1_1();
                }
                else if(Gamestate == 2)
                {
                    Level1_1();
                }
                else if(Gamestate == 3)
                {
                    Level1_1();
                }
                else if(Gamestate == 4)
                {
                    Level1_1();
                }
                else if(Gamestate == 5)
                {
                    Level1_1();
                }
                else if(Gamestate == 6)
                {
                    Level1_1();
                }
                else if(Gamestate == 7)
                {
                    Level1_1();
                }
                else if(Gamestate == 8)
                {
                    Level1_1();
                }
            }

            #endregion
            #region Level 2

            else if (ActiveLevel == "Level2_1")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level2_1();
                }
                // gamestate 1 wordt gedaan door de reset
                else if (Gamestate == 2)
                {
                    Level2_1();
                }
                else if (Gamestate == 3)
                {
                    Level2_1();
                }
                else if (Gamestate == 4)
                {
                    Level2_1();
                }
                else if (Gamestate == 5)
                {
                    Level2_1();
                }
                else if (Gamestate == 6)
                {
                    Level2_1();
                }
                else if (Gamestate == 7)
                {
                    Level2_1();
                }
                else if (Gamestate == 8)
                {
                    Level2_1();
                }
                else if (Gamestate == 9)
                {
                    Level2_1();
                }
                else if (Gamestate == 10)
                {
                    Level2_1();
                }
                else if (Gamestate == 11)
                {
                    Level2_1();
                }
                else if (Gamestate == 12)
                {
                    Level2_1();
                }
            }
            else if (ActiveLevel == "Level2_2")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level2_2();
                }
                // gamestate 1 wordt gedaan door de reset
                else if (Gamestate == 2)
                {
                    Level2_2();
                }
                else if (Gamestate == 3)
                {
                    Level2_2();
                }
                else if (Gamestate == 4)
                {
                    Level2_2();
                }
                else if (Gamestate == 5)
                {
                    Level2_2();
                }
                else if (Gamestate == 6)
                {
                    Level2_2();
                }
                else if (Gamestate == 7)
                {
                    Level2_2();
                }
                else if (Gamestate == 8)
                {
                    Level2_2();
                }
            }

            #endregion
            #region Level 3

            else if (ActiveLevel == "Level3_1")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level3_1();
                }
                // gamestate 1 wordt gedaan door de reset
                else if (Gamestate == 2)
                {
                    Level3_1();
                }
                else if (Gamestate == 3)
                {
                    Level3_1();
                }
                else if (Gamestate == 4)
                {
                    Level3_1();
                }
                else if (Gamestate == 5)
                {
                    Level3_1();
                }
            }
            else if (ActiveLevel == "Level3_2")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level3_2();
                }
                // gamestate 1 wordt gedaan door de reset
                else if (Gamestate == 2)
                {
                    Level3_2();
                }
                else if (Gamestate == 3)
                {
                    Level3_2();
                }
                else if (Gamestate == 4)
                {
                    Level3_2();
                }
                else if (Gamestate == 5)
                {
                    Level3_2();
                }
            }
            else if (ActiveLevel == "Level3_3")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level3_3();
                }
                // gamestate 1 wordt gedaan door de reset
                else if (Gamestate == 2)
                {
                    Level3_3();
                }
                else if (Gamestate == 3)
                {
                    Level3_3();
                }
                else if (Gamestate == 4)
                {
                    Level3_3();
                }
                else if (Gamestate == 5)
                {
                    Level3_3();
                }
                else if (Gamestate == 6)
                {
                    Level3_3();
                }
                else if (Gamestate == 7)
                {
                    Level3_3();
                }
                else if (Gamestate == 8)
                {
                    Level3_3();
                }
                else if (Gamestate == 9)
                {
                    Level3_3();
                }
                else if (Gamestate == 10)
                {
                    Level3_3();
                }
                else if (Gamestate == 11)
                {
                    Level3_3();
                }
                else if (Gamestate == 12)
                {
                    Level3_3();
                }
            }
            else if (ActiveLevel == "Level3_4")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level3_4();
                }
                // gamestate 1 wordt gedaan door de reset
                else if (Gamestate == 2)
                {
                    Level3_4();
                }
                else if (Gamestate == 3)
                {
                    Level3_4();
                }
                else if (Gamestate == 4)
                {
                    Level3_4();
                }
                else if (Gamestate == 5)
                {
                    Level3_4();
                }
                else if (Gamestate == 6)
                {
                    Level3_4();
                }
                else if (Gamestate == 7)
                {
                    Level3_4();
                }
                else if (Gamestate == 8)
                {
                    Level3_4();
                }
                else if (Gamestate == 9)
                {
                    Level3_4();
                }
                else if (Gamestate == 10)
                {
                    Level3_4();
                }
                else if (Gamestate == 11)
                {
                    Level3_4();
                }
                else if (Gamestate == 12)
                {
                    Level3_4();
                }
                else if (Gamestate == 13)
                {
                    Level3_4();
                }
                else if (Gamestate == 14)
                {
                    Level3_4();
                }
                else if (Gamestate == 15)
                {
                    Level3_4();
                }
                else if (Gamestate == 16)
                {
                    Level3_4();
                }
                else if (Gamestate == 17)
                {
                    Level3_4();
                }
            }

            #endregion
            #region Level 4

            else if (ActiveLevel == "Level4_1")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level4_1();
                }
                else if (Gamestate == 1)
                {
                    Level4_1();
                }
                else if (Gamestate == 2)
                {
                    Level4_1();
                }
            }
            else if (ActiveLevel == "Level4_2")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level4_2();
                }
                else if (Gamestate == 1)
                {
                    Level4_2();
                }
                else if (Gamestate == 2)
                {
                    Level4_2();
                }
                else if (Gamestate == 3)
                {
                    Level4_2();
                }
                else if (Gamestate == 4)
                {
                    Level4_2();
                }
                else if (Gamestate == 5)
                {
                    Level4_2();
                }
                else if (Gamestate == 6)
                {
                    Level4_2();
                }
                else if (Gamestate == 7)
                {
                    Level4_2();
                }
                else if (Gamestate == 8)
                {
                    Level4_2();
                }
            }
            else if (ActiveLevel == "Level4_3")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level4_3();
                }
                else if (Gamestate == 1)
                {
                    Level4_3();
                }
                else if (Gamestate == 2)
                {
                    Level4_3();
                }
                else if (Gamestate == 3)
                {
                    Level4_3();
                }
                else if (Gamestate == 4)
                {
                    Level4_3();
                }
            }
            else if (ActiveLevel == "Level4_4")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level4_4();
                }
                else if (Gamestate == 1)
                {
                    Level4_4();
                }
                else if (Gamestate == 2)
                {
                    Level4_4();
                }
                else if (Gamestate == 3)
                {
                    Level4_4();
                }
                else if (Gamestate == 4)
                {
                    Level4_4();
                }
                else if (Gamestate == 5)
                {
                    Level4_4();
                }
                else if (Gamestate == 6)
                {
                    Level4_4();
                }
                else if (Gamestate == 7)
                {
                    Level4_4();
                }
                else if (Gamestate == 8)
                {
                    Level4_4();
                }
                else if (Gamestate == 9)
                {
                    Level4_4();
                }
                else if (Gamestate == 10)
                {
                    Level4_4();
                }
                else if (Gamestate == 11)
                {
                    Level4_4();
                }
                else if (Gamestate == 12)
                {
                    Level4_4();
                }
                else if (Gamestate == 13)
                {
                    Level4_4();
                }
                else if (Gamestate == 14)
                {
                    Level4_4();
                }
                else if (Gamestate == 15)
                {
                    Level4_4();
                }
            }
            else if (ActiveLevel == "Level4_5")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level4_5();
                }
                else if (Gamestate == 1)
                {
                    Level4_5();
                }
                else if (Gamestate == 2)
                {
                    Level4_5();
                }
                else if (Gamestate == 3)
                {
                    Level4_5();
                }
                else if (Gamestate == 4)
                {
                    Level4_5();
                }
                else if (Gamestate == 5)
                {
                    Level4_5();
                }
                else if (Gamestate == 6)
                {
                    Level4_5();
                }
                else if (Gamestate == 7)
                {
                    Level4_5();
                }
                else if (Gamestate == 8)
                {
                    Level4_5();
                }
            }

            #endregion
            #region Level 5

            else if (ActiveLevel == "Level5_1")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level5_1();
                }
                else if (Gamestate == 1)
                {
                    Level5_1();
                }
                else if (Gamestate == 2)
                {
                    Level5_1();
                }
                else if (Gamestate == 3)
                {
                    Level5_1();
                }
                else if (Gamestate == 4)
                {
                    Level5_1();
                }
                else if (Gamestate == 5)
                {
                    Level5_1();
                }
                else if (Gamestate == 6)
                {
                    Level5_1();
                }
                else if (Gamestate == 7)
                {
                    Level5_1();
                }
            }
            else if (ActiveLevel == "Level5_2")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level5_2();
                }
                else if (Gamestate == 1)
                {
                    Level5_2();
                }
                else if (Gamestate == 2)
                {
                    Level5_2();
                }
                else if (Gamestate == 3)
                {
                    Level5_2();
                }
                else if (Gamestate == 4)
                {
                    Level5_2();
                }
                else if (Gamestate == 5)
                {
                    Level5_2();
                }
                else if (Gamestate == 6)
                {
                    Level5_2();
                }
                else if (Gamestate == 7)
                {
                    Level5_2();
                }
                else if (Gamestate == 8)
                {
                    Level5_2();
                }
                else if (Gamestate == 9)
                {
                    Level5_2();
                }
                else if (Gamestate == 10)
                {
                    Level5_2();
                }
                else if (Gamestate == 11)
                {
                    Level5_2();
                }
                else if (Gamestate == 12)
                {
                    Level5_2();
                }
                else if (Gamestate == 13)
                {
                    Level5_2();
                }
                else if (Gamestate == 14)
                {
                    Level5_2();
                }
            }
            else if (ActiveLevel == "Level5_3")
            {
                if (Gamestate == 0)
                {
                    FirstTimeLoading = false;
                    Gamestate = 1;
                    Level5_3();
                }
                else if (Gamestate == 1)
                {
                    Level5_3();
                }
                else if (Gamestate == 2)
                {
                    Level5_3();
                }
                else if (Gamestate == 3)
                {
                    Level5_3();
                }
                else if (Gamestate == 4)
                {
                    Level5_3();
                }
                else if (Gamestate == 5)
                {
                    Level5_3();
                }
                else if (Gamestate == 6)
                {
                    Level5_3();
                }
                else if (Gamestate == 7)
                {
                    Level5_3();
                }
                else if (Gamestate == 8)
                {
                    Level5_3();
                }
                else if (Gamestate == 9)
                {
                    Level5_3();
                }
                else if (Gamestate == 10)
                {
                    Level5_3();
                }
                else if (Gamestate == 11)
                {
                    Level5_3();
                }
                else if (Gamestate == 12)
                {
                    Level5_3();
                }
                else if (Gamestate == 13)
                {
                    Level5_3();
                }
                else if (Gamestate == 14)
                {
                    Level5_3();
                }
                else if (Gamestate == 15)
                {
                    Level5_3();
                }
                else if (Gamestate == 16)
                {
                    Level5_3();
                }
                else if (Gamestate == 17)
                {
                    Level5_3();
                }
                else if (Gamestate == 18)
                {
                    Level5_3();
                }
                else if (Gamestate == 19)
                {
                    Level5_3();
                }
            }
            else if (ActiveLevel == "Level5_4")
            {
                if (Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level5_4();
                }
                else if (Gamestate == 1)
                {
                    Level5_4();
                }
                else if (Gamestate == 2)
                {
                    Level5_4();
                }
                else if (Gamestate == 3)
                {
                    Level5_4();
                }
                else if (Gamestate == 4)
                {
                    Level5_4();
                }
                else if (Gamestate == 5)
                {
                    Level5_4();
                }
            }
            else if (ActiveLevel == "Level5_5")
            {
                Level5_5();
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level5_5();
                }
                else if(Gamestate == 1)
                {
                    Level5_5();
                }
                else if(Gamestate == 2)
                {
                    Level5_5();
                }
                else if(Gamestate == 3)
                {
                    Level5_5();
                }
                else if(Gamestate == 4)
                {
                    Level5_5();
                }
                else if(Gamestate == 5)
                {
                    Level5_5();
                }
                else if(Gamestate == 6)
                {
                    Level5_5();
                }
                else if(Gamestate == 7)
                {
                    Level5_5();
                }
                else if(Gamestate == 8)
                {
                    Level5_5();
                }
                else if(Gamestate == 9)
                {
                    Level5_5();
                }
                else if(Gamestate == 10)
                {
                    Level5_5();
                }
                else if(Gamestate == 11)
                {
                    Level5_5();
                }
                else if(Gamestate == 12)
                {
                    Level5_5();
                }
                else if(Gamestate == 13)
                {
                    Level5_5();
                }
                else if(Gamestate == 14)
                {
                    Level5_5();
                }
                else if(Gamestate == 15)
                {
                    Level5_5();
                }
                else if(Gamestate == 16)
                {
                    Level5_5();
                }
                else if(Gamestate == 17)
                {
                    Level5_5();
                }
                else if(Gamestate == 18)
                {
                    Level5_5();
                }
                else if(Gamestate == 19)
                {
                    Level5_5();
                }
                else if(Gamestate == 20)
                {
                    Level5_5();
                }
            }

            #endregion
            #region Level 6

            else if(ActiveLevel == "Level6_1")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level6_1();
                }
                else if(Gamestate == 1)
                {
                    Level6_1();
                }
                else if(Gamestate == 2)
                {
                    Level6_1();
                }
                else if(Gamestate == 3)
                {
                    Level6_1();
                }
                else if(Gamestate == 4)
                {
                    Level6_1();
                }
                else if(Gamestate == 5)
                {
                    Level6_1();
                }
                else if(Gamestate == 6)
                {
                    Level6_1();
                }
                else if(Gamestate == 7)
                {
                    Level6_1();
                }
                else if(Gamestate == 8)
                {
                    Level6_1();
                }
                else if(Gamestate == 9)
                {
                    Level6_1();
                }
                else if(Gamestate == 10)
                {
                    Level6_1();
                }
                else if(Gamestate == 11)
                {
                    Level6_1();
                }
                else if(Gamestate == 12)
                {
                    Level6_1();
                }
                else if(Gamestate == 13)
                {
                    Level6_1();
                }
                else if(Gamestate == 14)
                {
                    Level6_1();
                }
                else if(Gamestate == 15)
                {
                    Level6_1();
                }
                else if(Gamestate == 16)
                {
                    Level6_1();
                }
                else if(Gamestate == 17)
                {
                    Level6_1();
                }
            }
            else if(ActiveLevel == "Level6_2")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level6_2();
                }
                else if(Gamestate == 1)
                {
                    Level6_2();
                }
                else if(Gamestate == 2)
                {
                    Level6_2();
                }
                else if(Gamestate == 3)
                {
                    Level6_2();
                }
                else if(Gamestate == 4)
                {
                    Level6_2();
                }
                else if(Gamestate == 5)
                {
                    Level6_2();
                }
                else if(Gamestate == 6)
                {
                    Level6_2();
                }

            }
            else if(ActiveLevel == "Level6_3")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level6_3();
                }
                else if(Gamestate == 1)
                {
                    Level6_3();
                }
                else if(Gamestate == 2)
                {
                    Level6_3();
                }
                else if(Gamestate == 3)
                {
                    Level6_3();
                }
                else if(Gamestate == 4)
                {
                    Level6_3();
                }
                else if(Gamestate == 5)
                {
                    Level6_3();
                }
                else if(Gamestate == 6)
                {
                    Level6_3();
                }
                else if(Gamestate == 7)
                {
                    Level6_3();
                }
                else if(Gamestate == 8)
                {
                    Level6_3();
                }
                else if(Gamestate == 9)
                {
                    Level6_3();
                }
                else if(Gamestate == 10)
                {
                    Level6_3();
                }
                else if(Gamestate == 11)
                {
                    Level6_3();
                }
                else if(Gamestate == 12)
                {
                    Level6_3();
                }
                else if(Gamestate == 13)
                {
                    Level6_3();

                    #region password
                    Gamestate = 13;

                    if(TbUserInput1.Text == "Password")
                    {
                        LblTextBottom.Text = "Enter the password and click on the Continue button.";
                    }
                    else if(TbUserInput1.Text == "")
                    {
                        LblTextBottom.Text = "Please fill in a password.";
                    }
                    else if(TbUserInput1.Text == "PAC")
                    {
                        FirstTimeLoading = true;
                        Level7_1();
                    }
                    else
                    {
                        FirstTimeLoading = true;
                        Level7_2();
                    }
                    #endregion
                }
            }
            else if(ActiveLevel == "Level6_4")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level6_4();
                }
                else if(Gamestate == 1)
                {
                    Level6_4();
                }
                else if(Gamestate == 2)
                {
                    Level6_4();
                }
                else if(Gamestate == 3)
                {
                    Level6_4();
                }
                else if(Gamestate == 4)
                {
                    Level6_4();
                }
            }
            else if(ActiveLevel == "Level6_5")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level6_5();
                }
                else if(Gamestate == 1)
                {
                    Level6_5();
                }
                else if(Gamestate == 2)
                {
                    Level6_5();
                }
                else if(Gamestate == 3)
                {
                    Level6_5();
                }
            }
            else if(ActiveLevel == "Level6_6")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level6_6();
                }
                else if(Gamestate == 1)
                {
                    Level6_6();
                }
                else if(Gamestate == 2)
                {
                    Level6_6();
                }
                else if(Gamestate == 3)
                {
                    Level6_6();
                }
                else if(Gamestate == 4)
                {
                    Level6_6();
                }
                else if(Gamestate == 5)
                {
                    Level6_6();
                }
                else if(Gamestate == 6)
                {
                    Level6_6();
                }
                else if(Gamestate == 7)
                {
                    Level6_6();
                }
                else if(Gamestate == 8)
                {
                    Level6_6();
                }
                else if(Gamestate == 9)
                {
                    Level6_6();
                }
                else if(Gamestate == 10)
                {
                    Level6_6();
                }
                else if(Gamestate == 11)
                {
                    Level6_6();
                }
                else if(Gamestate == 12)
                {
                    Level6_6();
                }
                else if(Gamestate == 13)
                {
                    Level6_6();
                }
                else if(Gamestate == 14)
                {
                    Level6_6();
                }
                else if(Gamestate == 15)
                {
                    Level6_6();
                }
                else if(Gamestate == 16)
                {
                    Level6_6();
                }
                else if(Gamestate == 17)
                {
                    Level6_6();
                }
                else if(Gamestate == 18)
                {
                    Level6_6();
                }
                else if(Gamestate == 19)
                {
                    Level6_6();
                }
                else if(Gamestate == 20)
                {
                    Level6_6();
                }
                else if(Gamestate == 21)
                {
                    Level6_6();
                }
                else if(Gamestate == 22)
                {
                    Level6_6();
                }
            }

            #endregion
            #region Level 7

            else if(ActiveLevel == "Level7_1")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level7_1();
                }
                else if(Gamestate == 1)
                {
                    Level7_1();
                }
                else if(Gamestate == 2)
                {
                    Level7_1();
                }
                else if(Gamestate == 3)
                {
                    Level7_1();
                }
                else if(Gamestate == 4)
                {
                    Level7_1();
                }
                else if(Gamestate == 5)
                {
                    Level7_1();
                }
                else if(Gamestate == 6)
                {
                    Level7_1();
                }
                else if(Gamestate == 7)
                {
                    Level7_1();
                }
                else if(Gamestate == 8)
                {
                    Level7_1();
                }
            }
            else if(ActiveLevel == "Level7_2")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level7_2();
                }
                else if(Gamestate == 1)
                {
                    Level7_2();
                }
                else if(Gamestate == 2)
                {
                    Level7_2();
                }
            }
            else if(ActiveLevel == "Level7_3")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level7_3();
                }
                else if(Gamestate == 1)
                {
                    Level7_3();
                }
                else if(Gamestate == 2)
                {
                    Level7_3();
                }
                else if(Gamestate == 3)
                {
                    Level7_3();
                }
                else if(Gamestate == 4)
                {
                    Level7_3();
                }
                else if(Gamestate == 5)
                {
                    Level7_3();
                }
            }
            else if(ActiveLevel == "Level7_4")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level7_4();
                    TbuserInput1_Reset();
                }
                else if(Gamestate == 1)
                {
                    Level7_4();
                }
                else if(Gamestate == 2)
                {
                    Level7_4();

                    #region password
                    Gamestate = 2;

                    if(TbUserInput1.Text == "Password")
                    {
                        LblTextBottom.Text = "Enter the password and click on the Continue button.";
                    }
                    else if(TbUserInput1.Text == "")
                    {
                        LblTextBottom.Text = "Please fill in a password.";
                    }
                    else if(TbUserInput1.Text == "PAC")
                    {
                        FirstTimeLoading = true;
                        Level7_1();
                    }
                    else
                    {
                        FirstTimeLoading = true;
                        Level7_3();
                    }
                    #endregion
                }
            }

            #endregion
            #region Level 8

            else if(ActiveLevel == "Level8_1")
            {
                if(Gamestate == 0)
                {
                    FirstTimeLoading = false;
                    Gamestate = 1;
                    Level8_1();
                }
                else if(Gamestate == 1)
                {
                    Level8_1();
                }
                else if(Gamestate == 2)
                {
                    Level8_1();
                }
                else if(Gamestate == 3)
                {
                    Level8_1();
                }
                else if(Gamestate == 4)
                {
                    Level8_1();
                }
                else if(Gamestate == 5)
                {
                    Level8_1();
                }
                else if(Gamestate == 6)
                {
                    Level8_1();
                }
                else if(Gamestate == 7)
                {
                    Level8_1();
                }
                else if(Gamestate == 8)
                {
                    Level8_1();
                }
                else if(Gamestate == 9)
                {
                    Level8_1();
                }
                else if(Gamestate == 10)
                {
                    Level8_1();
                }
                else if(Gamestate == 11)
                {
                    Level8_1();
                }
                else if(Gamestate == 12)
                {
                    Level8_1();
                }
                else if(Gamestate == 13)
                {
                    Level8_1();
                }
                else if(Gamestate == 14)
                {
                    Level8_1();
                }
                else if(Gamestate == 15)
                {
                    Level8_1();
                }
                else if(Gamestate == 16)
                {
                    Level8_1();
                }
                else if(Gamestate == 17)
                {
                    Level8_1();
                }
                else if(Gamestate == 18)
                {
                    Level8_1();
                }
                else if(Gamestate == 19)
                {
                    Level8_1();
                }
                else if(Gamestate == 20)
                {
                    Level8_1();
                }
                else if(Gamestate == 21)
                {
                    Level8_1();
                }
                else if(Gamestate == 22)
                {
                    Level8_1();
                }
                else if(Gamestate == 23)
                {
                    Level8_1();
                }
            }
            else if(ActiveLevel == "Level8_2")
            {
                if(Gamestate == 0)
                {
                    FirstTimeLoading = false;
                    Gamestate = 1;
                    Level8_2();
                }
                else if(Gamestate == 1)
                {
                    Level8_2();
                }
                else if(Gamestate == 2)
                {
                   Level8_2();
                }
                else if(Gamestate == 3)
                {
                    Level8_2();
                }
                else if(Gamestate == 4)
                {
                    Level8_2();
                }
                else if(Gamestate == 5)
                {
                    Level8_2();
                }
                else if(Gamestate == 6)
                {
                    Level8_2();
                }
                else if(Gamestate == 7)
                {
                    Level8_2();
                }
            }

            #endregion
            #region Level 9

            else if(ActiveLevel == "Level9_1")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level9_1();
                }
                else if(Gamestate == 1)
                {
                    Level9_1();
                }
                else if(Gamestate == 2)
                {
                    Level9_1();
                }
                else if(Gamestate == 3)
                {
                    Level9_1();
                }
                else if(Gamestate == 4)
                {
                    Level9_1();
                }
                else if(Gamestate == 5)
                {
                    Level9_1();
                }
                else if(Gamestate == 6)
                {
                    Level9_1();
                }
                else if(Gamestate == 7)
                {
                    Level9_1();
                }
                else if(Gamestate == 8)
                {
                    Level9_1();
                }
                else if(Gamestate == 9)
                {
                    Level9_1();
                }
                else if(Gamestate == 10)
                {
                    Level9_1();
                }
            }
            else if(ActiveLevel == "Level9_2")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level9_2();
                }
                else if(Gamestate == 1)
                {
                    Level9_2();
                }
                else if(Gamestate == 2)
                {
                    Level9_2();
                }
                else if(Gamestate == 3)
                {
                    Level9_2();
                }
                else if(Gamestate == 4)
                {
                    Level9_2();
                }
                else if(Gamestate == 5)
                {
                    Level9_2();
                }
                else if(Gamestate == 6)
                {
                    Level9_2();
                }
                else if(Gamestate == 7)
                {
                    Level9_2();
                }
                else if(Gamestate == 8)
                {
                    Level9_2();
                }
                else if(Gamestate == 9)
                {
                    Level9_2();
                }
                else if(Gamestate == 10)
                {
                    Level9_2();
                }
                else if(Gamestate == 11)
                {
                    Level9_2();
                }
                else if(Gamestate == 12)
                {
                    Level9_2();
                }
            }
            else if(ActiveLevel == "Level9_3")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level9_3();
                }
                else if(Gamestate == 1)
                {
                    Level9_3();
                }
                else if(Gamestate == 2)
                {
                    Level9_3();
                }
                else if(Gamestate == 3)
                {
                    Level9_3();
                }
                else if(Gamestate == 4)
                {
                    Level9_3();
                }
                else if(Gamestate == 5)
                {
                    Level9_3();
                }
                else if(Gamestate == 6)
                {
                    Level9_3();
                }
                else if(Gamestate == 7)
                {
                    Level9_3();
                }
                else if(Gamestate == 8)
                {
                    Level9_3();
                }
                else if(Gamestate == 9)
                {
                    Level9_3();
                }
                else if(Gamestate == 10)
                {
                    Level9_3();
                }
                else if(Gamestate == 11)
                {
                    Level9_3();
                }
                else if(Gamestate == 12)
                {
                    Level9_3();
                }
                else if(Gamestate == 13)
                {
                    Level9_3();
                }
                else if(Gamestate == 14)
                {
                    Level9_3();
                }
                else if(Gamestate == 15)
                {
                    Level9_3();
                }
                else if(Gamestate == 16)
                {
                    Level9_3();
                }
                else if(Gamestate == 17)
                {
                    Level9_3();
                }
                else if(Gamestate == 18)
                {
                    Level9_3();
                }
                else if(Gamestate == 19)
                {
                    Level9_3();
                }
                else if(Gamestate == 20)
                {
                    Level9_3();
                }
                else if(Gamestate == 21)
                {
                    Level9_3();
                }
                else if(Gamestate == 22)
                {
                    Level9_3();
                }
                else if(Gamestate == 23)
                {
                    Level9_3();
                }
            }
            else if(ActiveLevel == "Level9_4")
            {
                if(Gamestate == 0)
                {
                    Gamestate = 1;
                    FirstTimeLoading = false;
                    Level9_4();
                }
                else if(Gamestate == 1)
                {
                    Level9_4();
                }
                else if(Gamestate == 2)
                {
                    Level9_4();
                }
                else if(Gamestate == 3)
                {
                    Level9_4();
                }
            }

            #endregion


            #region Error

            else
            {
                this.Close();
                MessageBox.Show("An error occured. We're sorry for the inconvinience", "Warning:");
                Application.Exit();
            }

            #endregion

        } //alle cycles die er moeten gebeuren bij PbFastForward_Click
        private void BtnChoice1_Cycle()
        {
            #region Level 1

            if(ActiveLevel == "Level1_1")
            {
                if (Gamestate == 2)
                {
                    Level1_1();
                }
                else if (Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level2_1();
                }
            }

            #endregion
            #region Level 2

            else if (ActiveLevel == "Level2_1")
            {
                if (Gamestate == 12)
                {
                    FirstTimeLoading = true;
                    Level3_1();
                }
            }
            else if (ActiveLevel == "Level2_2")
            {
                if (Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level3_3();
                }
            }

            #endregion
            #region Level 3

            else if (ActiveLevel == "Level3_1")
            {
                if (Gamestate == 5)
                {
                    FirstTimeLoading = true;
                    Level4_1();
                }
            }
            else if (ActiveLevel == "Level3_2")
            {
                if (Gamestate == 5)
                {
                    FirstTimeLoading = true;
                    Level4_3();
                }
            }
            else if (ActiveLevel == "Level3_3")
            {
                if (Gamestate == 12)
                {
                    FirstTimeLoading = true;
                    Level4_4();
                }
            }
            else if (ActiveLevel == "Level3_4")
            {
                if (Gamestate == 6)
                {
                    Level3_4();
                }
                else if (Gamestate == 17)
                {
                    FirstTimeLoading = true;
                    Level4_3();
                }
            }

            #endregion
            #region Level 4

            else if (ActiveLevel == "Level4_1")
            {
            }
            else if (ActiveLevel == "Level4_2")
            {
                if (Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level4_3();
                }
            }
            else if (ActiveLevel == "Level4_3")
            {
                if (Gamestate == 3)
                {
                    Level4_3();
                }
                else if (Gamestate == 4)
                {
                    FirstTimeLoading = true;
                    Level5_1();
                }
            }
            else if (ActiveLevel == "Level4_4")
            {
                if (Gamestate == 15)
                {
                    FirstTimeLoading = true;
                    Level5_3();
                }
            }
            else if (ActiveLevel == "Level4_5")
            {
                if (Gamestate == 3)
                {
                    Level4_5();
                }
                else if (Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level5_4();
                }
            }

            #endregion
            #region Level 5

            else if (ActiveLevel == "Level5_1")
            {
                if (Gamestate == 7)
                {
                    FirstTimeLoading = true;
                    Level6_1();
                }
            }
            else if (ActiveLevel == "Level5_2")
            {
                if (Gamestate == 3)
                {
                    Level5_2();
                }
                else if (Gamestate == 4)
                {
                    Level5_2();
                }
                else if (Gamestate == 5)
                {
                    Level5_2();
                }
                else if (Gamestate == 9)
                {
                    Level5_2();
                }
                else if (Gamestate == 10)
                {
                    Level5_2();
                }
                else if (Gamestate == 14)
                {
                    FirstTimeLoading = true;
                    Level6_3();
                }
            }
            else if (ActiveLevel == "Level5_3")
            {
                if (Gamestate == 19)
                {
                    FirstTimeLoading = true;
                    Level6_5();
                }
            }
            else if (ActiveLevel == "Level5_4")
            {
                if (Gamestate == 4)
                {
                    Level5_4();
                }
            }
            else if (ActiveLevel == "Level5_5")
            {
                if(Gamestate == 4)
                {
                    Level5_5();
                }
                else if(Gamestate == 5)
                {
                    Level5_5();
                }
                else if(Gamestate == 6)
                {
                    Level5_5();
                }
                else if(Gamestate == 7)
                {
                    Level5_5();
                }
                else if(Gamestate == 21)
                {
                    FirstTimeLoading = true;
                    Level5_3();
                }
            }

            #endregion
            #region Level 6

            else if(ActiveLevel == "Level6_1")
            {
                if(Gamestate == 3)
                {
                    Level6_1();
                }
                else if(Gamestate == 5)
                {
                    Level6_1();
                }
                else if(Gamestate == 7)
                {
                    Level6_1();
                }
                else if(Gamestate == 12)
                {
                    Level6_1();
                }
                else if(Gamestate == 13)
                {
                    Level6_1();
                }
                else if(Gamestate == 17)
                    {
                        FirstTimeLoading = true;
                        Level6_3();
                    }
            }
            else if(ActiveLevel == "Level6_2")
            {
                if(Gamestate == 3)
                {
                    Level6_2();
                }
                else if(Gamestate == 4)
                {
                    Level6_2();
                }
                else if(Gamestate == 5)
                {
                    Level6_2();
                }
            }
            else if(ActiveLevel == "Level6_3")
            {
                if(Gamestate == 5)
                {
                    Level6_3();
                }
                else if(Gamestate == 11)
                {
                    Level6_3();
                }
            }
            else if(ActiveLevel == "Level6_5")
            {
                if(Gamestate == 2)
                {
                Level6_5();
                }
            }
            else if(ActiveLevel == "Level6_6")
            {
                if(Gamestate == 7)
                {
                    Level6_6();
                }
                else if(Gamestate == 9)
                {
                    Level6_6();
                }
                else if(Gamestate == 10)
                {
                    Level6_6();
                }
                else if(Gamestate == 11)
                {
                    Level6_6();
                }
                else if(Gamestate == 12)
                {
                    Level6_6();
                }
                else if(Gamestate == 21)
                {
                    Level6_6();
                }
                else if(Gamestate == 22)
                {
                    FirstTimeLoading = true;
                    Level4_3();
                }
            }
            #endregion
            #region Level 7

            if(ActiveLevel == "Level7_1")
            {
                if(Gamestate == 6)
                {
                    Level7_1();
                }
                else if(Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level8_1();
                }
            }
            else if(ActiveLevel == "Level7_2")
            {
                if(Gamestate == 2)
                {
                    FirstTimeLoading = true;
                    Level7_3();
                }
            }

            #endregion
            #region Level 8

            else if(ActiveLevel == "Level8_1")
            {
                if(Gamestate == 2)
                {
                    Level8_1();
                }
                else if(Gamestate == 3)
                {
                    Level8_1();
                }
                else if(Gamestate == 4)
                {
                    Level8_1();
                }
                else if(Gamestate == 5)
                {
                    Level8_1();
                }
                else if(Gamestate == 8)
                {
                    Level8_1();
                }
                else if(Gamestate == 13)
                {
                    Level8_1();
                }
                else if(Gamestate == 23)
                {
                    FirstTimeLoading = true;
                    Level9_1();
                }
            }
            else if(ActiveLevel == "Level8_2")
            {
                if(Gamestate == 3)
                {
                    Level8_2();
                }
                else if(Gamestate == 4)
                {
                    Level8_2();
                }
                else if(Gamestate == 5)
                {
                    Level8_2();
                }
                else if(Gamestate == 7)
                {
                    FirstTimeLoading = true;
                    Level9_3();
                }
            }

            #endregion
            #region Level 9

            else if(ActiveLevel == "Level9_1")
            {
                if(Gamestate == 7)
                {
                    Level9_1();
                }
            }
            else if(ActiveLevel == "Level9_2")
            {
                if(Gamestate == 3)
                {
                    Level9_2();
                }
                else if(Gamestate == 5)
                {
                    Level9_2();
                }
                else if(Gamestate == 7)
                {
                    Level9_2();
                }
            }
            else if(ActiveLevel == "Level9_3")
            {
                if(Gamestate == 3)
                {
                    Level9_3();
                }
                else if(Gamestate == 4)
                {
                    Level9_3();
                }
                else if(Gamestate == 5)
                {
                    Level9_3();
                }
                else if(Gamestate == 6)
                {
                    Level9_3();
                }
                else if(Gamestate == 8)
                {
                    Level9_3();
                }
                else if(Gamestate == 9)
                {
                    Level9_3();
                }
                else if(Gamestate == 10)
                {
                    Level9_3();
                }
                else if(Gamestate == 13)
                {
                    Level9_3();
                }
                else if(Gamestate == 15)
                {
                    Level9_3();
                }
                else if(Gamestate == 16)
                {
                    Level9_3();
                }
            }

            #endregion

        } // alle cycles die er moeten gebeuren bij BtnChoice1_Click
        private void BtnChoice2_Cycle()
        {
            #region Level 1

            if(ActiveLevel == "Level1_1")
            {
                if(Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level2_2();
                }
            }

            #endregion
            #region Level 2

            else if(ActiveLevel == "Level2_1")
            {
                if(Gamestate == 12)
                {
                    FirstTimeLoading = true;
                    Level3_2();
                }
            }
            else if(ActiveLevel == "Level2_2")
            {
                if(Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level3_4();
                }
            }

            #endregion
            #region Level 3

            else if(ActiveLevel == "Level3_1")
            {
                if(Gamestate == 5)
                {
                    FirstTimeLoading = true;
                    Level4_2();
                }
            }
            else if(ActiveLevel == "Level3_3")
            {
                if(Gamestate == 12)
                {
                    FirstTimeLoading = true;
                    Level4_5();
                }
            }

            #endregion
            #region Level 4

            else if(ActiveLevel == "Level4_3")
            {
                if(Gamestate == 4)
                {
                    FirstTimeLoading = true;
                    Level5_2();
                }
            }
            else if(ActiveLevel == "Level4_5")
            {
                if(Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level5_5();
                }
            }

            #endregion
            #region Level 5

            else if(ActiveLevel == "Level5_1")
            {
                if(Gamestate == 7)
                {
                    FirstTimeLoading = true;
                    Level6_2();
                }
            }
            else if(ActiveLevel == "Level5_2")
            {
                if(Gamestate == 14)
                {
                    FirstTimeLoading = true;
                    Level6_4();
                }
            }
            else if(ActiveLevel == "Level5_3")
            {
                if(Gamestate == 19)
                {
                    FirstTimeLoading = true;
                    Level6_6();
                }
            }

            #endregion
            #region Level 6

            else if (ActiveLevel == "Level6_1")
            {
                if(Gamestate == 17)
                {
                    FirstTimeLoading = true;
                    Level6_4();
                }
            }

            #endregion
            #region Level 7

            if(ActiveLevel == "Level7_1")
            {
                if(Gamestate == 8)
                {
                    FirstTimeLoading = true;
                    Level8_2();
                }
            }
            else if(ActiveLevel == "Level7_2")
            {
                if(Gamestate == 2)
                {
                    FirstTimeLoading = true;
                    Level7_4();
                }
            }

            #endregion
            #region Level 8

            else if(ActiveLevel == "Level8_1")
            {
                if(Gamestate == 23)
                {
                    FirstTimeLoading = true;
                    Level9_2();
                }
            }
            else if(ActiveLevel == "Level8_2")
            {
                if(Gamestate == 7)
                {
                    FirstTimeLoading = true;
                    Level9_4();
                }
            }

            #endregion
            #region Level 9

            else if(ActiveLevel == "Level9_2")
            {
                if(Gamestate == 3)
                {
                    Level9_2();
                }
                else if(Gamestate == 5)
                {
                    Level9_2();
                }
                else if(Gamestate == 7)
                {
                    Level9_2();
                }
            }

            #endregion

        } // alle cycles die er moeten gebeuren bij BtnChoice2_Click

        private void PbFastForward_Click(object sender, EventArgs e)
        {
            #region sound

            if(SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            #region Typewriter

            if (IsActive == true)
            {
                TypeWriterEffectBottom();
                LoopDelay = 0;
            }
            else
            {
                TypeWriter_Reset();
                LoopDelay_Reset();

                Gamestate_Cycle(); // #1

                FullTextBottom = LblTextBottom.Text; // #2
                
                TypeWriterEffectBottom(); // #3
            }

            #endregion
        } // alle dingen die er moeten gebeuren bij klik op deze button, uitgesorteerd met afzonderlijke methods.

        private void BtnChoice1_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            #region Typewriter

            if (IsActive == true)
            {
                TypeWriterEffectBottom();
                LoopDelay = 0;
            }
            else
            {
                TypeWriter_Reset();
                LoopDelay_Reset();

                BtnChoice1_Cycle();

                FullTextBottom = LblTextBottom.Text; // #2

                TypeWriterEffectBottom(); // #3
            }

            #endregion
        } // alle dingen die er moeten gebeuren bij klik op deze button, uitgesorteerd met afzonderlijke methods.
        private void BtnChoice2_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            #region Typewriter

            if (IsActive == true)
            {
                TypeWriterEffectBottom();
                LoopDelay = 0;
            }
            else
            {
                TypeWriter_Reset();
                LoopDelay_Reset();

                BtnChoice2_Cycle();

                FullTextBottom = LblTextBottom.Text; // #2

                TypeWriterEffectBottom(); // #3
            }

            #endregion
        } // alle dingen die er moeten gebeuren bij klik op deze button, uitgesorteerd met afzonderlijke methods.

        private void BtnHome_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            #region sound resets

            FrmHome.FormFirstTimeLoaded = true;
            BgMusicMixGame.Stop();
            ButtonClickSound.Stop();
            FrmHome.MusicOn = MusicOn;
            FrmHome.SoundOn = SoundOn;

            #endregion

            this.Hide();
            FrmHome.Show();
            this.Close();

            ActiveLevel = "Level1_1";
            Gamestate = 0;
            FirstTimeLoading = true;
            UsernameGame = null;
        } // alle dingen die er moeten gebeuren bij klik op deze button

        private void TbUserInput1_Click(object sender, EventArgs e)
        {
            TbUserInput1.Text = "";
            TbUserInput1.ForeColor = System.Drawing.Color.White;
            TbUserInput1.Font = new Font("Consolas", 13, FontStyle.Bold);
            TbUserInput1.CharacterCasing = CharacterCasing.Upper;
        } // alle dingen die er moeten gebeuren bij klik op deze userinput
        private void TbuserInput1_Reset()
        {
            TbUserInput1.CharacterCasing = CharacterCasing.Normal;
            TbUserInput1.Text = "Password";
            TbUserInput1.ForeColor = System.Drawing.Color.Gray;
            TbUserInput1.Font = new System.Drawing.Font("Consolas", 13, System.Drawing.FontStyle.Italic);
        } // reset van de userinput qua kleur en letters, voor gebruik later

        #endregion


        #region Typewriter om text letter voor letter te laten zien

        public async void TypeWriterEffectBottom()
        {
            if(this.BackgroundImage != null)
            {
                if(LblTextBottom.Visible == true)
                {
                    for(i=0; i < FullTextBottom.Length + 1; i++)
                    {
                        CurrentTextBottom = FullTextBottom.Substring(0, i); // current string updaten met 1 letter erbij
                        LblTextBottom.Text = CurrentTextBottom; // die string "tijdelijk" plaatsen in de textbox
                        await Task.Delay(LoopDelay); // milliseconden wachten tot de volgende update
                    
                        #region checks for IsActive

                        if(i < FullTextBottom.Length + 1)
                        {
                            IsActive = true;
                        }
                        if(CurrentTextBottom.Length == FullTextBottom.Length)
                        {
                            IsActive = false;
                        }
                        if(i == FullTextBottom.Length)
                        {
                            IsActive = false;
                        }

                        #endregion
                    }
                }
            }
        }
        public void TypeWriter_Reset()
        {
            FullTextBottom = "";
            CurrentTextBottom = "";
        }
        public void LoopDelay_Reset()
        {
            LoopDelay = 30;
        }

        #endregion


        #region pausemenu

        // counters voor meldingen bij exiten van game form
        int counter1 = 0;
        int counter2 = 0;



        // button die de pause menu opent
        private void PbPause_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            // nieuwe controls over normale form heen laten zien:

            PbPauseBackground.Visible = true;
            PbPauseBackground.BringToFront();

            PbResume.Visible = true;
            PbResume.BringToFront();
            LblPauseSettings.Visible = true;
            LblPauseSettings.BringToFront();
            LblPauseTitle.Visible = true;
            LblPauseTitle.BringToFront();
            PbPauseMinimize.Visible = true;
            PbPauseMinimize.BringToFront();

            BtnPauseResume.Visible = true;
            BtnPauseResume.BringToFront();
            BtnPauseHowToPlay.Visible = true;
            BtnPauseHowToPlay.BringToFront();
            BtnPauseHome.Visible = true;
            BtnPauseHome.BringToFront();

            CbxSettingsSounds.Visible = true;
            CbxSettingsSounds.BringToFront();
            CbxSettingsMusic.Visible = true;
            CbxSettingsMusic.BringToFront();

            LblPauseStats.Visible = true;
            LblPauseStats.BringToFront();
            LblPauseStats2.Visible = true;
            LblPauseStats2.BringToFront();

            LblPauseStats2.Text = "Username: " + UsernameGame +
                "\r\n\r\n" +
                "Level: " + ActiveLevel +
                "\r\n" +
                "Scene: " + Gamestate;
        }

        // resume button 1 in de pause menu
        private void PbResume_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            PbPauseBackground.Visible = false;

            PbResume.Visible = false;
            PbPauseMinimize.Visible = false;
            LblPauseSettings.Visible = false;
            LblPauseTitle.Visible = false;

            BtnPauseResume.Visible = false;
            BtnPauseHowToPlay.Visible = false;
            BtnPauseHome.Visible = false;

            CbxSettingsSounds.Visible = false;
            CbxSettingsMusic.Visible = false;

            LblPauseStats.Visible = false;
            LblPauseStats2.Visible = false;
        }

        // resume button 2 in de pause menu
        private void PbPauseResume_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            PbPauseBackground.Visible = false;

            PbResume.Visible = false;
            PbPauseMinimize.Visible = false;
            LblPauseSettings.Visible = false;
            LblPauseTitle.Visible = false;

            BtnPauseResume.Visible = false;
            BtnPauseHowToPlay.Visible = false;
            BtnPauseHome.Visible = false;

            CbxSettingsSounds.Visible = false;
            CbxSettingsMusic.Visible = false;

            LblPauseStats.Visible = false;
            LblPauseStats2.Visible = false;
        }

        // button die voor het minimizen van de form zorgt
        private void PbPauseMinimize_Click(object sender, EventArgs e)
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

        // button voor naar het how to play menu te gaan
        private void BtnPauseHowToPlay_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            counter2 = 0;

            if (counter1 == 0)
            {
                MessageBox.Show("When you exit this pause menu, all your progress will be lost. Please click again to continue.", "Warning:");
                counter1 += 1;
            }
            else if (counter1 == 1)
            {
                #region sounds

                FrmHome.FormFirstTimeLoaded = true;
                BgMusicMixGame.Stop();
                ButtonClickSound.Stop();
                FrmHome.MusicOn = MusicOn;
                FrmHome.SoundOn = SoundOn;

                #endregion

                FrmHowTo FrmHowTo = new FrmHowTo();
                this.Hide();
                FrmHowTo.Show();
            }
        }

        // button voor naar het home menu te gaan
        private void BtnPauseHome_Click(object sender, EventArgs e)
        {
            #region sound

            if (SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            counter1 = 0;

            if (counter2 == 0)
            {
                MessageBox.Show("When you exit this pause menu, all your progress will be lost. Please click again to continue.", "Warning:");
                counter2 += 1;
            }
            else if (counter2 == 1)
            {
                #region sounds

                FrmHome.FormFirstTimeLoaded = true;
                BgMusicMixGame.Stop();
                ButtonClickSound.Stop();
                FrmHome.MusicOn = MusicOn;
                FrmHome.SoundOn = SoundOn;

                #endregion

                this.Hide();
                FrmHome.Show();
            }
        }

        // checkboxes voor instellingen
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
                BgMusicMixGame.Play();
                MusicOn = true;
            }
            else if(CbxSettingsMusic.Checked == false)
            {
                BgMusicMixGame.Pause();
                MusicOn = false;
            }
        }

        #endregion


        #region form movement

        private void FrmGame_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void FrmGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void FrmGame_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        #endregion


    }
}
