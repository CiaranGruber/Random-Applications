namespace FormApplication.ListRandomiser
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
            this.Lbl_title = new System.Windows.Forms.Label();
            this.Pnl_backPadding = new System.Windows.Forms.Panel();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Pnl_main = new System.Windows.Forms.Panel();
            this.Splt_mainSplit = new System.Windows.Forms.SplitContainer();
            this.Splt_display = new System.Windows.Forms.SplitContainer();
            this.Btn_roll = new System.Windows.Forms.Button();
            this.Pnl_extraFunctions = new System.Windows.Forms.Panel();
            this.Splt_extraFunctions = new System.Windows.Forms.SplitContainer();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Btn_reroll = new System.Windows.Forms.Button();
            this.Pnl_generateFullList = new System.Windows.Forms.Panel();
            this.Btn_generateRandomisedList = new System.Windows.Forms.Button();
            this.Pnl_saveCurrentList = new System.Windows.Forms.Panel();
            this.Btn_saveCurrentList = new System.Windows.Forms.Button();
            this.Pnl_createList = new System.Windows.Forms.Panel();
            this.Btn_modifyList = new System.Windows.Forms.Button();
            this.Pnl_backPadding.SuspendLayout();
            this.Pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splt_mainSplit)).BeginInit();
            this.Splt_mainSplit.Panel1.SuspendLayout();
            this.Splt_mainSplit.Panel2.SuspendLayout();
            this.Splt_mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splt_display)).BeginInit();
            this.Splt_display.Panel1.SuspendLayout();
            this.Splt_display.SuspendLayout();
            this.Pnl_extraFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Splt_extraFunctions)).BeginInit();
            this.Splt_extraFunctions.Panel1.SuspendLayout();
            this.Splt_extraFunctions.Panel2.SuspendLayout();
            this.Splt_extraFunctions.SuspendLayout();
            this.Pnl_generateFullList.SuspendLayout();
            this.Pnl_saveCurrentList.SuspendLayout();
            this.Pnl_createList.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_title
            // 
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Padding = new System.Windows.Forms.Padding(25, 25, 25, 25);
            this.Lbl_title.Size = new System.Drawing.Size(782, 100);
            this.Lbl_title.TabIndex = 1;
            this.Lbl_title.Text = "List Randomiser";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_backPadding
            // 
            this.Pnl_backPadding.Controls.Add(this.Btn_back);
            this.Pnl_backPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_backPadding.Location = new System.Drawing.Point(0, 403);
            this.Pnl_backPadding.Name = "Pnl_backPadding";
            this.Pnl_backPadding.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.Pnl_backPadding.Size = new System.Drawing.Size(782, 100);
            this.Pnl_backPadding.TabIndex = 2;
            // 
            // Btn_back
            // 
            this.Btn_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.Location = new System.Drawing.Point(50, 25);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(682, 50);
            this.Btn_back.TabIndex = 1;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Pnl_main
            // 
            this.Pnl_main.Controls.Add(this.Splt_mainSplit);
            this.Pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_main.Location = new System.Drawing.Point(0, 100);
            this.Pnl_main.Name = "Pnl_main";
            this.Pnl_main.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.Pnl_main.Size = new System.Drawing.Size(782, 303);
            this.Pnl_main.TabIndex = 3;
            // 
            // Splt_mainSplit
            // 
            this.Splt_mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splt_mainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Splt_mainSplit.IsSplitterFixed = true;
            this.Splt_mainSplit.Location = new System.Drawing.Point(50, 25);
            this.Splt_mainSplit.Name = "Splt_mainSplit";
            // 
            // Splt_mainSplit.Panel1
            // 
            this.Splt_mainSplit.Panel1.Controls.Add(this.Splt_display);
            this.Splt_mainSplit.Panel1.Controls.Add(this.Pnl_extraFunctions);
            // 
            // Splt_mainSplit.Panel2
            // 
            this.Splt_mainSplit.Panel2.AutoScroll = true;
            this.Splt_mainSplit.Panel2.Controls.Add(this.Pnl_generateFullList);
            this.Splt_mainSplit.Panel2.Controls.Add(this.Pnl_saveCurrentList);
            this.Splt_mainSplit.Panel2.Controls.Add(this.Pnl_createList);
            this.Splt_mainSplit.Size = new System.Drawing.Size(682, 253);
            this.Splt_mainSplit.SplitterDistance = 308;
            this.Splt_mainSplit.SplitterWidth = 50;
            this.Splt_mainSplit.TabIndex = 0;
            // 
            // Splt_display
            // 
            this.Splt_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splt_display.IsSplitterFixed = true;
            this.Splt_display.Location = new System.Drawing.Point(0, 0);
            this.Splt_display.Name = "Splt_display";
            // 
            // Splt_display.Panel1
            // 
            this.Splt_display.Panel1.Controls.Add(this.Btn_roll);
            this.Splt_display.Size = new System.Drawing.Size(308, 153);
            this.Splt_display.SplitterDistance = 146;
            this.Splt_display.SplitterWidth = 25;
            this.Splt_display.TabIndex = 1;
            // 
            // Btn_roll
            // 
            this.Btn_roll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_roll.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_roll.Location = new System.Drawing.Point(0, 0);
            this.Btn_roll.Name = "Btn_roll";
            this.Btn_roll.Size = new System.Drawing.Size(146, 153);
            this.Btn_roll.TabIndex = 1;
            this.Btn_roll.Text = "Roll";
            this.Btn_roll.UseVisualStyleBackColor = true;
            this.Btn_roll.Click += new System.EventHandler(this.Btn_roll_Click);
            // 
            // Pnl_extraFunctions
            // 
            this.Pnl_extraFunctions.Controls.Add(this.Splt_extraFunctions);
            this.Pnl_extraFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_extraFunctions.Location = new System.Drawing.Point(0, 153);
            this.Pnl_extraFunctions.Name = "Pnl_extraFunctions";
            this.Pnl_extraFunctions.Size = new System.Drawing.Size(308, 100);
            this.Pnl_extraFunctions.TabIndex = 0;
            // 
            // Splt_extraFunctions
            // 
            this.Splt_extraFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Splt_extraFunctions.IsSplitterFixed = true;
            this.Splt_extraFunctions.Location = new System.Drawing.Point(0, 0);
            this.Splt_extraFunctions.Name = "Splt_extraFunctions";
            // 
            // Splt_extraFunctions.Panel1
            // 
            this.Splt_extraFunctions.Panel1.Controls.Add(this.Btn_clear);
            this.Splt_extraFunctions.Panel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            // 
            // Splt_extraFunctions.Panel2
            // 
            this.Splt_extraFunctions.Panel2.Controls.Add(this.Btn_reroll);
            this.Splt_extraFunctions.Panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.Splt_extraFunctions.Size = new System.Drawing.Size(308, 100);
            this.Splt_extraFunctions.SplitterDistance = 146;
            this.Splt_extraFunctions.SplitterWidth = 25;
            this.Splt_extraFunctions.TabIndex = 0;
            // 
            // Btn_clear
            // 
            this.Btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_clear.Font = new System.Drawing.Font("Monotxt_IV25", 7.8F);
            this.Btn_clear.Location = new System.Drawing.Point(0, 25);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(146, 50);
            this.Btn_clear.TabIndex = 0;
            this.Btn_clear.Text = "Clear Results";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Btn_reroll
            // 
            this.Btn_reroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_reroll.Font = new System.Drawing.Font("Monotxt_IV25", 7.8F);
            this.Btn_reroll.Location = new System.Drawing.Point(0, 25);
            this.Btn_reroll.Name = "Btn_reroll";
            this.Btn_reroll.Size = new System.Drawing.Size(137, 50);
            this.Btn_reroll.TabIndex = 1;
            this.Btn_reroll.Text = "Reroll";
            this.Btn_reroll.UseVisualStyleBackColor = true;
            // 
            // Pnl_generateFullList
            // 
            this.Pnl_generateFullList.Controls.Add(this.Btn_generateRandomisedList);
            this.Pnl_generateFullList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_generateFullList.Location = new System.Drawing.Point(0, 140);
            this.Pnl_generateFullList.Name = "Pnl_generateFullList";
            this.Pnl_generateFullList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pnl_generateFullList.Size = new System.Drawing.Size(324, 70);
            this.Pnl_generateFullList.TabIndex = 3;
            // 
            // Btn_generateRandomisedList
            // 
            this.Btn_generateRandomisedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_generateRandomisedList.Location = new System.Drawing.Point(0, 10);
            this.Btn_generateRandomisedList.Name = "Btn_generateRandomisedList";
            this.Btn_generateRandomisedList.Size = new System.Drawing.Size(324, 50);
            this.Btn_generateRandomisedList.TabIndex = 0;
            this.Btn_generateRandomisedList.Text = "Generate Full List";
            this.Btn_generateRandomisedList.UseVisualStyleBackColor = true;
            // 
            // Pnl_saveCurrentList
            // 
            this.Pnl_saveCurrentList.Controls.Add(this.Btn_saveCurrentList);
            this.Pnl_saveCurrentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_saveCurrentList.Location = new System.Drawing.Point(0, 70);
            this.Pnl_saveCurrentList.Name = "Pnl_saveCurrentList";
            this.Pnl_saveCurrentList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pnl_saveCurrentList.Size = new System.Drawing.Size(324, 70);
            this.Pnl_saveCurrentList.TabIndex = 2;
            // 
            // Btn_saveCurrentList
            // 
            this.Btn_saveCurrentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_saveCurrentList.Location = new System.Drawing.Point(0, 10);
            this.Btn_saveCurrentList.Name = "Btn_saveCurrentList";
            this.Btn_saveCurrentList.Size = new System.Drawing.Size(324, 50);
            this.Btn_saveCurrentList.TabIndex = 0;
            this.Btn_saveCurrentList.Text = "Save Current List";
            this.Btn_saveCurrentList.UseVisualStyleBackColor = true;
            // 
            // Pnl_createList
            // 
            this.Pnl_createList.Controls.Add(this.Btn_modifyList);
            this.Pnl_createList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_createList.Location = new System.Drawing.Point(0, 0);
            this.Pnl_createList.Name = "Pnl_createList";
            this.Pnl_createList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pnl_createList.Size = new System.Drawing.Size(324, 70);
            this.Pnl_createList.TabIndex = 0;
            // 
            // Btn_modifyList
            // 
            this.Btn_modifyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_modifyList.Location = new System.Drawing.Point(0, 10);
            this.Btn_modifyList.Name = "Btn_modifyList";
            this.Btn_modifyList.Size = new System.Drawing.Size(324, 50);
            this.Btn_modifyList.TabIndex = 0;
            this.Btn_modifyList.Text = "Modify List";
            this.Btn_modifyList.UseVisualStyleBackColor = true;
            this.Btn_modifyList.Click += new System.EventHandler(this.Btn_createList_Click);
            // 
            // ListRandomiserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.Pnl_main);
            this.Controls.Add(this.Pnl_backPadding);
            this.Controls.Add(this.Lbl_title);
            this.Name = "ListRandomiserMenu";
            this.Text = "List Randomiser";
            this.Pnl_backPadding.ResumeLayout(false);
            this.Pnl_main.ResumeLayout(false);
            this.Splt_mainSplit.Panel1.ResumeLayout(false);
            this.Splt_mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splt_mainSplit)).EndInit();
            this.Splt_mainSplit.ResumeLayout(false);
            this.Splt_display.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splt_display)).EndInit();
            this.Splt_display.ResumeLayout(false);
            this.Pnl_extraFunctions.ResumeLayout(false);
            this.Splt_extraFunctions.Panel1.ResumeLayout(false);
            this.Splt_extraFunctions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Splt_extraFunctions)).EndInit();
            this.Splt_extraFunctions.ResumeLayout(false);
            this.Pnl_generateFullList.ResumeLayout(false);
            this.Pnl_saveCurrentList.ResumeLayout(false);
            this.Pnl_createList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_title;
        private System.Windows.Forms.Panel Pnl_backPadding;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Panel Pnl_main;
        private System.Windows.Forms.SplitContainer Splt_mainSplit;
        private System.Windows.Forms.SplitContainer Splt_display;
        private System.Windows.Forms.Button Btn_roll;
        private System.Windows.Forms.Panel Pnl_extraFunctions;
        private System.Windows.Forms.SplitContainer Splt_extraFunctions;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.Button Btn_reroll;
        private System.Windows.Forms.Panel Pnl_createList;
        private System.Windows.Forms.Button Btn_modifyList;
        private System.Windows.Forms.Panel Pnl_saveCurrentList;
        private System.Windows.Forms.Button Btn_saveCurrentList;
        private System.Windows.Forms.Panel Pnl_generateFullList;
        private System.Windows.Forms.Button Btn_generateRandomisedList;
    }
}