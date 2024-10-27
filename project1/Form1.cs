using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace project1
{
    public partial class Form1 : Form
    {
        /* private IMongoDatabase db;*/
        private IMongoCollection<BsonDocument> mongoCollection;
        private ObjectId currentRecordId;


        public Form1()
        {
            InitializeComponent();

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Signup");
            mongoCollection = database.GetCollection<BsonDocument>("Data");


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Do you want to delete?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirm == DialogResult.Yes)
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Signup");
                var collection = database.GetCollection<BsonDocument>("Data");

                var filter = Builders<BsonDocument>.Filter.Eq("_id", currentRecordId);

                var result = collection.DeleteOne(filter);

                if(result.DeletedCount > 0)
                {
                    MessageBox.Show("Yehee deleted");
                    LoadData();
                    Clear_Form();
                }
                else
                {
                    MessageBox.Show("No data selected to delete");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
                textName.Text = row.Cells["Name"].Value.ToString();
                textContact.Text = row.Cells["Contact"].Value.ToString();
                textAge.Text = row.Cells["Age"].Value.ToString();
                textAddress.Text = row.Cells["Address"].Value.ToString();
                textPassword.Text = "";
                textEmail.Text = row.Cells["Email"].Value.ToString();             
                rbMale.Checked = row.Cells["Gender"].Value.ToString() == "Male";
                rbFemale.Checked = row.Cells["Gender"].Value.ToString() == "Female";

                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Signup");
                mongoCollection = database.GetCollection<BsonDocument>("Data");

                var filter = Builders<BsonDocument>.Filter.Eq("Email", textEmail.Text);
                var document = mongoCollection.Find(filter).FirstOrDefault();

                if (document != null)
                {
                    currentRecordId = document["_id"].AsObjectId;
                }

             
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void Insert_Click(object sender, EventArgs e)
        {


            var document = new BsonDocument
            {
                { "Name", textName.Text},
                 { "Contact", textContact.Text},
                 { "Age", textAge.Text},
                 { "Address", textAddress.Text},
                 { "Email", textEmail.Text},
                 { "Password", textPassword.Text},
                 { "Username", textUsername.Text},
                {"Gender", rbMale.Checked ? "Male" : "Female"  }

            };

            mongoCollection.InsertOne(document);
            LoadData();

            Clear_Form();

        }

        private void Clear_Form()
        {
            textName.Clear();
            textContact.Clear();
            textAge.Clear();
            textAddress.Clear();
            textPassword.Clear();
            textUsername.Clear();
            textEmail.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
        }

        private void FormateGridView()
        {
            dataGridView1.Columns["Name"].HeaderText = "Name";
            dataGridView1.Columns["Age"].HeaderText = "Age";
            dataGridView1.Columns["Address"].HeaderText = "Address";
            dataGridView1.Columns["Contact"].HeaderText = "Contact";
            dataGridView1.Columns["Gender"].HeaderText = "Gender";
            dataGridView1.Columns["Email"].HeaderText = "Email";
            dataGridView1.Columns["Username"].HeaderText = "Username";

            dataGridView1.Columns["Name"].Width = 150;
            dataGridView1.Columns["Age"].Width = 100;
            dataGridView1.Columns["Address"].Width = 200;
            dataGridView1.Columns["Contact"].Width = 150;
            dataGridView1.Columns["Gender"].Width = 100;
            dataGridView1.Columns["Email"].Width = 200;
            dataGridView1.Columns["Username"].Width = 200;

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("arial", 10f, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;


        }

        private void LoadData()
        {
            var document = mongoCollection.Find(new BsonDocument()).ToList();

            dataGridView1.DataSource = document.Select(d => new
            {
                Name = d["Name"].AsString,
                Age = d["Age"].AsString,
                Address = d["Address"].AsString,
                Contact = d["Contact"].AsString,
                Gender = d["Gender"].AsString,
                Email = d["Email"].AsString,
                Username = d["Username"].AsString
            }).ToList();

            FormateGridView();  


        }
        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Signup");
            var collection = database.GetCollection<BsonDocument>("Data");

            var filter = Builders<BsonDocument>.Filter.Eq("_id", currentRecordId);


            var update = Builders<BsonDocument>.Update
                .Set("Name", textName.Text)
                .Set("Age", textAge.Text)
                .Set("Contact", textContact.Text)
                .Set("Address", textAddress.Text)
                .Set("Email", textEmail.Text)
                .Set("Gender", rbMale.Checked ? "Male" : "Female")
                .Set("Username", textUsername.Text);

            var endResult = collection.UpdateOne(filter, update);

            LoadData();
        }
    }
}
