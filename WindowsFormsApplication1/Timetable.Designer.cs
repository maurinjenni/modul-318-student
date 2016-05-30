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
            this.listConnectionSearch = new System.Windows.Forms.ListView();
            this.clmStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDeparture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPlatformStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPlatformDestination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabConnectionBoard = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDepartureStation = new System.Windows.Forms.Label();
            this.txtDepartureSearch = new System.Windows.Forms.ComboBox();
            this.cmdSearchTable = new System.Windows.Forms.Button();
            this.listDepartureSearch = new System.Windows.Forms.ListView();
            this.clmStartTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDestinationTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDepartureTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearchConnection)).BeginInit();
            this.splitContainerSearchConnection.Panel1.SuspendLayout();
            this.splitContainerSearchConnection.Panel2.SuspendLayout();
            this.splitContainerSearchConnection.SuspendLayout();
            this.tabConnectionBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStartSearch
            // 
            this.lblStartSearch.AutoSize = true;
            this.lblStartSearch.Location = new System.Drawing.Point(10, 10);
            this.lblStartSearch.Name = "lblStartSearch";
            this.lblStartSearch.Size = new System.Drawing.Size(30, 13);
            this.lblStartSearch.TabIndex = 3;
            this.lblStartSearch.Text = "From";
            // 
            // lblDestinationSearch
            // 
            this.lblDestinationSearch.AutoSize = true;
            this.lblDestinationSearch.Location = new System.Drawing.Point(10, 66);
            this.lblDestinationSearch.Name = "lblDestinationSearch";
            this.lblDestinationSearch.Size = new System.Drawing.Size(20, 13);
            this.lblDestinationSearch.TabIndex = 4;
            this.lblDestinationSearch.Text = "To";
            // 
            // txtStartSearch
            // 
            this.txtStartSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartSearch.FormattingEnabled = true;
            this.txtStartSearch.Location = new System.Drawing.Point(13, 26);
            this.txtStartSearch.Name = "txtStartSearch";
            this.txtStartSearch.Size = new System.Drawing.Size(209, 21);
            this.txtStartSearch.TabIndex = 5;
            this.txtStartSearch.DropDown += new System.EventHandler(this.txtStartSearch_DropDown);
            this.txtStartSearch.TextUpdate += new System.EventHandler(this.txtStartSearch_TextUpdate);
            // 
            // txtDestinationSearch
            // 
            this.txtDestinationSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationSearch.FormattingEnabled = true;
            this.txtDestinationSearch.Location = new System.Drawing.Point(13, 82);
            this.txtDestinationSearch.Name = "txtDestinationSearch";
            this.txtDestinationSearch.Size = new System.Drawing.Size(209, 21);
            this.txtDestinationSearch.TabIndex = 6;
            this.txtDestinationSearch.DropDown += new System.EventHandler(this.txtDestinationSearch_DropDown);
            this.txtDestinationSearch.TextUpdate += new System.EventHandler(this.txtDestinationSearch_TextUpdate);
            // 
            // cmdSearchConnection
            // 
            this.cmdSearchConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearchConnection.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdSearchConnection.Location = new System.Drawing.Point(13, 127);
            this.cmdSearchConnection.Name = "cmdSearchConnection";
            this.cmdSearchConnection.Size = new System.Drawing.Size(209, 21);
            this.cmdSearchConnection.TabIndex = 9;
            this.cmdSearchConnection.Text = "Search Connection";
            this.cmdSearchConnection.UseVisualStyleBackColor = false;
            this.cmdSearchConnection.Click += new System.EventHandler(this.cmdSearchConnection_Click);
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
            this.tabControl.Size = new System.Drawing.Size(780, 373);
            this.tabControl.TabIndex = 10;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.splitContainerSearchConnection);
            this.tabConnection.Location = new System.Drawing.Point(4, 22);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(772, 347);
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
            // 
            // splitContainerSearchConnection.Panel2
            // 
            this.splitContainerSearchConnection.Panel2.Controls.Add(this.listConnectionSearch);
            this.splitContainerSearchConnection.Panel2MinSize = 300;
            this.splitContainerSearchConnection.Size = new System.Drawing.Size(766, 341);
            this.splitContainerSearchConnection.SplitterDistance = 236;
            this.splitContainerSearchConnection.TabIndex = 10;
            // 
            // listConnectionSearch
            // 
            this.listConnectionSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStart,
            this.clmDeparture,
            this.clmPlatformStart,
            this.clmDestination,
            this.clmArrival,
            this.clmPlatformDestination,
            this.clmDuration});
            this.listConnectionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listConnectionSearch.Location = new System.Drawing.Point(0, 0);
            this.listConnectionSearch.Name = "listConnectionSearch";
            this.listConnectionSearch.Size = new System.Drawing.Size(524, 339);
            this.listConnectionSearch.TabIndex = 0;
            this.listConnectionSearch.UseCompatibleStateImageBehavior = false;
            this.listConnectionSearch.View = System.Windows.Forms.View.Details;
            // 
            // clmStart
            // 
            this.clmStart.Text = "Start";
            this.clmStart.Width = 110;
            // 
            // clmDeparture
            // 
            this.clmDeparture.Text = "Departure";
            // 
            // clmPlatformStart
            // 
            this.clmPlatformStart.Text = "Platform";
            // 
            // clmDestination
            // 
            this.clmDestination.Text = "Destination";
            this.clmDestination.Width = 110;
            // 
            // clmArrival
            // 
            this.clmArrival.Text = "Arrival";
            // 
            // clmPlatformDestination
            // 
            this.clmPlatformDestination.Text = "Platform";
            // 
            // clmDuration
            // 
            this.clmDuration.Text = "Duration";
            // 
            // tabConnectionBoard
            // 
            this.tabConnectionBoard.Controls.Add(this.splitContainer1);
            this.tabConnectionBoard.Location = new System.Drawing.Point(4, 22);
            this.tabConnectionBoard.Name = "tabConnectionBoard";
            this.tabConnectionBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnectionBoard.Size = new System.Drawing.Size(772, 347);
            this.tabConnectionBoard.TabIndex = 1;
            this.tabConnectionBoard.Text = "Departure Board";
            this.tabConnectionBoard.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblDepartureStation);
            this.splitContainer1.Panel1.Controls.Add(this.txtDepartureSearch);
            this.splitContainer1.Panel1.Controls.Add(this.cmdSearchTable);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listDepartureSearch);
            this.splitContainer1.Panel2MinSize = 300;
            this.splitContainer1.Size = new System.Drawing.Size(766, 341);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 11;
            // 
            // lblDepartureStation
            // 
            this.lblDepartureStation.AutoSize = true;
            this.lblDepartureStation.Location = new System.Drawing.Point(10, 10);
            this.lblDepartureStation.Name = "lblDepartureStation";
            this.lblDepartureStation.Size = new System.Drawing.Size(90, 13);
            this.lblDepartureStation.TabIndex = 3;
            this.lblDepartureStation.Text = "Departure Station";
            // 
            // txtDepartureSearch
            // 
            this.txtDepartureSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartureSearch.FormattingEnabled = true;
            this.txtDepartureSearch.Location = new System.Drawing.Point(13, 26);
            this.txtDepartureSearch.Name = "txtDepartureSearch";
            this.txtDepartureSearch.Size = new System.Drawing.Size(209, 21);
            this.txtDepartureSearch.TabIndex = 5;
            this.txtDepartureSearch.DropDown += new System.EventHandler(this.txtDepartureSearch_DropDown);
            this.txtDepartureSearch.TextUpdate += new System.EventHandler(this.txtDepartureSearch_TextUpdate);
            // 
            // cmdSearchTable
            // 
            this.cmdSearchTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSearchTable.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdSearchTable.Location = new System.Drawing.Point(13, 62);
            this.cmdSearchTable.Name = "cmdSearchTable";
            this.cmdSearchTable.Size = new System.Drawing.Size(209, 21);
            this.cmdSearchTable.TabIndex = 9;
            this.cmdSearchTable.Text = "Search Departure";
            this.cmdSearchTable.UseVisualStyleBackColor = false;
            this.cmdSearchTable.Click += new System.EventHandler(this.cmdSearchTable_Click);
            // 
            // listDepartureSearch
            // 
            this.listDepartureSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmStartTable,
            this.clmDepartureTable,
            this.clmDestinationTable,
            this.clmType});
            this.listDepartureSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDepartureSearch.Location = new System.Drawing.Point(0, 0);
            this.listDepartureSearch.Name = "listDepartureSearch";
            this.listDepartureSearch.Size = new System.Drawing.Size(524, 339);
            this.listDepartureSearch.TabIndex = 0;
            this.listDepartureSearch.UseCompatibleStateImageBehavior = false;
            this.listDepartureSearch.View = System.Windows.Forms.View.Details;
            // 
            // clmStartTable
            // 
            this.clmStartTable.Text = "Start";
            this.clmStartTable.Width = 140;
            // 
            // clmDestinationTable
            // 
            this.clmDestinationTable.Text = "Destination";
            this.clmDestinationTable.Width = 140;
            // 
            // clmDepartureTable
            // 
            this.clmDepartureTable.Text = "Departure";
            // 
            // clmType
            // 
            this.clmType.Text = "Type";
            this.clmType.Width = 80;
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 373);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(788, 800);
            this.MinimumSize = new System.Drawing.Size(788, 400);
            this.Name = "Timetable";
            this.Text = "Timetable";
            this.tabControl.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.splitContainerSearchConnection.Panel1.ResumeLayout(false);
            this.splitContainerSearchConnection.Panel1.PerformLayout();
            this.splitContainerSearchConnection.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearchConnection)).EndInit();
            this.splitContainerSearchConnection.ResumeLayout(false);
            this.tabConnectionBoard.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.ListView listConnectionSearch;
        private System.Windows.Forms.ColumnHeader clmDeparture;
        private System.Windows.Forms.ColumnHeader clmArrival;
        private System.Windows.Forms.ColumnHeader clmDuration;
        private System.Windows.Forms.ColumnHeader clmStart;
        private System.Windows.Forms.ColumnHeader clmDestination;
        private System.Windows.Forms.ColumnHeader clmPlatformStart;
        private System.Windows.Forms.ColumnHeader clmPlatformDestination;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblDepartureStation;
        private System.Windows.Forms.ComboBox txtDepartureSearch;
        private System.Windows.Forms.Button cmdSearchTable;
        private System.Windows.Forms.ListView listDepartureSearch;
        private System.Windows.Forms.ColumnHeader clmStartTable;
        private System.Windows.Forms.ColumnHeader clmDestinationTable;
        private System.Windows.Forms.ColumnHeader clmDepartureTable;
        private System.Windows.Forms.ColumnHeader clmType;
    }
}

