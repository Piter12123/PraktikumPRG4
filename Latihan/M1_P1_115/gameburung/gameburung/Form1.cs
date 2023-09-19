using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameburung
{

    public partial class Form1 : Form
    {
        int Graviti = 10;
        int kecepatan = 8;
        int skor = 0;
        bool isGameOver = false;

        public event EventHandler MoveToForm2;
        public Form1()
        {
            InitializeComponent();
        }

        private void jamwaktu(object sender, EventArgs e)
        {
            ScoreTeks.Text = skor.ToString();
            if(skor < 5 )
            {
                burung.Top += Graviti;
                batangatas.Left -= kecepatan;
                batangbawah.Left -= kecepatan;
            }
            if(skor > 4 && skor < 20)
            {
                burung.Top += Graviti;
                batangatas.Left -= 18;
                batangbawah.Left -= 18;
            }
            if (skor > 19 && skor < 30)
            {
                burung.Top += Graviti;
                batangatas.Left -= 25;
                batangbawah.Left -= 25;
            }
            if (skor > 29)
            {
                burung.Top += Graviti;
                batangatas.Left -= 50;
                batangbawah.Left -= 50;
            }

            if (batangatas.Left < -50)
            {
                batangatas.Left = 800;
                skor++;
            }
            if (batangbawah.Left < -80)
            {
                batangbawah.Left = 950;
                skor++;
            }
            if (burung.Bounds.IntersectsWith(batangbawah.Bounds) ||
                burung.Bounds.IntersectsWith(batangatas.Bounds) ||
                burung.Bounds.IntersectsWith(tanah.Bounds) ||
                burung.Bounds.IntersectsWith(batasatas.Bounds))
            {
                gameover();
            }

        }

        private void kodeturun(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Graviti = -10;
            }

        }

        private void kodenaik(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Graviti = 10;
            }
        }
        private void gameover()
        {
            jam.Stop();
            ScoreTeks.Text += "Game Over";

            // Menampilkan pesan dialog untuk mengulang permainan
            DialogResult result = MessageBox.Show("Game Over. Apakah Anda ingin mengulang permainan?", "Permainan Selesai", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                Close();
            }
        }

        private void RestartGame()
        {
            // Mengatur ulang kondisi permainan ke awal
            Graviti = 10;
            kecepatan = 8;
            skor = 0;
            isGameOver = false;
            ScoreTeks.Text = "0";

            // Mengatur ulang posisi burung, batang atas, dan batang bawah
            burung.Top = 50;
            batangatas.Left = 800;
            batangbawah.Left = 950;

            // Memulai kembali timer
            jam.Start();
        }


    }
}
