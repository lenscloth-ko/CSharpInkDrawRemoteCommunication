namespace InkdrawRemoteComWin
{
    partial class frmTest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMESOrder = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblLine01 = new System.Windows.Forms.Label();
            this.lblLine02 = new System.Windows.Forms.Label();
            this.lblLine03 = new System.Windows.Forms.Label();
            this.lblLine04 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMESOrder)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMESOrder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MES 마킹지시";
            // 
            // dgvMESOrder
            // 
            this.dgvMESOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMESOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMESOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvMESOrder.MultiSelect = false;
            this.dgvMESOrder.Name = "dgvMESOrder";
            this.dgvMESOrder.ReadOnly = true;
            this.dgvMESOrder.RowTemplate.Height = 23;
            this.dgvMESOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMESOrder.Size = new System.Drawing.Size(879, 171);
            this.dgvMESOrder.TabIndex = 0;
            this.dgvMESOrder.DoubleClick += new System.EventHandler(this.dgvMESOrder_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblLine01, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLine02, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLine03, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLine04, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 209);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 362);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblLine01
            // 
            this.lblLine01.AutoSize = true;
            this.lblLine01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine01.Font = new System.Drawing.Font("굴림", 30F);
            this.lblLine01.Location = new System.Drawing.Point(3, 0);
            this.lblLine01.Name = "lblLine01";
            this.lblLine01.Size = new System.Drawing.Size(483, 90);
            this.lblLine01.TabIndex = 0;
            this.lblLine01.Text = "노즐1";
            // 
            // lblLine02
            // 
            this.lblLine02.AutoSize = true;
            this.lblLine02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine02.Font = new System.Drawing.Font("굴림", 30F);
            this.lblLine02.Location = new System.Drawing.Point(3, 90);
            this.lblLine02.Name = "lblLine02";
            this.lblLine02.Size = new System.Drawing.Size(483, 90);
            this.lblLine02.TabIndex = 1;
            this.lblLine02.Text = "노즐2";
            // 
            // lblLine03
            // 
            this.lblLine03.AutoSize = true;
            this.lblLine03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine03.Font = new System.Drawing.Font("굴림", 30F);
            this.lblLine03.Location = new System.Drawing.Point(3, 180);
            this.lblLine03.Name = "lblLine03";
            this.lblLine03.Size = new System.Drawing.Size(483, 90);
            this.lblLine03.TabIndex = 2;
            this.lblLine03.Text = "노즐3";
            // 
            // lblLine04
            // 
            this.lblLine04.AutoSize = true;
            this.lblLine04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine04.Font = new System.Drawing.Font("굴림", 30F);
            this.lblLine04.Location = new System.Drawing.Point(3, 270);
            this.lblLine04.Name = "lblLine04";
            this.lblLine04.Size = new System.Drawing.Size(483, 92);
            this.lblLine04.TabIndex = 3;
            this.lblLine04.Text = "노즐4";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("굴림", 30F);
            this.btnSend.Location = new System.Drawing.Point(510, 209);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(384, 180);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "마킹기 전달";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbxLog);
            this.groupBox2.Location = new System.Drawing.Point(507, 395);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 176);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // lbxLog
            // 
            this.lbxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxLog.FormattingEnabled = true;
            this.lbxLog.HorizontalScrollbar = true;
            this.lbxLog.ItemHeight = 12;
            this.lbxLog.Location = new System.Drawing.Point(3, 17);
            this.lbxLog.Name = "lbxLog";
            this.lbxLog.ScrollAlwaysVisible = true;
            this.lbxLog.Size = new System.Drawing.Size(381, 156);
            this.lbxLog.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMESOrder)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMESOrder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLine01;
        private System.Windows.Forms.Label lblLine02;
        private System.Windows.Forms.Label lblLine03;
        private System.Windows.Forms.Label lblLine04;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbxLog;
    }
}