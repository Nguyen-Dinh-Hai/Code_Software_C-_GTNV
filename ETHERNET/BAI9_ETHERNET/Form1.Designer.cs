﻿
namespace BAI9_ETHERNET
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ServerPort = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP_4 = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP_3 = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP_2 = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP_1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bntDiscon = new System.Windows.Forms.Button();
            this.bntCon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(202, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ETHERNET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ServerPort);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_4);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_3);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_2);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bntDiscon);
            this.groupBox1.Controls.Add(this.bntCon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 192);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setup ";
            // 
            // textBox_ServerPort
            // 
            this.textBox_ServerPort.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBox_ServerPort.Location = new System.Drawing.Point(106, 78);
            this.textBox_ServerPort.Name = "textBox_ServerPort";
            this.textBox_ServerPort.Size = new System.Drawing.Size(68, 22);
            this.textBox_ServerPort.TabIndex = 11;
            this.textBox_ServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ServerPort.Validated += new System.EventHandler(this.textBox_ServerPort_Validated);
            // 
            // textBox_ServerIP_4
            // 
            this.textBox_ServerIP_4.BackColor = System.Drawing.Color.SpringGreen;
            this.textBox_ServerIP_4.Location = new System.Drawing.Point(279, 37);
            this.textBox_ServerIP_4.Name = "textBox_ServerIP_4";
            this.textBox_ServerIP_4.Size = new System.Drawing.Size(51, 22);
            this.textBox_ServerIP_4.TabIndex = 10;
            this.textBox_ServerIP_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ServerIP_4.Validated += new System.EventHandler(this.textBox_ServerIP_4_Validated);
            // 
            // textBox_ServerIP_3
            // 
            this.textBox_ServerIP_3.BackColor = System.Drawing.Color.SpringGreen;
            this.textBox_ServerIP_3.Location = new System.Drawing.Point(222, 37);
            this.textBox_ServerIP_3.Name = "textBox_ServerIP_3";
            this.textBox_ServerIP_3.Size = new System.Drawing.Size(51, 22);
            this.textBox_ServerIP_3.TabIndex = 9;
            this.textBox_ServerIP_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ServerIP_3.Validated += new System.EventHandler(this.textBox_ServerIP_3_Validated);
            // 
            // textBox_ServerIP_2
            // 
            this.textBox_ServerIP_2.BackColor = System.Drawing.Color.SpringGreen;
            this.textBox_ServerIP_2.Location = new System.Drawing.Point(165, 37);
            this.textBox_ServerIP_2.Name = "textBox_ServerIP_2";
            this.textBox_ServerIP_2.Size = new System.Drawing.Size(51, 22);
            this.textBox_ServerIP_2.TabIndex = 8;
            this.textBox_ServerIP_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ServerIP_2.Validated += new System.EventHandler(this.textBox_ServerIP_2_Validated);
            // 
            // textBox_ServerIP_1
            // 
            this.textBox_ServerIP_1.BackColor = System.Drawing.Color.SpringGreen;
            this.textBox_ServerIP_1.Location = new System.Drawing.Point(106, 37);
            this.textBox_ServerIP_1.Name = "textBox_ServerIP_1";
            this.textBox_ServerIP_1.Size = new System.Drawing.Size(51, 22);
            this.textBox_ServerIP_1.TabIndex = 7;
            this.textBox_ServerIP_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_ServerIP_1.TextChanged += new System.EventHandler(this.textBox_ServerIP_1_TextChanged);
            this.textBox_ServerIP_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ServerIP_1_KeyPress);
            this.textBox_ServerIP_1.Validated += new System.EventHandler(this.textBox_ServerIP_1_Validated);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Salmon;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Not connect!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bntDiscon
            // 
            this.bntDiscon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDiscon.Location = new System.Drawing.Point(185, 110);
            this.bntDiscon.Name = "bntDiscon";
            this.bntDiscon.Size = new System.Drawing.Size(104, 30);
            this.bntDiscon.TabIndex = 2;
            this.bntDiscon.Text = "Disconnect ";
            this.bntDiscon.UseVisualStyleBackColor = true;
            this.bntDiscon.Click += new System.EventHandler(this.bntDiscon_Click);
            // 
            // bntCon
            // 
            this.bntCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCon.Location = new System.Drawing.Point(61, 110);
            this.bntCon.Name = "bntCon";
            this.bntCon.Size = new System.Drawing.Size(99, 30);
            this.bntCon.TabIndex = 0;
            this.bntCon.Text = "Connect ";
            this.bntCon.UseVisualStyleBackColor = true;
            this.bntCon.Click += new System.EventHandler(this.bntCon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(348, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Mortor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BAI9_ETHERNET.Properties.Resources.cannuoc;
            this.pictureBox2.Location = new System.Drawing.Point(6, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAI9_ETHERNET.Properties.Resources.dongcooff;
            this.pictureBox1.Location = new System.Drawing.Point(6, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(94, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 27);
            this.button6.TabIndex = 6;
            this.button6.Text = "STOP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(94, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "START";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(94, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "MANUAL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(94, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "AUTO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 219);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ServerPort;
        private System.Windows.Forms.TextBox textBox_ServerIP_4;
        private System.Windows.Forms.TextBox textBox_ServerIP_3;
        private System.Windows.Forms.TextBox textBox_ServerIP_2;
        private System.Windows.Forms.TextBox textBox_ServerIP_1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bntDiscon;
        private System.Windows.Forms.Button bntCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

