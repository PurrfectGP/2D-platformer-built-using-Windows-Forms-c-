using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool goleft, goright, jumping, isGameover;
        int jumpheight;
        int gravity = 15;
        int force;
        int score = 0;

        public int Height()
        {
            jumpheight = pbSprite.Top;
            return jumpheight;
        }

        private void gameKeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }

            if (e.KeyCode == Keys.D)
            {
                force = 9;
            }

            if (e.KeyCode == Keys.A)
            {
                force = -9;
            }
        }

        private void gameKeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }

            if (e.KeyCode == Keys.D)
            {
                force = 0;
            }

            if (e.KeyCode == Keys.A)
            {
                force = 0;
            }
        }

        private void timerStart(object sender, EventArgs e)
        {
            pbSprite.Top += gravity;
            pbSprite.Left += force;

            if (pbSprite.Bounds.IntersectsWith(pbGround.Bounds))
            {
                gravity = 0;
            }
        }

        public void RestartGame()
        {
            jumping = false;
            goleft = false;
            goright = false;
            isGameover = false;
            score = 0;
        }
    }
}
