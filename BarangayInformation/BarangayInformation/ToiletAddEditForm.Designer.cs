﻿
namespace BarangayInformation
{
    partial class ToiletAddEditForm
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
            this.buttontoiletsave = new System.Windows.Forms.Button();
            this.textBoxwatersource = new System.Windows.Forms.TextBox();
            this.labelwatersource = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttontoiletsave
            // 
            this.buttontoiletsave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontoiletsave.Location = new System.Drawing.Point(76, 67);
            this.buttontoiletsave.Name = "buttontoiletsave";
            this.buttontoiletsave.Size = new System.Drawing.Size(84, 33);
            this.buttontoiletsave.TabIndex = 5;
            this.buttontoiletsave.Text = "Save";
            this.buttontoiletsave.UseVisualStyleBackColor = true;
            this.buttontoiletsave.Click += new System.EventHandler(this.buttontoiletsave_Click);
            // 
            // textBoxwatersource
            // 
            this.textBoxwatersource.Location = new System.Drawing.Point(76, 41);
            this.textBoxwatersource.Name = "textBoxwatersource";
            this.textBoxwatersource.Size = new System.Drawing.Size(197, 20);
            this.textBoxwatersource.TabIndex = 4;
            // 
            // labelwatersource
            // 
            this.labelwatersource.AutoSize = true;
            this.labelwatersource.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelwatersource.ForeColor = System.Drawing.Color.White;
            this.labelwatersource.Location = new System.Drawing.Point(20, 39);
            this.labelwatersource.Name = "labelwatersource";
            this.labelwatersource.Size = new System.Drawing.Size(52, 20);
            this.labelwatersource.TabIndex = 3;
            this.labelwatersource.Text = "Toilet:";
            // 
            // ToiletAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(307, 111);
            this.Controls.Add(this.buttontoiletsave);
            this.Controls.Add(this.textBoxwatersource);
            this.Controls.Add(this.labelwatersource);
            this.Name = "ToiletAddEditForm";
            this.Text = "ToiletAddEditForm";
            this.Load += new System.EventHandler(this.ToiletAddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttontoiletsave;
        private System.Windows.Forms.TextBox textBoxwatersource;
        private System.Windows.Forms.Label labelwatersource;
    }
}