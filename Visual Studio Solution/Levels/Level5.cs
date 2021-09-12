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
        public void Level5_1()
        {
            ActiveLevel = "Level5_1";

            if(FirstTimeLoading == true && ActiveLevel == "Level5_1")
            {
                Gamestate = 0;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.OrbHelpful_animated;
                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": What the...";

            }
            else if(Gamestate == 1 && ActiveLevel == "Level5_1")
            {
                Gamestate += 1;

                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                this.BackgroundImage = null;

                LblTextTop.Text = "You walk into the left corridor, and immediately get blasted by a bright light. " +
                    "You notice that it's some kind of Orb. It emits a monotone white noise." +
                    "\r\n\r\n" +
                    "The noise attracts you more than it bothers you. But you also pick up a vague growl, not from very far." +
                    "\r\n" +
                    "You decide to try and scare the Orb away.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level5_1")
            {
                Gamestate += 1;

                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.OrbHelpful_animated;

                LblTextBottom.Text = "You clap your hands and scream at the Orb." +
                    "\r\n\r\n" +
                    UsernameGame + ": Hey! get out of here! Yeah, go away. Hey!";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level5_1")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "Your loud but effective strategy worked out, and the Orb dissapears into thin air. " +
                    "It wanted nothing to do with you." +
                    "\r\n\r\n" +
                    "You feel happy, thinking that you have nothing to worry about." +
                    "\r\n\r\n" +
                    "But then you stiffen up, as you gaze upon a new threat, previously covered by the light of the Orb.";

            }
            else if(Gamestate == 4 && ActiveLevel == "Level5_1")
            {
                Gamestate += 1;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.HoundGray;
                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;

                LblTextBottom.Text = UsernameGame + ": fuck...";

            }
            else if(Gamestate == 5 && ActiveLevel == "Level5_1")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "In front of you stands a Hound. His bloody, scarred skin tells you " +
                    "you will not be his first victim." +
                    "\r\n\r\n" +
                    "He moves slowly towards you, and you try to calm him down as you think of what to do.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level5_1")
            {
                Gamestate += 1;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.HoundGray_animated;
                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;

                LblTextBottom.Text = UsernameGame + ": Good boy..." +
                    "\r\n\r\n\r\n\r\n" +
                    UsernameGame + ": Just don't do anything stupid right now.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level5_1")
            {
                Gamestate = 7;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Text = "Fight the Hound";
                BtnChoice2.Text = "Run away";

                LblTextBottom.Text = "Do you fight the Hound or do you run away?";
            }
        }
        public void Level5_2()
        {
            ActiveLevel = "Level5_2";
            
            if(FirstTimeLoading == true && ActiveLevel == "Level5_2")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;

                LblTextBottom.Text = UsernameGame + ": What is that...";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You see a strong light luminating the corridors behind you. " +
                    "You look backwards and you see an Orb floating in the left corridor." +
                    "\r\n\r\n" +
                    "You remember Colins talk about Orbs, and you decide you want nothing to do with it." +
                    "\r\nYou start to run away from the light.";

                LblTextBottom.Text = "Press the Run button repeatedly to run away from the Orb.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;
                LblTextBottom.Visible = false;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextTop.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Run";
                PbFastForward.Visible = false;
            }
            else if(Gamestate == 3 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
            }
            else if(Gamestate == 4 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;
            }
            else if(Gamestate == 5 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor6;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = true;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I must be far enough now.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You stop to take some rest, because you can't hear the monotone noise of the Orb anymore. " +
                    "You do hear the howl of some kind of wolf / hound far behind you, but you don't see it as an immediate danger.";

                LblTextBottom.Text = "But then you hear something that gets you excited instantly. The singing of a bird. " +
                    "You start running towards the sound.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor6;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextTop.Visible = false;

                LblTextBottom.Text = "Unknown bird: Chirp chirp." +
                    "\r\n\r\n" + 
                    UsernameGame + ": That's Jerry! I need to reach him.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Run towards the sound";
                PbFastForward.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Please don't dissappear now. I'm coming Jerry.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
            }
            else if(Gamestate == 10 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHall1;

                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Don't tell me that stupid bird got away now.";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: So I'm a stupid bird, huh?";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You heard a voice behind you, so you turn around.";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level5_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Jerry_animated;

                LblTextBottom.Text = "Jerry: I heard you were looking for me human. What is it that you desire?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Uhh...";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level5_2")
            {
                Gamestate = 14;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Text = "Aggressive and to the point";
                BtnChoice2.Text = "Friendly and pleasing";


                LblTextBottom.Text = "How do you react to Jerry?";
            }
        }
        public void Level5_3()
        {
            ActiveLevel = "Level5_3";

            if(FirstTimeLoading == true && ActiveLevel == "Level5_3")
            {
                Gamestate = 0;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You swallow the acid tab and Colin tells you to sit down.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomColin2;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin2_animated;

                LblTextBottom.Text = "Colin: Sit down buddy. I'm gonna get some water for us. " +
                    "\r\n\r\n" +
                    "Colin: I'll be back in 5 minutes.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                PbCharacter1.Visible = false;
                this.BackgroundImage = Properties.Resources.BackgroundRoomColin1;

                LblTextBottom.Text = "You sit down near the entrance and wait for Colin." +
                    "\r\n\r\n" +
                    UsernameGame + ": He better hurries up.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "After you see Colin returning you walk into the room again. " +
                    "You immediately notice the effects once Colin walks in.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomColin2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin3_animated;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = "Colin: You okay " + UsernameGame + "?" +
                    "\r\n\r\n" +
                    UsernameGame + ": What have you done?";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: I chose for you. Are you okay with that?" +
                    "\r\n\r\n" +
                    UsernameGame + ": I don't know.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "As the acid hits harder, you get to see more visuals and colors." +
                    "\r\n\r\n" +
                    "Colin also took a tab, and you see him tripping as well. He starts talking.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundLsdTrip2;
                PbCharacter1.Visible = true;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = "Colin: People think there’s only one reality, but there’s loads of them, " +
                    "all snaking off, like roots. And what we do on one path affects what happens on the other paths." +
                    "\r\n\r\n" +
                    "Colin: Time is a construct. People think you can’t go back and change things, but you can, " +
                    "that’s what flashbacks are, they’re invitations to go back and make different choices.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: When you make a decision, you think it’s you doing it, but it’s not. " +
                    "It’s the spirit out there that’s connected to our world that decides what we do and we just have to go along for the ride." +
                    "\r\n\r\n" +
                    "Colin: There’s messages in every game. Like Pac-Man. Do you know what PAC stands for?";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: P-A-C: “program and control.” He’s Program and Control Man. The whole things a metaphor. " +
                    "He thinks he’s got free will, but really he’s trapped in a maze, in a system." +
                    "\r\n\r\n" +
                    "Colin: All he can do is consume. He’s pursued by demons that are probably just in his own head. " +
                    "\r\n\r\n" +
                    "Colin: And even if he does manage to escape by slipping out one side of the maze, what happens?" +
                    "\r\nHe comes right back in on the other side.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: People think it’s a happy game, it’s not a happy game, it’s a fucking nightmare world " +
                    "and the worst thing is, it’s real and we live in it. " +
                    "\r\n\r\n" +
                    "Colin: It’s all code. If you listen closely, you can hear the numbers. " +
                    "There’s a cosmic flowchart that dictates where you can and where you can’t go.";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: I’ve given you the knowledge. I’ve set you free. Do you understand?" +
                    "\r\n\r\n" +
                    "Colin: I’ll show you what I mean. Come with me. We’re on one path. " +
                    "Right now, me and you. And how one path ends is immaterial. " +
                    "It’s how our decisions along the path affect the whole that matters.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: Do you believe me? Let me prove it.";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "As the acid trip decreases in color and intensity, you see Colin leaving the room, " +
                    "so you decide to follow him. " +
                    "\r\n\r\n" +
                    "You still have some minor visual effects, but you're sober enough to walk. So you follow Colin for about 10 minutes, " +
                    "untill you arrive at some big hole.";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHoleInTheGround;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                PbCharacter1.Visible = true;

                LblTextBottom.Text = "Colin: One of us is going. In there." +
                    "\r\n\r\n" +
                    "Colin points behind him and steps aside.";
            }
            else if(Gamestate == 15 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                PbCharacter1.Visible = false;
            }
            else if(Gamestate == 16 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Visible = true;
                PbCharacter1.Visible = false;

                LblTextBottom.Text = "You kick a rock into the hole, but you don't hear it hitting the ground." +
                    "\r\n\r\n" +
                    UsernameGame + ": You'll die.";
            }
            else if(Gamestate == 17 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                PbCharacter1.Visible = true;

                LblTextBottom.Text = "Colin: It wouldn't matter, because there are other timelines " + UsernameGame + "." +
                    "\r\n\r\n" +
                    "Colin: How many times have you watched Pac-Man die? Doesn't bother him. He just tries again.";
            }
            else if(Gamestate == 18 && ActiveLevel == "Level5_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: One of us is jumping. So who is it going to be?";
            }
            else if(Gamestate == 19 && ActiveLevel == "Level5_3")
            {
                Gamestate = 19;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Text = "You";
                BtnChoice2.Text = "Colin";

                LblTextBottom.Text = "Who is going to jump into the hole?";
            }
        }
        public void Level5_4()
        {
            ActiveLevel = "Level5_4";

            if(FirstTimeLoading == true && ActiveLevel == "Level5_4")
            {
                Gamestate = 0;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Despite of her open wounds and torn clothes, Lucia seems trustworthy to you, " +
                    "so you decide to go with her." +
                    "\r\n\r\n" +
                    "She hands you a flask with a black liquid in it.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level5_4")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                PbCharacter1.Visible = true;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": What is this?" +
                    "\r\n\r\n" +
                    "Lucia: Similar to chloroform, but less dangerous. " +
                    "It keeps you awake, but it causes short-term memory loss.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level5_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": And I don't die when drinking this?" +
                    "\r\n\r\n" +
                    "Lucia: It isn't harmful. Just trust me son.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level5_4")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Drink the liquid";
                PbFastForward.Visible = false;

                LblTextBottom.Text = "Do you drink the black luquid Lucia gave you?";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level5_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You drink the liquid, and you feel excited for what's going to come. \r\n" +
                    "You think about what to say to Jerry once you meet him, but you get very dizzy and " +
                    "drop to the ground." +
                    "\r\n\r\n" +
                    "You start feeling very nauseous, and your head is bursting from the pain.";

                LblTextBottom.Text = "Lucia bows over you and says some last words.\r\n" +
                    "Not untill now you realise this was a trap all along." +
                    "\r\n\r\n" +
                    "Lucia: Thank you for offering yourself to the allmighty lord Pax.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level5_4")
            {
                Gamestate = 5;

                LblTextBottom.Visible = true;
                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                "Lucia poisened you with cyanide. You had only seconds to live." +
                "\r\n\r\n" +
                "This was probably the stupidest way to die in the entire game" +
                "\r\n" +
                "~ The developers" +
                "\r\n\r\n\r\n" +
                "You died.";

                LblTextBottom.Text = "Press the button to go home.";
            }
        }
        public void Level5_5()
        {
            ActiveLevel = "Level5_5";

            if(FirstTimeLoading == true && ActiveLevel == "Level5_5")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                PbCharacter1.Image = Properties.Resources.Seducer1_animated;

                LblTextBottom.Text = UsernameGame + ": Yeah, I think it's better that I find Jerry myself..." +
                    "\r\n\r\n" +
                    "Lucia: I promised myself to take you to Jerry kid. Come with me. Now." +
                    "\r\n\r\n" +
                    UsernameGame + ": No thank you. I'm going now. Thanks for your help.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Lucia starts to get angry and threatens you to come with her. You're almost sure " +
                    "she is not going to take you to Jerry." +
                    "\r\n\r\n" +
                    "You decide to run away, because you don't feel safe anymore.";

            }
            else if(Gamestate == 2 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                PbCharacter1.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = false;

                LblTextBottom.Text = "Lucia: Come with me kid. Now. I don't want to use violence." +
                    "\r\n\r\n" +
                    UsernameGame + ": Well, nice to meet you.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Run";
                PbFastForward.Visible = false;

                LblTextBottom.Text = "Press the run button repeatedly to run through the corridors.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                PbCharacter1.Visible = false;
                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;
            }
            else if(Gamestate == 5 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
            }
            else if(Gamestate == 6 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;
            }
            else if(Gamestate == 7 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHall1;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Well I got away. So that's at least something." +
                    "\r\n\r\n" +
                    UsernameGame + ": I guess I'll head to Colin then. Asking anybody else in this place " +
                    "will get me killed for sure.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "You recognize where you are, and you remember Colin taking you here, " +
                    "so you vaguely know where the entrance is." +
                    "\r\n\r\n\r\n\r\n" +
                    "After walking for a while, you recognize halls of the entrance. The temperature " +
                    "increases and you see some sunlight slipping through the cracks in the walls and ceiling.";

                LblTextBottom.Text = "You start calling Colins name and after some tries you get a distant 'Yeah?'." +
                    "\r\nYou head to the sound.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level5_5")
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
            else if(Gamestate == 10 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextBottom.Text = UsernameGame + ": About the password." +
                    "\r\n\r\n" +
                    "Colin: So that's why you're here.";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: Well, I hate to break it to you, but I'm not going to tell you." +
                    "\r\n\r\n" +
                    UsernameGame + ": That's a shame. Why not?";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: If you would know how much trouble that simple, 3-letter password has given me. " +
                    "I don't want to saddle you up with that." +
                    "\r\n\r\n" +
                    "Colin: Plus I don't really know you well, do I? I don't want to put this life on the line for a stranger";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": So you're just going to let me die? I'll go in there, I die by either Pax, " +
                    "Jerry or whatever the fuck else roams around in this place, and the Agency will just send another of their guys." +
                    "\r\n\r\n" +
                    UsernameGame + ": Just like a never-ending loop. And Pax's reign will become stronger and stronger. Only because you " +
                    "don't want to say a stupid fucking password.";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: You're really pushing through huh?" +
                    "\r\n\r\n" +
                    "Colin: I'll give it to you, under one condition.";
            }
            else if(Gamestate == 15 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": And that condition may be?" +
                    "\r\n\r\n" +
                    "Colin: That you need to know the truth. That you need to suffer." +
                    "\r\n\r\n" +
                    "Colin: Follow me.";
            }
            else if(Gamestate == 16 && ActiveLevel == "Level5_5")
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
            else if(Gamestate == 17 && ActiveLevel == "Level5_5")
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
            else if(Gamestate == 18 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: I want to give you something.";
            }
            else if(Gamestate == 19 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Colin reaches under his bed and pulls out a bag with acid tabs. He offers you one, " +
                    "and you hold it in your hand.";
            }
            else if(Gamestate == 20 && ActiveLevel == "Level5_5")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomColin2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin_animated;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = "Colin: it'll let you see the full picture.";
            }
            else if(Gamestate == 21 && ActiveLevel == "Level5_5")
            {
                Gamestate = 20;

                PbCharacter1.Image = Properties.Resources.Colin;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Take the tab";
                PbFastForward.Visible = false;

                LblTextBottom.Text = "Do you take the acid tab?";
            }
        }
    }
}
