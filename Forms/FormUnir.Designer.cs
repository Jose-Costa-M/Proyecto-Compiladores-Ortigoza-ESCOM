﻿namespace Practica1.Forms
{
    partial class FormUnir
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
            this.label3 = new System.Windows.Forms.Label();
            this.unir = new System.Windows.Forms.ComboBox();
            this.con = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUnir_AFND = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(271, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unir Automatas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Con";
            // 
            // unir
            // 
            this.unir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unir.FormattingEnabled = true;
            this.unir.Location = new System.Drawing.Point(279, 128);
            this.unir.Name = "unir";
            this.unir.Size = new System.Drawing.Size(287, 21);
            this.unir.TabIndex = 4;
            // 
            // con
            // 
            this.con.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.con.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con.FormattingEnabled = true;
            this.con.Location = new System.Drawing.Point(279, 242);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(287, 21);
            this.con.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica1.Properties.Resources.pngegg__2_;
            this.pictureBox1.Location = new System.Drawing.Point(505, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnUnir_AFND
            // 
            this.btnUnir_AFND.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10F, System.Drawing.FontStyle.Bold);
            this.btnUnir_AFND.Location = new System.Drawing.Point(330, 303);
            this.btnUnir_AFND.Name = "btnUnir_AFND";
            this.btnUnir_AFND.Size = new System.Drawing.Size(191, 54);
            this.btnUnir_AFND.TabIndex = 7;
            this.btnUnir_AFND.Text = "UNIR AFND\'S";
            this.btnUnir_AFND.UseVisualStyleBackColor = true;
            this.btnUnir_AFND.Click += new System.EventHandler(this.btnUnir_AFND_Click);
            // 
            // FormUnir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUnir_AFND);
            this.Controls.Add(this.con);
            this.Controls.Add(this.unir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormUnir";
            this.Text = "Unir";
            this.Load += new System.EventHandler(this.FormUnir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox unir;
        private System.Windows.Forms.ComboBox con;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUnir_AFND;
    }
}