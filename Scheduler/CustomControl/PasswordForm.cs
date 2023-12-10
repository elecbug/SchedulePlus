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
    /// <summary>
    /// 비밀번호를 입력받는 폼
    /// </summary>
    public partial class PasswordForm : Form
    {
        /// <summary>
        /// 비밀번호 텍스트 박스
        /// </summary>
        public TextBox PasswordBox { get; private set; }

        /// <summary>
        /// 비밀번호 폼 생성
        /// </summary>
        /// <param name="text"> 폼 상단 텍스트 </param>
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

        /// <summary>
        /// 엔터 키를 입력 시 DialogResult.OK를 반환하고 폼 종료
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
