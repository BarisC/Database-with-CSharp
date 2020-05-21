using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace SonProje
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MARSGT;Initial Catalog=Marsdb;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                DataTable dt = baglanti.GetSchema("Tables");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i]["TABLE_NAME"]);
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }

        }


        public void Getlist()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                var list1 = baglanti.Query<Types>("select * from INDIVIDUAL_IMPORT_DOCUMENTS");
                dataGridView1.DataSource = list1;
                var list2 = baglanti.Query<Types2>("select * from INDIVIDUAL_IMPORTS");
                dataGridView2.DataSource = list2;
                baglanti.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }



        public void ProcessingFunction()
        {
            string tablo = comboBox2.Text;
            if (tablo == "INDIVIDUAL_IMPORT_DOCUMENTS")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    var record = baglanti.QueryFirst<Types2>(" SELECT * FROM INDIVIDUAL_IMPORTS WHERE INDIVIDUAL_IMPORT_ID = @a2 and BT = @b2", 
                        new { a2 = int.Parse(moveıd.Text), b2 = txtbt.Text });
                    baglanti.Execute(@"INSERT INTO INDIVIDUAL_IMPORT_DOCUMENTS VALUES (@a,@b)", 
                        new { a = record.INDIVIDUAL_IMPORT_ID, b = record.BT });
                    baglanti.Close();
                    Getlist();
                }
                catch
                {
                    MessageBox.Show("Can not open Connection!");
                }
            }
            else if (tablo == "INDIVIDUAL_IMPORTS")
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    var record3 = baglanti.QueryFirst<Types>(@" SELECT * FROM INDIVIDUAL_IMPORT_DOCUMENTS WHERE INDIVIDUAL_IMPORT_ID = @a3 and BIDS_DOCUMENT_NAME = @b3", new { a3 = int.Parse(moveıd.Text), b3 = txtbt.Text });
                    baglanti.Execute(@"INSERT INTO INDIVIDUAL_IMPORTS VALUES (@a4,@b4)", new { a4 = record3.INDIVIDUAL_IMPORT_ID, b4 = record3.BIDS_DOCUMENT_NAME });
                    baglanti.Close();
                    Getlist();
                }
                catch
                {
                    MessageBox.Show("Can not open Connection!");
                }
            }
        }



        public void SaveFunction()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Execute(@"INSERT INTO INDIVIDUAL_IMPORT_DOCUMENTS(INDIVIDUAL_IMPORT_ID, BIDS_DOCUMENT_NAME) VALUES (@a,@b)", new { a = int.Parse(txtıdsetup.Text), b = textBox2.Text });
                baglanti.Close();
                Getlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }


        public void DeleteFunction()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Execute(@"delete from INDIVIDUAL_IMPORT_DOCUMENTS where Id=@Number", 
                    new { @Number = dataGridView1.CurrentRow.Cells[0].Value.ToString() });
                baglanti.Close();
                Getlist();
            }
            catch
            {
                MessageBox.Show("Can not open Connection!");
            }
        }





        public void SaveFunctionImport()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Execute(@"insert into INDIVIDUAL_IMPORTS(BT) VALUES (@a)", new { a = txtbtsetup.Text });
                baglanti.Close();
                Getlist();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }




        //İMPORT DELETE---------------------------------------------------------------------------------------------------------------------------
        public void DeleteFunctionImport()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Execute(@"delete from INDIVIDUAL_IMPORTS where INDIVIDUAL_IMPORT_ID=@Number1", new { @Number1 = dataGridView2.CurrentRow.Cells[0].Value.ToString() });
                baglanti.Close();
                Getlist();
            }
            catch
            {
                MessageBox.Show("Can not open Connection!");
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------

        public void UpdateFunction()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Execute("UPDATE INDIVIDUAL_IMPORT_DOCUMENTS SET INDIVIDUAL_IMPORT_ID = @a ,BIDS_DOCUMENT_NAME=@b where Id=@ID", new { a = int.Parse(txtıdsetup.Text), b = textBox2.Text, ID = dataGridView1.CurrentRow.Cells[0].Value.ToString() });
        }
            
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }



        public void UpdateFunctionImport()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                baglanti.Execute("UPDATE INDIVIDUAL_IMPORTS SET INDIVIDUAL_IMPORT_ID = @INDIVIDUAL_IMPORT_ID,  BT  = @BT WHERE id = @Id", new { INDIVIDUAL_IMPORT_ID = int.Parse(txtıdsetup.Text) , BT = int.Parse(txtbtsetup.Text), ID = dataGridView2.CurrentRow.Cells[0].Value.ToString() });
                Getlist();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }




        

        private void List(object sender, EventArgs e)
        {
            Getlist();
        }

        private void Processing_Click(object sender, EventArgs e)
        {
            string tablo = comboBox2.Text;
            if (tablo == "INDIVIDUAL_IMPORT_DOCUMENTS")
            {
                ProcessingFunction();
            }
            else if(tablo == "INDIVIDUAL_IMPORTS")
            {
                ProcessingFunction();
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFunction();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteFunction();
        }

        private void Update1_Click(object sender, EventArgs e)
        {
            UpdateFunction();
        }

        private void Save2_Click(object sender, EventArgs e)
        {
            SaveFunctionImport();
        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            DeleteFunctionImport();
        }

        private void Update2_Click(object sender, EventArgs e)
        {
            UpdateFunctionImport();
        }

        private void move_Click(object sender, EventArgs e)
        {
            MoveFunction();
        }

        public void MoveFunction()
        {
            try
            {
                string combo2 = comboBox2.Text;
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                if (combo2 == "INDIVIDUAL_IMPORT_DOCUMENTS")
                {
                    baglanti.Execute(@"INSERT INTO INDIVIDUAL_IMPORT_DOCUMENTS SELECT * FROM INDIVIDUAL_IMPORTS WHERE BT=@a", new { a = txtbt.Text });
                }
                else if (combo2 == "INDIVIDUAL_IMPORTS")

                {
                    var record4 = baglanti.QueryFirst<Types>(@" SELECT * FROM INDIVIDUAL_IMPORT_DOCUMENTS WHERE BIDS_DOCUMENT_NAME = @b4", new {  b4 = txtbt.Text });
                    baglanti.Execute(@"INSERT INTO INDIVIDUAL_IMPORTS VALUES (BT=@b4)", new { b4 = record4.BIDS_DOCUMENT_NAME });
                }
                baglanti.Close();
                Getlist();

            }
            catch (Exception)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string tablo = comboBox2.Text;
                string sorgu = "SELECT * FROM " + tablo;
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                if (tablo == "INDIVIDUAL_IMPORT_DOCUMENTS")
                {
                    var list1 = baglanti.Query<Types>(sorgu);
                    dataGridView3.DataSource = list1;
                }
                else
                {
                    var list2 = baglanti.Query<Types2>(sorgu);
                    dataGridView3.DataSource = list2;
                }
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open Connection!");
            }
        }
    }
}
