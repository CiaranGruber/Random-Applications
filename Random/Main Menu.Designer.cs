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
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_quitPadding = new System.Windows.Forms.Panel();
            this.pnl_availableGenerators = new System.Windows.Forms.Panel();
            this.btn_quit = new System.Windows.Forms.Button();
            this.pnl_quitPadding.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(25);
            this.lbl_title.Size = new System.Drawing.Size(560, 100);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Random Generators";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_quitPadding
            // 
            this.pnl_quitPadding.Controls.Add(this.btn_quit);
            this.pnl_quitPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_quitPadding.Location = new System.Drawing.Point(0, 412);
            this.pnl_quitPadding.Name = "pnl_quitPadding";
            this.pnl_quitPadding.Padding = new System.Windows.Forms.Padding(25);
            this.pnl_quitPadding.Size = new System.Drawing.Size(560, 100);
            this.pnl_quitPadding.TabIndex = 2;
            // 
            // pnl_availableGenerators
            // 
            this.pnl_availableGenerators.AutoScroll = true;
            this.pnl_availableGenerators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_availableGenerators.Location = new System.Drawing.Point(0, 100);
            this.pnl_availableGenerators.Name = "pnl_availableGenerators";
            this.pnl_availableGenerators.Padding = new System.Windows.Forms.Padding(25);
            this.pnl_availableGenerators.Size = new System.Drawing.Size(560, 312);
            this.pnl_availableGenerators.TabIndex = 3;
            // 
            // btn_quit
            // 
            this.btn_quit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(25, 25);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(510, 50);
            this.btn_quit.TabIndex = 0;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 512);
            this.Controls.Add(this.pnl_availableGenerators);
            this.Controls.Add(this.pnl_quitPadding);
            this.Controls.Add(this.lbl_title);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.pnl_quitPadding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_quitPadding;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Panel pnl_availableGenerators;
    }
}