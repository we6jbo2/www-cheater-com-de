using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using www_cheater_com_de; /*621553*/ namespace WwwCheaterComDe.Forms
{
    public partial class Hidden : Form
    {
        public Hidden()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Normal; // Seems to do the trick in windows 8
        }
    }
}
