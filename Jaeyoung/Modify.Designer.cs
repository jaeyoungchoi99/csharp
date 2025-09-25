namespace Jaeyoung
{
    partial class Modify
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
            dateTimePicker1 = new DateTimePicker();
            BT_cancel = new Button();
            BT_confirm = new Button();
            idtext = new TextBox();
            phonetext = new TextBox();
            chkpwtext = new TextBox();
            pwtext = new TextBox();
            nametext = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(283, 310);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(419, 39);
            dateTimePicker1.TabIndex = 28;
            // 
            // BT_cancel
            // 
            BT_cancel.Location = new Point(731, 301);
            BT_cancel.Name = "BT_cancel";
            BT_cancel.Size = new Size(216, 217);
            BT_cancel.TabIndex = 27;
            BT_cancel.Text = "취소";
            BT_cancel.UseVisualStyleBackColor = true;
            BT_cancel.Click += BT_cancel_Click;
            // 
            // BT_confirm
            // 
            BT_confirm.Location = new Point(731, 75);
            BT_confirm.Name = "BT_confirm";
            BT_confirm.Size = new Size(216, 208);
            BT_confirm.TabIndex = 26;
            BT_confirm.Text = "확인";
            BT_confirm.UseVisualStyleBackColor = true;
            BT_confirm.Click += BT_confirm_Click;
            // 
            // idtext
            // 
            idtext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            idtext.Location = new Point(283, 75);
            idtext.Name = "idtext";
            idtext.Size = new Size(419, 57);
            idtext.TabIndex = 25;
            // 
            // phonetext
            // 
            phonetext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            phonetext.Location = new Point(283, 377);
            phonetext.Name = "phonetext";
            phonetext.Size = new Size(419, 57);
            phonetext.TabIndex = 24;
            // 
            // chkpwtext
            // 
            chkpwtext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkpwtext.Location = new Point(283, 226);
            chkpwtext.Name = "chkpwtext";
            chkpwtext.Size = new Size(419, 57);
            chkpwtext.TabIndex = 23;
            // 
            // pwtext
            // 
            pwtext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            pwtext.Location = new Point(283, 149);
            pwtext.Name = "pwtext";
            pwtext.Size = new Size(419, 57);
            pwtext.TabIndex = 22;
            // 
            // nametext
            // 
            nametext.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            nametext.Location = new Point(283, 461);
            nametext.Name = "nametext";
            nametext.Size = new Size(419, 57);
            nametext.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label6.Location = new Point(20, 75);
            label6.Name = "label6";
            label6.Size = new Size(133, 50);
            label6.TabIndex = 20;
            label6.Text = "아이디";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label5.Location = new Point(20, 377);
            label5.Name = "label5";
            label5.Size = new Size(170, 50);
            label5.TabIndex = 19;
            label5.Text = "전화번호";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label4.Location = new Point(20, 226);
            label4.Name = "label4";
            label4.Size = new Size(257, 50);
            label4.TabIndex = 18;
            label4.Text = "비밀번호 확인";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label3.Location = new Point(20, 149);
            label3.Name = "label3";
            label3.Size = new Size(170, 50);
            label3.TabIndex = 17;
            label3.Text = "비밀번호";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(20, 301);
            label2.Name = "label2";
            label2.Size = new Size(170, 50);
            label2.TabIndex = 16;
            label2.Text = "생년월일";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.Location = new Point(20, 461);
            label1.Name = "label1";
            label1.Size = new Size(96, 50);
            label1.TabIndex = 15;
            label1.Text = "이름";
            // 
            // Modify
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
            Name = "Modify";
            Text = "Modify";
            Load += Modify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button BT_cancel;
        private Button BT_confirm;
        private TextBox idtext;
        private TextBox phonetext;
        private TextBox chkpwtext;
        private TextBox pwtext;
        private TextBox nametext;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}