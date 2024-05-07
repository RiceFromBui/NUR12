using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        int seconds; // Proměnná pro uchování uplynulých sekund

        // Proměnné určující aktuální rotaci pro každý PictureBox
        int r1 = 2;
        int r2 = 1;
        int r3 = 3;
        int r4 = 3;
        int r5 = 1;
        int r6 = 2;
        int r7 = 3;
        int r8 = 1;
        int r9 = 3;

        public Form1()
        {
            InitializeComponent();
        }

        // Událost volaná každou vteřinu
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Zobrazí uplynulý čas
            if (seconds < 10)
            {
                lbtimer.Text = "0" + seconds++.ToString();
            }
            else
            {
                lbtimer.Text = seconds++.ToString();
            }
        }

        // Metoda pro rotaci obrázku
        private void Rotate(PictureBox pb, int r)
        {
            Bitmap img = new Bitmap(pb.Image);
            for (int i = 0; i < r; i++)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            pb.Image = img;
        }

        // Metoda pro otočení obrázku
        private void Flip(PictureBox pb)
        {
            Bitmap img = new Bitmap(pb.Image);
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pb.Image = img;
            CheckCompletion(); // Zkontroluje, zda je skládačka hotová
        }

        // Metoda zkontroluje, zda je skládačka hotová
        private void CheckCompletion()
        {
            if (r1 == 0 && r2 == 0 && r3 == 0 && r4 == 0 && r5 == 0 && r6 == 0 && r7 == 0 && r8 == 0 && r9 == 0)
            {
                timer1.Stop();
                button2.Visible = false;
                button2.Visible = true;
                MessageBox.Show("Výborně, zvládl jsi to za " + lbtimer.Text + " sekund.");
            }
        }

        // Tlačítko pro spuštění hry
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            seconds = 0;

            // Povolí všechny PictureBoxy a nastaví jejich rotace
            pictureBox1.Enabled = true;
            Rotate(pictureBox1, r1);
            pictureBox2.Enabled = true;
            Rotate(pictureBox2, r2);
            pictureBox3.Enabled = true;
            Rotate(pictureBox3, r3);
            pictureBox4.Enabled = true;
            Rotate(pictureBox4, r4);
            pictureBox5.Enabled = true;
            Rotate(pictureBox5, r5);
            pictureBox6.Enabled = true;
            Rotate(pictureBox6, r6);
            pictureBox7.Enabled = true;
            Rotate(pictureBox7, r7);
            pictureBox8.Enabled = true;
            Rotate(pictureBox8, r8);
            pictureBox9.Enabled = true;
            Rotate(pictureBox9, r9);
        }

        // Kliknutí na jednotlivé PictureBoxy
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            r1++;
            if (r1 == 4)
            {
                r1 = 0;
            }
            Flip(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            r2++;
            if (r2 == 4)
            {
                r2 = 0;
            }
            Flip(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            r3++;
            if (r3 == 4)
            {
                r3 = 0;
            }
            Flip(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            r4++;
            if (r4 == 4)
            {
                r4 = 0;
            }
            Flip(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            r5++;
            if (r5 == 4)
            {
                r5 = 0;
            }
            Flip(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            r6++;
            if (r6 == 4)
            {
                r6 = 0;
            }
            Flip(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            r7++;
            if (r7 == 4)
            {
                r7 = 0;
            }
            Flip(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            r8++;
            if (r8 == 4)
            {
                r8 = 0;
            }
            Flip(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            r9++;
            if (r9 == 4)
            {
                r9 = 0;
            }
            Flip(pictureBox9);
        }

        // Tlačítko pro ukončení aplikace
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
