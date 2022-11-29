using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBMSProject
{
    public partial class _Default : Page
    {

        String username, password;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text;
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT CustomerId FROM Accounts WHERE Username = '" + username + "' AND Password = '" + password + "';";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    Session["user"] = sdr["CustomerId"].ToString();
                    if((String)Session["user"] == "12")
                    {
                        Response.Redirect("AdminView.aspx");
                    }
                    else { 
                        Response.Redirect("AccountView.aspx");
                    }
                    
                }
                else
                {
                    lblLoginFail.Visible = true;
                }
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }
    }
}