using Demo_4.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_4
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void box_Check_CheckedChanged(object sender, EventArgs e)
        {
            box_Password.UseSystemPasswordChar = !box_Password.UseSystemPasswordChar;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            click_Autorization();
        }
        /// <summary>
        /// метод авторизации через БД
        /// </summary>
        private void click_Autorization()
        {
            try
            {
                bool result = false;
                DataTable dataTable = db_Connect.fromDB("select*from Users");
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (box_Login.Text == dataTable.Rows[i][2].ToString() && box_Password.Text == dataTable.Rows[i][3].ToString())
                    {
                        switch (dataTable.Rows[i][4])
                        {
                            case 1:
                                MessageBox.Show("Успешный вход");
                                AdminForm adminForm = new AdminForm();
                                adminForm.ShowDialog();
                                result = true;
                                break;
                            case 2:
                                MessageBox.Show("Успешный вход");
                                ProductForm productForm = new ProductForm();
                                productForm.ShowDialog();
                                result = true;
                                break;
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("НЕУспешный вход");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");

            }

        }

        private void lbl_Visit_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы точно хотите выйти?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
    }
}
