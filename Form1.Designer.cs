namespace BSP_Launcher
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxnoupdate = new System.Windows.Forms.CheckBox();
            this.checkBoxcheat = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labeldownload = new System.Windows.Forms.Label();
            this.checkBoxcheatreinstall = new System.Windows.Forms.CheckBox();
            this.checkBoxgamereinstall = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Launch Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxnoupdate
            // 
            this.checkBoxnoupdate.AutoSize = true;
            this.checkBoxnoupdate.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxnoupdate.ForeColor = System.Drawing.Color.White;
            this.checkBoxnoupdate.Location = new System.Drawing.Point(504, 22);
            this.checkBoxnoupdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxnoupdate.Name = "checkBoxnoupdate";
            this.checkBoxnoupdate.Size = new System.Drawing.Size(103, 24);
            this.checkBoxnoupdate.TabIndex = 2;
            this.checkBoxnoupdate.Text = "No Update";
            this.checkBoxnoupdate.UseVisualStyleBackColor = false;
            // 
            // checkBoxcheat
            // 
            this.checkBoxcheat.AutoSize = true;
            this.checkBoxcheat.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxcheat.ForeColor = System.Drawing.Color.White;
            this.checkBoxcheat.Location = new System.Drawing.Point(504, 90);
            this.checkBoxcheat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxcheat.Name = "checkBoxcheat";
            this.checkBoxcheat.Size = new System.Drawing.Size(102, 24);
            this.checkBoxcheat.TabIndex = 3;
            this.checkBoxcheat.Text = "MKS Cheat";
            this.checkBoxcheat.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 96);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 68);
            this.button2.TabIndex = 4;
            this.button2.Text = "Install NetCore6";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 381);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(777, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // labeldownload
            // 
            this.labeldownload.AutoSize = true;
            this.labeldownload.BackColor = System.Drawing.Color.Transparent;
            this.labeldownload.ForeColor = System.Drawing.Color.White;
            this.labeldownload.Location = new System.Drawing.Point(503, 333);
            this.labeldownload.Name = "labeldownload";
            this.labeldownload.Size = new System.Drawing.Size(183, 40);
            this.labeldownload.TabIndex = 6;
            this.labeldownload.Text = "BlockStarPlanet Launcher\r\nby maicja";
            // 
            // checkBoxcheatreinstall
            // 
            this.checkBoxcheatreinstall.AutoSize = true;
            this.checkBoxcheatreinstall.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxcheatreinstall.ForeColor = System.Drawing.Color.White;
            this.checkBoxcheatreinstall.Location = new System.Drawing.Point(504, 124);
            this.checkBoxcheatreinstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxcheatreinstall.Name = "checkBoxcheatreinstall";
            this.checkBoxcheatreinstall.Size = new System.Drawing.Size(115, 24);
            this.checkBoxcheatreinstall.TabIndex = 7;
            this.checkBoxcheatreinstall.Text = "Cheat Repair";
            this.checkBoxcheatreinstall.UseVisualStyleBackColor = false;
            // 
            // checkBoxgamereinstall
            // 
            this.checkBoxgamereinstall.AutoSize = true;
            this.checkBoxgamereinstall.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxgamereinstall.ForeColor = System.Drawing.Color.White;
            this.checkBoxgamereinstall.Location = new System.Drawing.Point(504, 56);
            this.checkBoxgamereinstall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxgamereinstall.Name = "checkBoxgamereinstall";
            this.checkBoxgamereinstall.Size = new System.Drawing.Size(85, 24);
            this.checkBoxgamereinstall.TabIndex = 8;
            this.checkBoxgamereinstall.Text = "ReInstall";
            this.checkBoxgamereinstall.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BSP_Launcher.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 355);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::BSP_Launcher.Properties.Resources.alegra;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 426);
            this.Controls.Add(this.checkBoxgamereinstall);
            this.Controls.Add(this.checkBoxcheatreinstall);
            this.Controls.Add(this.labeldownload);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxcheat);
            this.Controls.Add(this.checkBoxnoupdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlockStarPlanet Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxnoupdate;
        private System.Windows.Forms.CheckBox checkBoxcheat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labeldownload;
        private System.Windows.Forms.CheckBox checkBoxcheatreinstall;
        private System.Windows.Forms.CheckBox checkBoxgamereinstall;
    }
}

