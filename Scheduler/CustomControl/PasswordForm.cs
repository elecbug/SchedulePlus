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
        public TextBox Password { get; private set; }

        public PasswordForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Password";
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ClientSize = new Size(400, 30);

            this.Password = new TextBox() 
            {
                Parent = this,
                Visible = true,
                PasswordChar = '*',
                UseSystemPasswordChar = true,
                Dock = DockStyle.Fill,
            };

            this.Password.KeyDown += Password_KeyDown;
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
