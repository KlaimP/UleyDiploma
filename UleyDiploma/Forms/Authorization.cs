using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UleyDiploma.API;

namespace UleyDiploma.Forms
{
    public partial class Authorization : Form
    {
        bool exit = false;
        public Authorization()
        {
            InitializeComponent();
        }

        private void btn_autorization_Click(object sender, EventArgs e)
        {
//            string key = RestUleyAPI.Verify(i_login.Text, i_password.Text);


//            if (key != "null")
//            {
                exit = true;
                this.Close();
//            }
            //else
            //{
            //    DialogResult res = MessageBox.Show("Неправильный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exit)
            {
                DialogResult res = MessageBox.Show("Вы уверены что хотите выйти? Закрытие этого окна закроет приложение полностью.", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (res == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
