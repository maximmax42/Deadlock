using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deadlock
{
    public partial class RoundButton : UserControl
    {
        public RoundButton() => InitializeComponent();

        private void roundButton_MouseDown(object sender, MouseEventArgs e) => this.BackgroundImage = Deadlock.Properties.Resources.button_click;

        private void roundButton_MouseHover(object sender, EventArgs e) => this.BackgroundImage = Deadlock.Properties.Resources.button_hover;

        private void roundButton_MouseLeave(object sender, EventArgs e) => this.BackgroundImage = Deadlock.Properties.Resources.button;

        private void roundButton_MouseUp(object sender, MouseEventArgs e) => this.BackgroundImage = Deadlock.Properties.Resources.button_hover;
    }
}
