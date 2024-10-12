
namespace WaypointCreatorGen2
{
    partial class WaypointCreator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            TabControl = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox3 = new System.Windows.Forms.GroupBox();
            RemoveDuplicatesButton = new System.Windows.Forms.Button();
            SplineGridView = new System.Windows.Forms.DataGridView();
            SplineGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SplineGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SplineGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SplineGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SplineGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(components);
            CutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            CopyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PasteAboveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            PasteBelowStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            GenerateSQLStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            EditorGridView = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            EditorListBox = new System.Windows.Forms.ListBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            EditorWaypointChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            EditorToolStrip = new System.Windows.Forms.ToolStrip();
            EditorImportSniffButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            EditorFilterEntryTextBox = new System.Windows.Forms.ToolStripTextBox();
            EditorFilterEntryButton = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            EditorLoadingLabel = new System.Windows.Forms.ToolStripLabel();
            tabPage2 = new System.Windows.Forms.TabPage();
            SQLOutputTextBox = new System.Windows.Forms.TextBox();
            SQLOutputToolStrip = new System.Windows.Forms.ToolStrip();
            SQLOutputSaveButton = new System.Windows.Forms.ToolStripButton();
            ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PositionX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PositionY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PositionZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Orientation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MoveTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PointIdx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SplineGridView).BeginInit();
            GridViewContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditorGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditorWaypointChart).BeginInit();
            EditorToolStrip.SuspendLayout();
            tabPage2.SuspendLayout();
            SQLOutputToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabPage1);
            TabControl.Controls.Add(tabPage2);
            TabControl.Location = new System.Drawing.Point(20, 23);
            TabControl.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new System.Drawing.Size(2183, 1083);
            TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(EditorToolStrip);
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tabPage1.Size = new System.Drawing.Size(2175, 1045);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Editor";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(RemoveDuplicatesButton);
            groupBox3.Controls.Add(SplineGridView);
            groupBox3.Controls.Add(EditorGridView);
            groupBox3.Location = new System.Drawing.Point(1210, 60);
            groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox3.Size = new System.Drawing.Size(950, 962);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Data Table";
            // 
            // RemoveDuplicatesButton
            // 
            RemoveDuplicatesButton.Location = new System.Drawing.Point(737, 492);
            RemoveDuplicatesButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            RemoveDuplicatesButton.Name = "RemoveDuplicatesButton";
            RemoveDuplicatesButton.Size = new System.Drawing.Size(197, 46);
            RemoveDuplicatesButton.TabIndex = 2;
            RemoveDuplicatesButton.Text = "Remove Duplicates";
            RemoveDuplicatesButton.UseVisualStyleBackColor = true;
            RemoveDuplicatesButton.Click += RemoveDuplicatesButton_Click;
            // 
            // SplineGridView
            // 
            SplineGridView.AllowUserToAddRows = false;
            SplineGridView.AllowUserToDeleteRows = false;
            SplineGridView.AllowUserToResizeColumns = false;
            SplineGridView.AllowUserToResizeRows = false;
            SplineGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            SplineGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            SplineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SplineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { SplineGridViewTextBoxColumn1, SplineGridViewTextBoxColumn2, SplineGridViewTextBoxColumn3, SplineGridViewTextBoxColumn4, SplineGridViewTextBoxColumn5 });
            SplineGridView.ContextMenuStrip = GridViewContextMenuStrip;
            SplineGridView.Location = new System.Drawing.Point(12, 550);
            SplineGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            SplineGridView.Name = "SplineGridView";
            SplineGridView.RowHeadersWidth = 62;
            SplineGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SplineGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            SplineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            SplineGridView.Size = new System.Drawing.Size(922, 385);
            SplineGridView.TabIndex = 1;
            // 
            // SplineGridViewTextBoxColumn1
            // 
            SplineGridViewTextBoxColumn1.HeaderText = "PointID";
            SplineGridViewTextBoxColumn1.MinimumWidth = 8;
            SplineGridViewTextBoxColumn1.Name = "SplineGridViewTextBoxColumn1";
            SplineGridViewTextBoxColumn1.ReadOnly = true;
            SplineGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            SplineGridViewTextBoxColumn1.Width = 50;
            // 
            // SplineGridViewTextBoxColumn2
            // 
            SplineGridViewTextBoxColumn2.HeaderText = "SplinePointIndex";
            SplineGridViewTextBoxColumn2.MinimumWidth = 8;
            SplineGridViewTextBoxColumn2.Name = "SplineGridViewTextBoxColumn2";
            SplineGridViewTextBoxColumn2.ReadOnly = true;
            SplineGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            SplineGridViewTextBoxColumn2.Width = 150;
            // 
            // SplineGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle1.NullValue = "0.0";
            SplineGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            SplineGridViewTextBoxColumn3.HeaderText = "PositionX";
            SplineGridViewTextBoxColumn3.MinimumWidth = 8;
            SplineGridViewTextBoxColumn3.Name = "SplineGridViewTextBoxColumn3";
            SplineGridViewTextBoxColumn3.ReadOnly = true;
            SplineGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            SplineGridViewTextBoxColumn3.Width = 80;
            // 
            // SplineGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle2.NullValue = null;
            SplineGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            SplineGridViewTextBoxColumn4.HeaderText = "PositionY";
            SplineGridViewTextBoxColumn4.MinimumWidth = 8;
            SplineGridViewTextBoxColumn4.Name = "SplineGridViewTextBoxColumn4";
            SplineGridViewTextBoxColumn4.ReadOnly = true;
            SplineGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            SplineGridViewTextBoxColumn4.Width = 80;
            // 
            // SplineGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle3.NullValue = null;
            SplineGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            SplineGridViewTextBoxColumn5.HeaderText = "PositionZ";
            SplineGridViewTextBoxColumn5.MinimumWidth = 8;
            SplineGridViewTextBoxColumn5.Name = "SplineGridViewTextBoxColumn5";
            SplineGridViewTextBoxColumn5.ReadOnly = true;
            SplineGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            SplineGridViewTextBoxColumn5.Width = 80;
            // 
            // GridViewContextMenuStrip
            // 
            GridViewContextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            GridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { CutStripMenuItem, CopyStripMenuItem, PasteAboveStripMenuItem, PasteBelowStripMenuItem, GenerateSQLStripMenuItem });
            GridViewContextMenuStrip.Name = "GridViewContextMenuStrip";
            GridViewContextMenuStrip.Size = new System.Drawing.Size(192, 164);
            // 
            // CutStripMenuItem
            // 
            CutStripMenuItem.Name = "CutStripMenuItem";
            CutStripMenuItem.Size = new System.Drawing.Size(191, 32);
            CutStripMenuItem.Text = "Cut";
            CutStripMenuItem.Click += CutStripMenuItem_Click;
            // 
            // CopyStripMenuItem
            // 
            CopyStripMenuItem.Name = "CopyStripMenuItem";
            CopyStripMenuItem.Size = new System.Drawing.Size(191, 32);
            CopyStripMenuItem.Text = "Copy";
            CopyStripMenuItem.Click += CopyStripMenuItem_Click;
            // 
            // PasteAboveStripMenuItem
            // 
            PasteAboveStripMenuItem.Name = "PasteAboveStripMenuItem";
            PasteAboveStripMenuItem.Size = new System.Drawing.Size(191, 32);
            PasteAboveStripMenuItem.Text = "Paste Above";
            PasteAboveStripMenuItem.Click += PasteAboveStripMenuItem_Click;
            // 
            // PasteBelowStripMenuItem
            // 
            PasteBelowStripMenuItem.Name = "PasteBelowStripMenuItem";
            PasteBelowStripMenuItem.Size = new System.Drawing.Size(191, 32);
            PasteBelowStripMenuItem.Text = "Paste Below";
            PasteBelowStripMenuItem.Click += PasteBelowStripMenuItem_Click;
            // 
            // GenerateSQLStripMenuItem
            // 
            GenerateSQLStripMenuItem.Name = "GenerateSQLStripMenuItem";
            GenerateSQLStripMenuItem.Size = new System.Drawing.Size(191, 32);
            GenerateSQLStripMenuItem.Text = "Generate SQL";
            GenerateSQLStripMenuItem.Click += GenerateSQLStripMenuItem_Click;
            // 
            // EditorGridView
            // 
            EditorGridView.AllowUserToAddRows = false;
            EditorGridView.AllowUserToDeleteRows = false;
            EditorGridView.AllowUserToResizeColumns = false;
            EditorGridView.AllowUserToResizeRows = false;
            EditorGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            EditorGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            EditorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EditorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID, PositionX, PositionY, PositionZ, Orientation, MoveTime, Delay, PointIdx });
            EditorGridView.ContextMenuStrip = GridViewContextMenuStrip;
            EditorGridView.Location = new System.Drawing.Point(12, 27);
            EditorGridView.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            EditorGridView.Name = "EditorGridView";
            EditorGridView.RowHeadersWidth = 62;
            EditorGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            EditorGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            EditorGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            EditorGridView.Size = new System.Drawing.Size(922, 454);
            EditorGridView.TabIndex = 0;
            EditorGridView.RowsRemoved += EditorGridView_RowsRemoved;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(EditorListBox);
            groupBox2.Location = new System.Drawing.Point(855, 60);
            groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox2.Size = new System.Drawing.Size(345, 962);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Found Entries";
            // 
            // EditorListBox
            // 
            EditorListBox.FormattingEnabled = true;
            EditorListBox.ItemHeight = 25;
            EditorListBox.Location = new System.Drawing.Point(12, 27);
            EditorListBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            EditorListBox.Name = "EditorListBox";
            EditorListBox.Size = new System.Drawing.Size(321, 904);
            EditorListBox.TabIndex = 0;
            EditorListBox.SelectedValueChanged += EditorListBox_SelectedValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(EditorWaypointChart);
            groupBox1.Location = new System.Drawing.Point(25, 60);
            groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            groupBox1.Size = new System.Drawing.Size(820, 962);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waypoint Visualization";
            // 
            // EditorWaypointChart
            // 
            EditorWaypointChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LabelStyle.IsEndLabelVisible = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.None;
            chartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.ScrollBar.ButtonColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.MinorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.CursorX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            EditorWaypointChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            EditorWaypointChart.Legends.Add(legend1);
            EditorWaypointChart.Location = new System.Drawing.Point(10, 27);
            EditorWaypointChart.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            EditorWaypointChart.Name = "EditorWaypointChart";
            EditorWaypointChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Path";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Line";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            EditorWaypointChart.Series.Add(series1);
            EditorWaypointChart.Series.Add(series2);
            EditorWaypointChart.Size = new System.Drawing.Size(800, 923);
            EditorWaypointChart.TabIndex = 1;
            EditorWaypointChart.Text = "chart1";
            // 
            // EditorToolStrip
            // 
            EditorToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            EditorToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { EditorImportSniffButton, toolStripSeparator1, EditorFilterEntryTextBox, EditorFilterEntryButton, toolStripSeparator2, EditorLoadingLabel });
            EditorToolStrip.Location = new System.Drawing.Point(5, 6);
            EditorToolStrip.Name = "EditorToolStrip";
            EditorToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            EditorToolStrip.Size = new System.Drawing.Size(2165, 34);
            EditorToolStrip.TabIndex = 0;
            EditorToolStrip.Text = "toolStrip1";
            // 
            // EditorImportSniffButton
            // 
            EditorImportSniffButton.Image = Properties.Resources.PIC_Import;
            EditorImportSniffButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            EditorImportSniffButton.Name = "EditorImportSniffButton";
            EditorImportSniffButton.Size = new System.Drawing.Size(193, 29);
            EditorImportSniffButton.Text = "Import Parsed Sniff";
            EditorImportSniffButton.ToolTipText = "Loads a parsed sniff .txt file and generates waypoint data from it. You can obtain such .txt files by parsing .pkt sniff files with the WoW Packet Parser of TrinityCore.";
            EditorImportSniffButton.Click += EditorImportSniffButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // EditorFilterEntryTextBox
            // 
            EditorFilterEntryTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            EditorFilterEntryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            EditorFilterEntryTextBox.Name = "EditorFilterEntryTextBox";
            EditorFilterEntryTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            EditorFilterEntryTextBox.Size = new System.Drawing.Size(165, 34);
            // 
            // EditorFilterEntryButton
            // 
            EditorFilterEntryButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            EditorFilterEntryButton.Image = Properties.Resources.PIC_Search;
            EditorFilterEntryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            EditorFilterEntryButton.Name = "EditorFilterEntryButton";
            EditorFilterEntryButton.Size = new System.Drawing.Size(135, 29);
            EditorFilterEntryButton.Text = "Filter Entries";
            EditorFilterEntryButton.ToolTipText = "Filters the listed GUID values by CreatureID. If no or an invalid value is specified it will list all entries.";
            EditorFilterEntryButton.Click += EditorFilterEntryButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // EditorLoadingLabel
            // 
            EditorLoadingLabel.Name = "EditorLoadingLabel";
            EditorLoadingLabel.Size = new System.Drawing.Size(167, 29);
            EditorLoadingLabel.Text = "No sniff file loaded.";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(SQLOutputTextBox);
            tabPage2.Controls.Add(SQLOutputToolStrip);
            tabPage2.Location = new System.Drawing.Point(4, 34);
            tabPage2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tabPage2.Size = new System.Drawing.Size(2175, 1045);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SQL Output";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // SQLOutputTextBox
            // 
            SQLOutputTextBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            SQLOutputTextBox.Location = new System.Drawing.Point(10, 60);
            SQLOutputTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            SQLOutputTextBox.Multiline = true;
            SQLOutputTextBox.Name = "SQLOutputTextBox";
            SQLOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            SQLOutputTextBox.Size = new System.Drawing.Size(2142, 958);
            SQLOutputTextBox.TabIndex = 1;
            // 
            // SQLOutputToolStrip
            // 
            SQLOutputToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            SQLOutputToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { SQLOutputSaveButton });
            SQLOutputToolStrip.Location = new System.Drawing.Point(5, 6);
            SQLOutputToolStrip.Name = "SQLOutputToolStrip";
            SQLOutputToolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            SQLOutputToolStrip.Size = new System.Drawing.Size(2165, 34);
            SQLOutputToolStrip.TabIndex = 0;
            SQLOutputToolStrip.Text = "toolStrip1";
            // 
            // SQLOutputSaveButton
            // 
            SQLOutputSaveButton.Image = Properties.Resources.PIC_Write;
            SQLOutputSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            SQLOutputSaveButton.Name = "SQLOutputSaveButton";
            SQLOutputSaveButton.Size = new System.Drawing.Size(167, 29);
            SQLOutputSaveButton.Text = "Save as SQL File";
            SQLOutputSaveButton.Click += SQLOutputSaveButton_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            ID.Width = 50;
            // 
            // PositionX
            // 
            dataGridViewCellStyle4.NullValue = "0.0";
            PositionX.DefaultCellStyle = dataGridViewCellStyle4;
            PositionX.HeaderText = "PositionX";
            PositionX.MinimumWidth = 8;
            PositionX.Name = "PositionX";
            PositionX.ReadOnly = true;
            PositionX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            PositionX.Width = 80;
            // 
            // PositionY
            // 
            dataGridViewCellStyle5.NullValue = null;
            PositionY.DefaultCellStyle = dataGridViewCellStyle5;
            PositionY.HeaderText = "PositionY";
            PositionY.MinimumWidth = 8;
            PositionY.Name = "PositionY";
            PositionY.ReadOnly = true;
            PositionY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            PositionY.Width = 80;
            // 
            // PositionZ
            // 
            dataGridViewCellStyle6.NullValue = null;
            PositionZ.DefaultCellStyle = dataGridViewCellStyle6;
            PositionZ.HeaderText = "PositionZ";
            PositionZ.MinimumWidth = 8;
            PositionZ.Name = "PositionZ";
            PositionZ.ReadOnly = true;
            PositionZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            PositionZ.Width = 80;
            // 
            // Orientation
            // 
            dataGridViewCellStyle7.NullValue = null;
            Orientation.DefaultCellStyle = dataGridViewCellStyle7;
            Orientation.HeaderText = "Orientation";
            Orientation.MinimumWidth = 8;
            Orientation.Name = "Orientation";
            Orientation.ReadOnly = true;
            Orientation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Orientation.Width = 80;
            // 
            // MoveTime
            // 
            MoveTime.HeaderText = "MoveTime";
            MoveTime.MinimumWidth = 8;
            MoveTime.Name = "MoveTime";
            MoveTime.ReadOnly = true;
            MoveTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            MoveTime.Width = 80;
            // 
            // Delay
            // 
            Delay.HeaderText = "Delay";
            Delay.MinimumWidth = 8;
            Delay.Name = "Delay";
            Delay.ReadOnly = true;
            Delay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            Delay.Width = 80;
            // 
            // PointIdx
            // 
            PointIdx.HeaderText = "PointIdx";
            PointIdx.MinimumWidth = 8;
            PointIdx.Name = "PointIdx";
            PointIdx.ReadOnly = true;
            PointIdx.Visible = false;
            PointIdx.Width = 150;
            // 
            // WaypointCreator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2223, 1127);
            Controls.Add(TabControl);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "WaypointCreator";
            Text = "Waypoint Creator Gen2";
            Load += WaypointCreator_Load;
            TabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SplineGridView).EndInit();
            GridViewContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditorGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditorWaypointChart).EndInit();
            EditorToolStrip.ResumeLayout(false);
            EditorToolStrip.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            SQLOutputToolStrip.ResumeLayout(false);
            SQLOutputToolStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip SQLOutputToolStrip;
        private System.Windows.Forms.ToolStripButton SQLOutputSaveButton;
        private System.Windows.Forms.TextBox SQLOutputTextBox;
        private System.Windows.Forms.ToolStrip EditorToolStrip;
        private System.Windows.Forms.ToolStripButton EditorImportSniffButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart EditorWaypointChart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripTextBox EditorFilterEntryTextBox;
        private System.Windows.Forms.ToolStripButton EditorFilterEntryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ListBox EditorListBox;
        private System.Windows.Forms.DataGridView EditorGridView;
        private System.Windows.Forms.ToolStripLabel EditorLoadingLabel;
        private System.Windows.Forms.ContextMenuStrip GridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CutStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteAboveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteBelowStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenerateSQLStripMenuItem;
        private System.Windows.Forms.DataGridView SplineGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplineGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplineGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplineGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplineGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplineGridViewTextBoxColumn5;
        private System.Windows.Forms.Button RemoveDuplicatesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orientation;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoveTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointIdx;
    }
}

