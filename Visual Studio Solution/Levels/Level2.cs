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
        public void Level2_1()
        {
            ActiveLevel = "Level2_1";

            if(FirstTimeLoading == true && ActiveLevel == "Level2_1")
            {
                Gamestate = 0;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbFastForward.Visible = true;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;

                LblTextTop.Text = "You decide to ask Colin for info. \r\n\r\n" +
                    "He responds noddingly and starts telling you about the creatures in the dungeons.";
                    
            }
            else if(Gamestate == 1 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = "Colin: Good question. As of the creatures that walk around here, this isn't your average backyard.\r\n \r\n" +
                    "Colin: First, you have the least dangerous: the friendly Roamer.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;

                PbCharacter1.Image = Properties.Resources.RoamerFriendly1_animated;
                PbCharacter1.BorderStyle = BorderStyle.Fixed3D;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Colin: These guys don't hurt anybody. They're not crazy, just lost. They will probably help you, " +
                    "if you ask it nicely. Mostly hanging around the entrance, but unable to find the exit, they roam around, " +
                    "looking for company. The worst thing they are going to do to you, is trying to sell you junk. " +
                    "They are not your problem.";

                LblTextBottom.Text = "\r\nColin: But their big brothers could get you in trouble. We call them aggressive Roamers.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.RoamerAgressive2_animated;

                LblTextTop.Text = "Colin: These guys are generally pretty aggressive, and have spent at least a longer time in the dungeons, " +
                    "because their skins have discolored from not seeing enough sunlight. If you see one, you better start running, " +
                    "because they will attack you. But they don't have any superpowers, so there are worse creatures out there.";

                LblTextBottom.Text = "\r\nColin: The next guy isn't agrressive though. Very ignorant, always stoned. Hence the name: Ignorant Roamers.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.RoamerIgnorant1_animated;

                LblTextTop.Text = "Colin: I really don't know where you could get weed in this place. But if I find their stash, I'm taking some finders fee. " +
                    "But for them you don't have to worry. They probably won't even talk to you.";

                LblTextBottom.Text = "\r\nColin: The next folks you'll probably know. The Agents. And in this case the friendly ones. " +
                    "You also have mentally insane ones, but we'll cover them in a minute.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.AgentFriendly1_animated;

                LblTextTop.Text = "Colin: Your favorite buddies, but the ones that couldn't defeat Pax. They're doomed to roam the dungeons, " +
                    "because if Pax doesn't want you to leave, you're not leaving. If you're lucky they'll help you, and some even have " +
                    "some valuable information, that could help you.";

                LblTextBottom.Text = "\r\nColin: But some of your friends from the Agency haven't been handling the situation too well." +
                    "They have gone slightly insane, but with the power of an experienced Agent, an enemy to fear.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;
                PbCharacter1.Image = Properties.Resources.AgentAggressive1_animated;

                LblTextTop.Text = "Colin: Aggressive Agents are something you should look out for. Just as aggressive Roamers, they have multiple wounds " +
                    "and their skin is blistering and pale. And with the power of an Agent, they should be considered extremely dangerous. " +
                    "So if you see them, run the fuck away.";

                LblTextBottom.Text = "\r\nColin: Next up we have 2 very weird creatures. The first ones are damned souls of deceased persons, " +
                    "but we just simply call them orbs.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;
                PbCharacter1.Image = Properties.Resources.OrbHelpful_animated;

                LblTextTop.Text = "Colin: Orbs are dead souls roaming the dungeons, but they're kinda sneaky fuckers. " +
                    "They offer you a deal that can either benefit or disadvantage you. If you don't go in on it, " +
                    "they'll usually leave without bothering you. But if you agree to do it, you will learn the orbs true spirit " +
                    "(whether it's peaceful or harmful).";

                LblTextBottom.Text = "\r\nColin: If they turn red, they are evil and will try to harm you. But if they stay white, " +
                    "they are pure souls and will give you what you want. I would just ignore these orbs, until you really have no other option.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;
                PbCharacter1.Image = Properties.Resources.Jerry_animated;

                LblTextTop.Text = "Colin: Next up is Jerry. He is kind of weird, but definitely don't underestimate him. He has the power of mindcontrol. " +
                    "And yes, he's a parrot. \r\n\r\n";
                LblTextBottom.Text = "\r\nColin: He is the only one that isn't under the influence of Pax. He roams around in the deeper parts of the dungeon, " +
                    "which can only be accessed using a long, small staircase. " +
                    "And if he sees a victim he will either decide to kill him or take him to his room. And his room is where you want to go.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;

                LblTextTop.Text = "Colin: In his room he keeps the Demon's Sting. The only weapon powerful enough to kill Pax. The weapon is there for the taking. " +
                    "But to actually escape the room, you need a password. I don't know it, but I heard some Agent that's roaming near the entrance knows it.";

                LblTextBottom.Text = "\r\nColin: But before we make plans, I want to tell you about your true enemy: Pax.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;
                PbCharacter1.Image = Properties.Resources.Pax_animated;

                LblTextTop.Text = "Colin: Pax really is a son of a bitch. With mindcontrol, he kind of created his whole army down here. Anyone who isn't completely mentally sane anymore, " +
                    "will probably be controlled by Pax. He already knew of you before you even got this mission. And he won't just let you kill him. With this entire army around you, " +
                    "you'll need a solid plan.";

                LblTextBottom.Text = "\r\nColin: And I'm going to help you with that.";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level2_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin2_animated;
                PbCharacter1.BorderStyle = BorderStyle.None;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;

                LblTextTop.Visible = false;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;

                LblTextBottom.Text = "Colin: I think you have 2 choices here " + UsernameGame + ".\r\n\r\n" +
                    "Colin: Or we're going to search for this supposed Agent that knows the code, " +
                    "or we're going straight to the staircase, and you try to convince Jerry to give you the code to his room.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level2_1")
            {
                Gamestate = 12;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;

                PbFastForward.Visible = false;

                LblTextBottom.Text = "Colin: So what is it going to be bud? \r\n\r\n" +
                    "Do you go to the staircase or are you going to search for the Agent that has the password?";

                BtnChoice1.Text = "Search for the Agent";
                BtnChoice2.Text = "Head to the staircase";
            }
        }
        public void Level2_2()
        {
            ActiveLevel = "Level2_2";

            if(FirstTimeLoading == true && ActiveLevel == "Level2_2")
            {
                Gamestate = 0;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                PbCharacter1.Image = Properties.Resources.Colin;

                LblTextBottom.Text = UsernameGame + ": Well, as you would probably know, the Agency sent me here. " +
                    "The bastards knew everyone that came here would die." +
                    "\r\n\r\n" +
                    UsernameGame + ": But they need to keep sending people, because this mission started 23 years ago, " +
                    "and that stupid demon still isn't dead.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level2_2")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextBottom.Text = UsernameGame + ": I'm surprised they haven't bombed this place yet." +
                    "\r\n\r\n" +
                    "Colin: They can't. There are too many people in here. They can't afford so many casualties, " +
                    "just for one target.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level2_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: And the worst thing is, Pax would just crawl out of the debris and laugh at it all. " +
                    "Wouldn't even lightly hurt him." +
                    "\r\n\r\n" +
                    "Colin: And that's why they keep sending people like you. Single, unarmed Agents, because that is the safest, " +
                    "most 'humane' way to deal with this situation.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level2_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: You're not the first one that I've helped defeating Pax. " +
                    "Many went in, no one came out. And many more will follow." +
                    "\r\n\r\n" +
                    UsernameGame + ": Then why don't you just leave?" +
                    "\r\n\r\n" +
                    "Colin: Pax doesn't want me to. And if Pax doesn't want you to leave, you're not leaving.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level2_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: So I'm stuck here. Since 1978. I lost track of time, " +
                    "so I don't know for how long I've been down here." +
                    "\r\n\r\n" +
                    UsernameGame + ": Today is th 26th of June 1986. You've been down here for 8 years.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level2_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: 8 years huh. Well, at least I know what to do. " +
                    "More specifically, what you need to do." +
                    "\r\n\r\n" +
                    "Colin: You definitely don't want to underestimate Pax. I've seen many come in here, " +
                    "thinking they could just grab Pax by the neck and walk out of here. They did not age well. \r\n" +
                    "Not at all.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level2_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: Pax has the power of mind control. Just a single mental weakness, " +
                    "and you're done for." +
                    "\r\n\r\n" +
                    "Colin: So make sure you're not autistic or anything, because he will make use of that.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level2_2")
            {
                Gamestate += 1;
                LblTextBottom.Text = "Colin: Pax is hiding in the deeper parts of the dungeons. There is only one way to get there. " +
                    "\r\n\r\n" +
                    "Colin: There is a spiral staircase about 200m from here, leading to the deeper parts. " +
                    "I can take you to it if you want, but from there you're on your own. I'm not going down there.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level2_2")
            {
                Gamestate = 8;

                PbCharacter1.Image = Properties.Resources.Colin;

                PbFastForward.Visible = false;
                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;

                LblTextBottom.Text = "Do you follow Colin to the staircase or do you continue on your own?";

                BtnChoice1.Text = "Continue on your own";
                BtnChoice2.Text = "Follow Colin to the staircase";
            }
        }
    }
}