using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            string idpattern = @"^[a-zA-Z0-9]{4,}@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if(!Regex.IsMatch(idtext.Text, idpattern))
            {
                MessageBox.Show("아이디 형식이 맞지 않습니다 ex)example@naver.com");
                return;
            }

            string namepattern = @"^[가-힣]{2,}$";
            if (!Regex.IsMatch(nametext.Text, namepattern))
            {
                MessageBox.Show("이름 형식이 맞지 않습니다 ex)홍길동");
            }

            string pwpattern = @"^[a-zA-Z0-9]{8,}$";
            if (!Regex.IsMatch(pwtext.Text, pwpattern))
            {
                MessageBox.Show("비밀번호는 영문+숫자 8자리이상입니다");
                return;
            }

            if (pwtext.Text != chkpwtext.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다");
                return;
            }

            string phonepattern = @"^010[0-9]{4}[0-9]{4}$";
            if (!Regex.IsMatch(phonetext.Text, phonepattern))
            {
                MessageBox.Show("전화번호 형식이 맞지 않습니다 ex)010xxxxxxxx");
                return;
            }

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
                if(body == "이미 사용중인 아이디 입니다")
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
