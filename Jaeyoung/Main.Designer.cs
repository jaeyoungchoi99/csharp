namespace jaeyoung
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            dataGridView1 = new DataGridView();
            BT_search = new Button();
            BT_modify = new Button();
            BT_delete = new Button();
            BT_save = new Button();
            BT_add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1674, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1674, 513);
            dataGridView1.TabIndex = 2;
            // 
            // BT_search
            // 
            BT_search.Location = new Point(668, 27);
            BT_search.Name = "BT_search";
            BT_search.Size = new Size(192, 90);
            BT_search.TabIndex = 3;
            BT_search.Text = "조회";
            BT_search.UseVisualStyleBackColor = true;
            BT_search.Click += BT_search_Click;
            // 
            // BT_modify
            // 
            BT_modify.Location = new Point(1064, 27);
            BT_modify.Name = "BT_modify";
            BT_modify.Size = new Size(192, 90);
            BT_modify.TabIndex = 4;
            BT_modify.Text = "수정";
            BT_modify.UseVisualStyleBackColor = true;
            BT_modify.Click += BT_modify_Click;
            // 
            // BT_delete
            // 
            BT_delete.Location = new Point(1262, 27);
            BT_delete.Name = "BT_delete";
            BT_delete.Size = new Size(192, 90);
            BT_delete.TabIndex = 5;
            BT_delete.Text = "삭제";
            BT_delete.UseVisualStyleBackColor = true;
            BT_delete.Click += BT_delete_Click;
            // 
            // BT_save
            // 
            BT_save.Location = new Point(1460, 27);
            BT_save.Name = "BT_save";
            BT_save.Size = new Size(192, 90);
            BT_save.TabIndex = 6;
            BT_save.Text = "저장";
            BT_save.UseVisualStyleBackColor = true;
            // 
            // BT_add
            // 
            BT_add.Location = new Point(866, 27);
            BT_add.Name = "BT_add";
            BT_add.Size = new Size(192, 90);
            BT_add.TabIndex = 7;
            BT_add.Text = "추가";
            BT_add.UseVisualStyleBackColor = true;
            BT_add.Click += BT_add_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1674, 646);
            Controls.Add(BT_add);
            Controls.Add(BT_save);
            Controls.Add(BT_delete);
            Controls.Add(BT_modify);
            Controls.Add(BT_search);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "사용자관리";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private DataGridView dataGridView1;
        private Button BT_search;
        private Button BT_modify;
        private Button BT_delete;
        private Button BT_save;
        private Button BT_add;
    }
}