namespace Random.ListRandomiser
{
    partial class ListRandomiserMenu
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
            this.pnl_backPadding = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_backPadding.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(25);
            this.lbl_title.Size = new System.Drawing.Size(482, 100);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "List Randomiser";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_backPadding
            // 
            this.pnl_backPadding.Controls.Add(this.btn_back);
            this.pnl_backPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_backPadding.Location = new System.Drawing.Point(0, 361);
            this.pnl_backPadding.Name = "pnl_backPadding";
            this.pnl_backPadding.Padding = new System.Windows.Forms.Padding(25);
            this.pnl_backPadding.Size = new System.Drawing.Size(482, 100);
            this.pnl_backPadding.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 261);
            this.panel2.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(25, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(432, 50);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // ListRandomiserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_backPadding);
            this.Controls.Add(this.lbl_title);
            this.Name = "ListRandomiserMenu";
            this.Text = "List Randomiser";
            this.Load += new System.EventHandler(this.ListRandomiserMenu_Load);
            this.pnl_backPadding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_backPadding;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_back;
    }
}