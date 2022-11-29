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
    public partial class AccountView : System.Web.UI.Page
    {

        String username, password, email, address, phone;

        protected void txtPhone_TextChanged(object sender, EventArgs e)
        {
            phone = txtPhone.Text;
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {
            password = txtPassword.Text;
        }

        protected void btnUpdateUsername_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Accounts SET Username = '" + username + "' WHERE CustomerId = '" + Session["user"] + "';";
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE CustomerAddress SET Address = '" + address + "' WHERE CustomerId = '" + Session["user"] + "';";
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnUpdatePhone_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE CustomerPhone SET Phone = '" + phone + "' WHERE CustomerId = '" + Session["user"] + "';";
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE CustomerEmail SET Email = '" + email + "' WHERE CustomerId = '" + Session["user"] + "';";
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE Accounts SET Password = '" + password + "' WHERE CustomerId = '" + Session["user"] + "';";
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        protected void btnAddData_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                //SqlCommand cmd = new SqlCommand();
                //SqlCommand cmd2 = new SqlCommand();
                SqlCommand cmd3 = new SqlCommand();
                SqlCommand cmd4 = new SqlCommand();
                //cmd2.Connection = conn;
                cmd3.Connection = conn;
                cmd4.Connection = conn;
                //cmd.Connection = conn;
                //cmd.CommandText = "INSERT INTO Accounts (Username, Password, CustomerId) VALUES ('" + username + "', '" + password + "', '" + Session["user"] + "');";
                //cmd2.CommandText = "INSERT INTO CustomerEmail (CustomerId, Email) VALUES ('" + Session["user"] + "', '" + email + "');";
                cmd3.CommandText = "INSERT INTO CustomerAddress (CustomerId, Address) VALUES ('" + Session["user"] + "', '" + address + "');";
                cmd4.CommandText = "INSERT INTO CustomerPhone (CustomerId, PhoneNum) VALUES ('" + Session["user"] + "', '" + phone + "');";
                conn.Open();
                //cmd.ExecuteNonQuery();
                //cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewOrder.aspx");
        }

        protected void txtAddress_TextChanged(object sender, EventArgs e)
        {
            address = txtAddress.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void bookSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookSearch.aspx");
        }

        protected void txtNewUser_TextChanged(object sender, EventArgs e)
        {
            username = txtNewUser.Text;
        }
    }
}