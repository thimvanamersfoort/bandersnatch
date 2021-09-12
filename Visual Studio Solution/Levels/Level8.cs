using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandersnatch
{
    public partial class FrmGame
    {
        public void Level8_1()
        {
            ActiveLevel = "Level8_1";

            if(FirstTimeLoading == true && ActiveLevel == "Level8_1")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;
                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You decide to enter through the door, but you soon notice that the door is shut tight." +
                    "\r\n\r\n" +
                    "So you decide to start pushing.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundDoor1;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Push";
                PbFastForward.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Let's get this door open."; 
            }
            else if(Gamestate == 2 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Shit. This thing is heavy.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": One more try.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Uuugh.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Let's go.";
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
            }
            else if(Gamestate == 6 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You break through the door, and you're standing in a long hall. " +
                    "At the end is a small passthrough, but you can't see what's behind it." +
                    "\r\n\r\n" +
                    "You made the choice to open the door, so you're going to check it out.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor7;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go forward";
                PbFastForward.Visible = false;
            }
            else if(Gamestate == 8 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextTop.Visible = true;
                LblTextBottom.Visible = false;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;

                LblTextTop.Text = "You pass the dark part of the corridor, and you're standing in a dim-lighted hall. " +
                    "In the middle you spot some kind of inactive fountain.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHallPax1;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Hello? Anybody here?";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHallPax1;

                LblTextBottom.Text = "Pax: Were you looking for me?";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Since nobody is standing in front of you, you turn around. " +
                    "You stare into the empty hallway that you just came from." +
                    "\r\n\r\n" +
                    "But no one is there.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor7;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Turn back around";

                LblTextBottom.Text = UsernameGame + ": Hello?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Who said that?";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                this.BackgroundImage = null;

                LblTextTop.Text = "You hear heavy breathing behind you, now that you've turned around and you're staring " +
                    "into the hallway. You decide to turn back around, looking into the hall. " +
                    "But when you've turned around, you stiffen up." +
                    "\r\n\r\n" +
                    "In front of you is the creature you needed to find. But also the last person you'll ever want to encounter.";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundHallPax1;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Pax_animated;

                LblTextBottom.Text = "Pax: Hello " + UsernameGame + ". Glad you could make it. " +
                    "I hope they didn't hurt you too much." +
                    "\r\n\r\n" +
                    "Pax: Would you like something to drink maybe? There is some water in the fountain.";
            }
            else if(Gamestate == 15 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Pax;

                LblTextBottom.Text = UsernameGame + ": Uhhh..." +
                    "\r\n\r\n" +
                    UsernameGame + ": No thank you. I'll pass." +
                    "\r\n\r\n" +
                    "Pax: Suit yourself.";
            }
            else if(Gamestate == 16 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Pax_animated;

                LblTextBottom.Text = "Pax: Well " + UsernameGame + ". I have to say, for someone who's here for the first time, " +
                    "you sure did a good job." +
                    "\r\n\r\n" +
                    "Pax: Did Colin help you?";
            }
            else if(Gamestate == 17 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Pax;

                LblTextBottom.Text = UsernameGame + ": Without Colin I wouldn't be here." +
                    "\r\n\r\n" +
                    UsernameGame + ": But I'm damn glad I am...";
            }
            else if(Gamestate == 18 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Pax_animated;

                LblTextBottom.Text = "Pax: Ohh " + UsernameGame + ", " + UsernameGame + ", " + UsernameGame + "... " +
                    "\r\n\r\n" +
                    "Pax: So brave, yet so innocent." +
                    "\r\n\r\n" +
                    "Pax: But Colin is a good kid. We can't talk shit about him.";
            }
            else if(Gamestate == 19 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Pax: After all, he led you to me without hesitation." +
                    "\r\n\r\n\r\n" +
                    UsernameGame + ": He led me to Jerry. I found you by myself.";
            }
            else if(Gamestate == 20 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Pax: Jerry? You mean that pigeon like thing?" +
                    "\r\n\r\n" +
                    "Pax: I created that stupid mammal! To 'give people the illusion that I have a weakness'." +
                    "\r\n\r\n" +
                    "Pax: But my reign will NEVER DIE!";
            }
            else if(Gamestate == 21 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Pax;

                LblTextBottom.Text = "Pax: I'm guessing you brought his cute litte arrow as well?" +
                    "\r\n\r\n\r\n" +
                    "You let the Demons Sting slide out of your sleeve, into your hand." +
                    "\r\n\r\n" +
                    UsernameGame + ": I'm not scared of you. It's time you'll be dealt with.";
            }
            else if(Gamestate == 22 && ActiveLevel == "Level8_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Pax_animated;

                LblTextBottom.Text = "Pax: Listen " + UsernameGame + ". I admire your bravery, but your fairytale ends here." +
                    "\r\n\r\n\r\n" +
                    "Pax: I'll give you one chance. Surrender now, or your brain will be a smoothie within seconds.";
            }
            else if(Gamestate == 23 && ActiveLevel == "Level8_1")
            {
                Gamestate = 23;

                PbCharacter1.Image = Properties.Resources.Pax;
                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                BtnChoice1.Text = "Surrender";
                BtnChoice2.Text = "Fight Pax";

                LblTextBottom.Text = "Do you fight Pax or do you surrender under his power?";
            }
        }
        public void Level8_2()
        {
            ActiveLevel = "Level8_2";

            if(FirstTimeLoading == true && ActiveLevel == "Level8_2")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Yeah. Let's head back.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level8_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You don't feel safe going through the door. You decide to head back to the entrance. " +
                    "You don't care about Pax anymore. You don't care about any of this anymore. You're tired." +
                    "\r\n\r\n" +
                    "You want to go home. Alive.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level8_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;
                LblTextTop.Visible = false;
                LblTextBottom.Visible = false;
                BtnChoice1.Visible = true;
                PbFastForward.Visible = false;
                BtnChoice1.Text = "Head back to the entrance";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level8_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor2;
                BtnChoice1.Text = "Go forward";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level8_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;
            }
            else if(Gamestate == 5 && ActiveLevel == "Level8_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You have been walking for about 10 minutes now and you're getting even more tired. " +
                    "Until you go around a corner, and you see a creature sitting against the wall. " +
                    "\r\n\r\n" +
                    "He looks like a human, but his skin is bloody red and blistering. " +
                    "His transparent white pupils scanning the corridor. " +
                    "A mix of blood and drool dripping from the corners of his mouth." +
                    "\r\n\r\n\r\n" +
                    "You try to sneak away, but you accidentally kick a small rock in your way." +
                    "\r\n\r\n" +
                    "He noticed you.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level8_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection3;
                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.RoamerInsane1_animated;

                LblTextBottom.Text = "Roamer: Mmmgggrrrhh..." +
                    "\r\n\r\n\r\n" +
                    UsernameGame + ": Hell no. I don't think I can handle this anymore.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level8_2")
            {
                Gamestate = 7;

                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                BtnChoice1.Text = "Run";
                BtnChoice2.Text = "Fight";

                LblTextBottom.Text = "Do you run away from the Roamer or do you fight him?";
            }
        }
    }
}
