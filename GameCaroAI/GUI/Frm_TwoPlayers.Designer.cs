﻿using System;
using GameCaroAI.Classes;
using Guna.UI2.WinForms;
using System.Drawing;

namespace GameCaroAI.GUI
{
    partial class Frm_TwoPlayers
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

        public void DrawChessBoard()
        {
            Guna2Button oldButton = new Guna2Button()
            {
                Width = 0,
                Location = new Point(0, 0),
                BorderThickness = 1,
                BackColor = Color.White,
                FillColor = Color.Transparent,
            };
            for (int i = 0; i < Helpers.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j <= Helpers.CHESS_BOARD_WIDTH; j++)
                {
                    Guna2Button btn = new Guna2Button()
                    {
                        Width = Helpers.CHESS_WIDTH,
                        Height = Helpers.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BorderThickness = 1,
                        BackColor = Color.White,
                        FillColor = Color.Transparent,
                    };
                    pn_ChessBoard.Controls.Add(btn);
                    oldButton = btn;
                    btn.Click += Btn_Click;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Helpers.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TwoPlayers));
			this.lbl_O = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lbl_X = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btn_Thoat = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_Redo = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_Undo = new Guna.UI2.WinForms.Guna2GradientButton();
			this.btn_newGame = new Guna.UI2.WinForms.Guna2GradientButton();
			this.pn_HuongDan = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.pn_ChessBoard = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.pn_HuongDan.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_O
			// 
			this.lbl_O.BackColor = System.Drawing.Color.Transparent;
			this.lbl_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_O.ForeColor = System.Drawing.Color.Snow;
			this.lbl_O.Location = new System.Drawing.Point(435, 61);
			this.lbl_O.Name = "lbl_O";
			this.lbl_O.Size = new System.Drawing.Size(137, 31);
			this.lbl_O.TabIndex = 2;
			this.lbl_O.Text = "O (Player 2):";
			// 
			// lbl_X
			// 
			this.lbl_X.BackColor = System.Drawing.Color.Transparent;
			this.lbl_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_X.ForeColor = System.Drawing.Color.Lavender;
			this.lbl_X.Location = new System.Drawing.Point(212, 61);
			this.lbl_X.Name = "lbl_X";
			this.lbl_X.Size = new System.Drawing.Size(135, 31);
			this.lbl_X.TabIndex = 2;
			this.lbl_X.Text = "X (Player 1):";
			// 
			// btn_Thoat
			// 
			this.btn_Thoat.BackColor = System.Drawing.Color.Transparent;
			this.btn_Thoat.BorderRadius = 20;
			this.btn_Thoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btn_Thoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btn_Thoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Thoat.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btn_Thoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btn_Thoat.FillColor = System.Drawing.Color.Moccasin;
			this.btn_Thoat.FillColor2 = System.Drawing.Color.Transparent;
			this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Thoat.ForeColor = System.Drawing.Color.White;
			this.btn_Thoat.Location = new System.Drawing.Point(884, 225);
			this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Thoat.Name = "btn_Thoat";
			this.btn_Thoat.Size = new System.Drawing.Size(93, 45);
			this.btn_Thoat.TabIndex = 1;
			this.btn_Thoat.Text = "Thoát";
			this.btn_Thoat.Click += new System.EventHandler(this.btnThoat_Click);
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
			this.btn_Redo.Location = new System.Drawing.Point(884, 172);
			this.btn_Redo.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Redo.Name = "btn_Redo";
			this.btn_Redo.Size = new System.Drawing.Size(93, 45);
			this.btn_Redo.TabIndex = 1;
			this.btn_Redo.Text = "Redo";
			this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
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
			this.btn_Undo.Location = new System.Drawing.Point(884, 119);
			this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
			this.btn_Undo.Name = "btn_Undo";
			this.btn_Undo.Size = new System.Drawing.Size(93, 45);
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
			this.btn_newGame.Location = new System.Drawing.Point(863, 61);
			this.btn_newGame.Margin = new System.Windows.Forms.Padding(4);
			this.btn_newGame.Name = "btn_newGame";
			this.btn_newGame.Size = new System.Drawing.Size(133, 47);
			this.btn_newGame.TabIndex = 1;
			this.btn_newGame.Text = "New Game";
			this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
			// 
			// pn_HuongDan
			// 
			this.pn_HuongDan.BackColor = System.Drawing.Color.Transparent;
			this.pn_HuongDan.BorderColor = System.Drawing.Color.Black;
			this.pn_HuongDan.BorderRadius = 20;
			this.pn_HuongDan.BorderThickness = 1;
			this.pn_HuongDan.Controls.Add(this.guna2HtmlLabel1);
			this.pn_HuongDan.FillColor = System.Drawing.Color.PapayaWhip;
			this.pn_HuongDan.FillColor2 = System.Drawing.Color.Transparent;
			this.pn_HuongDan.Location = new System.Drawing.Point(24, 670);
			this.pn_HuongDan.Name = "pn_HuongDan";
			this.pn_HuongDan.Size = new System.Drawing.Size(1035, 73);
			this.pn_HuongDan.TabIndex = 1;
			// 
			// guna2HtmlLabel1
			// 
			this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Ivory;
			this.guna2HtmlLabel1.Location = new System.Drawing.Point(13, 3);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 31);
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
			this.pn_ChessBoard.Size = new System.Drawing.Size(674, 552);
			this.pn_ChessBoard.TabIndex = 3;
			// 
			// Frm_TwoPlayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImage = global::GameCaroAI.Properties.Resources.Khungad2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1085, 820);
			this.Controls.Add(this.lbl_X);
			this.Controls.Add(this.lbl_O);
			this.Controls.Add(this.btn_Thoat);
			this.Controls.Add(this.btn_Redo);
			this.Controls.Add(this.btn_newGame);
			this.Controls.Add(this.pn_ChessBoard);
			this.Controls.Add(this.pn_HuongDan);
			this.Controls.Add(this.btn_Undo);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Frm_TwoPlayers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game Cờ Caro";
			this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
			this.pn_HuongDan.ResumeLayout(false);
			this.pn_HuongDan.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2GradientPanel pn_ChessBoard;
        private Guna.UI2.WinForms.Guna2GradientPanel pn_HuongDan;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_newGame;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Redo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Undo;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Thoat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_O;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_X;
    }
}