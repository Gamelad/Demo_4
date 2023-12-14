using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_4.UI
{
    public partial class uc_Product : UserControl
    {
        public static int uc_id {  get; set; }
        public uc_Product()
        {
            InitializeComponent();
        }

        private void uc_Product_Load(object sender, EventArgs e)
        {
            uc_Fill();
        }

        private void uc_Fill()
        {
            try
            {
                DataTable dataTable = db_Connect.fromDB($"select*from v_Product_1 where ProductID = {uc_id}");
                for ( int i = 0; i < dataTable.Rows.Count; i++ )
                {
                    lbl_ID.Text = $"{dataTable.Rows[i][0]}";
                    lbl_Name.Text = $"{dataTable.Rows[i][1]}";
                    lbl_Desc.Text = $"{dataTable.Rows[i][2]}";
                    lbl_Discount.Text = $"Скидка: {dataTable.Rows[i][4]}%";
                    if (Convert.ToInt32(dataTable.Rows[i][4]) > 0)
                    {
                        BackColor = Color.LightGreen;
                        lbl_Cost_2.Visible = true;
                        lbl_Cost_2.Text = $"Цена: {dataTable.Rows[i][3]} руб.";
                        lbl_Cost.Text = $"Цена: {Convert.ToInt32(dataTable.Rows[i][3]) - (Convert.ToInt32(dataTable.Rows[i][3]) * Convert.ToInt32(dataTable.Rows[i][4])) / 100} руб.";
                    }
                    else
                    {
                        lbl_Cost.Text = $"Цена: {dataTable.Rows[i][3]} руб.";
                    }
                    lbl_Count.Text = $"Кол-во: {dataTable.Rows[i][5]}";
                    if (Convert.ToInt32(dataTable.Rows[i][5]) < 5)
                    {
                        BackColor = Color.LightPink;
                    }
                    lbl_Manuf.Text = $"Производитель: {dataTable.Rows[i][7]}";
                    lbl_Provider.Text = $"Постацщик: {dataTable.Rows[i][8]}";
                    if (dataTable.Rows[i][6].ToString() != "")
                    {
                        box_Image.Image = Image.FromFile($@"{dataTable.Rows[i][6]}");
                    }
                    else
                    {
                        box_Image.Image = Image.FromFile($@"Images\picture.png");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex}");
            }

        }
    }
}
