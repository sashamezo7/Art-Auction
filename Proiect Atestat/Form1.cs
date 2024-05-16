using Proiect_Atestat.Data_Base_AtestatDataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Atestat
{
    public partial class Form1 : Form
    {
        public int nr_tablou_licitat = 0;
        public int nr_sculptura_licitata = 0;

        public bool tablou=false;
        public Form1()
        {
            InitializeComponent();
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0,change);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.VerticalScroll.Value - flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, change);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[0];
            DataTable pret = data_Base_AtestatDataSet1.Picturi;
            label4.Text = Convert.ToString(pret.Rows[5]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Picturi;
            label5.Text = Convert.ToString(denumire.Rows[5]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Picturi;
            label8.Text = Convert.ToString(descriere.Rows[5]["Descriere"]);

            label10.Text = Convert.ToString(pret.Rows[5]["Pret"]); 

            label9.Visible = false;
            button8.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            button9.Visible = false;
            button14.Visible = false;

            nr_tablou_licitat = 6;
            tablou = true;
            label10.Text = "0";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel2.VerticalScroll.Value - flowLayoutPanel2.VerticalScroll.SmallChange * 30;
            flowLayoutPanel2.AutoScrollPosition = new Point(0, change);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel2.VerticalScroll.Value + flowLayoutPanel2.VerticalScroll.SmallChange * 30;
            flowLayoutPanel2.AutoScrollPosition = new Point(0, change);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ///tabControl1.SelectedTab = tabPage3;
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[2];
            DataTable denumire = data_Base_AtestatDataSet1.Picturi;
            label5.Text = Convert.ToString(denumire.Rows[0]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Picturi;
            label8.Text = Convert.ToString(denumire.Rows[0]["Descriere"]);
            DataTable pret = data_Base_AtestatDataSet1.Picturi;
            label4.Text = Convert.ToString(denumire.Rows[0]["Pret"]);

            label10.Text = Convert.ToString(pret.Rows[0]["Pret"]);

            label9.Visible = false;
            button8.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            button9.Visible = false;

            nr_tablou_licitat = 1;
            tablou = true;
            label10.Text = "0";

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            tabControl1.SelectedTab = tabPage1;
        }
        public int cont = 4;
        private void button8_Click(object sender, EventArgs e)
        {
           
            long pret = Convert.ToInt64(textBox2.Text);
            long  pret_initial = Convert.ToInt64(label4.Text);
            long  pret_licitator = Convert.ToInt64(label10.Text);
            
            if (pret > pret_initial && cont>0)
            {
                if(pret>pret_licitator && cont>0)
                {
                    pret_licitator = pret + 10000;

                    label10.Visible = true;
                    if(cont!=0)
                       label10.Text = Convert.ToString(pret_licitator);
                    cont--;
                }
                else MessageBox.Show("Pretul este prea mic!");

                if (cont == 0)
                {
                    MessageBox.Show("Ai castigat licitatia, felicitari!");
                    
                    button9.Visible = true;
                    label10.Visible = false;
                    cont = 4;
                    if (nr_tablou_licitat == 6)
                        pictureBox3.Visible = false;
                    if (nr_tablou_licitat == 3)
                        pictureBox1.Visible = false;
                    if (nr_tablou_licitat == 1)
                        pictureBox2.Visible = false;
                    if (nr_tablou_licitat == 7)
                        pictureBox4.Visible = false;
                    if (nr_tablou_licitat == 2)
                        pictureBox5.Visible = false;
                    if (nr_tablou_licitat == 4)
                        pictureBox6.Visible = false;
                    if (nr_tablou_licitat == 5)
                        pictureBox7.Visible = false;
                    if (nr_sculptura_licitata == 5)
                        pictureBox8.Visible = false;
                    if (nr_sculptura_licitata == 7)
                        pictureBox9.Visible = false;
                    if (nr_sculptura_licitata == 3)
                        pictureBox10.Visible = false;
                    if (nr_sculptura_licitata == 4)
                        pictureBox11.Visible = false;
                    if (nr_sculptura_licitata == 1)
                        pictureBox13.Visible = false;
                    if (nr_sculptura_licitata == 6)
                        pictureBox14.Visible = false;
                    if (nr_sculptura_licitata == 2)
                        pictureBox15.Visible = false;
                }
                    
            }
            else MessageBox.Show("Pretul este mai mic decat cel de lista!");


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[1];
            DataTable pret = data_Base_AtestatDataSet1.Picturi;
            label4.Text = Convert.ToString(pret.Rows[2]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Picturi;
            label5.Text = Convert.ToString(pret.Rows[2]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Picturi;
            label8.Text = Convert.ToString(pret.Rows[2]["Descriere"]);
            label9.Visible = true;
            button8.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            button9.Visible = false;
            nr_tablou_licitat = 3;

            tablou = true;
            label10.Text = "0";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[3];
            DataTable denumire = data_Base_AtestatDataSet1.Picturi;
            label5.Text = Convert.ToString(denumire.Rows[6]["Denumire"]);
            DataTable pret = data_Base_AtestatDataSet1.Picturi;
            label4.Text = Convert.ToString(pret.Rows[6]["Pret"]);
            DataTable descriere = data_Base_AtestatDataSet1.Picturi;
            label8.Text = Convert.ToString(descriere.Rows[6]["Descriere"]);
            label9.Visible = true;
            button8.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            button9.Visible = false;

            nr_tablou_licitat = 7;
            tablou = true;
            label10.Text = "0";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[4];
            DataTable denumire = data_Base_AtestatDataSet1.Picturi;
            label5.Text = Convert.ToString(denumire.Rows[1]["Denumire"]);
            DataTable pret = data_Base_AtestatDataSet1.Picturi;
            label4.Text = Convert.ToString(pret.Rows[1]["Pret"]);
            DataTable descriere = data_Base_AtestatDataSet1.Picturi;
            label8.Text = Convert.ToString(descriere.Rows[1]["Descriere"]);
            button8.Visible = false;
            label9.Visible = true;
            button8.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            button9.Visible = false;

            nr_tablou_licitat = 2;
            tablou = true;
            label10.Text = "0";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[5];
            DataTable denumire = data_Base_AtestatDataSet1.Picturi;
            label5.Text = Convert.ToString(denumire.Rows[3]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Picturi;
            label8.Text = Convert.ToString(descriere.Rows[3]["Descriere"]);
            DataTable pret = data_Base_AtestatDataSet1.Picturi;
            label4.Text = Convert.ToString(pret.Rows[3]["Pret"]);
            label9.Visible = false;
            button8.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            button9.Visible = false;
            button14.Visible = false;

            nr_tablou_licitat = 4;
            tablou = true;
            label10.Text = "0";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[6];
            DataTable denumire = data_Base_AtestatDataSet1.Picturi;
            label5.Text = Convert.ToString(denumire.Rows[4]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Picturi;
            label8.Text = Convert.ToString(descriere.Rows[4]["Descriere"]);
            DataTable pret = data_Base_AtestatDataSet1.Picturi;
            label4.Text = Convert.ToString(denumire.Rows[4]["Pret"]);
            label9.Visible = true;
            button8.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            button9.Visible = false;

            nr_tablou_licitat = 5;
            tablou = true;
            label10.Text = "0";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[7];
            DataTable edt = data_Base_AtestatDataSet1.Sculpturi;
            label4.Text = Convert.ToString(edt.Rows[4]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Sculpturi;
            label5.Text = Convert.ToString(denumire.Rows[4]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Sculpturi;
            label8.Text = Convert.ToString(descriere.Rows[4]["Descriere"]);

            label9.Visible = false;
            button8.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            button9.Visible = false;
            button14.Visible = false;

            nr_sculptura_licitata = 5;
            tablou = false;
            label10.Text = "0";

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[8];
            DataTable edt = data_Base_AtestatDataSet1.Sculpturi;
            label4.Text = Convert.ToString(edt.Rows[6]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Sculpturi;
            label5.Text = Convert.ToString(denumire.Rows[6]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Sculpturi;
            label8.Text = Convert.ToString(descriere.Rows[6]["Descriere"]);

            label9.Visible = false;
            button8.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            button9.Visible = false;
            button14.Visible = false;

            nr_sculptura_licitata = 7;
            tablou = false;
            label10.Text = "0";


        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[9];
            DataTable edt = data_Base_AtestatDataSet1.Sculpturi;
            label4.Text = Convert.ToString(edt.Rows[2]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Sculpturi;
            label5.Text = Convert.ToString(denumire.Rows[2]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Sculpturi;
            label8.Text = Convert.ToString(descriere.Rows[2]["Descriere"]);
            label9.Visible = true;
            button8.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            button9.Visible = false;

            nr_sculptura_licitata = 3;
            tablou = false;
            label10.Text = "0";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[10]; 
            DataTable edt = data_Base_AtestatDataSet1.Sculpturi;
            label4.Text = Convert.ToString(edt.Rows[3]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Sculpturi;
            label5.Text = Convert.ToString(denumire.Rows[3]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Sculpturi;
            label8.Text = Convert.ToString(descriere.Rows[3]["Descriere"]);

            label9.Visible = false;
            button8.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            button9.Visible = false;
            button14.Visible = false;

            nr_sculptura_licitata = 4;
            tablou = false;
            label10.Text = "0";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[11];
            DataTable edt = data_Base_AtestatDataSet1.Sculpturi;
            label4.Text = Convert.ToString(edt.Rows[0]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Sculpturi;
            label5.Text = Convert.ToString(denumire.Rows[0]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Sculpturi;
            label8.Text = Convert.ToString(descriere.Rows[0]["Descriere"]);
            label9.Visible = false;
            button8.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            button9.Visible = false;
            button14.Visible = false;

            nr_sculptura_licitata = 1;
            tablou = false;
            label10.Text = "0";

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[12];
            DataTable edt = data_Base_AtestatDataSet1.Sculpturi;
            label4.Text = Convert.ToString(edt.Rows[5]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Sculpturi;
            label5.Text = Convert.ToString(denumire.Rows[5]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Sculpturi;
            label8.Text = Convert.ToString(descriere.Rows[5]["Descriere"]);
            label9.Visible = true;
            button8.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            button9.Visible = false;

            nr_sculptura_licitata = 6;
            tablou = false;
            label10.Text = "0";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            pictureBox12.Image = imageList1.Images[13];
            DataTable edt = data_Base_AtestatDataSet1.Sculpturi;
            label4.Text = Convert.ToString(edt.Rows[1]["Pret"]);
            DataTable denumire = data_Base_AtestatDataSet1.Sculpturi;
            label5.Text = Convert.ToString(denumire.Rows[1]["Denumire"]);
            DataTable descriere = data_Base_AtestatDataSet1.Sculpturi;
            label8.Text = Convert.ToString(descriere.Rows[1]["Descriere"]);
            label9.Visible = true;
            button8.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            label10.Visible = false;
            button9.Visible = false;

            nr_sculptura_licitata = 2;
            tablou = false;
            label10.Text = "0";
        }

        private void sculpturiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sculpturiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.data_Base_AtestatDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_Base_AtestatDataSet1.Artisti' table. You can move, or remove it, as needed.
            this.artistiTableAdapter.Fill(this.data_Base_AtestatDataSet1.Artisti);
            // TODO: This line of code loads data into the 'data_Base_AtestatDataSet1.Licitatii' table. You can move, or remove it, as needed.
            this.licitatiiTableAdapter.Fill(this.data_Base_AtestatDataSet1.Licitatii);
            // TODO: This line of code loads data into the 'data_Base_AtestatDataSet1.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.data_Base_AtestatDataSet1.Clienti);
            // TODO: This line of code loads data into the 'data_Base_AtestatDataSet1.Picturi' table. You can move, or remove it, as needed.
            this.picturiTableAdapter.Fill(this.data_Base_AtestatDataSet1.Picturi);
            // TODO: This line of code loads data into the 'data_Base_AtestatDataSet1.Sculpturi' table. You can move, or remove it, as needed.
            this.sculpturiTableAdapter.Fill(this.data_Base_AtestatDataSet1.Sculpturi);
            data_Base_AtestatDataSet1.EnforceConstraints = false;
           

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
            richTextBox1.Visible = false;
        }

        private void adresaLabel_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            //bool ok = false;
            button11.Visible = false;
             
                richTextBox1.Text += "Datele dumneavoastra :";
                richTextBox1.Text += '\n';
                richTextBox1.Text +=textBox3.Text;
                richTextBox1.Text += '\n';
                richTextBox1.Text +=textBox4.Text;
                richTextBox1.Text += '\n';
                richTextBox1.Text +=textBox5.Text;
                richTextBox1.Text += '\n';
                richTextBox1.Text +=textBox6.Text;
                MessageBox.Show("Datele dumneavoastra au fost memorate"); 
                richTextBox1.Visible = true;

            //ok = true;

                button14.Visible = true;
                button11.Visible = true;
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            this.clientiTableAdapter.Fill(this.data_Base_AtestatDataSet1.Clienti);
            DataTable dt = data_Base_AtestatDataSet1.Clienti;
            for(int i=0;i<dt.Rows.Count;i++)
            {
                richTextBox2.Text += dt.Rows[i]["numele"]+" "+dt.Rows[i]["Prenume"]+"\n";

            }
            ///richTextBox2.Clear();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            this.licitatiiTableAdapter.FillBy_tablouri(data_Base_AtestatDataSet1.Licitatii);
            DataTable dt = data_Base_AtestatDataSet1.Licitatii;

            
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                //licitatiiTableAdapter.IDlicitatie_IDtablou();
                //richTextBox2.Text += dt.Rows[i]["id_tablou"]+ "\n";
                richTextBox2.Text += Convert.ToString(dt.Rows[i]["id_tablou"]) + " " + Convert.ToString(dt.Rows[i]["Denumire"]) + "\n";

            }
            ///richTextBox2.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ///int nr_clienti = clientiTableAdapter.Id_client().Value + 1;

            clientiTableAdapter.InsertQuery(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

            data_Base_AtestatDataSet1.AcceptChanges();
            //clientiTableAdapter.Update(data_Base_AtestatDataSet1);
            //int nr_licitatii = licitatiiTableAdapter.ID_Licitatie().Value + 1;
            int idclient = clientiTableAdapter.Id_client().Value;
           

            if (tablou == true)
                licitatiiTableAdapter.InsertTablou(label8.Text, nr_tablou_licitat,idclient);
            else
                licitatiiTableAdapter.InsertSculptura(label8.Text, nr_sculptura_licitata,idclient);
            licitatiiTableAdapter.Update(data_Base_AtestatDataSet1);
           

        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            licitatiiTableAdapter.FillByArtisti(data_Base_AtestatDataSet1.Licitatii);
            DataTable dt = data_Base_AtestatDataSet1.Licitatii;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox2.Text += dt.Rows[i]["Nume"].ToString() + " " + dt.Rows[i]["Prenume"].ToString() + "\n";
            }

            licitatiiTableAdapter.FillBy1Artistisculptura(data_Base_AtestatDataSet1.Licitatii);
            DataTable dt1 = data_Base_AtestatDataSet1.Licitatii;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                richTextBox2.Text += dt1.Rows[i]["Nume"].ToString() + " " + dt1.Rows[i]["Prenume"].ToString() + "\n";

            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            this.licitatiiTableAdapter.FillBy1Sculpturi(data_Base_AtestatDataSet1.Licitatii);
            DataTable dt = data_Base_AtestatDataSet1.Licitatii;


            for (int i = 0; i < dt.Rows.Count; i++)
            {

                //licitatiiTableAdapter.IDlicitatie_IDtablou();
                //richTextBox2.Text += dt.Rows[i]["id_tablou"]+ "\n";
                richTextBox2.Text += Convert.ToString(dt.Rows[i]["id_sculptura"]) + " " + Convert.ToString(dt.Rows[i]["Denumire"]) + "\n";

            }
            ///richTextBox2.Clear();
        }
    }
}
