using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Prueba_Desarrollo_CNT
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if(!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectDBSQL"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procedure_getUsers";
                    cmd.Connection = con;
                    con.Open();
                    gvdAlumnos.DataSource = cmd.ExecuteReader();
                    gvdAlumnos.DataBind();
                }
            }
            */

            if (!IsPostBack)
            {
                //LISTA DE TIPOS DE DOCUMENTOS DE IDENTIDAD
                ListItem rc = new ListItem("REGISTRO CIVIL", "REGISTRO CIVIL");
                ListItem ti = new ListItem("TARJETA DE IDENTIDAD", "TARJETA DE IDENTIDAD");
                ListItem cc = new ListItem("CEDULA DE CIUDADANIA", "CEDULA DE CIUDADANIA");
                ListItem pa = new ListItem("PASAPORTE", "PASAPORTE");
                ListItem pep = new ListItem("PERMISO ESPECIAL DE PERMANENCIA", "ERMISO ESPECIAL DE PERMANENCIA");
                ListItem ce = new ListItem("CEDULA DE EXTRANJERIA", "CEDULA DE EXTRANJERIA");

                typeIdentity.Items.Add(rc);
                typeIdentity.Items.Add(ti);
                typeIdentity.Items.Add(cc);
                typeIdentity.Items.Add(pa);
                typeIdentity.Items.Add(pep);
                typeIdentity.Items.Add(ce);

                //LISTA DE GENEROS
                ListItem masculino = new ListItem("MASCULINO", "MASCULINO");
                ListItem femenino = new ListItem("FEMENINO", "FEMENINO");

                Gender.Items.Add(masculino);
                Gender.Items.Add(femenino);

                //LISTA FUMADOR O NO FUMADOR
                ListItem is_smoker = new ListItem("SI", "SI");
                ListItem no_smoker = new ListItem("NO", "NO");

                IsSmoker.Items.Add(is_smoker);
                IsSmoker.Items.Add(no_smoker);

                //LISTA DIETA O NO DIETA
                ListItem is_diet = new ListItem("SI", "SI");
                ListItem no_diet = new ListItem("NO", "NO");

                Diet.Items.Add(is_diet);
                Diet.Items.Add(no_diet);

                //LISTA RELACION PESO ESTATURA
                ListItem hwrelation_0 = new ListItem("0", "0");
                ListItem hwrelation_1 = new ListItem("1", "1");
                ListItem hwrelation_2 = new ListItem("2", "2");
                ListItem hwrelation_3 = new ListItem("3", "3");
                ListItem hwrelation_4 = new ListItem("4", "4");
                ListItem hwrelation_5 = new ListItem("5", "5");
                ListItem hwrelation_6 = new ListItem("6", "6");

                HWRelation.Items.Add(hwrelation_0);
                HWRelation.Items.Add(hwrelation_1);
                HWRelation.Items.Add(hwrelation_2);
                HWRelation.Items.Add(hwrelation_3);
                HWRelation.Items.Add(hwrelation_4);
                HWRelation.Items.Add(hwrelation_5);
                HWRelation.Items.Add(hwrelation_6);
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string lbltypeIdentity = typeIdentity.SelectedValue.ToString();
            string number = txtNumberId.Text;
            string names = txtNames.Text;
            string surnames = txtSurnames.Text;
            string age = txtAge.Text;
            string address = txtAddress.Text;
            string lblGender = Gender.SelectedValue.ToString();
            string weight = txtWeight.Text;
            string height = txtHeight.Text;
            string lblIsSmoker = IsSmoker.SelectedValue.ToString();
            string yearsSmoking = txtYearsSmoking.Text;
            string lblDiet = Diet.SelectedValue.ToString();
            string lblHWRelation = HWRelation.SelectedValue.ToString();
            int status  = 2;
            string User_status = status.ToString();

            try
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectDBSQL"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(); // Crear un objeto de la clase SqlCommand
                    cmd.CommandType = CommandType.StoredProcedure; // Usaremos el Procedimiento Almacenado.
                    cmd.CommandText = "procedure_InsertUser"; // Nombre del Procedimiento Almacenado
                    cmd.Connection = con; // Pasamos el objeto de conexión a cmd
                    con.Open();

                    cmd.Parameters.Add("@typenationalid", SqlDbType.VarChar).Value = lbltypeIdentity;
                    cmd.Parameters.Add("@nationalidnumbers", SqlDbType.BigInt).Value = number;
                    cmd.Parameters.Add("@firstname", SqlDbType.VarChar).Value = names;
                    cmd.Parameters.Add("@surname", SqlDbType.VarChar).Value = surnames;
                    cmd.Parameters.Add("@age", SqlDbType.TinyInt).Value = age;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = address;
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = lblGender;
                    cmd.Parameters.Add("@weight", SqlDbType.Int).Value = weight;
                    cmd.Parameters.Add("@height", SqlDbType.Int).Value = height;
                    cmd.Parameters.Add("@is_smoker", SqlDbType.VarChar).Value = lblIsSmoker;
                    cmd.Parameters.Add("@years_smoking", SqlDbType.TinyInt).Value = yearsSmoking;
                    cmd.Parameters.Add("@diet", SqlDbType.VarChar).Value = lblDiet;
                    cmd.Parameters.Add("@hw_relationship", SqlDbType.TinyInt).Value = lblHWRelation;
                    cmd.Parameters.Add("@Users_status_idUsers", SqlDbType.Int).Value = User_status;
                        
                    cmd.ExecuteNonQuery();

                }

            }
            catch (IOException ex)
            {
                if (ex.Source != null)
                    Console.WriteLine("IOException source: {0}", ex.Source);
                throw;
            }
        }

    }
}