namespace FormApplication.ListRandomiser
{
    partial class ListRandomiser_AddTempList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRandomiser_AddTempList));
            this.Splt_buttons = new System.Windows.Forms.SplitContainer();
            this.Btn_addList = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Txt_listName = new System.Windows.Forms.TextBox();
            this.Lbl_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Splt_buttons)).BeginInit();
            this.Splt_buttons.Panel1.SuspendLayout();
            this.Splt_buttons.Panel2.SuspendLayout();
            this.Splt_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // Splt_buttons
            // 
            this.Splt_buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splt_buttons.Location = new System.Drawing.Point(20, 83);
            this.Splt_buttons.Name = "Splt_buttons";
            // 
            // Splt_buttons.Panel1
            // 
            this.Splt_buttons.Panel1.Controls.Add(this.Btn_addList);
            this.Splt_buttons.Panel1.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            // 
            // Splt_buttons.Panel2
            // 
            this.Splt_buttons.Panel2.Controls.Add(this.Btn_cancel);
            this.Splt_buttons.Panel2.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.Splt_buttons.Size = new System.Drawing.Size(342, 50);
            this.Splt_buttons.SplitterDistance = 167;
            this.Splt_buttons.SplitterWidth = 10;
            this.Splt_buttons.TabIndex = 0;
            // 
            // Btn_addList
            // 
            this.Btn_addList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_addList.Location = new System.Drawing.Point(0, 20);
            this.Btn_addList.Name = "Btn_addList";
            this.Btn_addList.Size = new System.Drawing.Size(147, 30);
            this.Btn_addList.TabIndex = 0;
            this.Btn_addList.Text = "Add List";
            this.Btn_addList.UseVisualStyleBackColor = true;
            this.Btn_addList.Click += new System.EventHandler(this.Btn_addList_Click);
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_cancel.Location = new System.Drawing.Point(20, 20);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(145, 30);
            this.Btn_cancel.TabIndex = 0;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Txt_listName
            // 
            this.Txt_listName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_listName.Location = new System.Drawing.Point(20, 61);
            this.Txt_listName.Name = "Txt_listName";
            this.Txt_listName.Size = new System.Drawing.Size(342, 22);
            this.Txt_listName.TabIndex = 1;
            // 
            // Lbl_title
            // 
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.Location = new System.Drawing.Point(20, 20);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Size = new System.Drawing.Size(342, 41);
            this.Lbl_title.TabIndex = 3;
            this.Lbl_title.Text = "Please choose a name for the list";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListRandomiser_AddTempList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.Lbl_title);
            this.Controls.Add(this.Txt_listName);
            this.Controls.Add(this.Splt_buttons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListRandomiser_AddTempList";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add List";
            this.Splt_buttons.Panel1.ResumeLayout(false);
            this.Splt_buttons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splt_buttons)).EndInit();
            this.Splt_buttons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer Splt_buttons;
        private System.Windows.Forms.Button Btn_addList;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.TextBox Txt_listName;
        private System.Windows.Forms.Label Lbl_title;
    }
}