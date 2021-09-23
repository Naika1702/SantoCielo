using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace sitiosconexion
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        static string conexion = "SERVER=sql10.freesqldatabase.com;PORT=3306;DATABASE=sql10438798;UID=sql10438798;PASSWORD=1FCrGerAw8;SSL Mode=none";
        MySqlConnection cn = new MySqlConnection(conexion);

        public DataTable llenargrid() 
        {
            cn.Open();
            DataTable dt = new DataTable();
            String llenar = "SELECT * FROM agenda";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();

            return dt;
        
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            gdmostrar.DataSource = llenargrid();
            gdmostrar.DataBind();
        }

        protected void btninsertar_Click(object sender, EventArgs e)
        {
            cn.Open();

            string insertar = "INSERT INTO agenda(NOMBRE,APELLIDOS,DIRECCION,TELEFONO,EDAD,ALTURA)values(@nombre,@apellidos,@direccion,@telefono,@edad,@altura)";
            MySqlCommand cmd = new MySqlCommand(insertar, cn);

            cmd.Parameters.AddWithValue("@nombre",txtnombre.Text);
            cmd.Parameters.AddWithValue("@apellidos", txtapellido.Text);
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
            cmd.Parameters.AddWithValue("@edad", txtedad.Text);
            cmd.Parameters.AddWithValue("@altura", txtaltura.Text);
            cmd.ExecuteNonQuery();

            cn.Close();
            gdmostrar.DataSource = llenargrid();
            gdmostrar.DataBind();

        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            cn.Open();

            string actualizar = "UPDATE agenda SET NOMBRE=@nombre, APELLIDOS=@apellidos, DIRECCION=@direccion, TELEFONO=@telefono, EDAD=@edad, ALTURA=@altura WHERE NOMBRE=@nombre";
            MySqlCommand cmd = new MySqlCommand(actualizar, cn);

            cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
            cmd.Parameters.AddWithValue("@apellidos", txtapellido.Text);
            cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
            cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
            cmd.Parameters.AddWithValue("@edad", txtedad.Text);
            cmd.Parameters.AddWithValue("@altura", txtaltura.Text);

            cmd.ExecuteNonQuery();
            cn.Close();

            gdmostrar.DataSource = llenargrid();
            gdmostrar.DataBind();

        }

        protected void btneliminar_Click(object sender, EventArgs e)
        {
            cn.Open();

            string eliminar = "DELETE FROM agenda WHERE NOMBRE=@nombre";

            MySqlCommand cmd = new MySqlCommand(eliminar, cn);

            cmd.Parameters.AddWithValue("@nombre",txtnombre.Text);

            cmd.ExecuteNonQuery();

            cn.Close();

            gdmostrar.DataSource = llenargrid();
            gdmostrar.DataBind();



        }
    }
}