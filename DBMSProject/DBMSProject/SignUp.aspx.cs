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
    public partial class WebForm1 : System.Web.UI.Page
    {

        String username, password, email, fname, lname;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void txtFname_TextChanged(object sender, EventArgs e)
        {
            fname = txtFname.Text;
        }

        protected void txtLname_TextChanged(object sender, EventArgs e)
        {
            lname = txtLname.Text;
        }

        protected void txtUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtUsername.Text;
        }

        protected void btnCreateProfile_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand createUser = new SqlCommand();
                SqlCommand createCust = new SqlCommand();
                SqlCommand createEmail = new SqlCommand();
                createEmail.Connection = conn;
                createUser.Connection = conn;
                createCust.Connection = conn;
                createEmail.CommandText = "INSERT INTO CustomerEmail (CustomerId, Email) VALUES ((SELECT CustomerId FROM Customer WHERE Fname = '" + fname + "' AND Lname = '" + lname + "'), '" + email + "');";
                createUser.CommandText = "INSERT INTO Accounts (Username, Password, CustomerId) VALUES ('" + username + "', '" + password + "', (SELECT CustomerId FROM CustomerEmail WHERE Email = '" + email + "'));";
                createCust.CommandText = "INSERT INTO Customer (Fname, Lname) VALUES ('" + fname + "', '" + lname + "');";
                conn.Open();
                createCust.ExecuteNonQuery();
                createEmail.ExecuteNonQuery();
                createUser.ExecuteNonQuery();
            }

            Response.Redirect("Login.aspx");
        }
    }
}