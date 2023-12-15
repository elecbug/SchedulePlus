namespace Scheduler.MainFunc
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainSplitContainer = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            TodoListBox = new CheckedListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            AddButton = new Button();
            RemoveButton = new Button();
            SortButton = new Button();
            TableLayout = new TableLayoutPanel();
            DescryptTextBox = new RichTextBox();
            TodoDatePicker = new DateTimePicker();
            TitleTextBox = new RichTextBox();
            DDayTaskButton = new CheckBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            TodoCancelButton = new Button();
            TodoSaveButton = new Button();
            DefaultMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            settingToolStripMenuItem = new ToolStripMenuItem();
            FontToolStripMenuItem = new ToolStripMenuItem();
            TopMostToolStripMenuItem = new ToolStripMenuItem();
            ExportToolStripMenuItem = new ToolStripMenuItem();
            ExportAESFileToolStripMenuItem = new ToolStripMenuItem();
            MainTabControl = new TabControl();
            TabPage1 = new TabPage();
            MainTreeView = new TreeView();
            TabPage2 = new TabPage();
            TabPage3 = new TabPage();
            MemoSplitter = new SplitContainer();
            DrawingPanel = new Panel();
            MemoTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            TableLayout.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            DefaultMenuStrip.SuspendLayout();
            MainTabControl.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemoSplitter).BeginInit();
            MemoSplitter.Panel1.SuspendLayout();
            MemoSplitter.Panel2.SuspendLayout();
            MemoSplitter.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(2, 2);
            MainSplitContainer.Margin = new Padding(2);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(TableLayout);
            MainSplitContainer.Size = new Size(985, 567);
            MainSplitContainer.SplitterDistance = 249;
            MainSplitContainer.SplitterWidth = 3;
            MainSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(TodoListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(249, 567);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TodoListBox
            // 
            TodoListBox.Dock = DockStyle.Fill;
            TodoListBox.FormattingEnabled = true;
            TodoListBox.Location = new Point(2, 2);
            TodoListBox.Margin = new Padding(2);
            TodoListBox.Name = "TodoListBox";
            TodoListBox.Size = new Size(245, 533);
            TodoListBox.TabIndex = 0;
            TodoListBox.ItemCheck += TodoListBox_ItemCheck;
            TodoListBox.SelectedIndexChanged += TodoListBox_SelectedIndexChanged;
            TodoListBox.Format += TodoListBox_Format;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Controls.Add(SortButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 539);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(245, 26);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(2, 2);
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(77, 22);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += TodoAddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(83, 2);
            RemoveButton.Margin = new Padding(2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(77, 22);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += TodoRemoveButton_Click;
            // 
            // SortButton
            // 
            SortButton.Dock = DockStyle.Fill;
            SortButton.Location = new Point(164, 2);
            SortButton.Margin = new Padding(2);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(79, 22);
            SortButton.TabIndex = 2;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += TodoSortButton_Click;
            // 
            // TableLayout
            // 
            TableLayout.ColumnCount = 1;
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayout.Controls.Add(DescryptTextBox, 0, 2);
            TableLayout.Controls.Add(TodoDatePicker, 0, 0);
            TableLayout.Controls.Add(TitleTextBox, 0, 1);
            TableLayout.Controls.Add(DDayTaskButton, 0, 3);
            TableLayout.Controls.Add(tableLayoutPanel3, 0, 4);
            TableLayout.Dock = DockStyle.Fill;
            TableLayout.Location = new Point(0, 0);
            TableLayout.Margin = new Padding(2);
            TableLayout.Name = "TableLayout";
            TableLayout.RowCount = 5;
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            TableLayout.Size = new Size(733, 567);
            TableLayout.TabIndex = 1;
            // 
            // DescryptTextBox
            // 
            DescryptTextBox.Dock = DockStyle.Fill;
            DescryptTextBox.Location = new Point(2, 67);
            DescryptTextBox.Margin = new Padding(2);
            DescryptTextBox.Name = "DescryptTextBox";
            DescryptTextBox.Size = new Size(729, 438);
            DescryptTextBox.TabIndex = 3;
            DescryptTextBox.Text = "";
            DescryptTextBox.TextChanged += Todo_Editted;
            // 
            // TodoDatePicker
            // 
            TodoDatePicker.CalendarForeColor = SystemColors.ControlLightLight;
            TodoDatePicker.CalendarMonthBackground = Color.FromArgb(64, 64, 64);
            TodoDatePicker.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            TodoDatePicker.CalendarTitleForeColor = SystemColors.ControlLightLight;
            TodoDatePicker.Dock = DockStyle.Fill;
            TodoDatePicker.Location = new Point(2, 2);
            TodoDatePicker.Margin = new Padding(2);
            TodoDatePicker.Name = "TodoDatePicker";
            TodoDatePicker.Size = new Size(729, 23);
            TodoDatePicker.TabIndex = 0;
            TodoDatePicker.ValueChanged += Todo_Editted;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Dock = DockStyle.Fill;
            TitleTextBox.ImeMode = ImeMode.NoControl;
            TitleTextBox.Location = new Point(2, 27);
            TitleTextBox.Margin = new Padding(2);
            TitleTextBox.Multiline = false;
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(729, 36);
            TitleTextBox.TabIndex = 2;
            TitleTextBox.Text = "";
            TitleTextBox.TextChanged += Todo_Editted;
            // 
            // DDayTaskButton
            // 
            DDayTaskButton.AutoSize = true;
            DDayTaskButton.Location = new Point(2, 509);
            DDayTaskButton.Margin = new Padding(2);
            DDayTaskButton.Name = "DDayTaskButton";
            DDayTaskButton.Size = new Size(100, 19);
            DDayTaskButton.TabIndex = 4;
            DDayTaskButton.Text = "Is D-Day Task";
            DDayTaskButton.UseVisualStyleBackColor = true;
            DDayTaskButton.CheckedChanged += Todo_Editted;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel3.Controls.Add(TodoCancelButton, 2, 0);
            tableLayoutPanel3.Controls.Add(TodoSaveButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 535);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(727, 29);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // TodoCancelButton
            // 
            TodoCancelButton.Dock = DockStyle.Fill;
            TodoCancelButton.Location = new Point(487, 3);
            TodoCancelButton.Name = "TodoCancelButton";
            TodoCancelButton.Size = new Size(237, 23);
            TodoCancelButton.TabIndex = 2;
            TodoCancelButton.Text = "Cancel";
            TodoCancelButton.UseVisualStyleBackColor = true;
            TodoCancelButton.Click += TodoCancelButton_Click;
            // 
            // TodoSaveButton
            // 
            TodoSaveButton.Dock = DockStyle.Fill;
            TodoSaveButton.Location = new Point(245, 3);
            TodoSaveButton.Name = "TodoSaveButton";
            TodoSaveButton.Size = new Size(236, 23);
            TodoSaveButton.TabIndex = 0;
            TodoSaveButton.Text = "Save";
            TodoSaveButton.UseVisualStyleBackColor = true;
            TodoSaveButton.Click += TodoSaveButton_Click;
            // 
            // DefaultMenuStrip
            // 
            DefaultMenuStrip.ImageScalingSize = new Size(20, 20);
            DefaultMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, settingToolStripMenuItem, ExportToolStripMenuItem });
            DefaultMenuStrip.Location = new Point(0, 0);
            DefaultMenuStrip.Name = "DefaultMenuStrip";
            DefaultMenuStrip.Padding = new Padding(5, 2, 0, 2);
            DefaultMenuStrip.Size = new Size(997, 24);
            DefaultMenuStrip.TabIndex = 1;
            DefaultMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, SaveAsToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(37, 20);
            FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(114, 22);
            NewToolStripMenuItem.Text = "New";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(114, 22);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(114, 22);
            SaveAsToolStripMenuItem.Text = "Save as";
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // settingToolStripMenuItem
            // 
            settingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontToolStripMenuItem, TopMostToolStripMenuItem });
            settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            settingToolStripMenuItem.Size = new Size(57, 20);
            settingToolStripMenuItem.Text = "Setting";
            // 
            // FontToolStripMenuItem
            // 
            FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            FontToolStripMenuItem.Size = new Size(125, 22);
            FontToolStripMenuItem.Text = "Font";
            FontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // TopMostToolStripMenuItem
            // 
            TopMostToolStripMenuItem.Name = "TopMostToolStripMenuItem";
            TopMostToolStripMenuItem.Size = new Size(125, 22);
            TopMostToolStripMenuItem.Text = "Top Most";
            TopMostToolStripMenuItem.Click += TopMostToolStripMenuItem_Click;
            // 
            // ExportToolStripMenuItem
            // 
            ExportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExportAESFileToolStripMenuItem });
            ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            ExportToolStripMenuItem.Size = new Size(53, 20);
            ExportToolStripMenuItem.Text = "Export";
            // 
            // ExportAESFileToolStripMenuItem
            // 
            ExportAESFileToolStripMenuItem.Name = "ExportAESFileToolStripMenuItem";
            ExportAESFileToolStripMenuItem.Size = new Size(153, 22);
            ExportAESFileToolStripMenuItem.Text = "Export AES file";
            ExportAESFileToolStripMenuItem.Click += ExportAESFileToolStripMenuItem_Click;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(TabPage1);
            MainTabControl.Controls.Add(TabPage2);
            MainTabControl.Controls.Add(TabPage3);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 24);
            MainTabControl.Margin = new Padding(2);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(997, 599);
            MainTabControl.TabIndex = 2;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(MainTreeView);
            TabPage1.Location = new Point(4, 24);
            TabPage1.Margin = new Padding(2);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(2);
            TabPage1.Size = new Size(989, 571);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Today";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // MainTreeView
            // 
            MainTreeView.Dock = DockStyle.Fill;
            MainTreeView.LineColor = Color.LightGray;
            MainTreeView.Location = new Point(2, 2);
            MainTreeView.Margin = new Padding(2);
            MainTreeView.Name = "MainTreeView";
            MainTreeView.Size = new Size(985, 567);
            MainTreeView.TabIndex = 0;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(MainSplitContainer);
            TabPage2.Location = new Point(4, 24);
            TabPage2.Margin = new Padding(2);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(2);
            TabPage2.Size = new Size(989, 571);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Detail";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(MemoSplitter);
            TabPage3.Location = new Point(4, 24);
            TabPage3.Margin = new Padding(2);
            TabPage3.Name = "TabPage3";
            TabPage3.Size = new Size(989, 571);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Memo";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // MemoSplitter
            // 
            MemoSplitter.Dock = DockStyle.Fill;
            MemoSplitter.Location = new Point(0, 0);
            MemoSplitter.Margin = new Padding(2);
            MemoSplitter.Name = "MemoSplitter";
            // 
            // MemoSplitter.Panel1
            // 
            MemoSplitter.Panel1.Controls.Add(DrawingPanel);
            // 
            // MemoSplitter.Panel2
            // 
            MemoSplitter.Panel2.Controls.Add(MemoTextBox);
            MemoSplitter.Size = new Size(989, 571);
            MemoSplitter.SplitterDistance = 731;
            MemoSplitter.SplitterWidth = 3;
            MemoSplitter.TabIndex = 0;
            // 
            // DrawingPanel
            // 
            DrawingPanel.Dock = DockStyle.Fill;
            DrawingPanel.Location = new Point(0, 0);
            DrawingPanel.Margin = new Padding(2);
            DrawingPanel.Name = "DrawingPanel";
            DrawingPanel.Size = new Size(731, 571);
            DrawingPanel.TabIndex = 0;
            DrawingPanel.Paint += DrawingPanel_Paint;
            DrawingPanel.DoubleClick += DrawingPanel_DoubleClick;
            DrawingPanel.MouseDown += DrawingPanel_MouseDown;
            DrawingPanel.MouseMove += DrawingPanel_MouseMove;
            DrawingPanel.MouseUp += DrawingPanel_MouseUp;
            // 
            // MemoTextBox
            // 
            MemoTextBox.Dock = DockStyle.Fill;
            MemoTextBox.Location = new Point(0, 0);
            MemoTextBox.Margin = new Padding(2);
            MemoTextBox.Name = "MemoTextBox";
            MemoTextBox.Size = new Size(255, 571);
            MemoTextBox.TabIndex = 0;
            MemoTextBox.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 623);
            Controls.Add(MainTabControl);
            Controls.Add(DefaultMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Scheduler";
            FormClosing += MainForm_FormClosing;
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            TableLayout.ResumeLayout(false);
            TableLayout.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            DefaultMenuStrip.ResumeLayout(false);
            DefaultMenuStrip.PerformLayout();
            MainTabControl.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
            TabPage3.ResumeLayout(false);
            MemoSplitter.Panel1.ResumeLayout(false);
            MemoSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MemoSplitter).EndInit();
            MemoSplitter.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer MainSplitContainer;
        private DateTimePicker TodoDatePicker;
        private TableLayoutPanel TableLayout;
        private RichTextBox DescryptTextBox;
        private RichTextBox TitleTextBox;
        private CheckedListBox TodoListBox;
        private CheckBox DDayTaskButton;
        private MenuStrip DefaultMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem ExportToolStripMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private TabControl MainTabControl;
        private TabPage TabPage1;
        private TabPage TabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button AddButton;
        private Button RemoveButton;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private Button SortButton;
        private TreeView MainTreeView;
        private TableLayoutPanel tableLayoutPanel3;
        private Button TodoCancelButton;
        private Button TodoSaveButton;
        private ToolStripMenuItem ExportAESFileToolStripMenuItem;
        private TabPage TabPage3;
        private SplitContainer MemoSplitter;
        private RichTextBox MemoTextBox;
        private Panel DrawingPanel;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem FontToolStripMenuItem;
        private ToolStripMenuItem TopMostToolStripMenuItem;
    }
}