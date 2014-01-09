namespace Swecockers
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BS = new System.Windows.Forms.BindingSource(this.components);
            this.BandBS = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bandSrchTbx = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bandInfoTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UrsprungTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bandCountTbx = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.bandStartYearTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bandNameTbx = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Button();
            this.BandDGV = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BandDGV)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bandSrchTbx);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.bandInfoTbx);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.UrsprungTbx);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.bandCountTbx);
            this.tabPage1.Controls.Add(this.Label2);
            this.tabPage1.Controls.Add(this.bandStartYearTbx);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bandNameTbx);
            this.tabPage1.Controls.Add(this.b);
            this.tabPage1.Controls.Add(this.BandDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(751, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bandSrchTbx
            // 
            this.bandSrchTbx.Location = new System.Drawing.Point(358, 347);
            this.bandSrchTbx.Name = "bandSrchTbx";
            this.bandSrchTbx.Size = new System.Drawing.Size(156, 20);
            this.bandSrchTbx.TabIndex = 32;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(439, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Rensa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Sök";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.bandSrchBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Ändra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bandChangeBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Ta bort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BandRemoveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Info";
            // 
            // bandInfoTbx
            // 
            this.bandInfoTbx.Location = new System.Drawing.Point(8, 347);
            this.bandInfoTbx.Name = "bandInfoTbx";
            this.bandInfoTbx.Size = new System.Drawing.Size(220, 20);
            this.bandInfoTbx.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ursprung:";
            // 
            // UrsprungTbx
            // 
            this.UrsprungTbx.Location = new System.Drawing.Point(128, 299);
            this.UrsprungTbx.Name = "UrsprungTbx";
            this.UrsprungTbx.Size = new System.Drawing.Size(100, 20);
            this.UrsprungTbx.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Antal Members:";
            // 
            // bandCountTbx
            // 
            this.bandCountTbx.Location = new System.Drawing.Point(8, 299);
            this.bandCountTbx.Name = "bandCountTbx";
            this.bandCountTbx.Size = new System.Drawing.Size(100, 20);
            this.bandCountTbx.TabIndex = 22;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(139, 244);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "Startår:";
            // 
            // bandStartYearTbx
            // 
            this.bandStartYearTbx.Location = new System.Drawing.Point(128, 260);
            this.bandStartYearTbx.Name = "bandStartYearTbx";
            this.bandStartYearTbx.Size = new System.Drawing.Size(100, 20);
            this.bandStartYearTbx.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bandnamn:";
            // 
            // bandNameTbx
            // 
            this.bandNameTbx.Location = new System.Drawing.Point(8, 260);
            this.bandNameTbx.Name = "bandNameTbx";
            this.bandNameTbx.Size = new System.Drawing.Size(100, 20);
            this.bandNameTbx.TabIndex = 18;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(234, 278);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 23);
            this.b.TabIndex = 17;
            this.b.Text = "Spara";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.bandAddBtn_Click);
            // 
            // BandDGV
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BandDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BandDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BandDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.BandDGV.Location = new System.Drawing.Point(6, 8);
            this.BandDGV.Name = "BandDGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BandDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BandDGV.Size = new System.Drawing.Size(653, 235);
            this.BandDGV.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(751, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(413, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(658, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Rensa";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(577, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Sök";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SweCockers Forsberg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BandBS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BandDGV)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BS;
        private System.Windows.Forms.BindingSource BandBS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bandInfoTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrsprungTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bandCountTbx;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox bandStartYearTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bandNameTbx;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.DataGridView BandDGV;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox bandSrchTbx;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
    }
}

