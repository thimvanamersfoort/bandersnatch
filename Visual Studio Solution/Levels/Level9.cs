using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandersnatch
{
    public partial class FrmGame
    {
        public void Level9_1()
        {
            ActiveLevel = "Level9_1";

            if(FirstTimeLoading == true && ActiveLevel == "Level9_1")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Shit. I can't beat you..." +
                    "\r\n\r\n\r\n" +
                    "Pax: You know you want it " + UsernameGame + ". Just give in. That's all you have to do.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "You start to feel dizzy, and your headache is increasing with the second. " +
                    "You can't think straight anymore." +
                    "\r\n\r\n" +
                    "You don't want to, but you have to give up. You can't possibly fight him anymore. " +
                    "You should have never come here.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHallPax1;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Pax_animated;

                LblTextBottom.Text = UsernameGame + ": Fuck...   ...you..." +
                    "\r\n\r\n" +
                    "You let the arrow fall out of your hand." +
                    "\r\n\r\n\r\n" +
                    "Pax: I knew you weren't powerful enough. You despise me " + UsernameGame + ". " +
                    "I expected more from you.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "You fall to your knees. You gave up. And Pax knows that." +
                    "\r\n\r\n" +
                    "His tail sweeps away the arrow on the floor. But even if you had the arrow, " +
                    "you wouldn't make a chance anyways.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHallPax1;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Pax_animated;

                LblTextBottom.Text = "Pax: I really wished I could kill you today " + UsernameGame + "." +
                    "\r\n\r\n" +
                    "Pax: But I like you, and you would be a good asset in my army. You would do great under my power." +
                    "\r\n\r\n" +
                    "Pax: So I'll spare you " + UsernameGame + ". Live to fight another day.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Pax: Now leave.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                PbFastForward.Visible = false;
                PbCharacter1.Image = Properties.Resources.Pax;
                LblTextBottom.Visible = true;
                BtnChoice1.Text = "Leave";

                LblTextBottom.Text = "Leave the room.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "You turn around and exit the room. You walk down the hallway, and for one more time " +
                    "you look back.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor7;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": ...";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level9_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "\r\n\r\n" +
                    "You don't feel scared." +
                    "\r\n\r\n\r\n\r\n" +
                    "You don't feel angry." +
                    "\r\n\r\n\r\n\r\n" +
                    "You don't feel happy." +
                    "\r\n\r\n\r\n\r\n" +
                    "You don't feel sad." +
                    "\r\n\r\n\r\n\r\n" +
                    "You feel nothing.";

                LblTextBottom.Text = "Pax took control." +
                    "\r\n\r\n" +
                    "And there is nothing you can do about it.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level9_1")
            {
                Gamestate = 10;

                PbGameOver.Visible = true;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "Pax took control over your brain. He decided not to kill you, " +
                    "and doomed you to roam the dungeons for ever." +
                    "\r\n\r\n\r\n" +
                    "Your former self would have wanted to die. To be put out of this misery. " +
                    "But you know that is not going to happen." +
                    "\r\n\r\n\r\n" +
                    "You walk through the corridors. For ever." +
                    "\r\n\r\n\r\n" +
                    "There is no end.";

                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";

                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;
            }
        }
        public void Level9_2()
        {
            #region RandomNumbers for fight scene

            Random rnd = new Random();
            int rnd1 = rnd.Next(2);
            int rnd2 = rnd.Next(2);
            int rnd3 = rnd.Next(2);

            #endregion

            ActiveLevel = "Level9_2";

            if(FirstTimeLoading == true && ActiveLevel == "Level9_2")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I'll rather die than surrender to you." +
                    "\r\n\r\n" +
                    "Pax: Then I'm afraid I have to kill you." +
                    "\r\n\r\n" +
                    UsernameGame + ": Try it.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "Despite your severe headache, " +
                    "and having serious trouble thinking, you still decide to attack Pax. " +
                    "You didn't came here for being surrendered. If you go down, you go down with a fight." +
                    "\r\n\r\n" +
                    "With the arrow in your hand, you start stabbing.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHallPax1;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Pax;
                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;

                LblTextBottom.Text = "Where do you stab Pax?";
                BtnChoice1.Text = "In his neck";
                BtnChoice2.Text = "In his thigh";
            } // stab 1 buttons
            else if(Gamestate == 3 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                PbCharacter1.Image = Properties.Resources.Pax_animated;

                if(rnd1 == 0)
                {
                    LblTextBottom.Text = "Your stab missed Pax! He jumped away from your swing. You did no damage." +
                        "\r\n\r\n\r\n" +
                        "Pax: Do you call this fighting?";
                }
                else if(rnd1 == 1)
                {
                    LblTextBottom.Text = "Your stab hit Pax! You cut a minor wound in his body. " +
                        "Black blood is dripping out." +
                        "\r\n\r\n\r\n" +
                        "Pax: You're going to die " + UsernameGame + "!";
                }
            } // stab 1 random
            else if(Gamestate == 4 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;
                PbCharacter1.Image = Properties.Resources.Pax;

                LblTextBottom.Text = "Where do you stab Pax next?";
                BtnChoice1.Text = "In his waist";
                BtnChoice2.Text = "In his chest";
            } // stab 2 buttons
            else if(Gamestate == 5 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                PbCharacter1.Image = Properties.Resources.Pax_animated;

                if(rnd2 == 0)
                {
                    LblTextBottom.Text = "Pax evaded your attack! You barely miss him, but as comeback, " +
                        "he slashes your face with his pointy tail." +
                        "\r\n\r\n\r\n" +
                        "Pax: Try me human.";
                }
                else if(rnd2 == 1)
                {
                    LblTextBottom.Text = "A direct hit! The arrow penetrates deep into his skin, " +
                        "and his scream fills the room." +
                        "\r\n\r\n\r\n" +
                        "Pax: You are doomed human! When I'm done with you, your brain will be pulp.";
                }
            } // stab 2 random
            else if(Gamestate == 6 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;
                PbCharacter1.Image = Properties.Resources.Pax;

                LblTextBottom.Text = "Where do you stab Pax next?";
                BtnChoice1.Text = "In his stomach";
                BtnChoice2.Text = "In his shoulder";
            } // stab 3 buttons
            else if(Gamestate == 7 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                PbCharacter1.Image = Properties.Resources.Pax_animated;

                if(rnd3 == 0)
                {
                    LblTextBottom.Text = "Your attack didn't do anything. Pax swiftly slides to the side, " +
                        "and you only cut air." +
                        "\r\n\r\n\r\n" +
                        "Pax: Pathetic.";
                }
                else if(rnd3 == 1)
                {
                    LblTextBottom.Text = "Hit! The arrow slashes Pax, but it only penetrates lightly." +
                        "\r\n\r\n\r\n" +
                        "Pax: I hope you said your mother goodbye " + UsernameGame + ". " +
                        "Because this ends here and now.";
                }
            } // stab 3 random
            else if(Gamestate == 8 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Pax: You fail to impress me " + UsernameGame + "." +
                    "\r\n\r\n" +
                    "Pax: Playtime is over. Let me end this.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "You tried to stab Pax, but your attacks didn't do much." +
                    "\r\n\r\n\r\n" +
                    "He laughs and slowly starts to walk in on you. " +
                    "\r\nIn reaction you walk backwards." +
                    "\r\n\r\n\r\n" +
                    "Not knowing he pushes you in a corner, you hit the wall and shock. " +
                    "\r\nYou're trapped.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHallPax1;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                PbCharacter1.Visible = true;

                LblTextBottom.Text = "Pax: This is the end " + UsernameGame + "..." +
                    "\r\n\r\n" +
                    "Pax: Ready to die?";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level9_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "You know you're going to die, so you close your eyes. " +
                    "You expect to be stabbed, slashed or any other kind of torture, but " +
                    "you only feel an increasing lightness in your head." +
                    "\r\n\r\n\r\n" +
                    "You feel that you bend through your knees, and you fall to the ground. " +
                    "\r\nThe impact does'nt hurt." +
                    "\r\n\r\n\r\n" +
                    "As the lightness in your head increases, you start breathing slower. " +
                    "A white light covers your eyes," +
                    "\r\n\r\n\r\n" +
                    "And the breathing stops.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level9_2")
            {
                Gamestate = 12;

                PbGameOver.Visible = true;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "Pax killed you. He used his mindcontrol to overactivate your brain, " +
                    "killing you painlessly in the process." +
                    "\r\n\r\n\r\n" +
                    "You died.";



                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";

                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;
            }
        }
        public void Level9_3()
        {
            ActiveLevel = "Level9_3";

            if(FirstTimeLoading == true && ActiveLevel == "Level9_3")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Sorry mate. I'm getting out of here.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "The Roamer quickly walks forward, pushing you back to the wall. You can run backwards, " +
                    "but then you would only get back to the door. " +
                    "\r\n\r\n" +
                    "So you decide there is only one option left. A risky one";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection3;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.RoamerInsane1_animated;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Push the Roamer away";

                LblTextBottom.Text = UsernameGame + ": Get the fuck out of my way.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                BtnChoice1.Text = "Run";
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
            }
            else if(Gamestate == 4 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;
            }
            else if(Gamestate == 5 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
            }
            else if(Gamestate == 6 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "You run and you keep running. You don't know where you're heading, " +
                    "but you know that if you keep running, you will eventually reach the exit. " +
                    "\r\n\r\n" +
                    "So you keep running.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = false;
                BtnChoice1.Visible = true;
                PbFastForward.Visible = false;
            }
            else if(Gamestate == 8 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor7;
            }
            else if(Gamestate == 9 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
            }
            else if(Gamestate == 10 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "Your confidence slowly decreases, as you don't reach the exit, " +
                    "even after almost 20 minutes of running. You lost the Roamer after 5 minutes, " +
                    "after you shook him off in the maze of corridors." +
                    "\r\n\r\n\r\n" +
                    "But then you see something that gets you hyped up.";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Is that the exit?";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;
                
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go forward";
                LblTextBottom.Visible = false;
            }
            else if(Gamestate == 13 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundEntrance3;
                PbFastForward.Visible = true;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Finally...";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go forward";
                LblTextBottom.Visible = false;
            }
            else if(Gamestate == 15 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundEntrance2;
                BtnChoice1.Text = "Exit the dungeons";
            }
            else if(Gamestate == 16 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You slowly walk up the stairs. When you reach the exit, " +
                    "the light hurts your eyes. " +
                    "\r\n\r\n" +
                    "You walk outside. The sunlight warms your skin. You look at the view.";
            }
            else if(Gamestate == 17 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundOutside1;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I made it.";
            }
            else if(Gamestate == 18 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
            }
            else if(Gamestate == 19 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                LblTextBottom.Visible = true;
                LblTextBottom.Text = "You escaped the Dungeons. You're free. You're relieved. " +
                    "The change of getting out was almost zero, but you still made it. " +
                    "\r\n\r\n" +
                    "And you have the arrow.";
            }
            else if(Gamestate == 20 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "You know you didn't complete your mission. But at least you have " +
                    "valuable information. And the only weapon able to kill Pax." +
                    "\r\n\r\n" +
                    "Even if they fire you, you don't care anymore. You're just happy you're still alive.";
            }
            else if(Gamestate == 21 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "But you still have a challenge. You're in the middle of an unknown jungle. " +
                    "\r\n\r\n" +
                    "You were dropped off with a helicopter when you came here. " +
                    "And the base is at least 60km away from you.";
            }
            else if(Gamestate == 22 && ActiveLevel == "Level9_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": I'll better start walking then.";
            }
            else if(Gamestate == 23 && ActiveLevel == "Level9_3")
            {
                Gamestate = 23;

                this.BackgroundImage = null;
                LblTextTop.Visible = true;
                PbGameOver.Visible = true;
                PbGameOver.Image = Properties.Resources.YouWin;
                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";
                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";
                PbFastForward.Visible = false;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "You made it out. You didn't know why, because it was Pax's choice to let you go. " +
                    "But you made it. Alive." +
                    "\r\n\r\n\r\n" +
                    "But this game isn't over. Pax's reign continues, and soon another Agent will be sent into " +
                    "the dungeons." +
                    "\r\n\r\n" +
                    "You might have escaped, but you failed your mission Agent.";
            }
        }
        public void Level9_4()
        {
            ActiveLevel = "Level9_4";

            if(FirstTimeLoading == true && ActiveLevel == "Level9_4")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I'll take my chances.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level9_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "With the arrow in your hand, you run towards the Roamer. " +
                    "With all the strength you have left, you stab the arrow between his ribs. " +
                    "You see the Roamer shrivel from pain, but the stab wasn't enough to kill him." +
                    "\r\n\r\n\r\n" +
                    "He screams in terror, and as a defense mechanism, you take a step back, " +
                    "forgetting to pull the arrow from his ribs." +
                    "\r\n\r\n\r\n" +
                    "Unarmed, you're facing the Roamer. Foaming from it's mouth, he slowly approaches you." +
                    "\r\n\r\n\r\n" +
                    "As a form of a surprise attack, he screams and jumps on top of you, " +
                    "with the arrow still between his ribs. You collapse under its weight, " +
                    "and you fall, the Roamer landing on top of you." +
                    "\r\n\r\n\r\n" +
                    "The Roamer looks straight at you, and a mixture of saliva " +
                    "\r\nand blood drips from his mouth onto your forehead." +
                    "\r\n\r\n\r\n" +
                    "You close your eyes. This is the end.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level9_4")
            {
                Gamestate = 2;

                PbGameOver.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";
                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";
                PbFastForward.Visible = false;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "The insane Roamer overpowered you and ate your face off. You didn't die immediately, " +
                    "but you bled out after around 20 minutes of suffering." +
                    "\r\n\r\n\r\n" +
                    "You died.";
            }
        }
    }
}
