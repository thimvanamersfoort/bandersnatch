using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandersnatch
{
    public partial class FrmGame
    {
        public void Level4_1()
        {
            ActiveLevel = "Level4_1";

            if(FirstTimeLoading == true && ActiveLevel == "Level4_1")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I think I can handle this piece of shit. Try me motherfucker.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level4_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;

                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = false;

                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You charge Agent 47, but he stops you with a powerful stomp to the throat." +
                    "\r\n" +
                    "You're staggered for a couple of seconds, and the Agent takes this opportunity to push you back with significant force. " +
                    "Whilst falling, you get the chance to look backwards, and you see Colin sprinting away. " +
                    "He probably didn't trust you enough." +
                    "\r\n\r\n" +
                    "You hit the cold stones and the Agent blocks you from moving by placing his heavy foot on your breast." +
                    "He places his other foot on your neck, and you start panicking as you don't get any air anymore." +
                    "\r\n\r\n" +
                    "You start struggling back, but your force doesn't do much. The world gets black before your eyes.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level4_1")
            {
                Gamestate = 2;

                PbGameOver.Visible = true;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "The aggressive mutated Agent choked you with his boot. He was probably stronger than you." +
                    "\r\n\r\n\r\n" +
                    "You died.";



                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";

                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;
            }

        }
        public void Level4_2()
        {
            ActiveLevel = "Level4_2";

            if(FirstTimeLoading == true && ActiveLevel == "Level4_2")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Good plan Colin. Let's get the hell out of here." +
                    "\r\n\r\n" +
                    "Colin: Couldn't have said it any sooner.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level4_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You and Colin start running away from Agent 47. You trip once, but the Agent is " +
                    "slow and clumsy, so you don't have much trouble with escaping." +
                    "\r\n\r\n" +
                    "The Agent keeps screaming threats, but the further you run, the weaker his voice gets, and once you don't hear " +
                    "the Agents screams anymore, you stop to catch a breath.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level4_2")
            {
                Gamestate += 1;
                
                this.BackgroundImage = Properties.Resources.BackgroundHall1;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Holy shit. That was really close." +
                    "\r\n\r\n" +
                    "Colin: It was. I stressed when you tripped mate. That could've cost us a life." +
                    "\r\n\r\n" +
                    UsernameGame + ": Yeah I know, sorry.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level4_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: Don't need to apologize. I'm just happy we're still here." +
                    "\r\n\r\n" +
                    "Colin: Speaking of here, I have no idea of where the fuck we are. " +
                    "But I think I know where we need to go. Follow me. I'm taking you to the staircase.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level4_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You follow Colin out of the hall, and quickly you're back in the " +
                    "never-ending maze of corridors. You don't know where you are, but Colin apparently " +
                    "feels right at home here, and blindly leads you to the staircase." +
                    "\r\n\r\n" +
                    "After about 15 minutes you arrive at the staircase.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level4_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection1;
                PbCharacter1.Visible = true;

                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": So this is the entrance or something?" +
                    "\r\n\r\n" +
                    "Colin: Yup. From here it all goes down(hill). Figuratively and litteraly.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level4_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: So you know what to do right?" +
                    "\r\n\r\n" +
                    UsernameGame + ": I think so. Find Jerry and get the weapon. From there you can fill it in yourselves. Right?" +
                    "\r\n\r\n" +
                    "Colin: That's the plan. Make it worth it.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level4_2")
            {
                Gamestate += 1;
                
                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You say goodbye to Colin, and walk into the hallway that leads to the staircase. " +
                    "You forgot about the password." +
                    "\r\n\r\n" +
                    "You stop before the staircase, as you think about your choice.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level4_2")
            {
                Gamestate = 8;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = false;

                this.BackgroundImage = Properties.Resources.BackgroundStaircase1;
                PbFastForward.Visible = false;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go down";
            }
        }
        public void Level4_3()
        {
            ActiveLevel = "Level4_3";

            if(FirstTimeLoading == true && ActiveLevel == "Level4_3")
            {
                Gamestate = 0;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You slowly descend the slippery, stone staircase. The weak torchlight reflects off the puddles on the uneven staircase. " +
                    "You look at yourself in the reflection, but you don't pay attention on your step and you slip." +
                    "\r\n\r\n" +
                    "You fall for some seconds, and land hard on your hip. You try to stand up, but it hurts too much." +
                    "\r\n" +
                    "You decide to take a rest.";

                LblTextBottom.Text = "After a short rest on the cold stairs, you continue downwards. You limp forwards, and finally reach the bottom." +
                    "\r\nYou're standing in front of a long, empty hallway.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level4_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Well, what is this...";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level4_3")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go forward";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level4_3")
            {
                Gamestate += 1;

                LblTextBottom.Visible = true;
                PbFastForward.Visible = true;
                BtnChoice1.Visible = false;
                this.BackgroundImage = Properties.Resources.BackgroundHall2;

                LblTextBottom.Text = UsernameGame + ": I don't know where the fuck I am right now, but this seems like a simple choice." +
                    "\r\n\r\n" +
                    UsernameGame + ": Go left..." +
                    "\r\n\r\n" +
                    UsernameGame + ": Or right...";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level4_3")
            {
                Gamestate = 4;

                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                BtnChoice1.Text = "Go left";
                BtnChoice2.Text = "Go right";

                LblTextBottom.Text = "Do you go left or right?";

            }
        }
        public void Level4_4()
        {
            ActiveLevel = "Level4_4";

            if(FirstTimeLoading == true && ActiveLevel == "Level4_4")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Well, if Colin has the password, I'll probably get it from him. " +
                    "Not feeling so safe with the thought of misleading some crazy murder parrot to give me the password " +
                    "to his personal belongings." +
                    "\r\n\r\n" +
                    "Gus: Haha, good point. Well, say hi to Colin for me if you want to. Good luck man.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Will do. Thanks for your help mate.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Gus quickly tells you how to get back to the entrance, and after saying goodbye to him, " +
                    "you head off." +
                    "\r\n\r\n" +
                    "After about 15 minutes, you get back to the entrance. The air around you gets warmer, you see some weak sunlight slipping trough " +
                    "cracks in the walls and roof." +
                    "\r\n\r\n" +
                    "You start calling Colins name, and after a couple of screams, you hear a vague 'yeah?'. \r\n" +
                    "You head into the direction of the sound, and after a couple of corners, you see Colin sitting against a wall.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin2;

                LblTextBottom.Text = "Colin: So you came back huh? What's up." +
                    "\r\n\r\n" +
                    UsernameGame + ": I ran into Gus. He told me more about this place. " +
                    "About Pax. About Jerry. About his room...";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextBottom.Text = UsernameGame + ": About the password." +
                    "\r\n\r\n" +
                    "Colin: So that's why you're here.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: Well, I hate to break it to you, but I'm not going to tell you." +
                    "\r\n\r\n" +
                    UsernameGame + ": That's a shame. Why not?";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: If you would know how much trouble that simple, 3-letter password has given me. " +
                    "I don't want to saddle you up with that." +
                    "\r\n\r\n" +
                    "Colin: Plus I don't really know you well, do I? I don't want to put this life on the line for a stranger";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": So you're just going to let me die? I'll go in there, I die by either Pax, " +
                    "Jerry or whatever the fuck else roams around in this place, and the Agency will just send another of their guys." +
                    "\r\n\r\n" +
                    UsernameGame + ": Just like a never-ending loop. And Pax's reign will become stronger and stronger. Only because you " +
                    "don't want to say a stupid fucking password.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: You're really pushing through huh?" +
                    "\r\n\r\n" +
                    "Colin: I'll give it to you, under one condition.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": And that condition may be?" +
                    "\r\n\r\n" +
                    "Colin: That you need to know the truth. That you need to suffer." +
                    "\r\n\r\n" +
                    "Colin: Follow me.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Colin turns around and starts walking away. You decide to follow him, " +
                    "and for the entire walk you don't talk to each other." +
                    "\r\n\r\n" +
                    "Finally you stop in a random corridor. Colin walks to the vine-covered wall, and pulls away some of the vines. " +
                    "The vines covered a big hole in the wall, to which Colin steps through." +
                    "\r\n\r\n" +
                    "You follow him.";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomColin2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin_animated;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = "Colin: Welcome to my humble residence. Here I spend my time when I'm not helping losers like you." +
                    "\r\n\r\n" +
                    UsernameGame + ": Nice place." +
                    "\r\n\r\n" +
                    "Colin: Thanks.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: I want to give you something.";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Colin reaches under his bed and pulls out a bag with acid tabs. He offers you one, " +
                    "and you hold it in your hand.";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level4_4")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomColin2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin_animated;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = "Colin: It'll let you see the full picture.";
            }
            else if(Gamestate == 15 && ActiveLevel == "Level4_4")
            {
                Gamestate = 15;

                PbCharacter1.Image = Properties.Resources.Colin;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Take the tab";
                PbFastForward.Visible = false;

                LblTextBottom.Text = "Do you take the acid tab?";
            }
        }
        public void Level4_5()
        {
            ActiveLevel = "Level4_5";

            if(FirstTimeLoading == true && ActiveLevel == "Level4_5")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": If I can't find a simple parrot on my own, then I can't call myself an Agent." +
                    "\r\n\r\n" +
                    "Gus: Well good luck man. I hope you get us out of here.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level4_5")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You say goodbye to Gus, and you roam off into the dungeons." +
                    "\r\n\r\n\r\n\r\n" +
                    "After a while you come to an entrance. This looks like a different section of the dungeon, " +
                    "so you enter, with the hope that you will find Jerry there.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level4_5")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection2;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = false;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Enter";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level4_5")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You walk forward and enter the next part of the dungeons. " +
                    "You instantly notice the thinner, much colder air and the decrease in precense of torches." +
                    "\r\n\r\n" +
                    "You travel through the dungeons for a while, and after around 10 minutes you run into " +
                    "a very pale, wounded woman. You ask her for help.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level4_5")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Seducer1;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Hello ma'am. Could I ask you for some help?";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level4_5")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Seducer1_animated;

                LblTextBottom.Text = "Woman: Ofcourse kid! I'm Lucia. What can I help you with?" +
                    "\r\n\r\n" +
                    UsernameGame + ": I'm looking for Jerry. Would you happen to know where he is?";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level4_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Lucia: Jerry the parrot? What do you need him for?" +
                    "\r\n\r\n" +
                    UsernameGame + ": I'm looking for the Demons Sting." +
                    "\r\n\r\n" +
                    "Lucia: I don't know the exact location of his room, but I know where Jerry usually hangs around. " +
                    "I can take you there if you want?";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level4_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Lucia: I do have to say that Jerry doesn't like his hanging place to be known, " +
                    "so I will have to blindfold you, if you're okay with that?";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level4_5")
            {
                Gamestate = 8;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                BtnChoice1.Text = "Trust Lucia";
                BtnChoice2.Text = "Don't trust Lucia";
                PbFastForward.Visible = false;

                LblTextBottom.Text = "Do you trust Lucia to kidnap you and take you to Jerry?";
            }
        }
    }
}
