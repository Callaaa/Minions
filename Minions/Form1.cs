using MySql.Data.MySqlClient;

namespace Minions
{
    public partial class Form1 : Form
    {
        string connstr = "server=10.42.41.221;" + "port=3306;"
            + "user=PC1;" + "password=1111;" + "database=minions;";

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //2
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            MessageBox.Show("Connection is now opened");
            //4
            MySqlCommand query = new MySqlCommand("select * from towns", connect);
            //5
            MySqlDataReader reader = query.ExecuteReader();
            //6
            List<ComboItem> items = new List<ComboItem>();
            while (reader.Read())
            {
                ComboItem item = new ComboItem();

                item.Id = (int)reader[0];
                item.Name = (string)reader[1];

                items.Add(item);
            }
            reader.Close();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Name";

            comboBox1.ValueMember = "Id";
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"109. Ti vavede {nameTextBox.Text}" +
                $"s godini {ageTextBox.Text} s grad" +
                $"{comboBox1.Text}--> {comboBox1.SelectedValue}");

            string insertSQL = "INSERT INTO minions.minions" +
                "(id,`name`,age,town_id)" +
                "VALUES (109,@minionName,@age,@townId)";
            //insert za`vka za query
            //podgotovka-connect to BazaDanni
            MySqlConnection connect = new MySqlConnection(connstr);
            if (connect.State == 0) connect.Open();
            //podgotvqm insert zaqvkata za purvi put
            
            MySqlCommand query = new MySqlCommand(insertSQL,connect);
            //podg za insert ->2 parametri ot ekrana
            query.Parameters.AddWithValue("@minionName",nameTextBox.Text);
            query.Parameters.AddWithValue("@age",ageTextBox.Text);
            query.Parameters.AddWithValue("@townId", comboBox1.SelectedValue);
            query.Parameters.AddWithValue("@id", idTextBox.Text);
            //izpulnenie na insert query
            query.ExecuteNonQuery();
            connect.Close();



        }
    }
}
