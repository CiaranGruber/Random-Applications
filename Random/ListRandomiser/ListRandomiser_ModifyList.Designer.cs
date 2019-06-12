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
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_backPadding = new System.Windows.Forms.Panel();
            this.btn_done = new System.Windows.Forms.Button();
            this.pnl_mainFunctions = new System.Windows.Forms.Panel();
            this.splt_mainFunctions = new System.Windows.Forms.SplitContainer();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.txt_newItem = new System.Windows.Forms.TextBox();
            this.btn_loadList = new System.Windows.Forms.Button();
            this.cBo_loadList = new System.Windows.Forms.ComboBox();
            this.pnl_currentList = new System.Windows.Forms.Panel();
            this.txt_currentList = new System.Windows.Forms.TextBox();
            this.lbl_currentListDescriptor = new System.Windows.Forms.Label();
            this.pnl_listOptions = new System.Windows.Forms.Panel();
            this.pnl_backPadding.SuspendLayout();
            this.pnl_mainFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_mainFunctions)).BeginInit();
            this.splt_mainFunctions.Panel1.SuspendLayout();
            this.splt_mainFunctions.Panel2.SuspendLayout();
            this.splt_mainFunctions.SuspendLayout();
            this.pnl_currentList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_title.Size = new System.Drawing.Size(415, 75);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "List Randomiser";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_backPadding
            // 
            this.pnl_backPadding.Controls.Add(this.btn_done);
            this.pnl_backPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_backPadding.Location = new System.Drawing.Point(0, 411);
            this.pnl_backPadding.Name = "pnl_backPadding";
            this.pnl_backPadding.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.pnl_backPadding.Size = new System.Drawing.Size(415, 100);
            this.pnl_backPadding.TabIndex = 3;
            // 
            // btn_done
            // 
            this.btn_done.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Location = new System.Drawing.Point(50, 25);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(315, 50);
            this.btn_done.TabIndex = 1;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // pnl_mainFunctions
            // 
            this.pnl_mainFunctions.Controls.Add(this.splt_mainFunctions);
            this.pnl_mainFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_mainFunctions.Location = new System.Drawing.Point(0, 341);
            this.pnl_mainFunctions.Name = "pnl_mainFunctions";
            this.pnl_mainFunctions.Padding = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.pnl_mainFunctions.Size = new System.Drawing.Size(415, 70);
            this.pnl_mainFunctions.TabIndex = 4;
            // 
            // splt_mainFunctions
            // 
            this.splt_mainFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_mainFunctions.Location = new System.Drawing.Point(25, 10);
            this.splt_mainFunctions.Name = "splt_mainFunctions";
            // 
            // splt_mainFunctions.Panel1
            // 
            this.splt_mainFunctions.Panel1.Controls.Add(this.btn_addItem);
            this.splt_mainFunctions.Panel1.Controls.Add(this.txt_newItem);
            // 
            // splt_mainFunctions.Panel2
            // 
            this.splt_mainFunctions.Panel2.Controls.Add(this.btn_loadList);
            this.splt_mainFunctions.Panel2.Controls.Add(this.cBo_loadList);
            this.splt_mainFunctions.Size = new System.Drawing.Size(365, 50);
            this.splt_mainFunctions.SplitterDistance = 169;
            this.splt_mainFunctions.SplitterWidth = 25;
            this.splt_mainFunctions.TabIndex = 0;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_addItem.Enabled = false;
            this.btn_addItem.Location = new System.Drawing.Point(0, 0);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(169, 28);
            this.btn_addItem.TabIndex = 2;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // txt_newItem
            // 
            this.txt_newItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_newItem.Location = new System.Drawing.Point(0, 28);
            this.txt_newItem.Name = "txt_newItem";
            this.txt_newItem.Size = new System.Drawing.Size(169, 22);
            this.txt_newItem.TabIndex = 0;
            this.txt_newItem.TextChanged += new System.EventHandler(this.txt_newItem_TextChanged);
            // 
            // btn_loadList
            // 
            this.btn_loadList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_loadList.Enabled = false;
            this.btn_loadList.Location = new System.Drawing.Point(0, 0);
            this.btn_loadList.Name = "btn_loadList";
            this.btn_loadList.Size = new System.Drawing.Size(171, 26);
            this.btn_loadList.TabIndex = 1;
            this.btn_loadList.Text = "Load List";
            this.btn_loadList.UseVisualStyleBackColor = true;
            // 
            // cBo_loadList
            // 
            this.cBo_loadList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBo_loadList.FormattingEnabled = true;
            this.cBo_loadList.Location = new System.Drawing.Point(0, 26);
            this.cBo_loadList.Name = "cBo_loadList";
            this.cBo_loadList.Size = new System.Drawing.Size(171, 24);
            this.cBo_loadList.TabIndex = 0;
            // 
            // pnl_currentList
            // 
            this.pnl_currentList.Controls.Add(this.txt_currentList);
            this.pnl_currentList.Controls.Add(this.lbl_currentListDescriptor);
            this.pnl_currentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_currentList.Location = new System.Drawing.Point(0, 75);
            this.pnl_currentList.Name = "pnl_currentList";
            this.pnl_currentList.Padding = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.pnl_currentList.Size = new System.Drawing.Size(415, 25);
            this.pnl_currentList.TabIndex = 5;
            // 
            // txt_currentList
            // 
            this.txt_currentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_currentList.Location = new System.Drawing.Point(115, 0);
            this.txt_currentList.Name = "txt_currentList";
            this.txt_currentList.Size = new System.Drawing.Size(275, 22);
            this.txt_currentList.TabIndex = 1;
            this.txt_currentList.TextChanged += new System.EventHandler(this.txt_currentList_TextChanged);
            // 
            // lbl_currentListDescriptor
            // 
            this.lbl_currentListDescriptor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_currentListDescriptor.Location = new System.Drawing.Point(25, 0);
            this.lbl_currentListDescriptor.Name = "lbl_currentListDescriptor";
            this.lbl_currentListDescriptor.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lbl_currentListDescriptor.Size = new System.Drawing.Size(90, 25);
            this.lbl_currentListDescriptor.TabIndex = 0;
            this.lbl_currentListDescriptor.Text = "Current List:";
            // 
            // pnl_listOptions
            // 
            this.pnl_listOptions.AutoScroll = true;
            this.pnl_listOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_listOptions.Location = new System.Drawing.Point(0, 100);
            this.pnl_listOptions.Name = "pnl_listOptions";
            this.pnl_listOptions.Padding = new System.Windows.Forms.Padding(25);
            this.pnl_listOptions.Size = new System.Drawing.Size(415, 241);
            this.pnl_listOptions.TabIndex = 6;
            // 
            // ListRandomiser_ModifyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 511);
            this.Controls.Add(this.pnl_listOptions);
            this.Controls.Add(this.pnl_currentList);
            this.Controls.Add(this.pnl_mainFunctions);
            this.Controls.Add(this.pnl_backPadding);
            this.Controls.Add(this.lbl_title);
            this.Name = "ListRandomiser_ModifyList";
            this.Text = "List Randomiser";
            this.pnl_backPadding.ResumeLayout(false);
            this.pnl_mainFunctions.ResumeLayout(false);
            this.splt_mainFunctions.Panel1.ResumeLayout(false);
            this.splt_mainFunctions.Panel1.PerformLayout();
            this.splt_mainFunctions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_mainFunctions)).EndInit();
            this.splt_mainFunctions.ResumeLayout(false);
            this.pnl_currentList.ResumeLayout(false);
            this.pnl_currentList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_backPadding;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Panel pnl_mainFunctions;
        private System.Windows.Forms.SplitContainer splt_mainFunctions;
        private System.Windows.Forms.TextBox txt_newItem;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.Button btn_loadList;
        private System.Windows.Forms.ComboBox cBo_loadList;
        private System.Windows.Forms.Panel pnl_currentList;
        private System.Windows.Forms.TextBox txt_currentList;
        private System.Windows.Forms.Label lbl_currentListDescriptor;
        private System.Windows.Forms.Panel pnl_listOptions;
    }
}