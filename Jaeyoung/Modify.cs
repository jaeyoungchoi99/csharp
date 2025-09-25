using jaeyoung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaeyoung
{
    public partial class Modify : Form
    {
        public Modify(string id, string pw, string name, string birth, string phone)
        {
            InitializeComponent();
            idtext.Text = id; idtext.ReadOnly = true;
            pwtext.Text = pw;
            nametext.Text = name;
            dateTimePicker1.Text = birth;
            phonetext.Text = phone;
        }

        private void Modify_Load(object sender, EventArgs e)
        {
            

        }

        private void BT_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BT_confirm_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value;
            String birth = dt1.ToString("yyyy-MM-dd");
            var userdto = new UserDto
            {
                u_id = idtext.Text,
                u_pw = pwtext.Text,
                u_name = nametext.Text,
                u_birth = birth,
                u_phone = phonetext.Text
            };

            var api = new Api();
            var response = await api.Modify(userdto);

            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();

                if(body == "True")
                {
                    MessageBox.Show("수정 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                if(body == "False")
                {
                    MessageBox.Show("수정 실패");
                }
            }
        }
    }
}
