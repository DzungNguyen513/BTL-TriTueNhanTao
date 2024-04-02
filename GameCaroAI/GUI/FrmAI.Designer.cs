﻿using GameCaroAI.Classes;
using Guna.UI2.WinForms;
using System.Drawing;

namespace GameCaroAI.GUI
{
    partial class FrmAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAI));
            this.lbl_Computer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_You = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Redo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Undo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_newGame = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pn_Intruction = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_ChessBoard = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.time_Instruction = new System.Windows.Forms.Timer(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lb_timer = new System.Windows.Forms.Label();
            this.timer_Lose = new System.Windows.Forms.Timer(this.components);
            this.pn_Intruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Computer
            // 
            this.lbl_Computer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Computer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Computer.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Computer.Location = new System.Drawing.Point(212, 81);
            this.lbl_Computer.Name = "lbl_Computer";
            this.lbl_Computer.Size = new System.Drawing.Size(117, 24);
            this.lbl_Computer.TabIndex = 2;
            this.lbl_Computer.Text = "O (Computer):";
            // 
            // lbl_You
            // 
            this.lbl_You.BackColor = System.Drawing.Color.Transparent;
            this.lbl_You.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_You.ForeColor = System.Drawing.Color.Lavender;
            this.lbl_You.Location = new System.Drawing.Point(212, 52);
            this.lbl_You.Name = "lbl_You";
            this.lbl_You.Size = new System.Drawing.Size(69, 24);
            this.lbl_You.TabIndex = 2;
            this.lbl_You.Text = "X (You):";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderRadius = 20;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.Color.Moccasin;
            this.btn_back.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(891, 229);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(112, 45);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Redo
            // 
            this.btn_Redo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Redo.BorderRadius = 20;
            this.btn_Redo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Redo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Redo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Redo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Redo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Redo.FillColor = System.Drawing.Color.Moccasin;
            this.btn_Redo.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Redo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Redo.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.Location = new System.Drawing.Point(891, 176);
            this.btn_Redo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(112, 45);
            this.btn_Redo.TabIndex = 1;
            this.btn_Redo.Text = "Redo";
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Undo.BorderRadius = 20;
            this.btn_Undo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Undo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Undo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Undo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Undo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Undo.FillColor = System.Drawing.Color.Moccasin;
            this.btn_Undo.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Undo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Undo.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.Location = new System.Drawing.Point(891, 123);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(112, 45);
            this.btn_Undo.TabIndex = 1;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.Color.Transparent;
            this.btn_newGame.BorderRadius = 20;
            this.btn_newGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_newGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_newGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newGame.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_newGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_newGame.FillColor = System.Drawing.Color.Moccasin;
            this.btn_newGame.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_newGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newGame.ForeColor = System.Drawing.Color.White;
            this.btn_newGame.Location = new System.Drawing.Point(870, 65);
            this.btn_newGame.Margin = new System.Windows.Forms.Padding(4);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(133, 47);
            this.btn_newGame.TabIndex = 1;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // pn_Intruction
            // 
            this.pn_Intruction.BackColor = System.Drawing.Color.Transparent;
            this.pn_Intruction.BorderColor = System.Drawing.Color.Black;
            this.pn_Intruction.BorderRadius = 20;
            this.pn_Intruction.BorderThickness = 1;
            this.pn_Intruction.Controls.Add(this.guna2HtmlLabel1);
            this.pn_Intruction.FillColor = System.Drawing.Color.PapayaWhip;
            this.pn_Intruction.FillColor2 = System.Drawing.Color.Transparent;
            this.pn_Intruction.Location = new System.Drawing.Point(21, 690);
            this.pn_Intruction.Name = "pn_Intruction";
            this.pn_Intruction.Size = new System.Drawing.Size(1056, 75);
            this.pn_Intruction.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Ivory;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(106, 24);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Hướng dẫn:";
            // 
            // pn_ChessBoard
            // 
            this.pn_ChessBoard.BackColor = System.Drawing.Color.White;
            this.pn_ChessBoard.BorderColor = System.Drawing.Color.Black;
            this.pn_ChessBoard.BorderThickness = 1;
            this.pn_ChessBoard.Location = new System.Drawing.Point(202, 119);
            this.pn_ChessBoard.Margin = new System.Windows.Forms.Padding(4);
            this.pn_ChessBoard.Name = "pn_ChessBoard";
            this.pn_ChessBoard.Size = new System.Drawing.Size(691, 571);
            this.pn_ChessBoard.TabIndex = 3;
            // 
            // time_Instruction
            // 
            this.time_Instruction.Tick += new System.EventHandler(this.time_Instruction_Tick);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(667, 52);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(47, 47);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // lb_timer
            // 
            this.lb_timer.AutoSize = true;
            this.lb_timer.BackColor = System.Drawing.Color.Transparent;
            this.lb_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timer.ForeColor = System.Drawing.Color.MistyRose;
            this.lb_timer.Location = new System.Drawing.Point(720, 65);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(67, 25);
            this.lb_timer.TabIndex = 5;
            this.lb_timer.Text = "00:00";
            // 
            // timer_Lose
            // 
            this.timer_Lose.Interval = 1000;
            this.timer_Lose.Tick += new System.EventHandler(this.timer_Lose_Tick);
            // 
            // FrmAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::GameCaroAI.Properties.Resources.Khungad2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 843);
            this.Controls.Add(this.lb_timer);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.lbl_Computer);
            this.Controls.Add(this.pn_ChessBoard);
            this.Controls.Add(this.lbl_You);
            this.Controls.Add(this.pn_Intruction);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Redo);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.btn_Undo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Cờ Caro";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.pn_Intruction.ResumeLayout(false);
            this.pn_Intruction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        #endregion
        public Guna.UI2.WinForms.Guna2GradientPanel pn_ChessBoard;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_Intruction;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_newGame;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Redo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Undo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_back;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_Computer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_You;
        private System.Windows.Forms.Timer time_Instruction;
        private Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.Timer timer_Lose;
    }
}