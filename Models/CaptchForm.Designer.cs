﻿namespace Serbina14.Models
{
    partial class CaptchForm
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
            this.LabelCaptch = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxCaptch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LabelCaptch
            // 
            this.LabelCaptch.AutoSize = true;
            this.LabelCaptch.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCaptch.Location = new System.Drawing.Point(325, 97);
            this.LabelCaptch.Name = "LabelCaptch";
            this.LabelCaptch.Size = new System.Drawing.Size(152, 76);
            this.LabelCaptch.TabIndex = 0;
            this.LabelCaptch.Text = "label1";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(283, 219);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(190, 57);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Обновить капчу";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxCaptch
            // 
            this.textBoxCaptch.Location = new System.Drawing.Point(141, 338);
            this.textBoxCaptch.Name = "textBoxCaptch";
            this.textBoxCaptch.Size = new System.Drawing.Size(459, 20);
            this.textBoxCaptch.TabIndex = 2;
            this.textBoxCaptch.TextChanged += new System.EventHandler(this.textBoxCaptch_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCaptch);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.LabelCaptch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CaptchForm";
            this.Load += new System.EventHandler(this.CaptchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCaptch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxCaptch;
        private System.Windows.Forms.Timer timer1;
    }
}