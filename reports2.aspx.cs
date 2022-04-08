using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Prueba_Desarrollo_CNT
{
    public partial class reports2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectDBSQL"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "procedure_User_Pendin_priority_hight";
                    cmd.Connection = con;
                    con.Open();
                    gridview2.DataSource = cmd.ExecuteReader();
                    gridview2.DataBind();
                }
            }
        }
    }
}