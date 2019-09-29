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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRandomiserMenu));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_RollSettings = new System.Windows.Forms.Button();
            this.Pnl_generateFullList = new System.Windows.Forms.Panel();
            this.Btn_generateRandomisedList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_resetList = new System.Windows.Forms.Button();
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
            this.panel2.SuspendLayout();
            this.Pnl_generateFullList.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Pnl_saveCurrentList.SuspendLayout();
            this.Pnl_createList.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_title
            // 
            this.Lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_title.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_title.Location = new System.Drawing.Point(0, 0);
            this.Lbl_title.Name = "Lbl_title";
            this.Lbl_title.Padding = new System.Windows.Forms.Padding(25);
            this.Lbl_title.Size = new System.Drawing.Size(782, 100);
            this.Lbl_title.TabIndex = 1;
            this.Lbl_title.Text = "List Randomiser";
            this.Lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_backPadding
            // 
            this.Pnl_backPadding.Controls.Add(this.Btn_back);
            this.Pnl_backPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_backPadding.Location = new System.Drawing.Point(0, 433);
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
            this.Btn_back.TabIndex = 8;
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
            this.Pnl_main.Size = new System.Drawing.Size(782, 333);
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
            this.Splt_mainSplit.Panel2.Controls.Add(this.panel2);
            this.Splt_mainSplit.Panel2.Controls.Add(this.Pnl_generateFullList);
            this.Splt_mainSplit.Panel2.Controls.Add(this.panel1);
            this.Splt_mainSplit.Panel2.Controls.Add(this.Pnl_saveCurrentList);
            this.Splt_mainSplit.Panel2.Controls.Add(this.Pnl_createList);
            this.Splt_mainSplit.Size = new System.Drawing.Size(682, 283);
            this.Splt_mainSplit.SplitterDistance = 354;
            this.Splt_mainSplit.SplitterWidth = 50;
            this.Splt_mainSplit.TabIndex = 0;
            this.Splt_mainSplit.TabStop = false;
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
            this.Splt_display.Size = new System.Drawing.Size(354, 183);
            this.Splt_display.SplitterDistance = 167;
            this.Splt_display.SplitterWidth = 25;
            this.Splt_display.TabIndex = 1;
            // 
            // Btn_roll
            // 
            this.Btn_roll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_roll.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_roll.Location = new System.Drawing.Point(0, 0);
            this.Btn_roll.Name = "Btn_roll";
            this.Btn_roll.Size = new System.Drawing.Size(167, 183);
            this.Btn_roll.TabIndex = 0;
            this.Btn_roll.Text = "Roll";
            this.Btn_roll.UseVisualStyleBackColor = true;
            this.Btn_roll.Click += new System.EventHandler(this.Btn_roll_Click);
            // 
            // Pnl_extraFunctions
            // 
            this.Pnl_extraFunctions.Controls.Add(this.Splt_extraFunctions);
            this.Pnl_extraFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_extraFunctions.Location = new System.Drawing.Point(0, 183);
            this.Pnl_extraFunctions.Name = "Pnl_extraFunctions";
            this.Pnl_extraFunctions.Size = new System.Drawing.Size(354, 100);
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
            this.Splt_extraFunctions.Size = new System.Drawing.Size(354, 100);
            this.Splt_extraFunctions.SplitterDistance = 167;
            this.Splt_extraFunctions.SplitterWidth = 25;
            this.Splt_extraFunctions.TabIndex = 0;
            // 
            // Btn_clear
            // 
            this.Btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_clear.Font = new System.Drawing.Font("Monotxt_IV25", 7.8F);
            this.Btn_clear.Location = new System.Drawing.Point(0, 25);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(167, 50);
            this.Btn_clear.TabIndex = 1;
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
            this.Btn_reroll.Size = new System.Drawing.Size(162, 50);
            this.Btn_reroll.TabIndex = 2;
            this.Btn_reroll.Text = "Reroll";
            this.Btn_reroll.UseVisualStyleBackColor = true;
            this.Btn_reroll.Click += new System.EventHandler(this.Btn_reroll_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_RollSettings);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 280);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel2.Size = new System.Drawing.Size(257, 70);
            this.panel2.TabIndex = 6;
            // 
            // Btn_RollSettings
            // 
            this.Btn_RollSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_RollSettings.Location = new System.Drawing.Point(0, 10);
            this.Btn_RollSettings.Name = "Btn_RollSettings";
            this.Btn_RollSettings.Size = new System.Drawing.Size(257, 50);
            this.Btn_RollSettings.TabIndex = 7;
            this.Btn_RollSettings.Text = "Roll Settings";
            this.Btn_RollSettings.UseVisualStyleBackColor = true;
            this.Btn_RollSettings.Click += new System.EventHandler(this.Btn_RollSettings_Click);
            // 
            // Pnl_generateFullList
            // 
            this.Pnl_generateFullList.Controls.Add(this.Btn_generateRandomisedList);
            this.Pnl_generateFullList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_generateFullList.Location = new System.Drawing.Point(0, 210);
            this.Pnl_generateFullList.Name = "Pnl_generateFullList";
            this.Pnl_generateFullList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pnl_generateFullList.Size = new System.Drawing.Size(257, 70);
            this.Pnl_generateFullList.TabIndex = 5;
            // 
            // Btn_generateRandomisedList
            // 
            this.Btn_generateRandomisedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_generateRandomisedList.Location = new System.Drawing.Point(0, 10);
            this.Btn_generateRandomisedList.Name = "Btn_generateRandomisedList";
            this.Btn_generateRandomisedList.Size = new System.Drawing.Size(257, 50);
            this.Btn_generateRandomisedList.TabIndex = 6;
            this.Btn_generateRandomisedList.Text = "Generate Full List";
            this.Btn_generateRandomisedList.UseVisualStyleBackColor = true;
            this.Btn_generateRandomisedList.Click += new System.EventHandler(this.Btn_generateRandomisedList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_resetList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(257, 70);
            this.panel1.TabIndex = 4;
            // 
            // Btn_resetList
            // 
            this.Btn_resetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_resetList.Location = new System.Drawing.Point(0, 10);
            this.Btn_resetList.Name = "Btn_resetList";
            this.Btn_resetList.Size = new System.Drawing.Size(257, 50);
            this.Btn_resetList.TabIndex = 5;
            this.Btn_resetList.Text = "Reset List";
            this.Btn_resetList.UseVisualStyleBackColor = true;
            this.Btn_resetList.Click += new System.EventHandler(this.Btn_resetList_Click);
            // 
            // Pnl_saveCurrentList
            // 
            this.Pnl_saveCurrentList.Controls.Add(this.Btn_saveCurrentList);
            this.Pnl_saveCurrentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_saveCurrentList.Location = new System.Drawing.Point(0, 70);
            this.Pnl_saveCurrentList.Name = "Pnl_saveCurrentList";
            this.Pnl_saveCurrentList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pnl_saveCurrentList.Size = new System.Drawing.Size(257, 70);
            this.Pnl_saveCurrentList.TabIndex = 2;
            // 
            // Btn_saveCurrentList
            // 
            this.Btn_saveCurrentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_saveCurrentList.Location = new System.Drawing.Point(0, 10);
            this.Btn_saveCurrentList.Name = "Btn_saveCurrentList";
            this.Btn_saveCurrentList.Size = new System.Drawing.Size(257, 50);
            this.Btn_saveCurrentList.TabIndex = 4;
            this.Btn_saveCurrentList.Text = "Save Current List";
            this.Btn_saveCurrentList.UseVisualStyleBackColor = true;
            this.Btn_saveCurrentList.Click += new System.EventHandler(this.Btn_saveCurrentList_Click);
            // 
            // Pnl_createList
            // 
            this.Pnl_createList.Controls.Add(this.Btn_modifyList);
            this.Pnl_createList.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_createList.Location = new System.Drawing.Point(0, 0);
            this.Pnl_createList.Name = "Pnl_createList";
            this.Pnl_createList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Pnl_createList.Size = new System.Drawing.Size(257, 70);
            this.Pnl_createList.TabIndex = 0;
            // 
            // Btn_modifyList
            // 
            this.Btn_modifyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_modifyList.Location = new System.Drawing.Point(0, 10);
            this.Btn_modifyList.Name = "Btn_modifyList";
            this.Btn_modifyList.Size = new System.Drawing.Size(257, 50);
            this.Btn_modifyList.TabIndex = 3;
            this.Btn_modifyList.Text = "Modify List";
            this.Btn_modifyList.UseVisualStyleBackColor = true;
            this.Btn_modifyList.Click += new System.EventHandler(this.Btn_createList_Click);
            // 
            // ListRandomiserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.Pnl_main);
            this.Controls.Add(this.Pnl_backPadding);
            this.Controls.Add(this.Lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListRandomiserMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
            this.panel2.ResumeLayout(false);
            this.Pnl_generateFullList.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_resetList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_RollSettings;
    }
}