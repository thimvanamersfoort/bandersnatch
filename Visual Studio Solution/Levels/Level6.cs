using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandersnatch
{
    public partial class FrmGame
    {
        public void Level6_1()
        {
            ActiveLevel = "Level6_1";

            if(FirstTimeLoading == true && ActiveLevel == "Level6_1")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": He's probably just a pup. I think I can handle him.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You decide to attack the Hound. You're not armed and the only item you're carrying " +
                    "on you is a flashlight. You grab it and storm the Hound." +
                    "\r\n\r\n" +
                    "The Hound barks and runs towards you. But then you notice a weakness. The Hound has a deep wound just below his neck." +
                    "\r\nYou decide to focus on it.";

                LblTextBottom.Text = "The Hound storms into you at an incredible pace, and just before he jumps onto you, " +
                    "you use his momentum to push him to your right, smacking the Hound to the wall.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                PbCharacter1.Image = Properties.Resources.HoundGray;
                PbCharacter1.Visible = true;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.Text = "";
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Throw Hound to the wall";
                PbFastForward.Visible = false;
            }
            else if(Gamestate == 3 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;
                PbFastForward.Visible = true;
                BtnChoice1.Visible = false;

                LblTextTop.Text = "The Hound smacks to the wall, and sinks to the floor on all four legs. He is stunned for a couple of seconds, " +
                    "but before he can get up, you grab your chance." +
                    "\r\n\r\n" +
                    "You see the wound below his neck clearly now, and you grab your iron flashlight. You stab the flashlight into the wound, and you " +
                    "hear the Hound scream. " +
                    "\r\n\r\n\r\n" +
                    "You kick the flashlight further into his throat, effectively blocking his respiratory system.";

                LblTextBottom.Text = "The hound cries of pain and scratches you multiple times. To release him from his pain " +
                    "you snap his neck, with difficulty." +
                    "\r\n\r\n" +
                    "The Hound blows his last breath, and you get up." +
                    "\r\nYou won.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Sorry boy. It was either you or me.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Walk further";
                PbFastForward.Visible = false;

                LblTextBottom.Text = UsernameGame + ": I should check out the rest of these corridors.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You walk further into the corridors, but you soon notice that the hallway " +
                    "leads to a dead end." +
                    "\r\n\r\n" +
                    "You decide to head back to the other hallway.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                LblTextBottom.Visible = true;
                LblTextBottom.Text = UsernameGame + ": Let's check out that other corridor.";
                LblTextTop.Visible = false;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Head to the other corridor";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "After walking back through the left corridor, you head into the right one. " +
                    "After about 15 minutes of walking, you stop to take some rest.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor6;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I must be far enough now.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbFastForward.Visible = true;

                LblTextTop.Text = "You stop walking. You lean against the wall, still processing the fight with the Hound." +
                    "\r\n\r\n" +
                    "But then you hear something that gets you excited instantly. The singing of a bird. " +
                    "You start running towards the sound.";

            }
            else if(Gamestate == 10 && ActiveLevel == "Level6_1")
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
            else if(Gamestate == 11 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Run towards the sound";
                PbFastForward.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Please don't dissappear now. I'm coming Jerry.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
            }
            else if(Gamestate == 13 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHall1;

                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Don't tell me that stupid bird got away now.";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: So I'm a stupid bird, huh?";
            }
            else if(Gamestate == 15 && ActiveLevel == "Level6_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You heard a voice behind you, so you turn around.";
            }
            else if(Gamestate == 16 && ActiveLevel == "Level6_1")
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
            else if(Gamestate == 17 && ActiveLevel == "Level6_1")
            {
                Gamestate = 17;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Text = "Aggressive and to the point";
                BtnChoice2.Text = "Friendly and pleasing";


                LblTextBottom.Text = "How do you react to Jerry?";
            }

        }
        public void Level6_2()
        {
            ActiveLevel = "Level6_2";

            if(FirstTimeLoading == true && ActiveLevel == "Level6_2")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I'll better get out of here."; 
            }
            else if(Gamestate == 1 && ActiveLevel == "Level6_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                LblTextTop.Text = "You throw your flashlight behind the Hound to distract him, " +
                    "and you turn around and start to run." +
                    "\r\n\r\n" +
                    "As fast as you can, in the dark. You hear the rapid footsteps of the Hound " +
                    "quickly closing in on you. You don't look back.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level6_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = false;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Run";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level6_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;
            }
            else if(Gamestate == 4 && ActiveLevel == "Level6_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor6;
            }
            else if(Gamestate == 5 && ActiveLevel == "Level6_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "You run as fast as you can, but you can barely see the granite floor, " +
                    "and you slip on a wet part. " +
                    "\r\n\r\n" +
                    "You smack to the ground, and the Hound quickly catches up to you.";
                LblTextBottom.Text = "You lay on your back, as the Hound leans over you. His drizzle and blood hit your forehead. " +
                    "This is the end.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level6_2")
            {
                Gamestate = 6;

                PbGameOver.Visible = true;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "Your throat was bitten through by a wild Hound. You couldn't defend yourself." +
                    "\r\n\r\n\r\n" +
                    "You died.";

                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";

                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;
            }
        }
        public void Level6_3()
        {
            ActiveLevel = "Level6_3";

            if(FirstTimeLoading == true && ActiveLevel == "Level6_3")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": So you're Jerry?" +
                    "\r\n\r\n" +
                    "Jerry: That's me human. Why were you looking for me?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Listen up.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": You're going to give me that arrow of yours. Demons sting." +
                    "\r\n\r\n" +
                    UsernameGame + ": I'm battling Pax, and I'm definitely not going to be stopped by some stupid little parrot. " +
                    "I've always thought you were more impressive anyways.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: Careful with your words human. You don't know who you're up against." +
                    "\r\n\r\n" +
                    UsernameGame + ": So what? You're gonna kill me?" +
                    "\r\n\r\n" +
                    UsernameGame + ": If anyone is going to kill me in this place, it's Pax. " +
                    "So better hurry up with that weapon pal.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: I admire your attitude human. You could be worthy of the weapon." +
                    "\r\n\r\n" +
                    "Jerry: Come with me.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go with Jerry";
                PbFastForward.Visible = false;

                LblTextBottom.Visible = false;
            }
            else if(Gamestate == 5 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;

                PbCharacter1.Visible = false;
                this.BackgroundImage = null;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You let Jerry take you to his room, and he tells you to relax your body and calm down." +
                    "\r\n\r\nYou start to feel dizzy and you pass out.";

                LblTextBottom.Text = "You wake up alone in an almost empty room. You look around.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomJerry;
                LblTextTop.Visible = false;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": This must be Jerry's room..." +
                    "\r\n\r\n" +
                    UsernameGame + ": Hello?";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = false;

                LblTextTop.Text = "You hear the chirping voice of Jerry answering your question, " +
                    "but he is not in the room with you." +
                    "\r\n\r\n" +
                    "You ask him where you are.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomJerry;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = "Jerry: Hello " + UsernameGame + ". Welcome in my room." +
                    "\r\n\r\n" +
                    UsernameGame + ": Cool room." +
                    "\r\n\r\n" +
                    "Jerry: Thank you. My excuse for any feces on the ground.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Jerry: The Demons Sting is located in the cage to your right." +
                    "\r\n\r\n" +
                    "Jerry: There isn't any security on it. You can just take it. But I hope that you know the password.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Grab the Demons Sting";
                PbFastForward.Visible = false;
                LblTextBottom.Visible = false;
            }
            else if(Gamestate == 11 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "You climb into the cage and retrieve the arrow from the ground. " +
                    "It looks like an ordinary arrow, but you notice that it's heavy. Very heavy." +
                    "\r\n\r\n" +
                    "You store it in your sleeve and climb back out of the cage.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level6_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomJerry;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Thanks for the arrow. Now what?" +
                    "\r\n\r\n" +
                    "Jerry: I hope you know the password..." +
                    "\r\n\r\n" +
                    "Jerry: Otherwise you'll be stuck here for a long time.";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level6_3")
            {
                TbUserInput1.Visible = true;

                // alle opties voor keuzes staan in de PbFastForward method
            }
        }
        public void Level6_4()
        {
            ActiveLevel = "Level6_4";

            if(FirstTimeLoading == true && ActiveLevel == "Level6_4")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I've been searching for you Sir. My sincere apologies " +
                    "for my rude entrance." +
                    "\r\n\r\n" +
                    "Jerry: What?";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level6_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": My apologies Sir. I shall come straight to the point. " +
                    "I'm looking for the Demons Sting, and I've heard you have it in your possession. I'm asking for " +
                    "permission to borrow it." +
                    "\r\n\r\n" +
                    "Jerry: What do you need that toy for?";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level6_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": I'm challenging Pax, Sir. It's time for his reign to end." +
                    "\r\n\r\n" +
                    "Jerry: You're not battling anyone ass-kisser. " +
                    "\r\n\r\n" +
                    "Jerry: I despise you human. You leave me unimpressed.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level6_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You failed to impress Jerry, and you remember what happened when that happens." +
                    "\r\nYou're done." +
                    "\r\n\r\n" +
                    "You think about running, but even before you can act on it, Jerry starts to flap his wings." +
                    "\r\nYou try to think of something to do, but nothing comes to mind.";

                LblTextBottom.Text = "You feel your body falling to the floor. But after that," +
                    "\r\nyou feel nothing anymore.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level6_4")
            {
                Gamestate = 4;

                PbGameOver.Visible = true;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "Jerry used his mindcontrol to erase the neurons in your brain. You were braindead in seconds." +
                    "\r\nIt took a minute after that for your body to shut down. You felt nothing." +
                    "\r\n\r\n\r\n" +
                    "You died.";

                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";

                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;
            }
        }
        public void Level6_5()
        {
            ActiveLevel = "Level6_5";

            if(FirstTimeLoading == true && ActiveLevel == "Level6_5")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I'll do it.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level6_5")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                PbCharacter1.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Jump";
                PbFastForward.Visible = false;
            }
            else if(Gamestate == 2 && ActiveLevel == "Level6_5")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "You let yourself fall into the pit, and you think of Colins words as you travel through the air." +
                    "\r\n\r\n" +
                    "For minutes you're freefalling, but you know there is an end. Or you hope so.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level6_5")
            {
                Gamestate = 3;

                PbGameOver.Visible = true;

                LblTextTop.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                    "Colin: Don't worry kid. You might be dead on this lifepath, but you can always try again on another one. " +
                    "Just like Pac-Man. You only have to click the home button." +
                    "\r\n\r\n\r\n\r\n" +
                    "You crushed your neck and spine after falling into a 200m deep pit." +
                    "\r\n\r\n" +
                    "You died.";

                LblTextBottom.Visible = true;
                LblTextBottom.Text = "Press the button to go home.";

                BtnHomeDeath.Visible = true;
                BtnHomeDeath.Text = "Home";

                PbFastForward.Visible = false;
            }
        }
        public void Level6_6()
        {
            ActiveLevel = "Level6_6";

            if(FirstTimeLoading == true && ActiveLevel == "Level6_6")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": You do it." +
                    "\r\n\r\n" +
                    "Colin: Fair enough.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: See you around!" +
                    "\r\n\r\n" +
                    "\r\n\r\n" +
                    UsernameGame + ": No, wait...";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You try to stop him, but filled with confidence, Colin jumps into the hole. " +
                    "You are in shock and can't move. You only listen.";

                LblTextBottom.Text = "After minutes you hear a faint clap in the depths.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHoleInTheGround;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": What the..." +
                    "\r\n\r\n" +
                    "\r\n\r\n" +
                    UsernameGame + ": Colin?";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You stand on the edge of the pit for minutes, processing what you just witnessed. " +
                    "Thinking about if you should jump or not." +
                    "\r\n\r\n" +
                    "But you have a mission to accomplish. You need to move on.";

                LblTextBottom.Text = "After thinking about what to do, you make a decision.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHoleInTheGround;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": He probably kept the password in his room." +
                    "\r\n\r\n" +
                    UsernameGame + ": Atleast, I hope so.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go to Colins room";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                PbFastForward.Visible = true;
                BtnChoice1.Visible = false;
                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = false;

                LblTextTop.Text = "You walk back, but you don't know where you're heading. You decide to just follow the path.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;
                LblTextBottom.Visible = false;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextTop.Visible = false;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go forward";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
            }
            else if(Gamestate == 10 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;
            }
            else if(Gamestate == 11 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor6;
            }
            else if(Gamestate == 12 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                LblTextBottom.Visible = true;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Fuck. I got lost." +
                    "\r\n\r\n" +
                    UsernameGame + ": Wasn't Colins room to the left? or to the right?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Shit.";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "After roaming around for another 15 minutes, unsuccessfully looking for Colins room, " +
                    "you run into another roamer. He doesn't look very threatening.";

                LblTextBottom.Text = "You decide to ask him for help.";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.RoamerIgnorant1_animated;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;

                LblTextBottom.Text = UsernameGame + ": Hey man. I'm " + UsernameGame + ". I know you don't know me, but could you help me out?" +
                    "\r\n\r\n" +
                    "Roamer: Hi. I'm Mikey. What can I help you with?";
            }
            else if(Gamestate == 15 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": I'm looking for Colins room. Would you maybe know where it is?" +
                    "\r\n\r\n" +
                    "Mikey: Colins room? That's litteraly around the corner. How is Colin doing by the way?";
            }
            else if(Gamestate == 16 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Oh really? Thanks man. It's a fucking maze for me here. I'm quite new in this place." +
                    "\r\n\r\n" +
                    UsernameGame + ": I don't know where Colin is by the way. So I couldn't tell you how he is." +
                    "\r\n\r\n" +
                    "Mikey: Oh, sad to hear. I haven't seen him in a while.";
            }
            else if(Gamestate == 17 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = false;

                LblTextTop.Text = "You say goodbye to Mikey, and after less than a minute of walking, you arrive at Colins room." +
                    "\r\n\r\n" +
                    "You immediately start searching for valuables and weapons, but you don't find anything." +
                    "\r\nUntil you look under the bed.";
            }
            else if(Gamestate == 18 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomColin2;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;

                LblTextBottom.Text = UsernameGame + ": What could he keep there?";
            }
            else if(Gamestate == 19 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You reach under the mattress, and you find exactly what you were looking for:" +
                    "\r\n\r\n\r\n\r\n" +
                    "---------------------------------------------------\r\n" +
                    "CREDENTIAL INFORMATION:" +
                    "\r\n\r\n\r\n" +
                    "Password to Jerry's room:" +
                    "\r\n'PAC'" +
                    "\r\n\r\n\r\n" +
                    "Info about the Demons Sting:" +
                    "\r\n- Must be stabbed right through the heart to have effect." +
                    "\r\n- Pax is easily distracted by sound. Use this to attack Pax from the back." +
                    "\r\n\r\n\r\n\r\n" +
                    "FILE WILL BE UPDATED WHEN I FIND NEW INFORMATION" +
                    "\r\n\r\n" +
                    "~ Colin Ritman, Adventurer of the Dungeons, 1984." +
                    "\r\n---------------------------------------------------";

                LblTextBottom.Text = "You remember the information and put the file back under the mattress. " +
                    "You also find an incomplete map of the dungeons, and you learn the route to the staircase.";
            }
            else if(Gamestate == 20 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundRoomColin2;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                BtnChoice1.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Text = "Go back to the staircase";

                LblTextBottom.Text = UsernameGame + ": Let's go then.";
            }
            else if(Gamestate == 21 && ActiveLevel == "Level6_6")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "After you tidy up the room in respect to Colin, you walk out and you go on your way. " +
                    "It's approximately a 10 minute trip to the staircase, and while you're walking, you think about Colins death." +
                    "\r\n\r\n" +
                    "You decide to give everything to kill Pax, because that's what Colin would've wanted.";

                LblTextBottom.Text = "You arrive at the staircase and you think about your choices. You hope to find Jerry, " +
                    "and you mourn for Colin. But you have to move on.";
            }
            else if(Gamestate == 22 && ActiveLevel == "Level6_6")
            {
                Gamestate = 22;

                this.BackgroundImage = Properties.Resources.BackgroundStaircase1;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = false;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go down";
            }
        }
    }
}
