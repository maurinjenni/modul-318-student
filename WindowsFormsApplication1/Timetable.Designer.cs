namespace WindowsFormsApplication1
{
    partial class Timetable
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
            this.lblStartSearch = new System.Windows.Forms.Label();
            this.lblDestinationSearch = new System.Windows.Forms.Label();
            this.txtStartSearch = new System.Windows.Forms.ComboBox();
            this.txtDestinationSearch = new System.Windows.Forms.ComboBox();
            this.cmdSearchConnection = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.splitContainerSearchConnection = new System.Windows.Forms.SplitContainer();
            this.tabConnectionBoard = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearchConnection)).BeginInit();
            this.splitContainerSearchConnection.Panel1.SuspendLayout();
            this.splitContainerSearchConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartSearch
            // 
            this.lblStartSearch.AutoSize = true;
            this.lblStartSearch.Location = new System.Drawing.Point(10, 10);
            this.lblStartSearch.Name = "lblStartSearch";
            this.lblStartSearch.Size = new System.Drawing.Size(29, 13);
            this.lblStartSearch.TabIndex = 3;
            this.lblStartSearch.Text = "Start";
            // 
            // lblDestinationSearch
            // 
            this.lblDestinationSearch.AutoSize = true;
            this.lblDestinationSearch.Location = new System.Drawing.Point(10, 66);
            this.lblDestinationSearch.Name = "lblDestinationSearch";
            this.lblDestinationSearch.Size = new System.Drawing.Size(60, 13);
            this.lblDestinationSearch.TabIndex = 4;
            this.lblDestinationSearch.Text = "Destination";
            // 
            // txtStartSearch
            // 
            this.txtStartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartSearch.FormattingEnabled = true;
            this.txtStartSearch.Location = new System.Drawing.Point(13, 26);
            this.txtStartSearch.Name = "txtStartSearch";
            this.txtStartSearch.Size = new System.Drawing.Size(246, 21);
            this.txtStartSearch.TabIndex = 5;
            this.txtStartSearch.TextUpdate += new System.EventHandler(this.txtStartSearch_TextUpdate);
            // 
            // txtDestinationSearch
            // 
            this.txtDestinationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationSearch.FormattingEnabled = true;
            this.txtDestinationSearch.Location = new System.Drawing.Point(13, 82);
            this.txtDestinationSearch.Name = "txtDestinationSearch";
            this.txtDestinationSearch.Size = new System.Drawing.Size(246, 21);
            this.txtDestinationSearch.TabIndex = 6;
            this.txtDestinationSearch.TextUpdate += new System.EventHandler(this.txtDestinationSearch_TextUpdate);
            // 
            // cmdSearchConnection
            // 
            this.cmdSearchConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearchConnection.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdSearchConnection.Location = new System.Drawing.Point(13, 127);
            this.cmdSearchConnection.Name = "cmdSearchConnection";
            this.cmdSearchConnection.Size = new System.Drawing.Size(246, 21);
            this.cmdSearchConnection.TabIndex = 9;
            this.cmdSearchConnection.Text = "Search Connection";
            this.cmdSearchConnection.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConnection);
            this.tabControl.Controls.Add(this.tabConnectionBoard);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(592, 373);
            this.tabControl.TabIndex = 10;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.splitContainerSearchConnection);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(584, 347);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Search Connection";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // splitContainerSearchConnection
            // 
            this.splitContainerSearchConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerSearchConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSearchConnection.Location = new System.Drawing.Point(3, 3);
            this.splitContainerSearchConnection.Name = "splitContainerSearchConnection";
            // 
            // splitContainerSearchConnection.Panel1
            // 
            this.splitContainerSearchConnection.Panel1.Controls.Add(this.lblStartSearch);
            this.splitContainerSearchConnection.Panel1.Controls.Add(this.txtStartSearch);
            this.splitContainerSearchConnection.Panel1.Controls.Add(this.cmdSearchConnection);
            this.splitContainerSearchConnection.Panel1.Controls.Add(this.lblDestinationSearch);
            this.splitContainerSearchConnection.Panel1.Controls.Add(this.txtDestinationSearch);
            this.splitContainerSearchConnection.Panel1MinSize = 200;
            this.splitContainerSearchConnection.Panel2MinSize = 300;
            this.splitContainerSearchConnection.Size = new System.Drawing.Size(578, 341);
            this.splitContainerSearchConnection.SplitterDistance = 273;
            this.splitContainerSearchConnection.TabIndex = 10;
            // 
            // tabConnectionBoard
            // 
            this.tabConnectionBoard.Location = new System.Drawing.Point(4, 22);
            this.tabConnectionBoard.Name = "tabConnectionBoard";
            this.tabConnectionBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnectionBoard.Size = new System.Drawing.Size(584, 347);
            this.tabConnectionBoard.TabIndex = 1;
            this.tabConnectionBoard.Text = "Connectionboard";
            this.tabConnectionBoard.UseVisualStyleBackColor = true;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 373);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Timetable";
            this.Text = "Timetable";
            this.tabControl.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.splitContainerSearchConnection.Panel1.ResumeLayout(false);
            this.splitContainerSearchConnection.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearchConnection)).EndInit();
            this.splitContainerSearchConnection.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblStartSearch;
        private System.Windows.Forms.Label lblDestinationSearch;
        private System.Windows.Forms.ComboBox txtStartSearch;
        private System.Windows.Forms.ComboBox txtDestinationSearch;
        private System.Windows.Forms.Button cmdSearchConnection;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.SplitContainer splitContainerSearchConnection;
        private System.Windows.Forms.TabPage tabConnectionBoard;
    }
}

