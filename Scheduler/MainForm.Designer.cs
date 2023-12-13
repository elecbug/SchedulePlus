namespace Scheduler
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
            ExportToolStripMenuItem = new ToolStripMenuItem();
            ExportAESFileToolStripMenuItem = new ToolStripMenuItem();
            MainTabControl = new TabControl();
            TabPage1 = new TabPage();
            MainTreeView = new TreeView();
            TabPage2 = new TabPage();
            TabPage3 = new TabPage();
            MemoSplitter = new SplitContainer();
            MemoTextBox = new RichTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            MemoListView = new ListView();
            tableLayoutPanel5 = new TableLayoutPanel();
            MemoAddButton = new Button();
            MemoRemoveButton = new Button();
            MemoSortButton = new Button();
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
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(3, 3);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(TableLayout);
            MainSplitContainer.Size = new Size(1079, 623);
            MainSplitContainer.SplitterDistance = 274;
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(274, 623);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TodoListBox
            // 
            TodoListBox.Dock = DockStyle.Fill;
            TodoListBox.FormattingEnabled = true;
            TodoListBox.Location = new Point(3, 3);
            TodoListBox.Name = "TodoListBox";
            TodoListBox.Size = new Size(268, 577);
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
            tableLayoutPanel2.Location = new Point(3, 586);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(268, 34);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(83, 28);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += TodoAddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(92, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(83, 28);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += TodoRemoveButton_Click;
            // 
            // SortButton
            // 
            SortButton.Dock = DockStyle.Fill;
            SortButton.Location = new Point(181, 3);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(84, 28);
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
            TableLayout.Name = "TableLayout";
            TableLayout.RowCount = 5;
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            TableLayout.Size = new Size(801, 623);
            TableLayout.TabIndex = 1;
            // 
            // DescryptTextBox
            // 
            DescryptTextBox.Dock = DockStyle.Fill;
            DescryptTextBox.Location = new Point(3, 89);
            DescryptTextBox.Name = "DescryptTextBox";
            DescryptTextBox.Size = new Size(795, 451);
            DescryptTextBox.TabIndex = 3;
            DescryptTextBox.Text = "";
            DescryptTextBox.TextChanged += Todo_Editted;
            // 
            // TodoDatePicker
            // 
            TodoDatePicker.Dock = DockStyle.Fill;
            TodoDatePicker.Location = new Point(3, 3);
            TodoDatePicker.Name = "TodoDatePicker";
            TodoDatePicker.Size = new Size(795, 27);
            TodoDatePicker.TabIndex = 0;
            TodoDatePicker.ValueChanged += Todo_Editted;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Dock = DockStyle.Fill;
            TitleTextBox.ImeMode = ImeMode.NoControl;
            TitleTextBox.Location = new Point(3, 36);
            TitleTextBox.Multiline = false;
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(795, 47);
            TitleTextBox.TabIndex = 2;
            TitleTextBox.Text = "";
            TitleTextBox.TextChanged += Todo_Editted;
            // 
            // DDayTaskButton
            // 
            DDayTaskButton.AutoSize = true;
            DDayTaskButton.Location = new Point(3, 546);
            DDayTaskButton.Name = "DDayTaskButton";
            DDayTaskButton.Size = new Size(124, 24);
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
            tableLayoutPanel3.Location = new Point(4, 580);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(793, 39);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // TodoCancelButton
            // 
            TodoCancelButton.Dock = DockStyle.Fill;
            TodoCancelButton.Location = new Point(532, 4);
            TodoCancelButton.Margin = new Padding(4);
            TodoCancelButton.Name = "TodoCancelButton";
            TodoCancelButton.Size = new Size(257, 31);
            TodoCancelButton.TabIndex = 2;
            TodoCancelButton.Text = "Cancel";
            TodoCancelButton.UseVisualStyleBackColor = true;
            TodoCancelButton.Click += CancelButton_Click;
            // 
            // TodoSaveButton
            // 
            TodoSaveButton.Dock = DockStyle.Fill;
            TodoSaveButton.Location = new Point(268, 4);
            TodoSaveButton.Margin = new Padding(4);
            TodoSaveButton.Name = "TodoSaveButton";
            TodoSaveButton.Size = new Size(256, 31);
            TodoSaveButton.TabIndex = 0;
            TodoSaveButton.Text = "Save";
            TodoSaveButton.UseVisualStyleBackColor = true;
            TodoSaveButton.Click += SaveButton_Click;
            // 
            // DefaultMenuStrip
            // 
            DefaultMenuStrip.ImageScalingSize = new Size(20, 20);
            DefaultMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, ExportToolStripMenuItem });
            DefaultMenuStrip.Location = new Point(0, 0);
            DefaultMenuStrip.Name = "DefaultMenuStrip";
            DefaultMenuStrip.Padding = new Padding(6, 3, 0, 3);
            DefaultMenuStrip.Size = new Size(1093, 30);
            DefaultMenuStrip.TabIndex = 1;
            DefaultMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, SaveAsToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(46, 24);
            FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(142, 26);
            NewToolStripMenuItem.Text = "New";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(142, 26);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(142, 26);
            SaveAsToolStripMenuItem.Text = "Save as";
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // ExportToolStripMenuItem
            // 
            ExportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExportAESFileToolStripMenuItem });
            ExportToolStripMenuItem.Name = "ExportToolStripMenuItem";
            ExportToolStripMenuItem.Size = new Size(66, 24);
            ExportToolStripMenuItem.Text = "Export";
            // 
            // ExportAESFileToolStripMenuItem
            // 
            ExportAESFileToolStripMenuItem.Name = "ExportAESFileToolStripMenuItem";
            ExportAESFileToolStripMenuItem.Size = new Size(192, 26);
            ExportAESFileToolStripMenuItem.Text = "Export AES file";
            ExportAESFileToolStripMenuItem.Click += ExportAESFileToolStripMenuItem_Click;
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(TabPage1);
            MainTabControl.Controls.Add(TabPage2);
            MainTabControl.Controls.Add(TabPage3);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 30);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1093, 662);
            MainTabControl.TabIndex = 2;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(MainTreeView);
            TabPage1.Location = new Point(4, 29);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1085, 629);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Today";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // MainTreeView
            // 
            MainTreeView.Dock = DockStyle.Fill;
            MainTreeView.Location = new Point(3, 3);
            MainTreeView.Name = "MainTreeView";
            MainTreeView.Size = new Size(1079, 623);
            MainTreeView.TabIndex = 0;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(MainSplitContainer);
            TabPage2.Location = new Point(4, 29);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(1085, 629);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Detail";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage3
            // 
            TabPage3.Controls.Add(MemoSplitter);
            TabPage3.Location = new Point(4, 29);
            TabPage3.Name = "TabPage3";
            TabPage3.Size = new Size(1085, 629);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Memo";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // MemoSplitter
            // 
            MemoSplitter.Dock = DockStyle.Fill;
            MemoSplitter.Location = new Point(0, 0);
            MemoSplitter.Name = "MemoSplitter";
            // 
            // MemoSplitter.Panel1
            // 
            MemoSplitter.Panel1.Controls.Add(MemoTextBox);
            // 
            // MemoSplitter.Panel2
            // 
            MemoSplitter.Panel2.Controls.Add(tableLayoutPanel4);
            MemoSplitter.Size = new Size(1085, 629);
            MemoSplitter.SplitterDistance = 722;
            MemoSplitter.TabIndex = 0;
            // 
            // MemoTextBox
            // 
            MemoTextBox.Dock = DockStyle.Fill;
            MemoTextBox.Location = new Point(0, 0);
            MemoTextBox.Name = "MemoTextBox";
            MemoTextBox.Size = new Size(722, 629);
            MemoTextBox.TabIndex = 0;
            MemoTextBox.Text = "";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(MemoListView, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel4.Size = new Size(359, 629);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // MemoListView
            // 
            MemoListView.Dock = DockStyle.Fill;
            MemoListView.Location = new Point(3, 3);
            MemoListView.MultiSelect = false;
            MemoListView.Name = "MemoListView";
            MemoListView.Size = new Size(353, 583);
            MemoListView.TabIndex = 0;
            MemoListView.UseCompatibleStateImageBehavior = false;
            MemoListView.View = View.Tile;
            MemoListView.SelectedIndexChanged += MemoListView_SelectedIndexChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(MemoAddButton, 0, 0);
            tableLayoutPanel5.Controls.Add(MemoRemoveButton, 1, 0);
            tableLayoutPanel5.Controls.Add(MemoSortButton, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 592);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(353, 34);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // MemoAddButton
            // 
            MemoAddButton.Dock = DockStyle.Fill;
            MemoAddButton.Location = new Point(3, 3);
            MemoAddButton.Name = "MemoAddButton";
            MemoAddButton.Size = new Size(111, 28);
            MemoAddButton.TabIndex = 0;
            MemoAddButton.Text = "Add";
            MemoAddButton.UseVisualStyleBackColor = true;
            MemoAddButton.Click += MemoAddButton_Click;
            // 
            // MemoRemoveButton
            // 
            MemoRemoveButton.Dock = DockStyle.Fill;
            MemoRemoveButton.Location = new Point(120, 3);
            MemoRemoveButton.Name = "MemoRemoveButton";
            MemoRemoveButton.Size = new Size(111, 28);
            MemoRemoveButton.TabIndex = 0;
            MemoRemoveButton.Text = "Remove";
            MemoRemoveButton.UseVisualStyleBackColor = true;
            MemoRemoveButton.Click += MemoRemoveButton_Click;
            // 
            // MemoSortButton
            // 
            MemoSortButton.Dock = DockStyle.Fill;
            MemoSortButton.Location = new Point(237, 3);
            MemoSortButton.Name = "MemoSortButton";
            MemoSortButton.Size = new Size(113, 28);
            MemoSortButton.TabIndex = 0;
            MemoSortButton.Text = "Sort";
            MemoSortButton.UseVisualStyleBackColor = true;
            MemoSortButton.Click += MemoSortButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 692);
            Controls.Add(MainTabControl);
            Controls.Add(DefaultMenuStrip);
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
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
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
        private ListView MemoListView;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button MemoAddButton;
        private Button MemoRemoveButton;
        private Button MemoSortButton;
    }
}