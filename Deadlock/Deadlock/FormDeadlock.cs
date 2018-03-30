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

/*--------------------------------\
|I am sorry for my code is a mess.|
|              Amen.              |
\--------------------------------*/

namespace Deadlock
{
    public partial class FormDeadlock : Form
    {
        // Current amount of inputted digits, -1 by default is to show that the app was run first time
        int nums = -1;
        // State of "Try Again" screen:
        // 0 - not that screen, 1 - flashy crosses sequence/"Access Granted" sequence
        // 2 - sequence ended
        int stateTryAgain = 0;
        // How many times did the user input correct password
        int trueRetries = 0;
        // You will need to type in the password 5 to 10 times before getting the "Access Granted"
        int trueNeededRetries = new Random().Next(4, 9);
        // Current password
        string curPassword = "";
        // Duh, required password
        const string realPassword = "59812598948524898";
        // I put them in a list so it will be easier to disable them all at once with foreach
        List<RoundButton> numberButtons = new List<RoundButton>();
        // Screen images for the inputed password
        List<Bitmap> images = new List<Bitmap>();

        // I hate this piece of garbage, but I couldn't get any other way of playing sounds to work
        // I just want to have something that could play multiple sounds at once :c
        private void PlaySound(string name) => new SoundPlayer(Properties.Resources.ResourceManager.GetStream("snd_" + name)).Play();

        public FormDeadlock()
        {
            InitializeComponent();
            // windows95_startup.ogg
            PlaySound("startup");
            // Because 9 lines of stuff like
            //   roundButton1.Enabled = false;
            // aren't worth it
            numberButtons.Add(roundButton1);
            numberButtons.Add(roundButton2);
            numberButtons.Add(roundButton3);
            numberButtons.Add(roundButton4);
            numberButtons.Add(roundButton5);
            numberButtons.Add(roundButton6);
            numberButtons.Add(roundButton7);
            numberButtons.Add(roundButton8);
            numberButtons.Add(roundButton9);
            // And here I just added the list because it's really easy to do images[i], where i runs from 0 to 17
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

        // Method for the 0 aka OK button
        private async void roundButton0_Click(object sender, EventArgs e)
        {
            // If this is first boot of the app or the Try Again sequence added
            if (nums == -1 || stateTryAgain == 2)
            {
                PlaySound("0");
                stateTryAgain = 0;
                pictureBoxScreen.BackgroundImage = null;
                nums = 0;
                curPassword = "";
                return;
            }

            // If the password confirmed to be wrong...
            if (stateTryAgain == 1)
            {
                // ...we play that sexy voice saying "Try again!"
                PlaySound("0_tryagain");
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_tryagain_no;
                roundButton0.Enabled = false;
                roundButton6.Enabled = true;
                stateTryAgain = 2;
                return;
            }

            // If none of above (as in when we need to confirm if password is right or wrong)
            stateTryAgain = 1;
            roundButton0.Enabled = false;            

            // Love you, async
            // Eff you, manual thread creation
            await Task.Factory.StartNew(() => {
                if (curPassword == realPassword)
                {
                    if (trueRetries == trueNeededRetries)
                    {
                        PlaySound("0");
                        pictureBoxScreen.BackgroundImage = null;
                        Thread.Sleep(1500);
                        pictureBoxScreen.BackgroundImage = Properties.Resources.screen_accessgranted;
                        PlaySound("accessgranted");
                        Thread.Sleep(2000);
                        Application.Exit();
                    }
                    else trueRetries++;
                }

                PlaySound("0_wrong");
                // That animation code... [sarcasm]Beautiful.[/sarcasm]
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_wrongpassword;
                Thread.Sleep(300);
                pictureBoxScreen.BackgroundImage = null;
                Thread.Sleep(300);
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_wrongpassword;
                Thread.Sleep(300);
                pictureBoxScreen.BackgroundImage = null;
            });
            roundButton0.Enabled = true;
        }

        // Common method for all the 1-9 buttons
        private void roundButton_Click(object sender, EventArgs e)
        {
            // If we still input the password
            if (stateTryAgain == 0)
            {
                pictureBoxScreen.BackgroundImage = images[++nums];
                RoundButton button = (RoundButton)sender;
                char btnNum = button.Name[button.Name.Length - 1];
                curPassword += btnNum;
                // Notes for the final input are different, and this is my "great" way to detect that
                if (trueRetries == trueNeededRetries && curPassword + "8" == realPassword) PlaySound("2");
                else if (trueRetries == trueNeededRetries && curPassword == realPassword) PlaySound("1");
                else PlaySound(btnNum.ToString());
            }
            // If we need to move the > to YES
            else
            {
                pictureBoxScreen.BackgroundImage = Properties.Resources.screen_tryagain_yes;
                roundButton0.Enabled = true;
                PlaySound("6");
            }
        }

        // Enabling/disabling certain button sets when typing the password
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