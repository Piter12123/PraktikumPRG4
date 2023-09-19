namespace gameburung
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tanah = new System.Windows.Forms.PictureBox();
            this.burung = new System.Windows.Forms.PictureBox();
            this.batangbawah = new System.Windows.Forms.PictureBox();
            this.jam = new System.Windows.Forms.Timer(this.components);
            this.batangatas = new System.Windows.Forms.PictureBox();
            this.ScoreTeks = new System.Windows.Forms.Label();
            this.batasatas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tanah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batangbawah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batangatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batasatas)).BeginInit();
            this.SuspendLayout();
            // 
            // tanah
            // 
            this.tanah.Image = global::gameburung.Properties.Resources.ground;
            this.tanah.Location = new System.Drawing.Point(-1, 475);
            this.tanah.Name = "tanah";
            this.tanah.Size = new System.Drawing.Size(1102, 63);
            this.tanah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tanah.TabIndex = 2;
            this.tanah.TabStop = false;
            // 
            // burung
            // 
            this.burung.Image = global::gameburung.Properties.Resources.bird;
            this.burung.Location = new System.Drawing.Point(191, 177);
            this.burung.Name = "burung";
            this.burung.Size = new System.Drawing.Size(79, 46);
            this.burung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.burung.TabIndex = 0;
            this.burung.TabStop = false;
            // 
            // batangbawah
            // 
            this.batangbawah.Image = global::gameburung.Properties.Resources.pipe;
            this.batangbawah.Location = new System.Drawing.Point(628, 280);
            this.batangbawah.Name = "batangbawah";
            this.batangbawah.Size = new System.Drawing.Size(118, 200);
            this.batangbawah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batangbawah.TabIndex = 3;
            this.batangbawah.TabStop = false;
            // 
            // jam
            // 
            this.jam.Enabled = true;
            this.jam.Interval = 20;
            this.jam.Tick += new System.EventHandler(this.jamwaktu);
            // 
            // batangatas
            // 
            this.batangatas.Image = global::gameburung.Properties.Resources.pipedown;
            this.batangatas.Location = new System.Drawing.Point(887, 9);
            this.batangatas.Name = "batangatas";
            this.batangatas.Size = new System.Drawing.Size(115, 213);
            this.batangatas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batangatas.TabIndex = 1;
            this.batangatas.TabStop = false;
            // 
            // ScoreTeks
            // 
            this.ScoreTeks.AutoSize = true;
            this.ScoreTeks.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeks.Location = new System.Drawing.Point(12, 9);
            this.ScoreTeks.Name = "ScoreTeks";
            this.ScoreTeks.Size = new System.Drawing.Size(86, 23);
            this.ScoreTeks.TabIndex = 4;
            this.ScoreTeks.Text = "Score : 0";
            // 
            // batasatas
            // 
            this.batasatas.Location = new System.Drawing.Point(-1, -20);
            this.batasatas.Name = "batasatas";
            this.batasatas.Size = new System.Drawing.Size(1102, 26);
            this.batasatas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.batasatas.TabIndex = 5;
            this.batasatas.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 536);
            this.Controls.Add(this.batasatas);
            this.Controls.Add(this.burung);
            this.Controls.Add(this.ScoreTeks);
            this.Controls.Add(this.batangatas);
            this.Controls.Add(this.tanah);
            this.Controls.Add(this.batangbawah);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kodeturun);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kodenaik);
            ((System.ComponentModel.ISupportInitialize)(this.tanah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batangbawah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batangatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batasatas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox burung;
        private System.Windows.Forms.PictureBox tanah;
        private System.Windows.Forms.PictureBox batangbawah;
        private System.Windows.Forms.Timer jam;
        private System.Windows.Forms.PictureBox batangatas;
        private System.Windows.Forms.Label ScoreTeks;
        private System.Windows.Forms.PictureBox batasatas;
    }
}

