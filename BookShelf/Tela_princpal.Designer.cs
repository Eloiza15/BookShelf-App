﻿namespace BookShelf
{
    partial class Tela_princpal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_princpal));
            PanelSuperior = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel_principal = new Panel();
            lblTitulo = new Label();
            pictureBox4 = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.Indigo;
            PanelSuperior.Controls.Add(pictureBox2);
            PanelSuperior.Controls.Add(pictureBox1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Margin = new Padding(2);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(595, 31);
            PanelSuperior.TabIndex = 0;
            PanelSuperior.MouseDown += PanelSuperior_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(542, 2);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(570, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel_principal
            // 
            panel_principal.BackColor = Color.FromArgb(224, 254, 255);
            panel_principal.Controls.Add(lblTitulo);
            panel_principal.Controls.Add(pictureBox4);
            panel_principal.Dock = DockStyle.Fill;
            panel_principal.Location = new Point(0, 31);
            panel_principal.Margin = new Padding(2);
            panel_principal.Name = "panel_principal";
            panel_principal.Size = new Size(595, 309);
            panel_principal.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(244, 237);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 25);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "BookShelf";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._5f9d8322_69d6_45f7_ad15_8ae4619609a7;
            pictureBox4.Location = new Point(158, 4);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(281, 279);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Tela_princpal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 340);
            Controls.Add(panel_principal);
            Controls.Add(PanelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Tela_princpal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookShelf";
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_principal.ResumeLayout(false);
            panel_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelSuperior;
        private Panel panel_principal;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer;
        private Label lblTitulo;
    }
}
