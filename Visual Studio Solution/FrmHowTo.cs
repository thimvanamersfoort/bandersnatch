using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
using System.Reflection;

namespace Bandersnatch
{
    public partial class FrmHowTo : Form
    {
        public FrmHowTo()
        {
            InitializeComponent();
        }


        #region variables

        #region general variables

        public static bool FormFirstTimeLoaded = true;
        FrmHome FrmHome = new FrmHome();

        #endregion
        #region sound variables

        string backgroundURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "BackgroundMusicMixHowToPlay.wav");
        string soundURI = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Click1.wav");

        public static MediaPlayer BgMusicMixHTP = new MediaPlayer();
        public static MediaPlayer ButtonClickSound = new MediaPlayer();

        #endregion

        #endregion


        #region FrmHowTo_Load + sound checks

        private void FrmHowTo_Load(object sender, EventArgs e)
        {
            SoundCheck();

            BgMusicMixHTP.MediaEnded += BgMusicMixHTP_MediaEnded;
        }
        private void SoundCheck()
        {
            if(FormFirstTimeLoaded == true && FrmHome.MusicOn == true)
            {
                BgMusicMixHTP.Open(new Uri(backgroundURI));
                BgMusicMixHTP.Play();

                FormFirstTimeLoaded = false;
            }
            if(FormFirstTimeLoaded == false && FrmHome.MusicOn == true)
            {
                BgMusicMixHTP.Play();

                FormFirstTimeLoaded = false;
            }
            if(FormFirstTimeLoaded == false && FrmHome.MusicOn == false)
            {
                FormFirstTimeLoaded = false;
            }
        } // gets called when form loads. only for home and how-to-play forms
        private void BgMusicMixHTP_MediaEnded(object sender, EventArgs e)
        {
            BgMusicMixHTP.Position = TimeSpan.Zero;
            BgMusicMixHTP.Play();
        } // gets called when backgroundmusic has ended. takes care of refresh.

        #endregion


        #region alle buttons

