namespace InjectMethod
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Init_BuffSct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Msg_tb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Init_HenchBook = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.Init_WorldmapIcon = new System.Windows.Forms.Button();
            this.CreateMonster = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "在线翻译注入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "选择 Assembly-CSharp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "未选择默认D:\\My Documents\\Desktop\\Assembly-CSharp.dll";
            // 
            // Init_BuffSct
            // 
            this.Init_BuffSct.Location = new System.Drawing.Point(12, 104);
            this.Init_BuffSct.Name = "Init_BuffSct";
            this.Init_BuffSct.Size = new System.Drawing.Size(75, 23);
            this.Init_BuffSct.TabIndex = 3;
            this.Init_BuffSct.Text = "Init_BuffSct";
            this.Init_BuffSct.UseVisualStyleBackColor = true;
            this.Init_BuffSct.Click += new System.EventHandler(this.Init_BuffSct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "翻译:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "汉化:";
            // 
            // Msg_tb
            // 
            this.Msg_tb.BackColor = System.Drawing.Color.Beige;
            this.Msg_tb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Msg_tb.ForeColor = System.Drawing.Color.Fuchsia;
            this.Msg_tb.Location = new System.Drawing.Point(0, 237);
            this.Msg_tb.Multiline = true;
            this.Msg_tb.Name = "Msg_tb";
            this.Msg_tb.Size = new System.Drawing.Size(654, 96);
            this.Msg_tb.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Init_NpcModel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(236, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Init_SkillTooltipSct";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(414, 104);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Init_StringTable";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Init_Table_Hench_Base";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(178, 133);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Init_NpcGroupName";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(279, 133);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(83, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Init_MapSct";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(368, 133);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(105, 23);
            this.button9.TabIndex = 12;
            this.button9.Text = "Init_SkillBase";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(479, 133);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Init_WarpMachine";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 162);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(143, 23);
            this.button12.TabIndex = 15;
            this.button12.Text = "Init_Luridia_QuestSct";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Init_HenchBook
            // 
            this.Init_HenchBook.Location = new System.Drawing.Point(134, 194);
            this.Init_HenchBook.Name = "Init_HenchBook";
            this.Init_HenchBook.Size = new System.Drawing.Size(107, 23);
            this.Init_HenchBook.TabIndex = 16;
            this.Init_HenchBook.Text = "Init_HenchBook";
            this.Init_HenchBook.UseVisualStyleBackColor = true;
            this.Init_HenchBook.Click += new System.EventHandler(this.Init_HenchBook_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(161, 162);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(123, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "Init_HenchBookSkill";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(290, 162);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(118, 23);
            this.button15.TabIndex = 18;
            this.button15.Text = "Init_MonsterModel";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(414, 162);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(85, 23);
            this.button16.TabIndex = 19;
            this.button16.Text = "Init_Dungeon";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(505, 162);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(122, 23);
            this.button17.TabIndex = 20;
            this.button17.Text = "Init_ItemSct_Tab";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Init_WorldmapIcon
            // 
            this.Init_WorldmapIcon.Location = new System.Drawing.Point(12, 194);
            this.Init_WorldmapIcon.Name = "Init_WorldmapIcon";
            this.Init_WorldmapIcon.Size = new System.Drawing.Size(116, 23);
            this.Init_WorldmapIcon.TabIndex = 21;
            this.Init_WorldmapIcon.Text = "Init_WorldmapIcon";
            this.Init_WorldmapIcon.UseVisualStyleBackColor = true;
            this.Init_WorldmapIcon.Click += new System.EventHandler(this.Init_WorldmapIcon_Click);
            // 
            // CreateMonster
            // 
            this.CreateMonster.Location = new System.Drawing.Point(247, 194);
            this.CreateMonster.Name = "CreateMonster";
            this.CreateMonster.Size = new System.Drawing.Size(115, 23);
            this.CreateMonster.TabIndex = 22;
            this.CreateMonster.Text = "CreateMonster";
            this.CreateMonster.UseVisualStyleBackColor = true;
            this.CreateMonster.Click += new System.EventHandler(this.CreateMonster_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox1.Location = new System.Drawing.Point(51, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 16);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "每次执行注入前备份";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 333);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CreateMonster);
            this.Controls.Add(this.Init_WorldmapIcon);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.Init_HenchBook);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Msg_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Init_BuffSct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Init_BuffSct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Msg_tb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Init_HenchBook;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button Init_WorldmapIcon;
        private System.Windows.Forms.Button CreateMonster;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

