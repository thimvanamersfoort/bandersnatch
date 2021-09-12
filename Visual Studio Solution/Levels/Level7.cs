using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandersnatch
{
    public partial class FrmGame
    {
        public void Level7_1()
        {
            ActiveLevel = "Level7_1";

            if(FirstTimeLoading == true && ActiveLevel == "Level7_1")
            {
                Gamestate = 0;

                TbUserInput1.Visible = false;

                LblTextBottom.Text = "Jerry: You sure about that " + UsernameGame + "?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Positive.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level7_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: If you're sure..." +
                    "\r\n\r\n" +
                    "Jerry: Then you can leave. Good luck battling Pax.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level7_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "The heavy door opens and you walk through it. You're standing in a dark, empty hallway. " +
                    "You don't recognize where you are, and you can't hear Jerry anymore.";

                LblTextBottom.Text = "The heavy door closes behind you. You try calling Jerry's name, but you're on your own." +
                    "\r\n\r\n\r\n" +
                    "With the Demons Sting up your sleeve, you decide to explore the area." +
                    "\r\nYou need to find Pax.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level7_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection3;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;

                LblTextBottom.Text = UsernameGame + ": Hello?" +
                    "\r\n\r\n\r\n" +
                    UsernameGame + ": Jerry?";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level7_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = false;

                LblTextTop.Text = "You get no reaction, so you move on. You walk in the dark corridors for a while, " +
                    "until you see a hallway that is covered in light. You decide to head there.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level7_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor1;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Head to the light";
                PbFastForward.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = false;
            }
            else if(Gamestate == 6 && ActiveLevel == "Level7_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You walk forward towards the light, and after going through a small gate," +
                    "\r\nyou're standing in front of a big door." +
                    "\r\n\r\n\r\n\r\n\r\n" +
                    "You feel uncomfortable being here, as if someone is staring at you." +
                    "\r\n\r\nSomeone like Pax."; 
            }
            else if(Gamestate == 7 && ActiveLevel == "Level7_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundDoor1;
                BtnChoice1.Visible = false;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": What is this?" +
                    "\r\n\r\n" +
                    UsernameGame + ": I don't like it here. I don't feel safe here. Maybe I should head back to the entrance.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level7_1")
            {
                Gamestate = 8;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                BtnChoice1.Text = "Enter";
                BtnChoice2.Text = "Head back";
                PbFastForward.Visible = false;

                LblTextBottom.Text = "Do you enter through the door or do you head back to the entrance?";
            }
        }
        public void Level7_2()
        {
            ActiveLevel = "Level7_2";

            if(FirstTimeLoading == true && ActiveLevel == "Level7_2")
            {
                Gamestate = 0;

                TbUserInput1.Visible = false;
                LblTextBottom.Text = "Jerry: You sure about that " + UsernameGame + "?";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level7_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: Careful with your answer human. I only give you one more chance.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level7_2")
            {
                Gamestate = 2;

                LblTextBottom.Text = "Are you sure about your answer?";
                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Text = "Yes";
                BtnChoice2.Text = "No";
            }
        }
        public void Level7_3()
        {
            ActiveLevel = "Level7_3";

            if(FirstTimeLoading == true && ActiveLevel == "Level7_3") // 2e antwoord is fout
            {
                Gamestate = 0;

                TbUserInput1.Visible = false;
                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = "Jerry: Oh " + UsernameGame + "..." +
                    "\r\n\r\n" +
                    "Jerry: You shouldn't have come here. I gave you a second chance, " +
                    "but you still fucked it up.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level7_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: I'm sorry human. But you're gonna be in here for a long time.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level7_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You start to scream to Jerry to let you out, but he doesn't answer anymore. You walk to the door." +
                    "\r\n\r\n" +
                    "Locked.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level7_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomJerry;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Jerry?" +
                    "\r\n\r\n\r\n" +
                    UsernameGame + ": Jerry!" +
                    "\r\n\r\n\r\n" +
                    UsernameGame + ": Let me out!";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level7_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You sit down and try to relax. You're going to be here for a long time:" +
                    "\r\n\r\n" +
                    "-----------------------------------------------------------------------" +
                    "\r\n\r\n" +
                    "DAY 1:" +
                    "\r\nYou find out that Jerry has a bathing bowl in his cage. You start drinking from it. " +
                    "It should be enough water to keep you alive for several days." +
                    "\r\n\r\n\r\n\r\n\r\n" +
                    "DAY 2:" +
                    "\r\nYou start to feel incredibly hungry, and you lay down on the ground to use the least amount of " +
                    "energy as possible. " +
                    "You wouldn't know if it was night or day if it wasn't for your watch. The weak lightning in the room " +
                    "gives you an headache." +
                    "\r\n\r\n\r\n\r\n\r\n" +
                    "DAY 3:" +
                    "\r\nYour watch fell out. You don't know the time, and you feel incredibly lonely and hungry. " +
                    "You sleep a lot, because you feel incredibly dizzy and lame.";

                LblTextBottom.Text = "DAY 4:" +
                    "\r\nYou kicked over the water bowl. You lost your only source of water, and you know your end is near. " +
                    "Your heavy headache makes it almost impossible for you to move. Out of despair you start drinking your own piss." +
                    "\r\n\r\n\r\n" +
                    "This might be the last day you record your messages.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level7_3")
            {
                Gamestate = 5;

                PbGameOver.Visible = true;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "After the 4th day you stopped recording your messages. You lost track of time, " +
                    "and you started seeing hallucinations on the 5th day." +
                    "\r\n\r\n" +
                    "After 2 horrible days of pain and hallucinations, you died of dehydration on day 7." +
                    "\r\n\r\n\r\n" +
                    "You died.";

                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";

                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;
            }
        }
        public void Level7_4()
        {
            ActiveLevel = "Level7_4";

            if(FirstTimeLoading == true && ActiveLevel == "Level7_4") 
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = "Jerry: You're not really good at making choices, are you?" +
                    "\r\n\r\n" +
                    "Jerry: I'll give you 1 more chance. 1 more.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level7_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: Please don't fuck it up now " + UsernameGame + ". I'm rooting for you." +
                    "\r\n\r\n" +
                    UsernameGame + ": Thanks for the tip.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level7_4")
            {
                TbUserInput1.Visible = true;
                // alle gamestate opties worden in PbFastForward gedaan
            }
        }
    }
}