        private void BtnControls_Click(object sender, EventArgs e)
        {
            #region sound

            if(FrmHome.SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            BtnDownload.Visible = false;
            TbUserInput1.Visible = false;

            #region text
            LblText1.Text = "Bandersnatch is an interactive story game, where you control your own story and ending. \r\n \r\n" +

                "The game is heavily based on the film Bandersnatch (available on Netflix), and is created with the idea of " +
                "having multiple paths in one story, each with a different ending. You control the game entirely using your mouse, " +
                "so you won't need your keyboard (exept for filling in text ofcourse). \r\n \r\n" +

                "You have 3 main controls to control your story. You have 2 main buttons to make choices, and you have a smaller button to skip to the next scene. " +
                "These buttons will appear and disappear when they're needed. \r\n \r\n" +

                "The game is build upon different scenes. If you're done with one scene (if you read everything, thought about your choices, etc.), " +
                "you can click the small button(2 arrows) in the lower-right corner to enter the next scene of your story. " +
                "The 2 buttons for making different choices will also take you to different scenes. \r\n \r\n" +

                "When you're in a dialogue scene, the text will be displayed using a typewriter effect (printed letter by letter). " +
                "To skip this effect, click on any button used to skip gamestates (no pause button etc.), and the full text will display " +
                "in the textbox. When all the text is displayed, the buttons can be used for their main purpose again. \r\n \r\n" +

                "A pause button is located in the upper-left corner of the screen. This will always be available," +
                " and here you will be able to look at your stats, enter different menus, change the sound settings," +
                " and just take a quick break from the game. \r\n \r\n" +

                "There are different easter eggs hidden in the game. " +
                "These can be references to the original film Bandersnatch, other games and films, or just simple small jokes. " +
                "We're not gonna tell you where they are, so keep an eye out ;)";
            #endregion
        }
        private void BtnStory_Click(object sender, EventArgs e)
        {
            #region sound

            if (FrmHome.SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            BtnDownload.Visible = false;
            TbUserInput1.Visible = false;

            #region text
            LblText1.Text = "In Bandersnatch you play as an Agent. The Agent works for a secret service called The Agency and specializes in dealing with extreme threats. \r\n \r\n" +

                "This time, you control The Agent when he goes after the demon Pax. Pax is hiding in the dungeons of an old castle in Ukraine, " +
                "and as his power slowly increases, he is seen to become more and more dangerous, and must be dealt with as soon as possible. \r\n \r\n" +

                "The Agency has already sent several other Agents into the dungeons of Pax, but there has yet to be someone who makes it out alive. " +
                "Pax is known for being able to brainwash humans (and other creatures), causing an army of insane 'roamers' to roam through the infinitely large dungeons of Pax. \r\n \r\n" +

                "During your search you will encounter many of these 'roamers'. Some of them friendly, these will even try to help you, " +
                "but some will also be extremely aggressive. Sometimes you will even meet another Agent, but friendly or not, no one can be trusted. \r\n \r\n" +

                "The dungeons you wander around in feel suspicious, and change you the more you stay in them. The deeper you go, the darker it gets, " +
                "and the longer you stay in the dungeons, the more control Pax gains over you. \r\n \r\n" +

                "The creatures you encounter in the dungeons will give you choices, and the choices you make determine your journey. " +
                "Are you going to fight or are you running away? Pax will do everything in his power to make you fail your goal, so stay alert when you're in there...";
            #endregion
        }
        private void BtnChoices_Click(object sender, EventArgs e)
        {
            #region sound

            if (FrmHome.SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            BtnDownload.Visible = false;
            TbUserInput1.Visible = false;

            #region text
            LblText1.Text = "Bandersnatch is based on making choices, which affect the story of the game and is done by the player. " +
                "Every choice you make alters the story in one way or another. So if you finish the game one way, " +
                "and you decide to retry with other choices, you'll see that the story will end in some other way. " +
                "\r\n\r\n" + 
                "So every choice you make will be your own choice, that you personally made, right?" +
                "\r\n\r\n" +
                "By creating the illusion of free will, we were able to make a game relatively small, yet so open and free, " +
                "and still keeping players intrigued by giving them many different options." +
                "\r\n\r\n" +
                "This is what gives the game its replay-value, and with over 30 minutes of fresh, new gameplay, " +
                "you will always be able to just start over and choose an entirely different story.";
            #endregion
        }
        private void BtnCredits_Click(object sender, EventArgs e)
        {
            #region sound

            if (FrmHome.SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            BtnDownload.Visible = true;
            TbUserInput1.Visible = true;

            #region text
            LblText1.Text = "Credits: " +
                "\r\n\r\n" +
                "Sounds / Songs:" +
                "\r\n" +
                "- https://free-sample-packs.com/300-free-16-bit-retro-arcade-sfx/" +
                "\r\n" +
                "- Eurythmics - Here comes the rain again" +
                "\r\n" +
                "- Micheal Jackson - Billy Jean" +
                "\r\n" +
                "- Lupus Nocte - Howling" +


                "\r\n\r\n" +
                "Artwork:" +
                "\r\n" +
                "- https://Icons8.com" +
                "\r\n" +
                "- Piskel 0.14 Pixel-art Maker" +
                "\r\n" +
                "- Pixelator" +
                "\r\n" +
                "- Sfxr Sound generator" +

                "\r\n\r\n" +
                "Game design:" +
                "\r\n" +
                "- Thim van Amersfoort (Programming && Sound Design)" +
                "\r\n" +
                "- Rens Aarts (Programming && Sound Design)" +
                "\r\n" +
                "- Koen van Heesch (Game Design && Sound Design)" +

                "\r\n\r\n\r\n\r\n" +
                "Please fill in the password below to access the site to the game files.";
            #endregion
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            #region sound

            if(FrmHome.SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }
            if(FrmHome.MusicOn == true)
            {
                BgMusicMixHTP.Pause();
            }

            #endregion

            this.Hide();
            FrmHome.Show();
        }

        #endregion


        #region download

        string password;

        private void TbUserInput1_Click(object sender, EventArgs e)
        {
            TbUserInput1.Text = "";
            TbUserInput1.ForeColor = System.Drawing.Color.White;
            TbUserInput1.Font = new Font("Consolas", 10);
            TbUserInput1.UseSystemPasswordChar = true;
            TbUserInput1.CharacterCasing = CharacterCasing.Upper;
        }
        private void TbUserInput1_TextChanged(object sender, EventArgs e)
        {
            password = TbUserInput1.Text;
        }
        private void BtnDownload_Click(object sender, EventArgs e)
        {
            #region sound

            if (FrmHome.SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            if (TbUserInput1.Text == "Fill in password")
            {
                MessageBox.Show("Please fill in a password.", "Warning:");
            }
            else if(password == "")
            {
                MessageBox.Show("Please fill in a password.", "Warning:");
            }
            else if(password == "PAC")
            {
                Process.Start("https://bandersnatchdownload.000webhostapp.com/index.html");
            }
            else
            {
                MessageBox.Show("Please fill in the correct password." +
                    "\r\n\r\n" +
                    "The password can easily be found by playing the game.", "Warning:");
            }
        }

        #endregion


        #region easter eggs

        private void PbTitle_Click(object sender, EventArgs e)
        {
            #region sound

            if (FrmHome.SoundOn == true)
            {
                ButtonClickSound.Open(new Uri(soundURI));
                ButtonClickSound.Play();
            }

            #endregion

            MessageBox.Show("Definitely not an easter egg...", "Nothing to see here.");
        }

        #endregion


        #region form movement

        // variables for form movement
        private bool mouseDown;
        private Point lastLocation;

        // form movement
        private void FrmHowTo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void FrmHowTo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
        private void FrmHowTo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
