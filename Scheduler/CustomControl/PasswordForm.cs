using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler.CustomControl
{
    public partial class PasswordForm : Form
    {
        public TextBox PasswordBox { get; private set; }

        public PasswordForm(string text)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = text;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ClientSize = new Size(400, 30);
            this.ShowIcon = false;

            this.PasswordBox = new TextBox()
            {
                Parent = this,
                Visible = true,
                PasswordChar = '*',
                UseSystemPasswordChar = true,
                Location = new Point(5, 5),
                Size = new Size(this.ClientSize.Width - 10, this.ClientSize.Height - 10),
            };

            this.PasswordBox.KeyDown += Password_KeyDown;
        }

        private void Password_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
