﻿namespace PUR2007NET
{
    partial class 品項明細
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(品項明細));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.naviDataGridView1 = new CosMoComponent.NaviDataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FDWG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FCDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSIZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGDEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGYM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUGNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.數量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FSMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMARK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CRDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMDUSR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AMDDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.帶入 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.其他資產 = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.naviDataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 37);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.naviDataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(892, 369);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 210;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 209;
            this.label1.Text = "金額會無條件進位。";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 20);
            this.label3.TabIndex = 208;
            this.label3.Text = "欲刪除明細，請按前面的序號，在按del。";
            // 
            // naviDataGridView1
            // 
            this.naviDataGridView1.AllowUserToAddRows = false;
            this.naviDataGridView1.AllowUserToOrderColumns = true;
            this.naviDataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.naviDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.naviDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.naviDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.FDWG,
            this.FCDS,
            this.FSIZ,
            this.BGDEP,
            this.BGYM,
            this.BUGNO,
            this.BGTYPE,
            this.數量,
            this.FSMT,
            this.金額,
            this.REMARK,
            this.CRUSER,
            this.CRDATE,
            this.AMDUSR,
            this.AMDDAY,
            this.NUM});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("新細明體", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.naviDataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.naviDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.naviDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.naviDataGridView1.Name = "naviDataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.naviDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.naviDataGridView1.RowHeadersWidth = 30;
            this.naviDataGridView1.RowTemplate.Height = 24;
            this.naviDataGridView1.Size = new System.Drawing.Size(892, 306);
            this.naviDataGridView1.TabIndex = 3;
            this.naviDataGridView1.儲存格合計 = null;
            this.naviDataGridView1.儲存格提示功能啟動或關閉 = false;
            this.naviDataGridView1.儲存格提示字串 = null;
            this.naviDataGridView1.儲存格為零值時抑制顯示 = false;
            this.naviDataGridView1.匯出檔名 = null;
            this.naviDataGridView1.匯出欄位名稱字串 = "ALL";
            this.naviDataGridView1.匯出結果字串 = "";
            this.naviDataGridView1.取得最大值欄位名稱 = "";
            this.naviDataGridView1.取得欄位最大值結果 = 0;
            this.naviDataGridView1.啟動三列一粗線 = false;
            this.naviDataGridView1.啟動儲存格日期選擇 = true;
            this.naviDataGridView1.啟動只顯示所設定欄位 = false;
            this.naviDataGridView1.啟動奇數資料列的儲存格顏色 = false;
            this.naviDataGridView1.啟動座標顏色顯示 = false;
            this.naviDataGridView1.指定儲存格停留欄位 = -1;
            this.naviDataGridView1.排序欄位 = null;
            this.naviDataGridView1.排序欄位顯示名稱 = null;
            this.naviDataGridView1.複製貼上列時忽略欄位 = null;
            this.naviDataGridView1.設計階段資料篩選指令 = null;
            this.naviDataGridView1.設計階段連結字串 = "Data Source=10.1.1.6;Initial Catalog=TEST;Integrated Security=False;User ID=;Pass" +
    "word=;MultipleActiveResultSets=True;Connect Timeout=0";
            this.naviDataGridView1.資料匯入XML功能啟動或關閉 = true;
            this.naviDataGridView1.資料匯出XML功能啟動或關閉 = true;
            this.naviDataGridView1.資料維護控制項 = null;
            this.naviDataGridView1.資料繫結時啟動自動增行功能 = true;
            this.naviDataGridView1.資料繫結時啟動自動增行序號欄位 = "";
            this.naviDataGridView1.資料繫結時空白列判定欄位 = "FQANO11";
            this.naviDataGridView1.關閉使用小算盤功能 = false;
            this.naviDataGridView1.關閉凍結目前行功能 = false;
            this.naviDataGridView1.關閉匯入XML格式檔案功能 = false;
            this.naviDataGridView1.關閉匯出XML格式檔案功能 = false;
            this.naviDataGridView1.關閉區塊複製至剪貼功能 = false;
            this.naviDataGridView1.關閉區塊複製至剪貼含抬頭功能 = false;
            this.naviDataGridView1.關閉右鍵複製至剪貼及匯出功能 = false;
            this.naviDataGridView1.關閉按鍵判斷處理程序 = false;
            this.naviDataGridView1.關閉排序功能 = false;
            this.naviDataGridView1.關閉換行鍵右移儲存格功能 = false;
            this.naviDataGridView1.關閉搜尋功能 = false;
            this.naviDataGridView1.關閉整體匯出EXCEL檔功能 = false;
            this.naviDataGridView1.關閉整體匯出格式EXCEL檔功能 = false;
            this.naviDataGridView1.關閉整體複製至剪貼功能 = false;
            this.naviDataGridView1.關閉目前位置插入一列功能 = false;
            this.naviDataGridView1.關閉目前列複製功能 = false;
            this.naviDataGridView1.關閉目前列貼上功能 = false;
            this.naviDataGridView1.關閉自訂顯示欄位設定功能 = false;
            this.naviDataGridView1.關閉菜單所有預設功能 = false;
            this.naviDataGridView1.關閉隠藏目前行功能 = false;
            this.naviDataGridView1.顯示列號 = true;
            this.naviDataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.naviDataGridView1_CellEnter);
            this.naviDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.naviDataGridView1_CellFormatting);
            this.naviDataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.naviDataGridView1_CellValidating);
            this.naviDataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.naviDataGridView1_CellValueChanged);
            this.naviDataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.naviDataGridView1_KeyDown);
            // 
            // UID
            // 
            this.UID.DataPropertyName = "UID";
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.Visible = false;
            // 
            // FDWG
            // 
            this.FDWG.DataPropertyName = "FDWG";
            this.FDWG.HeaderText = "品項";
            this.FDWG.Name = "FDWG";
            this.FDWG.Width = 150;
            // 
            // FCDS
            // 
            this.FCDS.DataPropertyName = "FCDS";
            this.FCDS.HeaderText = "名稱";
            this.FCDS.Name = "FCDS";
            this.FCDS.Width = 250;
            // 
            // FSIZ
            // 
            this.FSIZ.DataPropertyName = "FSIZ";
            this.FSIZ.HeaderText = "規格尺寸";
            this.FSIZ.Name = "FSIZ";
            this.FSIZ.Width = 200;
            // 
            // BGDEP
            // 
            this.BGDEP.DataPropertyName = "BGDEP";
            this.BGDEP.HeaderText = "預算部門";
            this.BGDEP.Name = "BGDEP";
            this.BGDEP.Visible = false;
            // 
            // BGYM
            // 
            this.BGYM.DataPropertyName = "BGYM";
            this.BGYM.HeaderText = "預算期間";
            this.BGYM.Name = "BGYM";
            this.BGYM.Visible = false;
            // 
            // BUGNO
            // 
            this.BUGNO.DataPropertyName = "BUGNO";
            this.BUGNO.HeaderText = "科目";
            this.BUGNO.Name = "BUGNO";
            this.BUGNO.Visible = false;
            // 
            // BGTYPE
            // 
            this.BGTYPE.DataPropertyName = "BGTYPE";
            this.BGTYPE.HeaderText = "BGTYPE";
            this.BGTYPE.Name = "BGTYPE";
            this.BGTYPE.Visible = false;
            // 
            // 數量
            // 
            this.數量.DataPropertyName = "數量";
            this.數量.HeaderText = "數量";
            this.數量.Name = "數量";
            this.數量.Width = 80;
            // 
            // FSMT
            // 
            this.FSMT.DataPropertyName = "FSMT";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FSMT.DefaultCellStyle = dataGridViewCellStyle7;
            this.FSMT.HeaderText = "單價";
            this.FSMT.Name = "FSMT";
            this.FSMT.Width = 80;
            // 
            // 金額
            // 
            this.金額.DataPropertyName = "金額";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.金額.DefaultCellStyle = dataGridViewCellStyle8;
            this.金額.HeaderText = "金額";
            this.金額.Name = "金額";
            this.金額.ReadOnly = true;
            // 
            // REMARK
            // 
            this.REMARK.DataPropertyName = "REMARK";
            this.REMARK.HeaderText = "備註";
            this.REMARK.Name = "REMARK";
            this.REMARK.Width = 300;
            // 
            // CRUSER
            // 
            this.CRUSER.DataPropertyName = "CRUSER";
            this.CRUSER.HeaderText = "CRUSER";
            this.CRUSER.Name = "CRUSER";
            this.CRUSER.Visible = false;
            // 
            // CRDATE
            // 
            this.CRDATE.DataPropertyName = "CRDATE";
            this.CRDATE.HeaderText = "CRDATE";
            this.CRDATE.Name = "CRDATE";
            this.CRDATE.Visible = false;
            // 
            // AMDUSR
            // 
            this.AMDUSR.DataPropertyName = "AMDUSR";
            this.AMDUSR.HeaderText = "AMDUSR";
            this.AMDUSR.Name = "AMDUSR";
            this.AMDUSR.Visible = false;
            // 
            // AMDDAY
            // 
            this.AMDDAY.DataPropertyName = "AMDDAY";
            this.AMDDAY.HeaderText = "AMDDAY";
            this.AMDDAY.Name = "AMDDAY";
            this.AMDDAY.Visible = false;
            // 
            // NUM
            // 
            this.NUM.DataPropertyName = "NUM";
            this.NUM.HeaderText = "序";
            this.NUM.Name = "NUM";
            this.NUM.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帶入,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.其他資產,
            this.button2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(892, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 帶入
            // 
            this.帶入.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.帶入.Image = ((System.Drawing.Image)(resources.GetObject("帶入.Image")));
            this.帶入.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.帶入.Name = "帶入";
            this.帶入.Size = new System.Drawing.Size(63, 34);
            this.帶入.Text = "確定帶入";
            this.帶入.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.帶入.Click += new System.EventHandler(this.帶入_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 34);
            this.toolStripButton1.Text = "選擇品項";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // 其他資產
            // 
            this.其他資產.Image = ((System.Drawing.Image)(resources.GetObject("其他資產.Image")));
            this.其他資產.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.其他資產.Name = "其他資產";
            this.其他資產.Size = new System.Drawing.Size(57, 34);
            this.其他資產.Text = "其他資產";
            this.其他資產.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.其他資產.Click += new System.EventHandler(this.其他資產_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 10F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 34);
            this.button2.Text = "關閉";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 品項明細
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 406);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "品項明細";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "品項明細";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.品項明細_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.naviDataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 帶入;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton button2;
        private CosMoComponent.NaviDataGridView naviDataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton 其他資產;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDWG;
        private System.Windows.Forms.DataGridViewTextBoxColumn FCDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSIZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGDEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGYM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BUGNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BGTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn 數量;
        private System.Windows.Forms.DataGridViewTextBoxColumn FSMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMARK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMDUSR;
        private System.Windows.Forms.DataGridViewTextBoxColumn AMDDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.Label label2;
    }
}