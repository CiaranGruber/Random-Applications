﻿namespace FormApplication
{
    partial class Navigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigation));
            this.Lbl_loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_loading
            // 
            this.Lbl_loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_loading.Font = new System.Drawing.Font("Monotxt", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loading.Location = new System.Drawing.Point(0, 0);
            this.Lbl_loading.Name = "Lbl_loading";
            this.Lbl_loading.Size = new System.Drawing.Size(300, 100);
            this.Lbl_loading.TabIndex = 0;
            this.Lbl_loading.Text = "Loading...";
            this.Lbl_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.Lbl_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Navigation";
            this.Text = "Loading...";
            this.Load += new System.EventHandler(this.Navigation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_loading;
    }
}

