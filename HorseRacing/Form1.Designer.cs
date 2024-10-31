namespace AtYarisi_v2
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
            this.btnDevam = new System.Windows.Forms.Button();
            this.btnBasaAl = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbxBeyaz = new System.Windows.Forms.PictureBox();
            this.pbxSiyah = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeyaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSiyah)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevam
            // 
            this.btnDevam.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDevam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDevam.Location = new System.Drawing.Point(462, 29);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(173, 45);
            this.btnDevam.TabIndex = 15;
            this.btnDevam.Text = "STOP";
            this.btnDevam.UseVisualStyleBackColor = false;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // btnBasaAl
            // 
            this.btnBasaAl.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBasaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasaAl.Location = new System.Drawing.Point(242, 29);
            this.btnBasaAl.Name = "btnBasaAl";
            this.btnBasaAl.Size = new System.Drawing.Size(173, 45);
            this.btnBasaAl.TabIndex = 14;
            this.btnBasaAl.Text = "S.OVER!";
            this.btnBasaAl.UseVisualStyleBackColor = false;
            this.btnBasaAl.Click += new System.EventHandler(this.btnBasaAl_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Blue;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFinish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinish.Location = new System.Drawing.Point(723, 29);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(45, 392);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "FINISH";
            this.btnFinish.UseVisualStyleBackColor = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Fuchsia;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(33, 29);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(173, 45);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbxBeyaz
            // 
            this.pbxBeyaz.Image = global::AtYarisi_v2.Properties.Resources.beyaz;
            this.pbxBeyaz.Location = new System.Drawing.Point(33, 248);
            this.pbxBeyaz.Name = "pbxBeyaz";
            this.pbxBeyaz.Size = new System.Drawing.Size(118, 113);
            this.pbxBeyaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBeyaz.TabIndex = 13;
            this.pbxBeyaz.TabStop = false;
            // 
            // pbxSiyah
            // 
            this.pbxSiyah.Image = global::AtYarisi_v2.Properties.Resources.siyah;
            this.pbxSiyah.Location = new System.Drawing.Point(33, 108);
            this.pbxSiyah.Name = "pbxSiyah";
            this.pbxSiyah.Size = new System.Drawing.Size(118, 113);
            this.pbxSiyah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSiyah.TabIndex = 12;
            this.pbxSiyah.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnBasaAl);
            this.Controls.Add(this.pbxBeyaz);
            this.Controls.Add(this.pbxSiyah);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBeyaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSiyah)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.Button btnBasaAl;
        private System.Windows.Forms.PictureBox pbxBeyaz;
        private System.Windows.Forms.PictureBox pbxSiyah;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

