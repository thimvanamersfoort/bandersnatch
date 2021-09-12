using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandersnatch
{
    public partial class FrmGame
    {
        public void Level1_1()
        {
            ActiveLevel = "Level1_1";

            if (Gamestate == 0 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                BtnChoice2.Visible = false;
                TbUserInput1.Visible = false;
                BtnHomeDeath.Visible = false;

                LblTextTop.Text = "Agent " + UsernameGame + " reporting: \r\n\r\n" +
                                "Well here I am. The Agency sent me here to kill this demon, Pax. He's rumored to roam the dungeons of Ukraine. " +
                                "I don't know much about him, but they said to me that there would be more humans roaming these dungeons. " +
                                "So I think this won't be very hard. Let's do this.";

                LblTextBottom.Text = "Click the button in the right corner to continue after a scene.";
                LblTextBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else if (Gamestate == 1 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundEntrance1;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                LblTextBottom.Text = UsernameGame + ": Let's get down there. \r\n" +
                    "The sooner that demon is killed, the sooner I can get home.";
                LblTextBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                BtnChoice1.Text = "Go down";
                BtnChoice1.Visible = true;

                PbFastForward.Visible = false;
            }
            else if (Gamestate == 2 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                BtnChoice1.Visible = false;
                LblTextTop.Visible = true;
                LblTextTop.Text = "You slowly descend the stairs, into the darkness of the dungeons. The cold, musty air fills your nostrils. \r\n \r\n" +
                    "For a second you stop in the dimly lit corridor, as you think of what to do.";

                LblTextBottom.Visible = false;
                PbFastForward.Visible = true;
            }
            else if (Gamestate == 3 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;
                LblTextBottom.Text = UsernameGame + ": I think I'll need to ask someone for help. Because I haven't even been in here for one minute, and I'm already getting lost. \r\n \r\n" +
                    UsernameGame + ": So let's see if I can find someone. I even have some money to spare.";
            }
            else if (Gamestate == 4 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                this.BackgroundImage = null;
                LblTextBottom.Visible = false;
                LblTextTop.Visible = true;
                LblTextTop.Text = "After randomly taking corners and travelling for some minutes, you walk around a corner and see someone sitting against the wall. " +
                    "You're not far away from the entrance, so you decide to greet him. There's not much that could go wrong. \r\n \r\n \r\n" +
                    "He stands up and introduces himself. His name is Colin.";
            }
            else if (Gamestate == 5 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                LblTextTop.Visible = false;
                LblTextBottom.Visible = true;

                this.BackgroundImage = Properties.Resources.BackgroundCorridor4;
                PbCharacter1.Image = Properties.Resources.Colin2_animated;

                LblTextBottom.Text = "Colin: Hey man, whats up. You look lost. Need some help? \r\n \r\n" +
                    UsernameGame + ": I have a mission to execute here. The Agency sent me.";
            }
            else if (Gamestate == 6 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                PbCharacter1.Image = Properties.Resources.Colin_animated;

                LblTextBottom.Text = "Colin: Ah. The next demon hunter. I've seen many like you come in before. " +
                    "No one ever came out again.";
            }
            else if (Gamestate == 7 && ActiveLevel == "Level1_1")
            {
                Gamestate += 1;

                LblTextBottom.Text = "Colin: I'll help you out. For once. You don't look like you would make it otherwise. \r\n \r\n" +
                    UsernameGame + ": ... \r\n \r\n" +
                    "Colin: But first tell me what you need.";
            }
            else if (Gamestate == 8 && ActiveLevel == "Level1_1")
            {
                // laatste gamestate van het level
                Gamestate = 8;

                LblTextBottom.Text = "Do you ask Colin for info about the dungeons or do you tell Colin more about your mission?";

                PbCharacter1.Image = Properties.Resources.Colin;

                BtnChoice1.Visible = true;
                BtnChoice2.Visible = true;

                BtnChoice1.Text = "Ask Colin for info";
                BtnChoice2.Text = "Tell Colin about your mission";

                PbFastForward.Visible = false;
            }
        }
    }
}
