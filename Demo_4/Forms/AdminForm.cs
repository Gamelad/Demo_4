using Demo_4.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_4.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Вы точно хотите вернуться?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Close();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            uc_Load();
        }
        /// <summary>
        /// 
        /// </summary>
        private void uc_Load()
        {
            try
            {
                pnl_Product.Controls.Clear();
                DataTable dataTable = db_Connect.fromDB($"execute sp_Load_2 '{box_Filter.SelectedItem}','{box_Sort.SelectedIndex}','{box_Search.Text}'");
                for ( int i = 0; i < dataTable.Rows.Count; i++ )
                {
                    uc_Product uc_Product = new uc_Product();
                    uc_Product.uc_id = (int)dataTable.Rows[i][0];
                    pnl_Product.Controls.Add(uc_Product);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }
        }

        private void box_Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void box_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            uc_Load();
        }

        private void box_Search_TextChanged(object sender, EventArgs e)
        {
            uc_Load();
        }
    }
}
