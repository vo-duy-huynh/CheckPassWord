namespace CheckPass
{
    partial class PASS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PASS));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtClear = new System.Windows.Forms.Button();
            this.BtCopyPass = new System.Windows.Forms.Button();
            this.LbUserCode = new System.Windows.Forms.Label();
            this.LbUserName = new System.Windows.Forms.Label();
            this.LbPassWord = new System.Windows.Forms.Label();
            this.TbUserName = new System.Windows.Forms.TextBox();
            this.TbUserCode = new System.Windows.Forms.TextBox();
            this.TbPhone = new System.Windows.Forms.TextBox();
            this.TbPassWord = new System.Windows.Forms.TextBox();
            this.LbPhone = new System.Windows.Forms.Label();
            this.LbGroup = new System.Windows.Forms.Label();
            this.CbGroup = new System.Windows.Forms.ComboBox();
            this.DgMain = new System.Windows.Forms.DataGridView();
            this.CkDatabaseNow = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtPrt = new System.Windows.Forms.Button();
            this.BtSearch = new System.Windows.Forms.Button();
            this.BtEsc = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusinessGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMain)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1323, 528);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DgMain);
            this.splitContainer2.Size = new System.Drawing.Size(1323, 380);
            this.splitContainer2.SplitterDistance = 335;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.35443F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.64557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.Controls.Add(this.BtClear, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BtCopyPass, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LbUserCode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LbUserName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LbPassWord, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbUserName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbUserCode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbPhone, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbPassWord, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LbPhone, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LbGroup, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CbGroup, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 328);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtClear
            // 
            this.BtClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtClear.Location = new System.Drawing.Point(140, 281);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(102, 35);
            this.BtClear.TabIndex = 2;
            this.BtClear.Text = "Clear";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // BtCopyPass
            // 
            this.BtCopyPass.Location = new System.Drawing.Point(319, 111);
            this.BtCopyPass.Name = "BtCopyPass";
            this.BtCopyPass.Size = new System.Drawing.Size(85, 35);
            this.BtCopyPass.TabIndex = 3;
            this.BtCopyPass.Text = "CopyPW";
            this.BtCopyPass.UseVisualStyleBackColor = true;
            this.BtCopyPass.Click += new System.EventHandler(this.BtCopyPass_Click);
            // 
            // LbUserCode
            // 
            this.LbUserCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbUserCode.AutoSize = true;
            this.LbUserCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserCode.Location = new System.Drawing.Point(58, 72);
            this.LbUserCode.Name = "LbUserCode";
            this.LbUserCode.Size = new System.Drawing.Size(76, 18);
            this.LbUserCode.TabIndex = 14;
            this.LbUserCode.Text = "UserCode";
            // 
            // LbUserName
            // 
            this.LbUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbUserName.AutoSize = true;
            this.LbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUserName.Location = new System.Drawing.Point(54, 18);
            this.LbUserName.Name = "LbUserName";
            this.LbUserName.Size = new System.Drawing.Size(80, 18);
            this.LbUserName.TabIndex = 13;
            this.LbUserName.Text = "UserName";
            // 
            // LbPassWord
            // 
            this.LbPassWord.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbPassWord.AutoSize = true;
            this.LbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassWord.Location = new System.Drawing.Point(55, 126);
            this.LbPassWord.Name = "LbPassWord";
            this.LbPassWord.Size = new System.Drawing.Size(79, 18);
            this.LbPassWord.TabIndex = 15;
            this.LbPassWord.Text = "PassWord";
            // 
            // TbUserName
            // 
            this.TbUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbUserName.Location = new System.Drawing.Point(140, 16);
            this.TbUserName.Name = "TbUserName";
            this.TbUserName.Size = new System.Drawing.Size(173, 22);
            this.TbUserName.TabIndex = 9;
            // 
            // TbUserCode
            // 
            this.TbUserCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbUserCode.Location = new System.Drawing.Point(140, 70);
            this.TbUserCode.Name = "TbUserCode";
            this.TbUserCode.Size = new System.Drawing.Size(173, 22);
            this.TbUserCode.TabIndex = 10;
            // 
            // TbPhone
            // 
            this.TbPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbPhone.Enabled = false;
            this.TbPhone.Location = new System.Drawing.Point(140, 178);
            this.TbPhone.Name = "TbPhone";
            this.TbPhone.Size = new System.Drawing.Size(173, 22);
            this.TbPhone.TabIndex = 12;
            // 
            // TbPassWord
            // 
            this.TbPassWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbPassWord.Enabled = false;
            this.TbPassWord.Location = new System.Drawing.Point(140, 124);
            this.TbPassWord.Name = "TbPassWord";
            this.TbPassWord.Size = new System.Drawing.Size(173, 22);
            this.TbPassWord.TabIndex = 11;
            // 
            // LbPhone
            // 
            this.LbPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbPhone.AutoSize = true;
            this.LbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPhone.Location = new System.Drawing.Point(83, 180);
            this.LbPhone.Name = "LbPhone";
            this.LbPhone.Size = new System.Drawing.Size(51, 18);
            this.LbPhone.TabIndex = 16;
            this.LbPhone.Text = "Phone";
            // 
            // LbGroup
            // 
            this.LbGroup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LbGroup.AutoSize = true;
            this.LbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGroup.Location = new System.Drawing.Point(15, 234);
            this.LbGroup.Name = "LbGroup";
            this.LbGroup.Size = new System.Drawing.Size(119, 18);
            this.LbGroup.TabIndex = 19;
            this.LbGroup.Text = "BussinessGroup";
            // 
            // CbGroup
            // 
            this.CbGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbGroup.FormattingEnabled = true;
            this.CbGroup.Location = new System.Drawing.Point(140, 230);
            this.CbGroup.Name = "CbGroup";
            this.CbGroup.Size = new System.Drawing.Size(173, 26);
            this.CbGroup.TabIndex = 18;
            this.CbGroup.SelectedIndexChanged += new System.EventHandler(this.CbGroup_SelectionChangeCommitted);
            // 
            // DgMain
            // 
            this.DgMain.AllowUserToAddRows = false;
            this.DgMain.AllowUserToDeleteRows = false;
            this.DgMain.BackgroundColor = System.Drawing.Color.White;
            this.DgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.UserCode,
            this.BusinessGroup,
            this.PassWord,
            this.Phone});
            this.DgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgMain.Location = new System.Drawing.Point(0, 0);
            this.DgMain.Name = "DgMain";
            this.DgMain.RowHeadersWidth = 51;
            this.DgMain.RowTemplate.Height = 24;
            this.DgMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgMain.Size = new System.Drawing.Size(982, 378);
            this.DgMain.TabIndex = 0;
            this.DgMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgMain_CellContentClick);
            // 
            // CkDatabaseNow
            // 
            this.CkDatabaseNow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkDatabaseNow.AutoSize = true;
            this.CkDatabaseNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkDatabaseNow.Location = new System.Drawing.Point(14, 40);
            this.CkDatabaseNow.Name = "CkDatabaseNow";
            this.CkDatabaseNow.Size = new System.Drawing.Size(153, 24);
            this.CkDatabaseNow.TabIndex = 1;
            this.CkDatabaseNow.Text = "Dữ liệu mới nhất";
            this.CkDatabaseNow.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.7592F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.07358F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.CkDatabaseNow, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtEsc, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtPrt, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtSearch, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(279, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(652, 105);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtPrt
            // 
            this.BtPrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtPrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPrt.Location = new System.Drawing.Point(353, 28);
            this.BtPrt.Name = "BtPrt";
            this.BtPrt.Size = new System.Drawing.Size(106, 49);
            this.BtPrt.TabIndex = 2;
            this.BtPrt.Text = "EXCEL";
            this.BtPrt.UseVisualStyleBackColor = true;
            this.BtPrt.Click += new System.EventHandler(this.BtPrt_Click);
            // 
            // BtSearch
            // 
            this.BtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearch.Location = new System.Drawing.Point(200, 28);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(106, 49);
            this.BtSearch.TabIndex = 0;
            this.BtSearch.Text = "SEARCH";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.BtSearch_Click);
            // 
            // BtEsc
            // 
            this.BtEsc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEsc.Location = new System.Drawing.Point(517, 28);
            this.BtEsc.Name = "BtEsc";
            this.BtEsc.Size = new System.Drawing.Size(106, 49);
            this.BtEsc.TabIndex = 1;
            this.BtEsc.Text = "ESC";
            this.BtEsc.UseVisualStyleBackColor = true;
            this.BtEsc.Click += new System.EventHandler(this.BtEsc_Click);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "UserName";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 125;
            // 
            // UserCode
            // 
            this.UserCode.DataPropertyName = "usercode";
            this.UserCode.HeaderText = "UserCode";
            this.UserCode.MinimumWidth = 6;
            this.UserCode.Name = "UserCode";
            this.UserCode.Width = 125;
            // 
            // BusinessGroup
            // 
            this.BusinessGroup.DataPropertyName = "businessgroup";
            this.BusinessGroup.HeaderText = "BusinessGroup";
            this.BusinessGroup.MinimumWidth = 6;
            this.BusinessGroup.Name = "BusinessGroup";
            this.BusinessGroup.Width = 125;
            // 
            // PassWord
            // 
            this.PassWord.DataPropertyName = "password";
            this.PassWord.HeaderText = "PassWord";
            this.PassWord.MinimumWidth = 6;
            this.PassWord.Name = "PassWord";
            this.PassWord.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // PASS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1323, 528);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PASS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PASS";
            this.Load += new System.EventHandler(this.PASS_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMain)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.Button BtEsc;
        private System.Windows.Forms.CheckBox CkDatabaseNow;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LbUserCode;
        private System.Windows.Forms.Label LbUserName;
        private System.Windows.Forms.Label LbPassWord;
        private System.Windows.Forms.TextBox TbUserName;
        private System.Windows.Forms.TextBox TbUserCode;
        private System.Windows.Forms.TextBox TbPhone;
        private System.Windows.Forms.TextBox TbPassWord;
        private System.Windows.Forms.Label LbPhone;
        private System.Windows.Forms.Label LbGroup;
        private System.Windows.Forms.ComboBox CbGroup;
        private System.Windows.Forms.DataGridView DgMain;
        private System.Windows.Forms.Button BtPrt;
        private System.Windows.Forms.Button BtClear;
        private System.Windows.Forms.Button BtCopyPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}

