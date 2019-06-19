namespace FormApplication
{
    partial class MainMenu
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
            this.Lbl_title = new System.Windows.Forms.Label();
            this.Pnl_quitPadding = new System.Windows.Forms.Panel();
            this.Btn_quit = new System.Windows.Forms.Button();
            this.Pnl_availableGenerators = new System.Windows.Forms.Panel();
            this.Pnl_quitPadding.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_title
            // 
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_title.Font = new System.Drawing.Font("Monotxt", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Padding = new System.Windows.Forms.Padding(50, 48, 50, 48);
            this.Lbl_title.Size = new System.Drawing.Size(1120, 194);
            this.Lbl_title.TabIndex = 0;
            this.Lbl_title.Text = "Random Generators";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_quitPadding
            // 
            this.Pnl_quitPadding.Controls.Add(this.Btn_quit);
            this.Pnl_quitPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_quitPadding.Location = new System.Drawing.Point(0, 798);
            this.Pnl_quitPadding.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pnl_quitPadding.Name = "Pnl_quitPadding";
            this.Pnl_quitPadding.Padding = new System.Windows.Forms.Padding(50, 48, 50, 48);
            this.Pnl_quitPadding.Size = new System.Drawing.Size(1120, 194);
            this.Pnl_quitPadding.TabIndex = 2;
            // 
            // Btn_quit
            // 
            this.Btn_quit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_quit.Location = new System.Drawing.Point(50, 48);
            this.Btn_quit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Btn_quit.Name = "Btn_quit";
            this.Btn_quit.Size = new System.Drawing.Size(1020, 98);
            this.Btn_quit.TabIndex = 0;
            this.Btn_quit.Text = "Quit";
            this.Btn_quit.UseVisualStyleBackColor = true;
            this.Btn_quit.Click += new System.EventHandler(this.Btn_quit_Click);
            // 
            // Pnl_availableGenerators
            // 
            this.Pnl_availableGenerators.AutoScroll = true;
            this.Pnl_availableGenerators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_availableGenerators.Location = new System.Drawing.Point(0, 194);
            this.Pnl_availableGenerators.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Pnl_availableGenerators.Name = "Pnl_availableGenerators";
            this.Pnl_availableGenerators.Padding = new System.Windows.Forms.Padding(50, 48, 50, 48);
            this.Pnl_availableGenerators.Size = new System.Drawing.Size(1120, 604);
            this.Pnl_availableGenerators.TabIndex = 3;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 992);
            this.Controls.Add(this.Pnl_availableGenerators);
            this.Controls.Add(this.Pnl_quitPadding);
            this.Controls.Add(this.Lbl_title);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Pnl_quitPadding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.Panel Pnl_quitPadding;
        private System.Windows.Forms.Button Btn_quit;
        private System.Windows.Forms.Panel Pnl_availableGenerators;
    }
}