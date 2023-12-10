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
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TodoListBox = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DescryptTextBox = new System.Windows.Forms.RichTextBox();
            this.TodoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.TitleTextBox = new System.Windows.Forms.RichTextBox();
            this.DDayTaskButton = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TodoCancelButton = new System.Windows.Forms.Button();
            this.TodoSaveButton = new System.Windows.Forms.Button();
            this.DefaultMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.TableLayout.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.DefaultMenuStrip.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplitContainer.Location = new System.Drawing.Point(2, 2);
            this.MainSplitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.TableLayout);
            this.MainSplitContainer.Size = new System.Drawing.Size(838, 463);
            this.MainSplitContainer.SplitterDistance = 213;
            this.MainSplitContainer.SplitterWidth = 3;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TodoListBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 463);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TodoListBox
            // 
            this.TodoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoListBox.FormattingEnabled = true;
            this.TodoListBox.Location = new System.Drawing.Point(2, 2);
            this.TodoListBox.Margin = new System.Windows.Forms.Padding(2);
            this.TodoListBox.Name = "TodoListBox";
            this.TodoListBox.Size = new System.Drawing.Size(209, 429);
            this.TodoListBox.TabIndex = 0;
            this.TodoListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.TodoListBox_ItemCheck);
            this.TodoListBox.SelectedIndexChanged += new System.EventHandler(this.TodoListBox_SelectedIndexChanged);
            this.TodoListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.TodoListBox_Format);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RemoveButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SortButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 435);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(209, 26);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(2, 2);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(65, 22);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(71, 2);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(65, 22);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortButton.Location = new System.Drawing.Point(140, 2);
            this.SortButton.Margin = new System.Windows.Forms.Padding(2);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(67, 22);
            this.SortButton.TabIndex = 2;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 1;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Controls.Add(this.DescryptTextBox, 0, 2);
            this.TableLayout.Controls.Add(this.TodoDatePicker, 0, 0);
            this.TableLayout.Controls.Add(this.TitleTextBox, 0, 1);
            this.TableLayout.Controls.Add(this.DDayTaskButton, 0, 3);
            this.TableLayout.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Margin = new System.Windows.Forms.Padding(2);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 5;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayout.Size = new System.Drawing.Size(622, 463);
            this.TableLayout.TabIndex = 1;
            // 
            // DescryptTextBox
            // 
            this.DescryptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescryptTextBox.Location = new System.Drawing.Point(2, 67);
            this.DescryptTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DescryptTextBox.Name = "DescryptTextBox";
            this.DescryptTextBox.Size = new System.Drawing.Size(618, 334);
            this.DescryptTextBox.TabIndex = 3;
            this.DescryptTextBox.Text = "";
            this.DescryptTextBox.TextChanged += new System.EventHandler(this.Todo_Editted);
            // 
            // TodoDatePicker
            // 
            this.TodoDatePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoDatePicker.Location = new System.Drawing.Point(2, 2);
            this.TodoDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.TodoDatePicker.Name = "TodoDatePicker";
            this.TodoDatePicker.Size = new System.Drawing.Size(618, 23);
            this.TodoDatePicker.TabIndex = 0;
            this.TodoDatePicker.ValueChanged += new System.EventHandler(this.Todo_Editted);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TitleTextBox.Location = new System.Drawing.Point(2, 27);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TitleTextBox.Multiline = false;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(618, 36);
            this.TitleTextBox.TabIndex = 2;
            this.TitleTextBox.Text = "";
            this.TitleTextBox.TextChanged += new System.EventHandler(this.Todo_Editted);
            // 
            // DDayTaskButton
            // 
            this.DDayTaskButton.AutoSize = true;
            this.DDayTaskButton.Location = new System.Drawing.Point(2, 405);
            this.DDayTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.DDayTaskButton.Name = "DDayTaskButton";
            this.DDayTaskButton.Size = new System.Drawing.Size(100, 19);
            this.DDayTaskButton.TabIndex = 4;
            this.DDayTaskButton.Text = "Is D-Day Task";
            this.DDayTaskButton.UseVisualStyleBackColor = true;
            this.DDayTaskButton.CheckedChanged += new System.EventHandler(this.Todo_Editted);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.TodoCancelButton, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.TodoSaveButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 431);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(616, 29);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // TodoCancelButton
            // 
            this.TodoCancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoCancelButton.Location = new System.Drawing.Point(413, 3);
            this.TodoCancelButton.Name = "TodoCancelButton";
            this.TodoCancelButton.Size = new System.Drawing.Size(200, 23);
            this.TodoCancelButton.TabIndex = 2;
            this.TodoCancelButton.Text = "Cancel";
            this.TodoCancelButton.UseVisualStyleBackColor = true;
            this.TodoCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TodoSaveButton
            // 
            this.TodoSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodoSaveButton.Location = new System.Drawing.Point(208, 3);
            this.TodoSaveButton.Name = "TodoSaveButton";
            this.TodoSaveButton.Size = new System.Drawing.Size(199, 23);
            this.TodoSaveButton.TabIndex = 0;
            this.TodoSaveButton.Text = "Save";
            this.TodoSaveButton.UseVisualStyleBackColor = true;
            this.TodoSaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DefaultMenuStrip
            // 
            this.DefaultMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DefaultMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SettingToolStripMenuItem});
            this.DefaultMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.DefaultMenuStrip.Name = "DefaultMenuStrip";
            this.DefaultMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.DefaultMenuStrip.Size = new System.Drawing.Size(850, 24);
            this.DefaultMenuStrip.TabIndex = 1;
            this.DefaultMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.SaveAsToolStripMenuItem.Text = "Save as";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.SettingToolStripMenuItem.Text = "Setting";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.TabPage1);
            this.MainTabControl.Controls.Add(this.TabPage2);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 24);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(850, 495);
            this.MainTabControl.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.MainTreeView);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.TabPage1.Size = new System.Drawing.Size(842, 467);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Today";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(2, 2);
            this.MainTreeView.Margin = new System.Windows.Forms.Padding(2);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(838, 463);
            this.MainTreeView.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.MainSplitContainer);
            this.TabPage2.Location = new System.Drawing.Point(4, 24);
            this.TabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.TabPage2.Size = new System.Drawing.Size(842, 467);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Detail";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 519);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.DefaultMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.TableLayout.ResumeLayout(false);
            this.TableLayout.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.DefaultMenuStrip.ResumeLayout(false);
            this.DefaultMenuStrip.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TableLayoutPanel tableLayoutPanel3;
        private Button TodoCancelButton;
        private Button TodoSaveButton;
    }
}