using krasotkaa.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace krasotkaa
{
    public partial class Autorization : Form
    {
        private string? UserName;
        public Autorization()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            panel1.BackColor = Color.FromArgb(255, 204, 153);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                var user = db.Users.FirstOrDefault(x => x.UserLogin == txtLogin.Text && x.UserPassword == txtPassword.Text);

                if (user != null)
                {
                    var role = db.Roles.FirstOrDefault(x => x.RoleId == user.UserRole);
                    UserName = $"{user.UserName} {user.UserSurname}";
                    if (user.UserSurname != null) UserName += $"{user.UserPatronymic}";
                    MessageBox.Show($"{UserName}\nУровень доступа: {role!.RoleName}", "Добро пожаловать");
                    OpenForm(role.RoleId);
                }
                else
                    MessageBox.Show("Некорректные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenForm(int role)
        {
            Hide();
            txtLogin.Clear();
            txtPassword.Clear();
            FormProducts form = new FormProducts(UserName!, role);
            form.ShowDialog();
            UserName = null;
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            OpenForm(0);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //txtPassword.UseSystemPasswordChar = true;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
