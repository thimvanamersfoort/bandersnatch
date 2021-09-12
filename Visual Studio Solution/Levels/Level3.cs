using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandersnatch
{
    public partial class FrmGame
    {
        public void Level3_1()
        {
            ActiveLevel = "Level3_1";

            if (FirstTimeLoading == true && ActiveLevel == "Level3_1")
            {
                Gamestate = 0;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;

                PbFastForward.Visible = true;

                LblTextBottom.Text = "Colin: Wouldn't be my first choice, but I promised to help you. " +
                    "So let's go.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level3_1")
            {
                Gamestate += 1;

                PbCharacter1.Visible = false;
                this.BackgroundImage = null;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You travel trough the dungeons together with Colin, " +
                    "and after following him for a while, you run into an Agent. His skin is blistering and turned yellow. " +
                    "\r\n\r\n" +
                    "You recognize him as Agent 47, an old friend. They used to call him Mike.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level3_1")
            {
                Gamestate += 1;

                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.AgentAggressive2_animated;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor3;

                LblTextBottom.Visible = true;
                LblTextTop.Visible = false;

                LblTextBottom.Text = UsernameGame + ": Hey Mike. How are you doing?" +
                    "\r\n\r\n" +
                    "Agent 47: Jerry is life. Jerry is your fate, and you must accept Jerry. What is the purpose of life?" +
                    "\r\n\r\n" +
                    "Agent 47: Jerry.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level3_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.AgentAggressive2;

                LblTextBottom.Text = "Colin: Hey " + UsernameGame + ". I think your friend here is possessed by Jerry. We can't trust him." +
                    "\r\n\r\n" +
                    "Colin: We should get out of here.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level3_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.AgentAggressive2_animated;

                LblTextBottom.Text = "Agent 47: Fight me losers, and die in the name of the Almighty Jerry.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level3_1")
            {
                Gamestate = 5;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;

                PbCharacter1.Image = Properties.Resources.AgentAggressive2;

                BtnChoice1.Text = "Fight Agent 47";
                BtnChoice2.Text = "Run away";

                LblTextBottom.Text = "Do you fight Agent 47 or do you run away with Colin?";
            }
        }
        public void Level3_2()
        {
            ActiveLevel = "Level3_2";

            if(FirstTimeLoading == true && ActiveLevel == "Level3_2")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = "Colin: Wasn't expecting that, but okay. Saves some time." +
                    "\r\n\r\n" +
                    "Colin: Follow me. And don't forget your balls. You're going to need them.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level3_2")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You follow Colin trough different corridors, and after about half an hour " +
                    "you reach the stairs. You want to go down, but Colin stops you.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level3_2")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection1;
                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin2;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = "Colin: Hey man. Good luck down there. If you want a chance to survive, " +
                    "ask someone for the password to Jerry's room. " +
                    "\r\n\r\n" +
                    "Colin: I wish I could give it to you. But that would be madness.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level3_2")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Wait. You know the password?" +
                    "\r\n\r\n" +
                    "Colin: I do. But Jerry knows that I know it. And he likes to control who goes in and comes out of his room. " +
                    "So if I tell you I'm really fucked. You need to find it out for yourselves. Sorry man.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level3_2")
            {
                Gamestate += 1;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                PbCharacter1.Visible = false;

                this.BackgroundImage = null;

                LblTextTop.Text = "Colin leaves you behind and heads back to the entrance. There's only one option now.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level3_2")
            {
                Gamestate = 5;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = false;

                this.BackgroundImage = Properties.Resources.BackgroundStaircase1;
                PbFastForward.Visible = false;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go down";
            }
        }
        public void Level3_3()
        {
            ActiveLevel = "Level3_3";

            if(FirstTimeLoading == true && ActiveLevel == "Level3_3")
            {
                Gamestate = 0;

                PbCharacter1.Image = Properties.Resources.Colin;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I think I can handle this on my own. But thanks for the help man. " +
                    "\r\n\r\n" +
                    "Colin: No problem. If you need me, I'll be hanging around at the entrance. Good luck.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextTop.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextTop.Text = "You say goodbye to Colin and start travelling into the dungeons. You don't know where you're headed " +
                    "but you just follow your gut.";
                LblTextBottom.Text = "After a while you run into a friendly Roamer. His name is Gus.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;

                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.RoamerFriendly2_animated;

                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextTop.Visible = false;

                LblTextBottom.Text = "Gus: Hey what's up. Need some help?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Yeah, I think I could use some. I just left someone who offered to help me, " +
                    "but I thought that I could handle it myself.";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Gus: Do you mean Colin?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Yea, do you know him?" +
                    "\r\n\r\n" +
                    "Gus: Ofcourse I know him. When I came down here a couple of years ago, he saved me. " +
                    "We came down here with some friends for fun, but we ran into an aggressive Roamer.";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Gus: Colin shot him, but when he showed up, my friends were already gone, and I would be next." +
                    "\r\n\r\n" +
                    UsernameGame + ": Sorry for your loss." +
                    "\r\n\r\n" +
                    "Gus: Thanks. But a friend of Colin is a friend of mine. So if you want, I can try to help you out?";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": That would be really nice. Colin told me about a staircase that I needed to find? " +
                    "\r\n\r\n" +
                    UsernameGame + ": He told me he could take me there, but I said no, because I wanted to find out how to kill Pax first, " +
                    "before I'm standing in front of him.";
            }
            else if(Gamestate == 6 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Gus: So you're searching for the Demon's Sting? You're another Demon Hunter eh?" +
                    "\r\n\r\n" +
                    UsernameGame + ": I guess so. What's this Demon's Sting you're talking about?";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Gus: The Demon's Sting is the only weapon that can kill Pax. An arrow made of pure Damascus Titanium. " +
                    "Handcrafted thousands of years ago, by the master of Pax, to protect the world if Pax once became too strong. " +
                    "There used to be a bow that could fire it, but Pax managed to break it." +
                    "\r\n\r\n" +
                    "Gus: Jerry took the arrow long ago, and kept it in it's room, where it still is. If you can get the arrow and stab it through " +
                    "the heart of that monster, this will all be over.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Wait, who is Jerry? and where can I find his room?" +
                    "\r\n\r\n" +
                    "Gus: Oh boy, you need some schooling.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                this.BackgroundImage = null;

                PbCharacter1.Image = Properties.Resources.Jerry_animated;
                PbCharacter1.BorderStyle = BorderStyle.Fixed3D;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Gus: Jerry is the natural archenemy of Pax. He is the only one that isn't affected by Pax, " +
                    "and has the power of mindcontrol himselves too. He guards the arrow with his life, and if he thinks you're" +
                    "worthy of battling Pax, you can take it.";

                LblTextBottom.Text = "\r\nGus: He can be found in the deeper parts of the dungeons. Nobody knows where his room is, " +
                    "but if you encounter him and he thinks you're capable of defeating Pax, he'll kidnap you and take you to his room. " +
                    "If he doesn't think you're capable, you die.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.BackgroundRoomJerry;

                LblTextTop.Text = "Gus: This is Jerry's room. Here is where he keeps the Demon's sting. No security, you can just take it. " +
                    "But be careful, because there is only one way out, and that could be your death.";
                LblTextBottom.Text = "\r\nGus: The only exit requires a password. Jerry will ask it to you, and if you answer incorrect, " +
                    "the door stays locked. You'll survive for a maximum of 4 days without water, so be sure you know the password.";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level3_3")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.RoamerFriendly2_animated;
                PbCharacter1.BorderStyle = BorderStyle.None;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor5;

                LblTextTop.Visible = false;
                LblTextBottom.Text = "Gus: You will need that password. I know that Colin has it, " +
                    "but I've also heard stories about people asking Jerry for the password, " +
                    "and getting it from him.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level3_3")
            {
                Gamestate = 12;

                PbCharacter1.Image = Properties.Resources.RoamerFriendly2;

                LblTextBottom.Text = "Do you return to Colin or are you going to look for Jerry?";

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;
                PbFastForward.Visible = false;

                BtnChoice1.Text = "Return to Colin";
                BtnChoice2.Text = "Look for Jerry";
            }
        }
        public void Level3_4()
        {
            ActiveLevel = "Level3_4";

            if (FirstTimeLoading == true && ActiveLevel == "Level3_4")
            {
                Gamestate = 0;

                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                PbFastForward.Visible = true;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextBottom.Text = "Colin: Smart choice. Follow me." +
                    "\r\n\r\n" +
                    UsernameGame + ": Is it far?" +
                    "\r\n\r\n" +
                    "Colin: Not really. We'll be there in 5 minutes, if you hurry up.";
            }
            else if(Gamestate == 1 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "After around 10 minutes, and a lot of whining from Colin because you didn't hurry, you arrive at the staircase. " +
                    "\r\n Colin stops you from going down, and says some last words.";
            }
            else if(Gamestate == 2 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection1;

                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin2_animated;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = "Colin: Wait up kid. You know nothing. How are you gonna defeat Pax?";
            }
            else if(Gamestate == 3 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin2;

                LblTextBottom.Text = UsernameGame + ": ...";
            }
            else if(Gamestate == 4 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextBottom.Text = "Colin: Yeah right." +
                    "\r\n\r\n" +
                    "Colin: Listen man. I like you. And that's not something I say to everyone. " +
                    "If you go down there without any knowledge, you have 0 chance to survive. So let me help you, please.";
            }
            else if(Gamestate == 5 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin;

                LblTextBottom.Text = "Do you accept Colins offer for help?";

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Accept offer";

                PbFastForward.Visible = false;
            }
            else if(Gamestate == 6 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                BtnChoice1.Visible = false;
                PbFastForward.Visible = true;

                LblTextBottom.Text = "Colin: I don't think I've told you about Jerry, did I?" +
                    "\r\n\r\n" +
                    UsernameGame + ": Doesn't ring a bell." +
                    "\r\n\r\n" +
                    "Colin: Alright then. Well, in that case, let me tell you about Jerry.";
            }
            else if(Gamestate == 7 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;

                PbCharacter1.Image = Properties.Resources.Jerry_animated;
                PbCharacter1.BorderStyle = BorderStyle.Fixed3D;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Colin: Jerry is the natural archenemy of Pax. He is the only one that isn't affected by Pax, " +
                    "and has the power of mindcontrol himselves too. He possesses the Demons Sting, the only weapon able to kill Pax." ;

                LblTextBottom.Text = "\r\nColin: Crafted thousands of years ago, Pax's master created it for if Pax would ever grow out of his own powers. " +
                    "It was meant to be shot out of a spectral bow, but Pax managed to break the bow. So you will need to stab the arrow through his heart.";
            }
            else if(Gamestate == 8 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Jerry_animated;
                PbCharacter1.BorderStyle = BorderStyle.Fixed3D;
                LblTextBottom.BorderStyle = BorderStyle.None;

                LblTextBottom.Visible = true;
                LblTextTop.Visible = true;

                LblTextTop.Text = "Jerry guards that arrow with his life, but if he thinks you're worthy of battling Pax, you can take it.";

                LblTextBottom.Text = "\r\nColin: He can be found in the deeper parts of the dungeons. Nobody knows where his room is, " +
                    "but if you encounter him and he thinks you're capable of defeating Pax, he'll kidnap you and take you to his room. " +
                    "If he doesn't think you're capable, you die.";
            }
            else if(Gamestate == 9 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.BackgroundRoomJerry;

                LblTextTop.Text = "Colin: This is Jerry's room. That's where you're headed. Here is where he keeps the Demon's sting. No security, you can just take it. " +
                    "But be careful, because there is only one way out, and that could be your death.";
                LblTextBottom.Text = "\r\nColin: The only exit requires a password. Jerry will ask it to you, and if you answer incorrect, " +
                    "the door stays locked. You'll survive for a maximum of 4 days without water, so be sure you know the password.";
            }
            else if(Gamestate == 10 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                PbCharacter1.BorderStyle = BorderStyle.None;
                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection1;

                PbCharacter1.Visible = true;
                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": I like the plan, but there's one problem. I don't know the password..." +
                    "\r\n\r\n" +
                    "Colin: I know it. But I'm scared to give it to you." +
                    "\r\n\r\n" +
                    UsernameGame + ": Why?";
            }
            else if(Gamestate == 11 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: Well, I know it, but Jerry knows it too. I'm not under the influence by him, but he keeps an eye on me. " +
                    "He thinks that I'm a threat. If I give you the password, Jerry doesn't have full control over who enters and exits his room anymore, " +
                    "So he will have to kill me. As punishment." +
                    "\r\n\r\n" +
                    "Colin: So I need to know if I can trust you, before I offer my own life here.";
            }
            else if(Gamestate == 12 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = UsernameGame + ": Don't you care about offering your own life? For a plan that you don't know if it will succeed or not?" +
                    "\r\n\r\n" +
                    "Colin: This isn't my first time in here. And this will definitely not be my last time. So no.";
            }
            else if(Gamestate == 13 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: Good luck kid. \r\nThe password is 'PAC'." +
                    "\r\n\r\nColin: Make this worth it.";
            }
            else if(Gamestate == 14 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;

                LblTextTop.Text = "You say goodbye to Colin and he walks away. After he is around the corner, you start to stress out and decide to go after him. " +
                    "But when you turn around the corner, you're staring into an empty hallway. Colin is gone.";
            }
            else if(Gamestate == 15 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundIntersection3;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": What the fuck...";
            }
            else if(Gamestate == 16 && ActiveLevel == "Level3_4")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                PbCharacter1.Visible = false;

                LblTextBottom.Visible = true;
                LblTextBottom.BorderStyle = BorderStyle.None;
                LblTextTop.Visible = true;

                LblTextTop.Text = "After standing confused for some minutes, you walk into other hallways and start screaming Colins name. " +
                    "But you get no answer. Colin really is gone.";

                LblTextBottom.Text = "You decide you can only do one thing now, and you head to the staircase.";
            }
            else if(Gamestate == 17 && ActiveLevel == "Level3_4")
            {
                Gamestate = 17;

                this.BackgroundImage = Properties.Resources.BackgroundStaircase1;

                LblTextBottom.BorderStyle = BorderStyle.Fixed3D;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = false;

                BtnChoice1.Visible = true;
                BtnChoice1.Text = "Go down";
            }
        }
    }
}
