using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1

{
    public partial class fusuarios : Form
    {
        //Creamos cadena de conexión como variable publica antes de la función fusuario() 
        public string cadena_conexion = "Database=agenda;Data Source=localhost;User Id=dba;Password=123";
        
        

        public string usuario_modificar;
        public string usuario_eliminar;
        private string myInsertQuery;
        private string id;

        public fusuarios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Desabilitar campos, se activan al crear nuevo registro 
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;

            try
            {
                string consulta = "select * from contactos";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)
            {

            }

        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "delete from usuarios Where idusuario = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Connection = myConnection;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario eliminado con éxito", "Ok",MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usuarios";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Error al eliminar el usuario, primero realice búsqueda del usuario y después puede eliminar.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txtcodigo.Enabled = false;
            lstcorreo.Enabled = false;

            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtcodigo.Text = "";
            lstcorreo.Text = "";
            txtbuscar.Focus();

        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "INSERT INTO contactos(nombre,clave,nivel,codigo,correo) Values(?nombre,?clave,?nivel,?codigo,?correo)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 40).Value = txtusuario.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 45).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 4).Value = lstnivel.Text;
                myCommand.Parameters.Add("?codigo", MySqlDbType.Int32, 4).Value = txtcodigo.Text;
                myCommand.Parameters.Add("?correo", MySqlDbType.Int32, 4).Value = lstcorreo.Text;

                myCommand.Connection = myConnection;

                myConnection.Open();
                
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK,MessageBoxIcon.Information);

                string consulta = "select * from contactos";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";

            }

            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            bnuevo.Visible = true;
            bguardar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro 
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txtcodigo.Enabled = false;
            lstcorreo.Enabled = false;
            bnuevo.Focus();
        }

        private void bbuscar_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "select * from usuarios Where idusuario = " + txtbuscar.Text + "";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery, myConnection);
                myCommand.Connection = myConnection;
                myConnection.Open();
                MySqlDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (myReader.Read())
                {
                    txtusuario.Text = (myReader.GetString(1));
                    txtclave.Text = (myReader.GetString(2));
                    lstnivel.Text = (myReader.GetString(3));
                    txtcodigo.Text = (myReader.GetString(4)); 
                    lstcorreo.Text = (myReader.GetString(5)); 
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myReader.Close();
                myConnection.Close();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Campo de busqueda está vacío", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bnuevo.Visible = true;
            bguardar.Visible = false;
            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txtcodigo.Enabled = false;
            lstcorreo.Enabled = false;
            bmodificar.Focus();

            //Finalizada la busqueda y llenado de campos
            //guardamos el contenido de txtusuario.Text por si se quiere eliminar por medio del usuario
            usuario_eliminar = txtusuario.Text;
        }



        private void bsalir_Click(object sender, EventArgs e)
        {

            {
                this.Close();
            }

           

        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;
                string cod = txtcodigo.Text;
                string cor = lstcorreo.Text;


                //Primera forma de pasar los valores
                string myInsertQuery = "UPDATE usuarios SET nombre = ? nombre, clave = ? clave, nivel = ? nivel, codigo = ? codigo, correo = ? correo Where nombre = " + usuario_modificar + "";



                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                

                    //En caso de usar primera forma, se pasan estos parámetros.
                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 75).Value = txtusuario.Text;
                    myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 75).Value= txtclave.Text;
                    myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 11).Value =lstnivel.Text;
                    myCommand.Parameters.Add("?codigo", MySqlDbType.Int32, 4).Value = txtcodigo.Text;
                    myCommand.Parameters.Add("?correo", MySqlDbType.Int32, 4).Value = lstcorreo.Text;

                myCommand.Connection = myConnection;
                myConnection.Open();
                
                myCommand.Connection.Close();
            
                

                MessageBox.Show("Usuario modificado con éxito", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                string consulta = "select * from usuarios";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "agenda");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "agenda";
            }
            catch (MySqlException)

            {
               // MessageBox.Show("Error al modificar el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);//
            }

            bmodificar.Visible = true;
            bactualizar.Visible = false;

            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            txtcodigo.Enabled = false;
            lstcorreo.Enabled = false;
            bmodificar.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
    


        
