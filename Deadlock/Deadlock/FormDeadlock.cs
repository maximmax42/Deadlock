using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Deadlock
{
    public partial class FormDeadlock : Form
    {
        int nums = -1;
        int stateTryAgain = 0;
        string curPassword = "";
        const string realPassword = "59812598948524898";
        List<RoundButton> numberButtons = new List<RoundButton>();
        List<Bitmap> images = new List<Bitmap>();

        private void PlaySound(string name) => new SoundPlayer(Properties.Resources.ResourceManager.GetStream("snd_" + name)).Play();

        public FormDeadlock()
        {
            InitializeComponent();
            PlaySound("startup");
            numberButtons.Add(roundButton1);
            numberButtons.Add(roundButton2);
            numberButtons.Add(roundButton3);
            numberButtons.Add(roundButton4);
            numberButtons.Add(roundButton5);
            numberButtons.Add(roundButton6);
            numberButtons.Add(roundButton7);
            numberButtons.Add(roundButton8);
            numberButtons.Add(roundButton9);
            images.Add(null);
            images.Add(Properties.Resources.screen_password1);
            images.Add(Properties.Resources.screen_password2);
            images.Add(Properties.Resources.screen_password3);
            images.Add(Properties.Resources.screen_password4);
            images.Add(Properties.Resources.screen_password5);
            images.Add(Properties.Resources.screen_password6);
            images.Add(Properties.Resources.screen_password7);
            images.Add(Properties.Resources.screen_password8);
            images.Add(Properties.Resources.screen_password9);
            images.Add(Properties.Resources.screen_password10);
            images.Add(Properties.Resources.screen_password11);
            images.Add(Properties.Resources.screen_password12);
            images.Add(Properties.Resources.screen_password13);
            images.Add(Properties.Resources.screen_password14);
            images.Add(Properties.Resources.screen_password15);
            images.Add(Properties.Resources.screen_password16);
            images.Add(Properties.Resources.screen_password17);
        }

        private async void roundButton0_Click(object sender, EventArgs e)
        {
            if (nums == -1 || stateTryAgain == 2)
            {
                PlaySound("0");
                stateTryAgain = 0;
                pictureBoxScreen.BackgroundImage = null;
                nums = 0;
                curPassword = "";
                return;
            }

            if (stateTryAgain == 1)
            {
                PlaySound("0_tryagain");
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_tryagain_no;
                roundButton0.Enabled = false;
                roundButton6.Enabled = true;
                stateTryAgain = 2;
                return;
            }

            stateTryAgain = 1;
            roundButton0.Enabled = false;

            void func()
            {
                if (curPassword == realPassword)
                {
                    PlaySound("0");
                    pictureBoxScreen.BackgroundImage = null;
                    Thread.Sleep(1500);
                    pictureBoxScreen.BackgroundImage = Properties.Resources.screen_accessgranted;
                    PlaySound("accessgranted");
                    Thread.Sleep(2000);
                    Application.Exit();
                }

                PlaySound("0_wrong");
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_wrongpassword;
                Thread.Sleep(300);
                pictureBoxScreen.BackgroundImage = null;
                Thread.Sleep(300);
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_wrongpassword;
                Thread.Sleep(300);
                pictureBoxScreen.BackgroundImage = null;
            }

            await Task.Factory.StartNew(func);
            roundButton0.Enabled = true;
        }

        private void roundButton_Click(object sender, EventArgs e)
        {
            if (stateTryAgain == 0)
            {
                nums++;
                pictureBoxScreen.BackgroundImage = images[nums];
                RoundButton button = (RoundButton)sender;
                for (int i = 0; i < 9; i++) if (button == numberButtons[i])
                    {
                        curPassword += (i + 1).ToString();
                        PlaySound((i + 1).ToString());
                    }
            }
            else
            {
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_tryagain_yes;
                roundButton0.Enabled = true;
                PlaySound("6");
            }
        }

        private void pictureBoxScreen_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (pictureBoxScreen.BackgroundImage == images[17])
            {
                roundButton0.Enabled = true;
                foreach (RoundButton button in numberButtons) button.Enabled = false;
            }
            else if (stateTryAgain == 0 && pictureBoxScreen.BackgroundImage == null)
            {
                roundButton0.Enabled = false;
                foreach (RoundButton button in numberButtons) button.Enabled = true;
            }
        }
    }
}