using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypingSpeedCheckerISuppose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pboxClose_MouseEnter(object sender, EventArgs e)
        {
            pboxClose.Image = Properties.Resources.download__2_;
        }

        private void pboxClose_MouseLeave(object sender, EventArgs e)
        {
            pboxClose.Image = Properties.Resources.download__1_;
        }

        private void pboxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tboxWritingSpace_TextChanged(object sender, EventArgs e)
        {
            int textCount = tboxWritingSpace.Text.Length;
            string lablString = lablMainText.Text.Substring(0, textCount);
            if(tboxWritingSpace.Text != lablString)
            {
                tboxWritingSpace.MaxLength = textCount;
            }
            else
            {
                tboxWritingSpace.MaxLength = lablMainText.Text.Length;
            }
            if(tboxWritingSpace.Text == lablMainText.Text)
            {
                MessageBox.Show("You did it! Good job!");
            }
        }
    }
}
