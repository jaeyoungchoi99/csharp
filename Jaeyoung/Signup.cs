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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        

        private async void BT_confirm_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            DateTime dt1 = dateTimePicker1.Value;
            String birth = dt1.ToString("yyyy-MM-dd");
            var user = new UserDto
            {
                u_id = idtext.Text,
                u_pw = pwtext.Text,
                u_name = nametext.Text,
                u_birth = birth,
                u_phone = phonetext.Text

            };

            var api = new Api();
            var response = await api.Signup(user);

            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                
                if(body == "True")
                {
                    MessageBox.Show("추가 성공");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
                if(body == "False")
                {
                    MessageBox.Show($"추가 실패: {body}");
                }
    
            }
            
            



        }

        private void BT_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
