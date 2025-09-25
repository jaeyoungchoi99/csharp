using Jaeyoung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaeyoung
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }



        private async void BT_search_Click(object sender, EventArgs e)
        {
            var api = new Api();

            var list = await api.GetData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = list;
        }

        private void BT_add_Click(object sender, EventArgs e)
        {
            Signup showsignup = new Signup();

            if (showsignup.ShowDialog() == DialogResult.OK)
            {
                BT_search.PerformClick();
            }
        }

        static string Txt(DataGridViewRow row, string col)
        {
            return Convert.ToString(row.Cells[col].FormattedValue);
        }

        private void BT_modify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("수정할 행을 선택하세요");
                return;
            }
            var row = dataGridView1.CurrentRow;

            string id = Txt(row, "u_id");
            string pw = Txt(row, "u_pw");
            string name = Txt(row, "u_name");
            string birth = Txt(row, "u_birth");
            string phone = Txt(row, "u_phone");

            Modify showmodify = new Modify(id, pw, name, birth, phone);
            if (showmodify.ShowDialog() == DialogResult.OK)
            {
                BT_search.PerformClick();
            }

        }

        private async void BT_delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 행을 선택하세요");
                return;
            }

            var row = dataGridView1.SelectedRows[0];
            var u_id = row.Cells["u_id"].Value.ToString();

            var api = new Api();
            var response = await api.Delete(u_id);

            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();

                if(body == "True")
                {
                    MessageBox.Show("삭제 완료");
                    dataGridView1.Rows.Remove(row);
                    BT_search.PerformClick();
                }
                if(body == "False")
                {
                    
                    MessageBox.Show("삭제 실패");
                }
            }
            
        }
    }
}
