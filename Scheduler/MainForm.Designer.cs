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
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            TableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.Location = new Point(0, 0);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(TodoListBox);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(TableLayout);
            MainSplitContainer.Size = new Size(800, 450);
            MainSplitContainer.SplitterDistance = 266;
            MainSplitContainer.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            TodoListBox.Dock = DockStyle.Fill;
            TodoListBox.FormattingEnabled = true;
            TodoListBox.Location = new Point(0, 0);
            TodoListBox.Name = "checkedListBox1";
            TodoListBox.Size = new Size(266, 450);
            TodoListBox.TabIndex = 0;
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
            TableLayout.Size = new Size(530, 450);
            TableLayout.TabIndex = 1;
            // 
            // DDayTaskButton
            // 
            DDayTaskButton.AutoSize = true;
            DDayTaskButton.Dock = DockStyle.Fill;
            DDayTaskButton.Location = new Point(3, 423);
            DDayTaskButton.Name = "DDayTaskButton";
            DDayTaskButton.Size = new Size(524, 24);
            DDayTaskButton.TabIndex = 4;
            DDayTaskButton.Text = "Is D-Day Task";
            DDayTaskButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            DescryptTextBox.Dock = DockStyle.Fill;
            DescryptTextBox.Location = new Point(3, 87);
            DescryptTextBox.Name = "richTextBox2";
            DescryptTextBox.Size = new Size(524, 330);
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
            // richTextBox1
            // 
            TitleTextBox.Dock = DockStyle.Fill;
            TitleTextBox.Location = new Point(3, 36);
            TitleTextBox.Name = "richTextBox1";
            TitleTextBox.Size = new Size(524, 45);
            TitleTextBox.TabIndex = 2;
            TitleTextBox.Text = "";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainSplitContainer);
            Name = "MainForm";
            Text = "Scheduler";
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            TableLayout.ResumeLayout(false);
            TableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer MainSplitContainer;
        private DateTimePicker TodoDatePicker;
        private TableLayoutPanel TableLayout;
        private RichTextBox DescryptTextBox;
        private RichTextBox TitleTextBox;
        private CheckedListBox TodoListBox;
        private CheckBox DDayTaskButton;
    }
}