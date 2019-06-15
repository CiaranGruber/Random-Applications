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
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_backPadding = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.splt_mainSplit = new System.Windows.Forms.SplitContainer();
            this.splt_display = new System.Windows.Forms.SplitContainer();
            this.btn_roll = new System.Windows.Forms.Button();
            this.pnl_extraFunctions = new System.Windows.Forms.Panel();
            this.splt_extraFunctions = new System.Windows.Forms.SplitContainer();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_reroll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_generateRandomisedList = new System.Windows.Forms.Button();
            this.pnl_saveCurrentList = new System.Windows.Forms.Panel();
            this.btn_saveCurrentList = new System.Windows.Forms.Button();
            this.pnl_createList = new System.Windows.Forms.Panel();
            this.btn_modifyList = new System.Windows.Forms.Button();
            this.pnl_backPadding.SuspendLayout();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_mainSplit)).BeginInit();
            this.splt_mainSplit.Panel1.SuspendLayout();
            this.splt_mainSplit.Panel2.SuspendLayout();
            this.splt_mainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_display)).BeginInit();
            this.splt_display.Panel1.SuspendLayout();
            this.splt_display.SuspendLayout();
            this.pnl_extraFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splt_extraFunctions)).BeginInit();
            this.splt_extraFunctions.Panel1.SuspendLayout();
            this.splt_extraFunctions.Panel2.SuspendLayout();
            this.splt_extraFunctions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_saveCurrentList.SuspendLayout();
            this.pnl_createList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Monotxt_IV25", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(25);
            this.lbl_title.Size = new System.Drawing.Size(782, 100);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "List Randomiser";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_backPadding
            // 
            this.pnl_backPadding.Controls.Add(this.btn_back);
            this.pnl_backPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_backPadding.Location = new System.Drawing.Point(0, 403);
            this.pnl_backPadding.Name = "pnl_backPadding";
            this.pnl_backPadding.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.pnl_backPadding.Size = new System.Drawing.Size(782, 100);
            this.pnl_backPadding.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(50, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(682, 50);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.splt_mainSplit);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 100);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Padding = new System.Windows.Forms.Padding(50, 25, 50, 25);
            this.pnl_main.Size = new System.Drawing.Size(782, 303);
            this.pnl_main.TabIndex = 3;
            // 
            // splt_mainSplit
            // 
            this.splt_mainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_mainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splt_mainSplit.IsSplitterFixed = true;
            this.splt_mainSplit.Location = new System.Drawing.Point(50, 25);
            this.splt_mainSplit.Name = "splt_mainSplit";
            // 
            // splt_mainSplit.Panel1
            // 
            this.splt_mainSplit.Panel1.Controls.Add(this.splt_display);
            this.splt_mainSplit.Panel1.Controls.Add(this.pnl_extraFunctions);
            // 
            // splt_mainSplit.Panel2
            // 
            this.splt_mainSplit.Panel2.AutoScroll = true;
            this.splt_mainSplit.Panel2.Controls.Add(this.panel1);
            this.splt_mainSplit.Panel2.Controls.Add(this.pnl_saveCurrentList);
            this.splt_mainSplit.Panel2.Controls.Add(this.pnl_createList);
            this.splt_mainSplit.Size = new System.Drawing.Size(682, 253);
            this.splt_mainSplit.SplitterDistance = 450;
            this.splt_mainSplit.SplitterWidth = 50;
            this.splt_mainSplit.TabIndex = 0;
            // 
            // splt_display
            // 
            this.splt_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_display.IsSplitterFixed = true;
            this.splt_display.Location = new System.Drawing.Point(0, 0);
            this.splt_display.Name = "splt_display";
            // 
            // splt_display.Panel1
            // 
            this.splt_display.Panel1.Controls.Add(this.btn_roll);
            this.splt_display.Size = new System.Drawing.Size(450, 153);
            this.splt_display.SplitterDistance = 214;
            this.splt_display.SplitterWidth = 25;
            this.splt_display.TabIndex = 1;
            // 
            // btn_roll
            // 
            this.btn_roll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_roll.Font = new System.Drawing.Font("Monotxt_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roll.Location = new System.Drawing.Point(0, 0);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(214, 153);
            this.btn_roll.TabIndex = 1;
            this.btn_roll.Text = "Roll";
            this.btn_roll.UseVisualStyleBackColor = true;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // pnl_extraFunctions
            // 
            this.pnl_extraFunctions.Controls.Add(this.splt_extraFunctions);
            this.pnl_extraFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_extraFunctions.Location = new System.Drawing.Point(0, 153);
            this.pnl_extraFunctions.Name = "pnl_extraFunctions";
            this.pnl_extraFunctions.Size = new System.Drawing.Size(450, 100);
            this.pnl_extraFunctions.TabIndex = 0;
            // 
            // splt_extraFunctions
            // 
            this.splt_extraFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt_extraFunctions.IsSplitterFixed = true;
            this.splt_extraFunctions.Location = new System.Drawing.Point(0, 0);
            this.splt_extraFunctions.Name = "splt_extraFunctions";
            // 
            // splt_extraFunctions.Panel1
            // 
            this.splt_extraFunctions.Panel1.Controls.Add(this.btn_clear);
            this.splt_extraFunctions.Panel1.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            // 
            // splt_extraFunctions.Panel2
            // 
            this.splt_extraFunctions.Panel2.Controls.Add(this.btn_reroll);
            this.splt_extraFunctions.Panel2.Padding = new System.Windows.Forms.Padding(0, 25, 0, 25);
            this.splt_extraFunctions.Size = new System.Drawing.Size(450, 100);
            this.splt_extraFunctions.SplitterDistance = 214;
            this.splt_extraFunctions.SplitterWidth = 25;
            this.splt_extraFunctions.TabIndex = 0;
            // 
            // btn_clear
            // 
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_clear.Font = new System.Drawing.Font("Monotxt_IV25", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(0, 25);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(214, 50);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear Results";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_reroll
            // 
            this.btn_reroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reroll.Font = new System.Drawing.Font("Monotxt_IV25", 7.8F);
            this.btn_reroll.Location = new System.Drawing.Point(0, 25);
            this.btn_reroll.Name = "btn_reroll";
            this.btn_reroll.Size = new System.Drawing.Size(211, 50);
            this.btn_reroll.TabIndex = 1;
            this.btn_reroll.Text = "Reroll";
            this.btn_reroll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_generateRandomisedList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 140);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(182, 70);
            this.panel1.TabIndex = 3;
            // 
            // btn_generateRandomisedList
            // 
            this.btn_generateRandomisedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_generateRandomisedList.Location = new System.Drawing.Point(0, 10);
            this.btn_generateRandomisedList.Name = "btn_generateRandomisedList";
            this.btn_generateRandomisedList.Size = new System.Drawing.Size(182, 50);
            this.btn_generateRandomisedList.TabIndex = 0;
            this.btn_generateRandomisedList.Text = "Generate Full List";
            this.btn_generateRandomisedList.UseVisualStyleBackColor = true;
            // 
            // pnl_saveCurrentList
            // 
            this.pnl_saveCurrentList.Controls.Add(this.btn_saveCurrentList);
            this.pnl_saveCurrentList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_saveCurrentList.Location = new System.Drawing.Point(0, 70);
            this.pnl_saveCurrentList.Name = "pnl_saveCurrentList";
            this.pnl_saveCurrentList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnl_saveCurrentList.Size = new System.Drawing.Size(182, 70);
            this.pnl_saveCurrentList.TabIndex = 2;
            // 
            // btn_saveCurrentList
            // 
            this.btn_saveCurrentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_saveCurrentList.Location = new System.Drawing.Point(0, 10);
            this.btn_saveCurrentList.Name = "btn_saveCurrentList";
            this.btn_saveCurrentList.Size = new System.Drawing.Size(182, 50);
            this.btn_saveCurrentList.TabIndex = 0;
            this.btn_saveCurrentList.Text = "Save Current List";
            this.btn_saveCurrentList.UseVisualStyleBackColor = true;
            // 
            // pnl_createList
            // 
            this.pnl_createList.Controls.Add(this.btn_modifyList);
            this.pnl_createList.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_createList.Location = new System.Drawing.Point(0, 0);
            this.pnl_createList.Name = "pnl_createList";
            this.pnl_createList.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnl_createList.Size = new System.Drawing.Size(182, 70);
            this.pnl_createList.TabIndex = 0;
            // 
            // btn_modifyList
            // 
            this.btn_modifyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_modifyList.Location = new System.Drawing.Point(0, 10);
            this.btn_modifyList.Name = "btn_modifyList";
            this.btn_modifyList.Size = new System.Drawing.Size(182, 50);
            this.btn_modifyList.TabIndex = 0;
            this.btn_modifyList.Text = "Modify List";
            this.btn_modifyList.UseVisualStyleBackColor = true;
            this.btn_modifyList.Click += new System.EventHandler(this.btn_createList_Click);
            // 
            // ListRandomiserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.pnl_backPadding);
            this.Controls.Add(this.lbl_title);
            this.Name = "ListRandomiserMenu";
            this.Text = "List Randomiser";
            this.pnl_backPadding.ResumeLayout(false);
            this.pnl_main.ResumeLayout(false);
            this.splt_mainSplit.Panel1.ResumeLayout(false);
            this.splt_mainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_mainSplit)).EndInit();
            this.splt_mainSplit.ResumeLayout(false);
            this.splt_display.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_display)).EndInit();
            this.splt_display.ResumeLayout(false);
            this.pnl_extraFunctions.ResumeLayout(false);
            this.splt_extraFunctions.Panel1.ResumeLayout(false);
            this.splt_extraFunctions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splt_extraFunctions)).EndInit();
            this.splt_extraFunctions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_saveCurrentList.ResumeLayout(false);
            this.pnl_createList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_backPadding;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.SplitContainer splt_mainSplit;
        private System.Windows.Forms.SplitContainer splt_display;
        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Panel pnl_extraFunctions;
        private System.Windows.Forms.SplitContainer splt_extraFunctions;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_reroll;
        private System.Windows.Forms.Panel pnl_createList;
        private System.Windows.Forms.Button btn_modifyList;
        private System.Windows.Forms.Panel pnl_saveCurrentList;
        private System.Windows.Forms.Button btn_saveCurrentList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_generateRandomisedList;
    }
}