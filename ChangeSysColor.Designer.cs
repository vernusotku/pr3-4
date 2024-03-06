namespace WindowsFormsApp3
{
    partial class ChangeSysColor
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
            this.RedTackBar = new System.Windows.Forms.TrackBar();
            this.GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HEXColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.HEXDesktopColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RedTackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RedTackBar
            // 
            this.RedTackBar.LargeChange = 1;
            this.RedTackBar.Location = new System.Drawing.Point(70, 22);
            this.RedTackBar.Maximum = 255;
            this.RedTackBar.Name = "RedTackBar";
            this.RedTackBar.Size = new System.Drawing.Size(164, 45);
            this.RedTackBar.TabIndex = 0;
            this.RedTackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RedTackBar.Scroll += new System.EventHandler(this.TackBar_Scroll);
            // 
            // GreenTrackBar
            // 
            this.GreenTrackBar.LargeChange = 1;
            this.GreenTrackBar.Location = new System.Drawing.Point(70, 54);
            this.GreenTrackBar.Maximum = 255;
            this.GreenTrackBar.Name = "GreenTrackBar";
            this.GreenTrackBar.Size = new System.Drawing.Size(164, 45);
            this.GreenTrackBar.TabIndex = 2;
            this.GreenTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.GreenTrackBar.Scroll += new System.EventHandler(this.TackBar_Scroll);
            // 
            // BlueTrackBar
            // 
            this.BlueTrackBar.LargeChange = 1;
            this.BlueTrackBar.Location = new System.Drawing.Point(70, 84);
            this.BlueTrackBar.Maximum = 255;
            this.BlueTrackBar.Name = "BlueTrackBar";
            this.BlueTrackBar.Size = new System.Drawing.Size(164, 45);
            this.BlueTrackBar.TabIndex = 3;
            this.BlueTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BlueTrackBar.Scroll += new System.EventHandler(this.TackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Green:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(301, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 170);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // HEXColor
            // 
            this.HEXColor.AutoSize = true;
            this.HEXColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.HEXColor.Location = new System.Drawing.Point(355, 195);
            this.HEXColor.Name = "HEXColor";
            this.HEXColor.Size = new System.Drawing.Size(73, 19);
            this.HEXColor.TabIndex = 8;
            this.HEXColor.Text = "#000000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Текущий цвет рабочего стола:";
            // 
            // HEXDesktopColor
            // 
            this.HEXDesktopColor.AutoSize = true;
            this.HEXDesktopColor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.HEXDesktopColor.Location = new System.Drawing.Point(12, 163);
            this.HEXDesktopColor.Name = "HEXDesktopColor";
            this.HEXDesktopColor.Size = new System.Drawing.Size(73, 19);
            this.HEXDesktopColor.TabIndex = 11;
            this.HEXDesktopColor.Text = "#000000";
            // 
            // ChangeSysColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.Controls.Add(this.HEXDesktopColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HEXColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlueTrackBar);
            this.Controls.Add(this.GreenTrackBar);
            this.Controls.Add(this.RedTackBar);
            this.Name = "ChangeSysColor";
            this.Text = "ChangeSysColor";
            ((System.ComponentModel.ISupportInitialize)(this.RedTackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar RedTackBar;
        private System.Windows.Forms.TrackBar GreenTrackBar;
        private System.Windows.Forms.TrackBar BlueTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HEXColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label HEXDesktopColor;
    }
}