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
            TodoListBox = new CheckedListBox();
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
            SettingToolStripMenuItem = new ToolStripMenuItem();
            PasswordToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            TableLayout.SuspendLayout();
            DefaultMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 28);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(TodoListBox);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(TableLayout);
            MainSplitContainer.Size = new Size(800, 422);
            MainSplitContainer.SplitterDistance = 266;
            MainSplitContainer.TabIndex = 0;
            // 
            // TodoListBox
            // 
            TodoListBox.Dock = DockStyle.Fill;
            TodoListBox.FormattingEnabled = true;
            TodoListBox.Location = new Point(0, 0);
            TodoListBox.Name = "TodoListBox";
            TodoListBox.Size = new Size(266, 422);
            TodoListBox.TabIndex = 0;
            TodoListBox.SelectedIndexChanged += TodoListBox_SelectedIndexChanged;
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
            TableLayout.Size = new Size(530, 422);
            TableLayout.TabIndex = 1;
            // 
            // DDayTaskButton
            // 
            DDayTaskButton.AutoSize = true;
            DDayTaskButton.Dock = DockStyle.Fill;
            DDayTaskButton.Location = new Point(3, 395);
            DDayTaskButton.Name = "DDayTaskButton";
            DDayTaskButton.Size = new Size(524, 24);
            DDayTaskButton.TabIndex = 4;
            DDayTaskButton.Text = "Is D-Day Task";
            DDayTaskButton.UseVisualStyleBackColor = true;
            // 
            // DescryptTextBox
            // 
            DescryptTextBox.Dock = DockStyle.Fill;
            DescryptTextBox.Location = new Point(3, 87);
            DescryptTextBox.Name = "DescryptTextBox";
            DescryptTextBox.Size = new Size(524, 302);
            DescryptTextBox.TabIndex = 3;
            DescryptTextBox.Text = "";
            // 
            // TodoDatePicker
            // 
            TodoDatePicker.Dock = DockStyle.Fill;
            TodoDatePicker.Location = new Point(3, 3);
            TodoDatePicker.Name = "TodoDatePicker";
            TodoDatePicker.Size = new Size(524, 27);
            TodoDatePicker.TabIndex = 0;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Dock = DockStyle.Fill;
            TitleTextBox.Location = new Point(3, 36);
            TitleTextBox.Multiline = false;
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(524, 45);
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
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, CloseToolStripMenuItem, SaveToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(46, 24);
            FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.Size = new Size(224, 26);
            NewToolStripMenuItem.Text = "New";
            NewToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(224, 26);
            OpenToolStripMenuItem.Text = "Open";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(224, 26);
            CloseToolStripMenuItem.Text = "Close";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(224, 26);
            SaveToolStripMenuItem.Text = "Save";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainSplitContainer);
            Controls.Add(DefaultMenuStrip);
            Name = "MainForm";
            Text = "Scheduler";
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            TableLayout.ResumeLayout(false);
            TableLayout.PerformLayout();
            DefaultMenuStrip.ResumeLayout(false);
            DefaultMenuStrip.PerformLayout();
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
    }
}