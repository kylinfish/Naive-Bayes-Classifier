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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e) //load data btn
        {
            // select dataset
            if (this.openFileDlg.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDlg.FileName;
                this.textBox1.Text = filepath;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

                initial_state();  //clear componment tools
                if (this.textBox3.Text == "")
                {
                    test_count = 10;
                    this.textBox3.Text = "10";  //default test count = 10
                }
                else
                    test_count = Convert.ToInt16(this.textBox3.Text);  //get test count value
                sampleing();   //get data counts to bagging(testing)
                data_preprocessing();
                NavieClassifier();

        }

        private void initial_state()
        {
            result.Clear();
            this.dataGridView1.Rows.Clear();
            this.dataGridView2.Rows.Clear();
            this.textBox2.Text = ("");
            dataSet.Clear();
            testData.Clear();
        }

        private void sampleing()
        {
            testData_id = getTestData();   // get records randomly
            int count = 0;
            string line;
            // read iris dataset
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            while ((line = file.ReadLine()) != null)
            {
                string[] tmparr = line.Split(new Char[] { ',', '\t' });
                if (testData_id.Contains(count))
                {
                    Iris test = new Iris();
                    test.s_length = Convert.ToSingle(tmparr[0]);
                    test.s_width = Convert.ToSingle(tmparr[1]);
                    test.p_length = Convert.ToSingle(tmparr[2]);
                    test.p_width = Convert.ToSingle(tmparr[3]);
                    test.iris_class = tmparr[4];
                    testData.Add(test);
                    DataGridViewRow Row = new DataGridViewRow();
                    Row.CreateCells(dataGridView1);
                    Row.Cells[dataGridView1.Columns["s_length"].Index].Value = tmparr[0];
                    Row.Cells[dataGridView1.Columns["s_width"].Index].Value = tmparr[1];
                    Row.Cells[dataGridView1.Columns["p_length"].Index].Value = tmparr[2];
                    Row.Cells[dataGridView1.Columns["p_width"].Index].Value = tmparr[3];
                    Row.Cells[dataGridView1.Columns["iris_class"].Index].Value = tmparr[4];
                    dataGridView1.Rows.Add(Row);
                }
                Iris data = new Iris();
                data.s_length = Convert.ToSingle(tmparr[0]);
                data.s_width = Convert.ToSingle(tmparr[1]);
                data.p_length = Convert.ToSingle(tmparr[2]);
                data.p_width = Convert.ToSingle(tmparr[3]);
                data.iris_class = tmparr[4];
                dataSet.Add(data);
                count++;
            }
        }

        private void data_preprocessing()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(filepath);
            int count = 0;
            string line;
            while ((line = file.ReadLine()) != null)      // read iris dataset
            {
                string[] tmparr = line.Split(new Char[] { ',', '\t' });
                Iris data = new Iris();
                data.s_length = Convert.ToSingle(tmparr[0]);
                data.s_width = Convert.ToSingle(tmparr[1]);
                data.p_length = Convert.ToSingle(tmparr[2]);
                data.p_width = Convert.ToSingle(tmparr[3]);
                data.iris_class = tmparr[4];
                dataSet.Add(data);
                count++;
            }
            cal_mean();
            cal_variance();
            showToDatagried();
        }
        private void showToDatagried()
        {
            // show class => setosa
            DataGridViewRow setosa = new DataGridViewRow();
            setosa.CreateCells(dataGridView2);
            setosa.Cells[dataGridView2.Columns["s_length_m_v"].Index].Value = "mean: " + mean_a1_set + " variance: " + var_a1_set;
            setosa.Cells[dataGridView2.Columns["s_width_m_v"].Index].Value = "mean: " + mean_a2_set + " variance: " + var_a2_set;
            setosa.Cells[dataGridView2.Columns["p_length_m_v"].Index].Value = "mean: " + mean_a3_set + " variance: " + var_a3_set;
            setosa.Cells[dataGridView2.Columns["p_width_m_v"].Index].Value = "mean: " + mean_a4_set + " variance: " + var_a4_set;
            dataGridView2.Rows.Add(setosa);
            // show class => versicolor
            DataGridViewRow versicolor = new DataGridViewRow();
            versicolor.CreateCells(dataGridView2);
            versicolor.Cells[dataGridView2.Columns["s_length_m_v"].Index].Value = "mean: " + mean_a1_ver + " variance: " + var_a1_ver;
            versicolor.Cells[dataGridView2.Columns["s_width_m_v"].Index].Value = "mean: " + mean_a2_ver + " variance: " + var_a2_ver;
            versicolor.Cells[dataGridView2.Columns["p_length_m_v"].Index].Value = "mean: " + mean_a3_ver + " variance: " + var_a3_ver;
            versicolor.Cells[dataGridView2.Columns["p_width_m_v"].Index].Value = "mean: " + mean_a4_ver + " variance: " + var_a4_ver;
            dataGridView2.Rows.Add(versicolor);
            // show class => virginica
            DataGridViewRow virginica = new DataGridViewRow();
            virginica.CreateCells(dataGridView2);
            virginica.Cells[dataGridView2.Columns["s_length_m_v"].Index].Value = "mean: " + mean_a1_vir + " variance: " + var_a1_vir;
            virginica.Cells[dataGridView2.Columns["s_width_m_v"].Index].Value = "mean: " + mean_a2_vir + " variance: " + var_a2_vir;
            virginica.Cells[dataGridView2.Columns["p_length_m_v"].Index].Value = "mean: " + mean_a3_vir + " variance: " + var_a3_vir;
            virginica.Cells[dataGridView2.Columns["p_width_m_v"].Index].Value = "mean: " + mean_a4_vir + " variance: " + var_a4_vir;
            //virginica.Cells[dataGridView2.Colums['Prediected'].
            dataGridView2.Rows.Add(virginica);

        }
        private void cal_mean()
        {
            float total_m1_set = 0, total_m1_ver = 0, total_m1_vir = 0;
            float total_m2_set = 0, total_m2_ver = 0, total_m2_vir = 0;
            float total_m3_set = 0, total_m3_ver = 0, total_m3_vir = 0;
            float total_m4_set = 0, total_m4_ver = 0, total_m4_vir = 0;
            //----------------150---------------------
            for (int i = 0; i < dataSet.Count; i++)
            {

                {
                    if (i < 50)
                    {   //attribute => mean =>setosa 
                        total_m1_set += (dataSet[i].s_length);
                        total_m2_set += (dataSet[i].s_width);
                        total_m3_set += (dataSet[i].p_length);
                        total_m4_set += (dataSet[i].p_width);
                    }
                    else if (50 <= i && i < 100)
                    {    //attribute =>  mean =>versicolor 
                        total_m1_ver += (dataSet[i].s_length);
                        total_m2_ver += (dataSet[i].s_width);
                        total_m3_ver += (dataSet[i].p_length);
                        total_m4_ver += (dataSet[i].p_width);
                    }
                    else
                    {  //attribute =>  mean =>virginica 
                        total_m1_vir += (dataSet[i].s_length);
                        total_m2_vir += (dataSet[i].s_width);
                        total_m3_vir += (dataSet[i].p_length);
                        total_m4_vir += (dataSet[i].p_width);
                    }
                }
            }
            //----------------150-end--------------------
            int one_class_Count = 50;
            mean_a1_set = total_m1_set / one_class_Count;
            mean_a2_set = total_m2_set / one_class_Count;
            mean_a3_set = total_m3_set / one_class_Count;
            mean_a4_set = total_m4_set / one_class_Count;

            mean_a1_ver = total_m1_ver / one_class_Count;
            mean_a2_ver = total_m2_ver / one_class_Count;
            mean_a3_ver = total_m3_ver / one_class_Count;
            mean_a4_ver = total_m4_ver / one_class_Count;

            mean_a1_vir = total_m1_vir / one_class_Count;
            mean_a2_vir = total_m2_vir / one_class_Count;
            mean_a3_vir = total_m3_vir / one_class_Count;
            mean_a4_vir = total_m4_vir / one_class_Count;


        }
        private void cal_variance()
        {
            double total_v1_set = 0, total_v1_ver = 0, total_v1_vir = 0;
            double total_v2_set = 0, total_v2_ver = 0, total_v2_vir = 0;
            double total_v3_set = 0, total_v3_ver = 0, total_v3_vir = 0;
            double total_v4_set = 0, total_v4_ver = 0, total_v4_vir = 0;
            for (int i = 0; i < dataSet.Count; i++)
            {
                if (i < 50)
                {   //attribute => variance =>setosa 
                    total_v1_set += Math.Pow(dataSet[i].s_length - mean_a1_set, 2);
                    total_v2_set += Math.Pow(dataSet[i].s_width - mean_a2_set, 2);
                    total_v3_set += Math.Pow(dataSet[i].p_length - mean_a3_set, 2);
                    total_v4_set += Math.Pow(dataSet[i].p_width - mean_a4_set, 2);
                }
                else if (50 <= i && i < 100)
                {    //attribute =>  variance =>versicolor 
                    total_v1_ver += Math.Pow(dataSet[i].s_length - mean_a1_ver, 2);
                    total_v2_ver += Math.Pow(dataSet[i].s_width - mean_a2_ver, 2);
                    total_v3_ver += Math.Pow(dataSet[i].p_length - mean_a3_ver, 2);
                    total_v4_ver += Math.Pow(dataSet[i].p_width - mean_a4_ver, 2);
                }
                else
                {  //attribute =>  variance =>virginica 
                    total_v1_vir += Math.Pow(dataSet[i].s_length - mean_a1_vir, 2);
                    total_v2_vir += Math.Pow(dataSet[i].s_width - mean_a2_vir, 2);
                    total_v3_vir += Math.Pow(dataSet[i].p_length - mean_a3_vir, 2);
                    total_v4_vir += Math.Pow(dataSet[i].p_width - mean_a4_vir, 2);
                }
            }
            var_a1_set = var_Transform(total_v1_set);
            var_a2_set = var_Transform(total_v2_set);
            var_a3_set = var_Transform(total_v3_set);
            var_a4_set = var_Transform(total_v4_set);
            var_a1_ver = var_Transform(total_v1_ver);
            var_a2_ver = var_Transform(total_v2_ver);
            var_a3_ver = var_Transform(total_v3_ver);
            var_a4_ver = var_Transform(total_v4_ver);
            var_a1_vir = var_Transform(total_v1_vir);
            var_a2_vir = var_Transform(total_v2_vir);
            var_a3_vir = var_Transform(total_v3_vir);
            var_a4_vir = var_Transform(total_v4_vir);
        }
        private double var_Transform(double sumData)
        {
            int one_class_Count = 50 - 1;
            double ita = sumData / one_class_Count;
            ita = Math.Round(ita, 4);  //get double only 4 bits
            return ita;
        }

        private void NavieClassifier()
        {
            for (int i = 0; i < testData.Count; i++)
            {
                List<double> P = new List<double>();
                //--P(Test|class= setosa)
                double setosa_p1 = Normal_Distributaion(testData[i].s_length, mean_a1_set, var_a1_set);
                double setosa_p2 = Normal_Distributaion(testData[i].s_width, mean_a2_set, var_a2_set);
                double setosa_p3 = Normal_Distributaion(testData[i].p_length, mean_a3_set, var_a3_set);
                double setosa_p4 = Normal_Distributaion(testData[i].p_width, mean_a4_set, var_a4_set);
                double class_Setosa = setosa_p1 * setosa_p2 * setosa_p3 * setosa_p4;
                class_Setosa = Math.Round(class_Setosa, 4);
                this.textBox2.AppendText("P(test" + i + " | setosa)" + setosa_p1 + "\n");
                P.Add(class_Setosa);

                //--P(Test|class= versicolor)
                double versicolor_p1 = Normal_Distributaion(testData[i].s_length, mean_a1_ver, var_a1_ver);
                double versicolor_p2 = Normal_Distributaion(testData[i].s_width, mean_a2_ver, var_a2_ver);
                double versicolor_p3 = Normal_Distributaion(testData[i].p_length, mean_a3_ver, var_a3_ver);
                double versicolor_p4 = Normal_Distributaion(testData[i].p_width, mean_a4_ver, var_a4_ver);
                double class_Versicolor = versicolor_p1 * versicolor_p2 * versicolor_p3 * versicolor_p4;
                class_Versicolor = Math.Round(class_Versicolor, 4);
                this.textBox2.AppendText("P(test" + i + " | Versicolor)" + class_Versicolor + "\n");
                P.Add(class_Versicolor);

                //--P(Test|class= versicolor)
                double virginica_p1 = Normal_Distributaion(testData[i].s_length, mean_a1_vir, var_a1_vir);
                double virginica_p2 = Normal_Distributaion(testData[i].s_width, mean_a2_vir, var_a2_vir);
                double virginica_p3 = Normal_Distributaion(testData[i].p_length, mean_a3_vir, var_a3_vir);
                double virginica_p4 = Normal_Distributaion(testData[i].p_width, mean_a4_vir, var_a4_vir);
                double class_Virginica = virginica_p1 * virginica_p2 * virginica_p3 * virginica_p4;
                class_Virginica = Math.Round(class_Virginica, 4);
                this.textBox2.AppendText("P(test" + i + " | Virginica)" + class_Virginica + "\n");
                P.Add(class_Virginica);
                //P.Sort();
                if (P.Min() == class_Setosa)
                {
                    result.Add("Iris-setosa");
                    this.textBox2.AppendText("P(test" + i + "==>>  Setosa\n");
                    dataGridView1.Rows[i].Cells[dataGridView1.Columns["Predicted"].Index].Value = "Iris-setosa";

                }
                else if (P.Min() == class_Versicolor)
                {
                    result.Add("Iris-versicolor");
                    this.textBox2.AppendText("P(test" + i + "==>>  Versicolor\n\n");
                    dataGridView1.Rows[i].Cells[dataGridView1.Columns["Predicted"].Index].Value = "Iris-versicolor";

                }
                else if (P.Min() == class_Virginica)
                {
                    result.Add("Iris-virginica");
                    dataGridView1.Rows[i].Cells[dataGridView1.Columns["Predicted"].Index].Value = "Iris-virginica";
                    this.textBox2.AppendText("P(test" + i + "==>>  Virginica\n\n");
                }
                this.textBox2.AppendText("--------------------------------------\n");
            }
            confusion_matriex();
        }

        private double Normal_Distributaion(float condition, float mean, double variance)
        {
            double diff = Math.Pow((mean - condition), 2);
            double pow = diff / (2 * variance);
            double numerator = Math.Exp(pow);  //分子
            double denominator = Math.Sqrt(2 * Math.PI * variance);//分母
            double result = numerator / denominator;
            return Math.Round(result, 4);
        }
        private List<int> getTestData()
        {
            List<int> test = new List<int>();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            List<int> listLinq = new List<int>(Enumerable.Range(0, 149));
            listLinq = listLinq.OrderBy(o => rand.Next()).ToList<int>();
            for (int i = 0; i < test_count; i++)
            {
                test.Add(listLinq[i]);
                //this.textBox2.AppendText(sd + "\n");
            }
            return test;

        }
        private void confusion_matriex()
        {
            int t11 = 0, t10 = 0;
            for (int i = 0; i < test_count; i++)
            {
                if (testData[i].iris_class == result[i])
                    t11++;
                else
                    t10++;
            }
            DataGridViewRow positive = new DataGridViewRow();
            positive.CreateCells(dataGridView4);
            positive.Cells[dataGridView4.Columns["Prediected_P"].Index].Value = t11;
            positive.Cells[dataGridView4.Columns["Prediected_N"].Index].Value = t10;
            dataGridView4.Rows.Add(positive);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            initial_state();
            sampleing();      //get data counts to bagging(testing)
            data_preprocessing();
            NavieClassifier();
        }
    }
}

