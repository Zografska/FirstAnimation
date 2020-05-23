using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ThisAnim
{
    public partial class frmGame : Form
    {
        int score = 0;
        int vx = 2;
        PictureBox[] rings = new PictureBox[4];
        Panel[] panels = new Panel[2];
        private SoundPlayer coinCollect;
        private SoundPlayer ouch;

        public frmGame()
        {
            InitializeComponent();
            coinCollect = new SoundPlayer("coin.wav.wav");
            ouch = new SoundPlayer("thud.wav");
        }


        private void tmrBlueOcto_Tick(object sender, EventArgs e)
        {

            //   int flag = 0;
            //Player starting from the begining
            /*  if (picBlueOcto.Left < 700)
             {
                 picBlueOcto.Left += 1;

             }
             else flag = 1;
             if (flag == 1)
                 picBlueOcto.Left = -100;
             */
            
            picBlueOcto.Location = new Point(picBlueOcto.Location.X + vx, picBlueOcto.Location.Y);
            for (int i = 0; i < 2; i++)
            {
                if (panels[i].Bounds.IntersectsWith(picBlueOcto.Bounds))
                {
                    ouch.Play();
                    vx *= -1;
                    picBlueOcto.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
            }

        

                Random random = new Random();
            if (random.Next(10) % 2 == 0)
                picBlueOcto.Location = new Point(picBlueOcto.Location.X, picBlueOcto.Location.Y + random.Next(5)+2);
            else
                picBlueOcto.Location = new Point(picBlueOcto.Location.X, picBlueOcto.Location.Y - random.Next(5));

         

        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            rings[0] = picRing1;
            rings[1] = picRing2;
            rings[2] = picRing3;
            rings[3] = picRing4;

            tmrBlueOcto.Start();
            panels[0] = panel1;
            panels[1] = panel2;
        }

        private void tmrWindow_Tick(object sender, EventArgs e)
        {
           
                for (int i = 0; i < 4; i++)
                {
                    if (picBlueOcto.Bounds.IntersectsWith(rings[i].Bounds) && rings[i].Visible)
                    {
                        rings[i].Hide();
                        score += 1;
                        coinCollect.Play();
                        lblScore.Text = "Coins: " + score.ToString();
                    }
                }

        }

        private void picBlueOcto_Click(object sender, EventArgs e)
        {
            picBlueOcto.Location = new Point(picBlueOcto.Location.X, picBlueOcto.Location.Y - 25);
        }
    }
}
