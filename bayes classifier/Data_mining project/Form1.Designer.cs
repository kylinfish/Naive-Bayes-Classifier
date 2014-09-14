using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_mining_project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.s_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iris_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predicted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.s_length_m_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_width_m_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_length_m_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_width_m_v = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Prediected_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prediected_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(787, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "◎Claissify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(95, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(392, 33);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox2.Location = new System.Drawing.Point(679, 198);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(419, 278);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(200)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_length,
            this.s_width,
            this.p_length,
            this.p_width,
            this.iris_class,
            this.Predicted});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(24, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(649, 278);
            this.dataGridView1.TabIndex = 8;
            // 
            // s_length
            // 
            this.s_length.HeaderText = "sepal length";
            this.s_length.Name = "s_length";
            // 
            // s_width
            // 
            this.s_width.HeaderText = "sepal width";
            this.s_width.Name = "s_width";
            // 
            // p_length
            // 
            this.p_length.HeaderText = "petal length";
            this.p_length.Name = "p_length";
            // 
            // p_width
            // 
            this.p_width.HeaderText = "petal width";
            this.p_width.Name = "p_width";
            // 
            // iris_class
            // 
            this.iris_class.HeaderText = "Actural Class";
            this.iris_class.Name = "iris_class";
            // 
            // Predicted
            // 
            this.Predicted.HeaderText = "Predicted Class";
            this.Predicted.Name = "Predicted";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(200)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_length_m_v,
            this.s_width_m_v,
            this.p_length_m_v,
            this.p_width_m_v});
            this.dataGridView2.Location = new System.Drawing.Point(76, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(847, 115);
            this.dataGridView2.TabIndex = 9;
            // 
            // s_length_m_v
            // 
            this.s_length_m_v.HeaderText = "speal length \'s ( mean / variance )";
            this.s_length_m_v.Name = "s_length_m_v";
            this.s_length_m_v.Width = 200;
            // 
            // s_width_m_v
            // 
            this.s_width_m_v.HeaderText = "speal width \'s  ( mean / variance )";
            this.s_width_m_v.Name = "s_width_m_v";
            this.s_width_m_v.Width = 200;
            // 
            // p_length_m_v
            // 
            this.p_length_m_v.HeaderText = "petal length \'s  ( mean / variance )";
            this.p_length_m_v.Name = "p_length_m_v";
            this.p_length_m_v.Width = 200;
            // 
            // p_width_m_v
            // 
            this.p_width_m_v.HeaderText = "petal width \'s ( mean / variance )";
            this.p_width_m_v.Name = "p_width_m_v";
            this.p_width_m_v.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "setosa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(5, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "versicolor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "virginica";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox3.Location = new System.Drawing.Point(710, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 33);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(608, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Test 筆數:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(228, 174);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Testing Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(794, 174);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(182, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Probability of Record";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "DataPath:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(499, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 19;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prediected_P,
            this.Prediected_N});
            this.dataGridView4.Location = new System.Drawing.Point(24, 482);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(329, 263);
            this.dataGridView4.TabIndex = 21;
            // 
            // Prediected_P
            // 
            this.Prediected_P.HeaderText = "Prediected_P";
            this.Prediected_P.Name = "Prediected_P";
            // 
            // Prediected_N
            // 
            this.Prediected_N.HeaderText = "Prediected_N";
            this.Prediected_N.Name = "Prediected_N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1138, 769);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Naive Bates Classifier(Beta)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_length_m_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_width_m_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_length_m_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_width_m_v;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_width;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_width;
        private System.Windows.Forms.DataGridViewTextBoxColumn iris_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predicted;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
        private DataGridView dataGridView4;
        private DataGridViewTextBoxColumn Prediected_P;
        private DataGridViewTextBoxColumn Prediected_N;


        /*-------------------------------------------------*/
        public struct Iris
        {
            public float s_length;
            public float s_width;
            public float p_length;
            public float p_width;
            public string iris_class;
        }

        public List<Iris> dataSet = new List<Iris>();
        public List<Iris> testData = new List<Iris>();
        public List<int> testData_id = new List<int>();
        public List<string> result = new List<string>();
        public List<int> bagging_test = new List<int>();
        OpenFileDialog openFileDlg = new OpenFileDialog();
        static float mean_a1_set, mean_a1_ver, mean_a1_vir;
        static float mean_a2_set, mean_a2_ver, mean_a2_vir;
        static float mean_a3_set, mean_a3_ver, mean_a3_vir;
        static float mean_a4_set, mean_a4_ver, mean_a4_vir;
        static double var_a1_set, var_a1_ver, var_a1_vir;
        static double var_a2_set, var_a2_ver, var_a2_vir;
        static double var_a3_set, var_a3_ver, var_a3_vir;
        static double var_a4_set, var_a4_ver, var_a4_vir;
        static string filepath ="";
        static int test_count = 10;


        /*-------------------------------------------------*/
    }
}

