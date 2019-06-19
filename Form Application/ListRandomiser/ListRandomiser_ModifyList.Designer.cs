namespace FormApplication.ListRandomiser
{
    partial class ListRandomiser_ModifyList
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
            this.Pnl_backPadding = new System.Windows.Forms.Panel();
            this.Btn_done = new System.Windows.Forms.Button();
            this.Pnl_mainFunctions = new System.Windows.Forms.Panel();
            this.Splt_mainFunctions = new System.Windows.Forms.SplitContainer();
            this.Btn_addItem = new System.Windows.Forms.Button();
            this.Txt_newItem = new System.Windows.Forms.TextBox();
            this.Btn_loadList = new System.Windows.Forms.Button();
            this.CBo_loadList = new System.Windows.Forms.ComboBox();
            this.Pnl_currentList = new System.Windows.Forms.Panel();
            this.Txt_currentList = new System.Windows.Forms.TextBox();
            this.Lbl_currentListDescriptor = new System.Windows.Forms.Label();
            this.Pnl_listOptions = new System.Windows.Forms.Panel();
            this.Pnl_backPadding.SuspendLayout();
            this.Pnl_mainFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splt_mainFunctions)).BeginInit();
            this.Splt_mainFunctions.Panel1.SuspendLayout();
            this.Splt_mainFunctions.Panel2.SuspendLayout();
            this.Splt_mainFunctions.SuspendLayout();
            this.Pnl_currentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_title
            // 
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Padding = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.Lbl_title.Size = new System.Drawing.Size(830, 145);
            this.Lbl_title.TabIndex = 2;
            this.Lbl_title.Text = "List Randomiser";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_backPadding
            // 
            this.Pnl_backPadding.Controls.Add(this.Btn_done);
            this.Pnl_backPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_backPadding.Location = new System.Drawing.Point(0, 796);
            this.Pnl_backPadding.Margin = new System.Windows.Forms.Padding(6);
            this.Pnl_backPadding.Name = "Pnl_backPadding";
            this.Pnl_backPadding.Padding = new System.Windows.Forms.Padding(100, 48, 100, 48);
            this.Pnl_backPadding.Size = new System.Drawing.Size(830, 194);
            this.Pnl_backPadding.TabIndex = 3;
            // 
            // Btn_done
            // 
            this.Btn_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_done.Location = new System.Drawing.Point(100, 48);
            this.Btn_done.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_done.Name = "Btn_done";
            this.Btn_done.Size = new System.Drawing.Size(630, 98);
            this.Btn_done.TabIndex = 1;
            this.Btn_done.Text = "Done";
            this.Btn_done.UseVisualStyleBackColor = true;
            this.Btn_done.Click += new System.EventHandler(this.Btn_done_Click);
            // 
            // Pnl_mainFunctions
            // 
            this.Pnl_mainFunctions.Controls.Add(this.Splt_mainFunctions);
            this.Pnl_mainFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_mainFunctions.Location = new System.Drawing.Point(0, 660);
            this.Pnl_mainFunctions.Margin = new System.Windows.Forms.Padding(6);
            this.Pnl_mainFunctions.Name = "Pnl_mainFunctions";
            this.Pnl_mainFunctions.Padding = new System.Windows.Forms.Padding(50, 19, 50, 19);
            this.Pnl_mainFunctions.Size = new System.Drawing.Size(830, 136);
            this.Pnl_mainFunctions.TabIndex = 4;
            // 
            // Splt_mainFunctions
            // 
            this.Splt_mainFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splt_mainFunctions.Location = new System.Drawing.Point(50, 19);
            this.Splt_mainFunctions.Margin = new System.Windows.Forms.Padding(6);
            this.Splt_mainFunctions.Name = "Splt_mainFunctions";
            // 
            // Splt_mainFunctions.Panel1
            // 
            this.Splt_mainFunctions.Panel1.Controls.Add(this.Btn_addItem);
            this.Splt_mainFunctions.Panel1.Controls.Add(this.Txt_newItem);
            // 
            // Splt_mainFunctions.Panel2
            // 
            this.Splt_mainFunctions.Panel2.Controls.Add(this.Btn_loadList);
            this.Splt_mainFunctions.Panel2.Controls.Add(this.CBo_loadList);
            this.Splt_mainFunctions.Size = new System.Drawing.Size(730, 98);
            this.Splt_mainFunctions.SplitterDistance = 338;
            this.Splt_mainFunctions.SplitterWidth = 50;
            this.Splt_mainFunctions.TabIndex = 0;
            // 
            // Btn_addItem
            // 
            this.Btn_addItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_addItem.Enabled = false;
            this.Btn_addItem.Location = new System.Drawing.Point(0, 0);
            this.Btn_addItem.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_addItem.Name = "Btn_addItem";
            this.Btn_addItem.Size = new System.Drawing.Size(338, 60);
            this.Btn_addItem.TabIndex = 2;
            this.Btn_addItem.Text = "Add Item";
            this.Btn_addItem.UseVisualStyleBackColor = true;
            this.Btn_addItem.Click += new System.EventHandler(this.Btn_addItem_Click);
            // 
            // Txt_newItem
            // 
            this.Txt_newItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Txt_newItem.Location = new System.Drawing.Point(0, 60);
            this.Txt_newItem.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_newItem.Name = "Txt_newItem";
            this.Txt_newItem.Size = new System.Drawing.Size(338, 38);
            this.Txt_newItem.TabIndex = 0;
            this.Txt_newItem.TextChanged += new System.EventHandler(this.Txt_newItem_TextChanged);
            // 
            // Btn_loadList
            // 
            this.Btn_loadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_loadList.Enabled = false;
            this.Btn_loadList.Location = new System.Drawing.Point(0, 0);
            this.Btn_loadList.Margin = new System.Windows.Forms.Padding(6);
            this.Btn_loadList.Name = "Btn_loadList";
            this.Btn_loadList.Size = new System.Drawing.Size(342, 59);
            this.Btn_loadList.TabIndex = 1;
            this.Btn_loadList.Text = "Load List";
            this.Btn_loadList.UseVisualStyleBackColor = true;
            // 
            // CBo_loadList
            // 
            this.CBo_loadList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CBo_loadList.FormattingEnabled = true;
            this.CBo_loadList.Location = new System.Drawing.Point(0, 59);
            this.CBo_loadList.Margin = new System.Windows.Forms.Padding(6);
            this.CBo_loadList.Name = "CBo_loadList";
            this.CBo_loadList.Size = new System.Drawing.Size(342, 39);
            this.CBo_loadList.TabIndex = 0;
            // 
            // Pnl_currentList
            // 
            this.Pnl_currentList.Controls.Add(this.Txt_currentList);
            this.Pnl_currentList.Controls.Add(this.Lbl_currentListDescriptor);
            this.Pnl_currentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_currentList.Location = new System.Drawing.Point(0, 145);
            this.Pnl_currentList.Margin = new System.Windows.Forms.Padding(6);
            this.Pnl_currentList.Name = "Pnl_currentList";
            this.Pnl_currentList.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.Pnl_currentList.Size = new System.Drawing.Size(830, 48);
            this.Pnl_currentList.TabIndex = 5;
            // 
            // Txt_currentList
            // 
            this.Txt_currentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_currentList.Location = new System.Drawing.Point(230, 0);
            this.Txt_currentList.Margin = new System.Windows.Forms.Padding(6);
            this.Txt_currentList.Name = "Txt_currentList";
            this.Txt_currentList.Size = new System.Drawing.Size(550, 38);
            this.Txt_currentList.TabIndex = 1;
            this.Txt_currentList.TextChanged += new System.EventHandler(this.Txt_currentList_TextChanged);
            // 
            // Lbl_currentListDescriptor
            // 
            this.Lbl_currentListDescriptor.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_currentListDescriptor.Location = new System.Drawing.Point(50, 0);
            this.Lbl_currentListDescriptor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_currentListDescriptor.Name = "Lbl_currentListDescriptor";
            this.Lbl_currentListDescriptor.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.Lbl_currentListDescriptor.Size = new System.Drawing.Size(180, 48);
            this.Lbl_currentListDescriptor.TabIndex = 0;
            this.Lbl_currentListDescriptor.Text = "Current List:";
            // 
            // Pnl_listOptions
            // 
            this.Pnl_listOptions.AutoScroll = true;
            this.Pnl_listOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_listOptions.Location = new System.Drawing.Point(0, 193);
            this.Pnl_listOptions.Margin = new System.Windows.Forms.Padding(6);
            this.Pnl_listOptions.Name = "Pnl_listOptions";
            this.Pnl_listOptions.Padding = new System.Windows.Forms.Padding(50, 48, 50, 48);
            this.Pnl_listOptions.Size = new System.Drawing.Size(830, 467);
            this.Pnl_listOptions.TabIndex = 6;
            // 
            // ListRandomiser_ModifyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 990);
            this.Controls.Add(this.Pnl_listOptions);
            this.Controls.Add(this.Pnl_currentList);
            this.Controls.Add(this.Pnl_mainFunctions);
            this.Controls.Add(this.Pnl_backPadding);
            this.Controls.Add(this.Lbl_title);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ListRandomiser_ModifyList";
            this.Text = "List Randomiser";
            this.Pnl_backPadding.ResumeLayout(false);
            this.Pnl_mainFunctions.ResumeLayout(false);
            this.Splt_mainFunctions.Panel1.ResumeLayout(false);
            this.Splt_mainFunctions.Panel1.PerformLayout();
            this.Splt_mainFunctions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splt_mainFunctions)).EndInit();
            this.Splt_mainFunctions.ResumeLayout(false);
            this.Pnl_currentList.ResumeLayout(false);
            this.Pnl_currentList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.Panel Pnl_backPadding;
        private System.Windows.Forms.Button Btn_done;
        private System.Windows.Forms.Panel Pnl_mainFunctions;
        private System.Windows.Forms.SplitContainer Splt_mainFunctions;
        private System.Windows.Forms.TextBox Txt_newItem;
        private System.Windows.Forms.Button Btn_addItem;
        private System.Windows.Forms.Button Btn_loadList;
        private System.Windows.Forms.ComboBox CBo_loadList;
        private System.Windows.Forms.Panel Pnl_currentList;
        private System.Windows.Forms.TextBox Txt_currentList;
        private System.Windows.Forms.Label Lbl_currentListDescriptor;
        private System.Windows.Forms.Panel Pnl_listOptions;
    }
}