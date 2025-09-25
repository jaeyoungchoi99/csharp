namespace jaeyoung
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nametext = new TextBox();
            pwtext = new TextBox();
            chkpwtext = new TextBox();
            phonetext = new TextBox();
            idtext = new TextBox();
            BT_confirm = new Button();
            BT_cancel = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(27, 465);
            label1.Name = "label1";
            label1.Size = new Size(96, 50);
            label1.TabIndex = 0;
            label1.Text = "이름";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(27, 305);
            label2.Name = "label2";
            label2.Size = new Size(170, 50);
            label2.TabIndex = 1;
            label2.Text = "생년월일";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(27, 153);
            label3.Name = "label3";
            label3.Size = new Size(170, 50);
            label3.TabIndex = 2;
            label3.Text = "비밀번호";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(27, 230);
            label4.Name = "label4";
            label4.Size = new Size(257, 50);
            label4.TabIndex = 3;
            label4.Text = "비밀번호 확인";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label5.Location = new Point(27, 381);
            label5.Name = "label5";
            label5.Size = new Size(170, 50);
            label5.TabIndex = 4;
            label5.Text = "전화번호";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.Location = new Point(27, 79);
            label6.Name = "label6";
            label6.Size = new Size(133, 50);
            label6.TabIndex = 5;
            label6.Text = "아이디";
            // 
            // nametext
            // 
            nametext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            nametext.Location = new Point(290, 465);
            nametext.Name = "nametext";
            nametext.Size = new Size(419, 57);
            nametext.TabIndex = 6;
            // 
            // pwtext
            // 
            pwtext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            pwtext.Location = new Point(290, 153);
            pwtext.Name = "pwtext";
            pwtext.PasswordChar = '*';
            pwtext.Size = new Size(419, 57);
            pwtext.TabIndex = 7;
            // 
            // chkpwtext
            // 
            chkpwtext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkpwtext.Location = new Point(290, 230);
            chkpwtext.Name = "chkpwtext";
            chkpwtext.PasswordChar = '*';
            chkpwtext.Size = new Size(419, 57);
            chkpwtext.TabIndex = 8;
            // 
            // phonetext
            // 
            phonetext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            phonetext.Location = new Point(290, 381);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(419, 57);
            phonetext.TabIndex = 10;
            // 
            // idtext
            // 
            idtext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            idtext.Location = new Point(290, 79);
            idtext.Name = "idtext";
            idtext.Size = new Size(419, 57);
            idtext.TabIndex = 11;
            // 
            // BT_confirm
            // 
            BT_confirm.Location = new Point(738, 79);
            BT_confirm.Name = "BT_confirm";
            BT_confirm.Size = new Size(216, 208);
            BT_confirm.TabIndex = 12;
            BT_confirm.Text = "확인";
            BT_confirm.UseVisualStyleBackColor = true;
            BT_confirm.Click += BT_confirm_Click;
            // 
            // BT_cancel
            // 
            BT_cancel.Location = new Point(738, 305);
            BT_cancel.Name = "BT_cancel";
            BT_cancel.Size = new Size(216, 217);
            BT_cancel.TabIndex = 13;
            BT_cancel.Text = "취소";
            BT_cancel.UseVisualStyleBackColor = true;
            BT_cancel.Click += BT_cancel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(290, 314);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(419, 39);
            dateTimePicker1.TabIndex = 14;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 592);
            Controls.Add(dateTimePicker1);
            Controls.Add(BT_cancel);
            Controls.Add(BT_confirm);
            Controls.Add(idtext);
            Controls.Add(phonetext);
            Controls.Add(chkpwtext);
            Controls.Add(pwtext);
            Controls.Add(nametext);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "사용자 추가";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nametext;
        private TextBox pwtext;
        private TextBox chkpwtext;
        private TextBox phonetext;
        private TextBox idtext;
        private Button BT_confirm;
        private Button BT_cancel;
        private DateTimePicker dateTimePicker1;
    }
}