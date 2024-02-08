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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace krasotkaa
{
    public partial class Autorization : Form
    {
        private int timer = 0;
        private string? UserName;
        public Autorization()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 255);
            btnEnter.BackColor = Color.FromArgb(204, 102, 0);
            btnGuest.BackColor = Color.FromArgb(204, 102, 0);
            button1.BackColor = Color.FromArgb(204, 102, 0);
            txtPassword.UseSystemPasswordChar = true;
            panel1.BackColor = Color.FromArgb(255, 204, 153);

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void block_btn()
        {
            timer1.Interval = 1000;
            btnEnter.Enabled = false;
            timer1.Start();
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
            
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += 1;
            if (timer == 10)
            {
                timer1.Stop();
                timer = 0;
                btnEnter.Enabled = true;
            }
        }

        private void Autorization_Load(object sender, EventArgs e)
        {
          
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            using (DB_AleynikovContext db = new DB_AleynikovContext())
            {
                var user = db.Users.FirstOrDefault(x => x.UserLogin == txtLogin.Text && x.UserPassword == txtPassword.Text);
                if (user != null)
                {
                    var role = db.Roles.FirstOrDefault(x => x.RoleId == user.UserRole);
                    UserName = $"{user.UserName} {user.UserSurname}";
                    if (user.UserSurname != null) UserName += $" {user.UserPatronymic}";
                    MessageBox.Show($"{UserName}\nУровень доступа: {role!.RoleName}", "Добро пожаловать");
                    OpenForm(role.RoleId);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    block_btn();
                }
            }
        }

        private void btnGuest_Click_1(object sender, EventArgs e)
        {
            OpenForm(0);
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
