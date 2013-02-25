﻿using System;
namespace AionLauncher
{
    partial class Launcher
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
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.news_panel = new System.Windows.Forms.Panel();
            this.lblNews = new HtmlRenderer.HtmlLabel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnLaunch = new Glass.GlassButton();
            this.btnSettings = new Glass.GlassButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstLang = new System.Windows.Forms.ComboBox();
            this.labelLang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.btnMin = new Glass.GlassButton();
            this.btnExit = new Glass.GlassButton();
            this.appName = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.grap = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timerNews = new System.Windows.Forms.Timer(this.components);
            this.news_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.lblStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusText.ForeColor = System.Drawing.Color.Black;
            this.lblStatusText.Location = new System.Drawing.Point(-1, 381);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(105, 16);
            this.lblStatusText.TabIndex = 2;
            this.lblStatusText.Text = "Server Status:";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.lblServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.ForeColor = System.Drawing.Color.Khaki;
            this.lblServerStatus.Location = new System.Drawing.Point(101, 381);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(72, 16);
            this.lblServerStatus.TabIndex = 3;
            this.lblServerStatus.Text = "Pinging...";
            // 
            // news_panel
            // 
            this.news_panel.BackColor = System.Drawing.Color.Transparent;
            this.news_panel.BackgroundImage = global::AionLauncher.Properties.Resources.u3jsplash;
            this.news_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.news_panel.Controls.Add(this.lblNews);
            this.news_panel.ForeColor = System.Drawing.Color.Transparent;
            this.news_panel.Location = new System.Drawing.Point(12, 61);
            this.news_panel.Margin = new System.Windows.Forms.Padding(0);
            this.news_panel.Name = "news_panel";
            this.news_panel.Size = new System.Drawing.Size(590, 242);
            this.news_panel.TabIndex = 4;
            this.news_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.news_panel_Paint);
            // 
            // lblNews
            // 
            this.lblNews.BackColor = System.Drawing.Color.Transparent;
            this.lblNews.BaseStylesheet = null;
            this.lblNews.Bridge = null;
            this.lblNews.ForeColor = System.Drawing.Color.White;
            this.lblNews.Location = new System.Drawing.Point(0, 0);
            this.lblNews.MaximumSize = new System.Drawing.Size(590, 242);
            this.lblNews.MinimumSize = new System.Drawing.Size(590, 242);
            this.lblNews.Name = "lblNews";
            this.lblNews.Size = new System.Drawing.Size(590, 242);
            this.lblNews.TabIndex = 0;
            this.lblNews.Text = " ";
            this.lblNews.Click += new System.EventHandler(this.lblNews_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.BackgroundImage = global::AionLauncher.Properties.Resources.logo;
            this.pctLogo.Location = new System.Drawing.Point(-8, 6);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(164, 35);
            this.pctLogo.TabIndex = 5;
            this.pctLogo.TabStop = false;
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.MediumBlue;
            this.btnLaunch.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 9.5F);
            this.btnLaunch.ForeColor = System.Drawing.Color.Lavender;
            this.btnLaunch.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLaunch.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnLaunch.Location = new System.Drawing.Point(507, 330);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(87, 57);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "       RUN         GAME";
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Silver;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Font = new System.Drawing.Font("Corbel", 8.5F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSettings.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnSettings.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(481, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.OuterBorderColor = System.Drawing.Color.Silver;
            this.btnSettings.ShineColor = System.Drawing.Color.Transparent;
            this.btnSettings.Size = new System.Drawing.Size(87, 20);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 88);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lstLang
            // 
            this.lstLang.FormattingEnabled = true;
            this.lstLang.Items.AddRange(new object[] {
            "DE",
            "EN",
            "ES",
            "FR",
            "JP"});
            this.lstLang.Location = new System.Drawing.Point(437, 349);
            this.lstLang.MaxLength = 2;
            this.lstLang.Name = "lstLang";
            this.lstLang.Size = new System.Drawing.Size(43, 21);
            this.lstLang.TabIndex = 8;
            this.lstLang.Text = "EN";
            this.lstLang.SelectedIndexChanged += new System.EventHandler(this.lstLang_SelectedIndexChanged);
            // 
            // labelLang
            // 
            this.labelLang.AutoSize = true;
            this.labelLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelLang.ForeColor = System.Drawing.Color.Black;
            this.labelLang.Location = new System.Drawing.Point(368, 350);
            this.labelLang.Name = "labelLang";
            this.labelLang.Size = new System.Drawing.Size(63, 15);
            this.labelLang.TabIndex = 9;
            this.labelLang.Text = "Language";
            this.labelLang.Click += new System.EventHandler(this.labelLang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(174, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "You have the latest version";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(180, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(35, 352);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(139, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Current";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tag = "";
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tag = "";
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tag = "";
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tag = "";
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 500;
            this.timer5.Tag = "";
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Silver;
            this.btnMin.BackgroundImage = global::AionLauncher.Properties.Resources.minimize;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnMin.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnMin.Location = new System.Drawing.Point(570, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.OuterBorderColor = System.Drawing.Color.Silver;
            this.btnMin.ShineColor = System.Drawing.Color.Transparent;
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.TabIndex = 15;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.BackgroundImage = global::AionLauncher.Properties.Resources.close;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.btnExit.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(592, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.OuterBorderColor = System.Drawing.Color.Silver;
            this.btnExit.ShineColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 16;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.appName.Location = new System.Drawing.Point(135, 16);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(108, 17);
            this.appName.TabIndex = 1;
            this.appName.Text = "Game Launch";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.grap});
            this.shapeContainer1.Size = new System.Drawing.Size(620, 409);
            this.shapeContainer1.TabIndex = 17;
            this.shapeContainer1.TabStop = false;
            // 
            // grap
            // 
            this.grap.BackColor = System.Drawing.Color.Transparent;
            this.grap.BorderColor = System.Drawing.Color.Transparent;
            this.grap.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.grap.FillColor = System.Drawing.Color.Transparent;
            this.grap.FillGradientColor = System.Drawing.Color.Transparent;
            this.grap.Location = new System.Drawing.Point(-2, -2);
            this.grap.Name = "grap";
            this.grap.SelectionColor = System.Drawing.Color.Transparent;
            this.grap.Size = new System.Drawing.Size(624, 62);
            this.grap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drag_MouseDown);
            // 
            // timerNews
            // 
            this.timerNews.Interval = 3000;
            this.timerNews.Tick += new System.EventHandler(this.news_Tick);
            // 
            // Launcher
            // 
            this.AcceptButton = this.btnLaunch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(620, 409);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLang);
            this.Controls.Add(this.lstLang);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.news_panel);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aion Launcher";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.news_panel.ResumeLayout(false);
            this.news_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Glass.GlassButton btnSettings;
        private System.Windows.Forms.Label lblStatusText;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Panel news_panel;
        private System.Windows.Forms.PictureBox pctLogo;
        private Glass.GlassButton btnLaunch;
        private Glass.GlassButton btnMin;
        private Glass.GlassButton btnExit;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox lstLang;
        private System.Windows.Forms.Label labelLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape grap;
        private System.Windows.Forms.Timer timerNews;
        private HtmlRenderer.HtmlLabel lblNews;
    }
}
