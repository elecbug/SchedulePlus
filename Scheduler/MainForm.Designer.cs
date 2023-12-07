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
            DDayTaskButton = new CheckBox();
            DescryptTextBox = new RichTextBox();
            TodoDatePicker = new DateTimePicker();
            TitleTextBox = new RichTextBox();
            DefaultMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            CloseToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            SettingToolStripMenuItem = new ToolStripMenuItem();
            PasswordToolStripMenuItem = new ToolStripMenuItem();
            MainTabControl = new TabControl();
            TabPage1 = new TabPage();
            MainTreeView = new TreeView();
            TabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            TableLayout.SuspendLayout();
            DefaultMenuStrip.SuspendLayout();
            MainTabControl.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
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
            MainSplitContainer.Size = new Size(786, 383);
            MainSplitContainer.SplitterDistance = 261;
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
            tableLayoutPanel1.Size = new Size(261, 383);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TodoListBox
            // 
            TodoListBox.Dock = DockStyle.Fill;
            TodoListBox.FormattingEnabled = true;
            TodoListBox.Location = new Point(3, 3);
            TodoListBox.Name = "TodoListBox";
            TodoListBox.Size = new Size(255, 337);
            TodoListBox.TabIndex = 0;
            TodoListBox.ItemCheck += TodoListBox_ItemCheck;
            TodoListBox.SelectedIndexChanged += TodoListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(AddButton, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveButton, 1, 0);
            tableLayoutPanel2.Controls.Add(SortButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 346);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(255, 34);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(79, 28);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(88, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(79, 28);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SortButton
            // 
            SortButton.Dock = DockStyle.Fill;
            SortButton.Location = new Point(173, 3);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(79, 28);
            SortButton.TabIndex = 2;
            SortButton.Text = "Sort";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // TableLayout
            // 
            TableLayout.ColumnCount = 1;
            TableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayout.Controls.Add(DDayTaskButton, 0, 3);
            TableLayout.Controls.Add(DescryptTextBox, 0, 2);
            TableLayout.Controls.Add(TodoDatePicker, 0, 0);
            TableLayout.Controls.Add(TitleTextBox, 0, 1);
            TableLayout.Dock = DockStyle.Fill;
            TableLayout.Location = new Point(0, 0);
            TableLayout.Name = "TableLayout";
            TableLayout.RowCount = 4;
            TableLayout.RowStyles.Add(new RowStyle());
            TableLayout.RowStyles.Add(new RowStyle());
            TableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayout.RowStyles.Add(new RowStyle());
            TableLayout.Size = new Size(521, 383);
            TableLayout.TabIndex = 1;
            // 
            // DDayTaskButton
            // 
            DDayTaskButton.AutoSize = true;
            DDayTaskButton.Dock = DockStyle.Fill;
            DDayTaskButton.Location = new Point(3, 356);
            DDayTaskButton.Name = "DDayTaskButton";
            DDayTaskButton.Size = new Size(515, 24);
            DDayTaskButton.TabIndex = 4;
            DDayTaskButton.Text = "Is D-Day Task";
            DDayTaskButton.UseVisualStyleBackColor = true;
            // 
            // DescryptTextBox
            // 
            DescryptTextBox.Dock = DockStyle.Fill;
            DescryptTextBox.Location = new Point(3, 87);
            DescryptTextBox.Name = "DescryptTextBox";
            DescryptTextBox.Size = new Size(515, 263);
            DescryptTextBox.TabIndex = 3;
            DescryptTextBox.Text = "";
            // 
            // TodoDatePicker
            // 
            TodoDatePicker.Dock = DockStyle.Fill;
            TodoDatePicker.Location = new Point(3, 3);
            TodoDatePicker.Name = "TodoDatePicker";
            TodoDatePicker.Size = new Size(515, 27);
            TodoDatePicker.TabIndex = 0;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Dock = DockStyle.Fill;
            TitleTextBox.ImeMode = ImeMode.NoControl;
            TitleTextBox.Location = new Point(3, 36);
            TitleTextBox.Multiline = false;
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(515, 45);
            TitleTextBox.TabIndex = 2;
            TitleTextBox.Text = "";
            // 
            // DefaultMenuStrip
            // 
            DefaultMenuStrip.ImageScalingSize = new Size(20, 20);
            DefaultMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, SettingToolStripMenuItem });
            DefaultMenuStrip.Location = new Point(0, 0);
            DefaultMenuStrip.Name = "DefaultMenuStrip";
            DefaultMenuStrip.Size = new Size(800, 28);
            DefaultMenuStrip.TabIndex = 1;
            DefaultMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, CloseToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem });
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
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(142, 26);
            CloseToolStripMenuItem.Text = "Close";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(142, 26);
            SaveToolStripMenuItem.Text = "Save";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(142, 26);
            SaveAsToolStripMenuItem.Text = "Save as";
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // SettingToolStripMenuItem
            // 
            SettingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PasswordToolStripMenuItem });
            SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            SettingToolStripMenuItem.Size = new Size(71, 24);
            SettingToolStripMenuItem.Text = "Setting";
            // 
            // PasswordToolStripMenuItem
            // 
            PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem";
            PasswordToolStripMenuItem.Size = new Size(155, 26);
            PasswordToolStripMenuItem.Text = "Password";
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(TabPage1);
            MainTabControl.Controls.Add(TabPage2);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 28);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(800, 422);
            MainTabControl.TabIndex = 2;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(MainTreeView);
            TabPage1.Location = new Point(4, 29);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(792, 389);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Today";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // MainTreeView
            // 
            MainTreeView.Dock = DockStyle.Fill;
            MainTreeView.Location = new Point(3, 3);
            MainTreeView.Name = "MainTreeView";
            MainTreeView.Size = new Size(786, 383);
            MainTreeView.TabIndex = 0;
            // 
            // TabPage2
            // 
            TabPage2.Controls.Add(MainSplitContainer);
            TabPage2.Location = new Point(4, 29);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(792, 389);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "Detail";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTabControl);
            Controls.Add(DefaultMenuStrip);
            Name = "MainForm";
            Text = "Scheduler";
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            TableLayout.ResumeLayout(false);
            TableLayout.PerformLayout();
            DefaultMenuStrip.ResumeLayout(false);
            DefaultMenuStrip.PerformLayout();
            MainTabControl.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage2.ResumeLayout(false);
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
        private ToolStripMenuItem SettingToolStripMenuItem;
        private ToolStripMenuItem PasswordToolStripMenuItem;
        private ToolStripMenuItem NewToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
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
    }
}