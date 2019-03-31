namespace execl_tool
{
    partial class confForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.table_id = new CCWin.SkinControl.SkinLabel();
            this.show_name = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.table_list = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.modify_Button = new CCWin.SkinControl.SkinButton();
            this.add_Button = new CCWin.SkinControl.SkinButton();
            this.del_button = new CCWin.SkinControl.SkinButton();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.show_table = new CCWin.SkinControl.SkinDataGridView();
            this.skinPanel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_table)).BeginInit();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.table_id);
            this.skinPanel1.Controls.Add(this.show_name);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.table_list);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.Controls.Add(this.modify_Button);
            this.skinPanel1.Controls.Add(this.add_Button);
            this.skinPanel1.Controls.Add(this.del_button);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 32);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(388, 103);
            this.skinPanel1.TabIndex = 0;
            // 
            // table_id
            // 
            this.table_id.AutoSize = true;
            this.table_id.BackColor = System.Drawing.Color.Transparent;
            this.table_id.BorderColor = System.Drawing.Color.White;
            this.table_id.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.table_id.Location = new System.Drawing.Point(13, 63);
            this.table_id.Name = "table_id";
            this.table_id.Size = new System.Drawing.Size(0, 17);
            this.table_id.TabIndex = 9;
            this.table_id.Visible = false;
            // 
            // show_name
            // 
            this.show_name.BackColor = System.Drawing.Color.Transparent;
            this.show_name.DownBack = null;
            this.show_name.Icon = null;
            this.show_name.IconIsButton = false;
            this.show_name.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.show_name.IsPasswordChat = '\0';
            this.show_name.IsSystemPasswordChar = false;
            this.show_name.Lines = new string[0];
            this.show_name.Location = new System.Drawing.Point(255, 13);
            this.show_name.Margin = new System.Windows.Forms.Padding(0);
            this.show_name.MaxLength = 32767;
            this.show_name.MinimumSize = new System.Drawing.Size(28, 28);
            this.show_name.MouseBack = null;
            this.show_name.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.show_name.Multiline = false;
            this.show_name.Name = "show_name";
            this.show_name.NormlBack = null;
            this.show_name.Padding = new System.Windows.Forms.Padding(5);
            this.show_name.ReadOnly = false;
            this.show_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.show_name.Size = new System.Drawing.Size(121, 28);
            // 
            // 
            // 
            this.show_name.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.show_name.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_name.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.show_name.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.show_name.SkinTxt.Name = "BaseText";
            this.show_name.SkinTxt.Size = new System.Drawing.Size(111, 18);
            this.show_name.SkinTxt.TabIndex = 0;
            this.show_name.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.show_name.SkinTxt.WaterText = "对应表名";
            this.show_name.TabIndex = 8;
            this.show_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.show_name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.show_name.WaterText = "对应表名";
            this.show_name.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(204, 21);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(47, 17);
            this.skinLabel2.TabIndex = 7;
            this.skinLabel2.Text = "数据表:";
            // 
            // table_list
            // 
            this.table_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_list.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.table_list.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.table_list.FormattingEnabled = true;
            this.table_list.Location = new System.Drawing.Point(65, 16);
            this.table_list.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.table_list.Name = "table_list";
            this.table_list.Size = new System.Drawing.Size(114, 25);
            this.table_list.TabIndex = 6;
            this.table_list.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(13, 21);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(47, 17);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "数据表:";
            // 
            // modify_Button
            // 
            this.modify_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_Button.BackColor = System.Drawing.Color.Transparent;
            this.modify_Button.BaseColor = System.Drawing.Color.SteelBlue;
            this.modify_Button.BorderColor = System.Drawing.Color.Blue;
            this.modify_Button.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.modify_Button.DownBack = null;
            this.modify_Button.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.modify_Button.ForeColor = System.Drawing.Color.Azure;
            this.modify_Button.GlowColor = System.Drawing.Color.SkyBlue;
            this.modify_Button.InnerBorderColor = System.Drawing.Color.DodgerBlue;
            this.modify_Button.Location = new System.Drawing.Point(241, 63);
            this.modify_Button.MouseBack = null;
            this.modify_Button.Name = "modify_Button";
            this.modify_Button.NormlBack = null;
            this.modify_Button.Radius = 15;
            this.modify_Button.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.modify_Button.Size = new System.Drawing.Size(66, 28);
            this.modify_Button.TabIndex = 4;
            this.modify_Button.Text = "修改对应";
            this.modify_Button.UseVisualStyleBackColor = false;
            this.modify_Button.Click += new System.EventHandler(this.modify_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_Button.BackColor = System.Drawing.Color.Transparent;
            this.add_Button.BaseColor = System.Drawing.Color.SteelBlue;
            this.add_Button.BorderColor = System.Drawing.Color.Blue;
            this.add_Button.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.add_Button.DownBack = null;
            this.add_Button.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.add_Button.ForeColor = System.Drawing.Color.Azure;
            this.add_Button.GlowColor = System.Drawing.Color.SkyBlue;
            this.add_Button.InnerBorderColor = System.Drawing.Color.DodgerBlue;
            this.add_Button.Location = new System.Drawing.Point(170, 63);
            this.add_Button.MouseBack = null;
            this.add_Button.Name = "add_Button";
            this.add_Button.NormlBack = null;
            this.add_Button.Radius = 15;
            this.add_Button.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.add_Button.Size = new System.Drawing.Size(66, 28);
            this.add_Button.TabIndex = 3;
            this.add_Button.Text = "新增对应";
            this.add_Button.UseVisualStyleBackColor = false;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // del_button
            // 
            this.del_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.del_button.BackColor = System.Drawing.Color.Transparent;
            this.del_button.BaseColor = System.Drawing.Color.SteelBlue;
            this.del_button.BorderColor = System.Drawing.Color.Blue;
            this.del_button.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.del_button.DownBack = null;
            this.del_button.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.del_button.ForeColor = System.Drawing.Color.Azure;
            this.del_button.GlowColor = System.Drawing.Color.SkyBlue;
            this.del_button.InnerBorderColor = System.Drawing.Color.DodgerBlue;
            this.del_button.Location = new System.Drawing.Point(313, 63);
            this.del_button.MouseBack = null;
            this.del_button.Name = "del_button";
            this.del_button.NormlBack = null;
            this.del_button.Radius = 15;
            this.del_button.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.del_button.Size = new System.Drawing.Size(63, 28);
            this.del_button.TabIndex = 2;
            this.del_button.Text = "删除对应";
            this.del_button.UseVisualStyleBackColor = false;
            this.del_button.Click += new System.EventHandler(this.del_button_Click);
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.skinButton4);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(4, 356);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(388, 48);
            this.skinPanel2.TabIndex = 1;
            // 
            // skinButton4
            // 
            this.skinButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.BaseColor = System.Drawing.Color.SteelBlue;
            this.skinButton4.BorderColor = System.Drawing.Color.Blue;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.DownBaseColor = System.Drawing.Color.SkyBlue;
            this.skinButton4.ForeColor = System.Drawing.Color.Azure;
            this.skinButton4.GlowColor = System.Drawing.Color.SkyBlue;
            this.skinButton4.InnerBorderColor = System.Drawing.Color.DodgerBlue;
            this.skinButton4.Location = new System.Drawing.Point(284, 10);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Radius = 15;
            this.skinButton4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton4.Size = new System.Drawing.Size(92, 28);
            this.skinButton4.TabIndex = 9;
            this.skinButton4.Text = "关闭";
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // show_table
            // 
            this.show_table.AllowUserToAddRows = false;
            this.show_table.AllowUserToDeleteRows = false;
            this.show_table.AllowUserToResizeColumns = false;
            this.show_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.show_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.show_table.BackgroundColor = System.Drawing.SystemColors.Window;
            this.show_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.show_table.ColumnFont = null;
            this.show_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.show_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.show_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_table.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.show_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.show_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_table.EnableHeadersVisualStyles = false;
            this.show_table.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.show_table.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.show_table.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.show_table.Location = new System.Drawing.Point(4, 135);
            this.show_table.MultiSelect = false;
            this.show_table.Name = "show_table";
            this.show_table.ReadOnly = true;
            this.show_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.show_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.show_table.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.show_table.RowTemplate.Height = 23;
            this.show_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.show_table.Size = new System.Drawing.Size(388, 221);
            this.show_table.TabIndex = 2;
            this.show_table.TitleBack = null;
            this.show_table.TitleBackColorBegin = System.Drawing.Color.White;
            this.show_table.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.show_table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.show_table_CellMouseClick);
            // 
            // confForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.SteelBlue;
            this.CaptionBackColorTop = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(396, 408);
            this.Controls.Add(this.show_table);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.skinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "confForm";
            this.ShowDrawIcon = false;
            this.Text = "设置";
            this.TitleCenter = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.confForm_FormClosing);
            this.Load += new System.EventHandler(this.confForm_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.show_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinButton modify_Button;
        private CCWin.SkinControl.SkinButton add_Button;
        private CCWin.SkinControl.SkinButton del_button;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinComboBox table_list;
        private CCWin.SkinControl.SkinTextBox show_name;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinDataGridView show_table;
        private CCWin.SkinControl.SkinLabel table_id;
    }
}