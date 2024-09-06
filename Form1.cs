using ExelSolar.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExelSolar.Classes;
using ExelSolar.Logica;



namespace ExelSolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //evento botón añadir
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text == "" || txt_FirstName.Text == null)
            {
                 MessageBox.Show("Error al agregar cliente falta un campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_MiddleName.Text == "" || txt_MiddleName.Text == null)
            {
                MessageBox.Show("Error al agregar cliente falta un campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_Email.Text == "" || txt_Email.Text == null)
            {
                MessageBox.Show("Error al agregar cliente falta un campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_PhoneNumber.Text == "" || txt_PhoneNumber.Text == null)
            {
                MessageBox.Show("Error al agregar cliente falta un campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Client AddNewClient = new Client(
                txt_FirstName.Text,
                txt_MiddleName.Text,
                txt_Email.Text,
                Convert.ToInt32(txt_PhoneNumber.Text)  // Aquí accede al texto con .Text
            );




            try
            {
                if (AddNewClient != null ) {
                    using (SQLiteConnection con = Conecction.getInstance().CreateConnection())
                    {
                        con.Open();

                        string query = "INSERT INTO Clients (FirstName, MiddleName, Email, PhoneNumber) VALUES (@FirstName, @MiddleName, @Email, @PhoneNumber)";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@FirstName", AddNewClient.GetFN());
                            cmd.Parameters.AddWithValue("@MiddleName", AddNewClient.GetMN());
                            cmd.Parameters.AddWithValue("@Email", AddNewClient.GetE());
                            cmd.Parameters.AddWithValue("@PhoneNumber", AddNewClient.GetPN());

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Actualizar el DataGridView después de agregar un cliente
            CargarDatos();
            AddNewClient = null;

        }
        //evento botón modificar 
        private void btn_modify_Click(object sender, EventArgs e)
        {
            Client ModifyClient = new Client(Convert.ToInt32(txtModifyId.Text), txt_FirstName.Text, txt_MiddleName.Text, txt_Email.Text, Convert.ToInt32(txt_PhoneNumber.Text));

            try
            {
                if (ModifyClient != null)
                {
                    using (SQLiteConnection con = Conecction.getInstance().CreateConnection())
                    {
                        con.Open();

                        string query = "UPDATE Clients SET FirstName = @FirstName, MiddleName = @MiddleName, Email = @Email, PhoneNumber = @PhoneNumber WHERE Id = @Id";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", ModifyClient.GetID());
                            cmd.Parameters.AddWithValue("@FirstName", ModifyClient.GetFN());
                            cmd.Parameters.AddWithValue("@MiddleName", ModifyClient.GetMN());
                            cmd.Parameters.AddWithValue("@Email", ModifyClient.GetE());
                            cmd.Parameters.AddWithValue("@PhoneNumber", ModifyClient.GetPN());

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Cliente modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Actualizar el DataGridView después de modificar un cliente
            CargarDatos();
        }

        //evento botón borrar
        private void btn_delete_Click(object sender, EventArgs e)
        {
            {

                Client ClientDelete = new Client(Convert.ToInt32(txt_IdDM.Text));


                try
                {

                   if (ClientDelete != null)
                    {
                        // Verificar si el ID es válido
                        if (int.TryParse(txt_IdDM.Text, out int id))
                        {

                            using (SQLiteConnection con = Conecction.getInstance().CreateConnection())
                            {
                                con.Open();

                                string query = "DELETE FROM Clients WHERE Id = @IdClient";

                                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                                {
                                    cmd.Parameters.AddWithValue("@IdClient", Convert.ToInt32(ClientDelete.GetID()));

                                    cmd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Por favor, ingrese un ID válido para eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Actualizar el DataGridView después de eliminar un cliente
                        CargarDatos();
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClientDelete = null;
            }
        }


        //evento borrar datos
        private void btn_find_Click(object sender, EventArgs e)
        {

            CargarDatos();
        }




        private void CargarDatos()
        {
            try
            {
                using (SQLiteConnection con = Conecction.getInstance().CreateConnection())
                {
                    con.Open();

                    string query = "SELECT * FROM Clients";

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asignar el DataTable al DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
