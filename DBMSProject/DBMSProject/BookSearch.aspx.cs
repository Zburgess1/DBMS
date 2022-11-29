using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBMSProject
{
    public partial class BookSearch : System.Web.UI.Page
    {

        String text;

        protected void category_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand updateTable = new SqlCommand();
                updateTable.Connection = conn;

                updateTable.CommandText = "SELECT Books.ISBN, Books.Title, Books.Price, Books.PubDate, Books.SupplierId FROM Books JOIN BookCat ON BookCat.ISBN = Books.ISBN JOIN BookCategories ON BookCat.CategoryId = BookCategories.CategoryId WHERE BookCategories.CategoryDesc LIKE '%" + text + "%';";

                sda.SelectCommand = updateTable;

                conn.Open();
                SqlDataReader read = updateTable.ExecuteReader();
                if (read.Read())
                {
                    read.Close();
                    sda.Fill(dt);
                    gvOutput.DataSource = dt;
                    gvOutput.DataBind();
                }
                else
                {
                    read.Close();
                    updateTable.ExecuteNonQuery();
                }
            }
        }

        protected void reviews_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand updateTable = new SqlCommand();
                updateTable.Connection = conn;

                updateTable.CommandText = "SELECT Books.ISBN, Books.Title, Books.Price, Books.PubDate, Books.SupplierId FROM Books JOIN UserReviews ON UserReviews.ISBN = Books.ISBN WHERE UserReviews.Review LIKE '%" + text + "%';";

                sda.SelectCommand = updateTable;

                conn.Open();
                SqlDataReader read = updateTable.ExecuteReader();
                if (read.Read())
                {
                    read.Close();
                    sda.Fill(dt);
                    gvOutput.DataSource = dt;
                    gvOutput.DataBind();
                }
                else
                {
                    read.Close();
                    updateTable.ExecuteNonQuery();
                }
            }
        }

        protected void searchBox_TextChanged(object sender, EventArgs e)
        {
            text = searchBox.Text;
        }

        protected void pubDate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand updateTable = new SqlCommand();
                updateTable.Connection = conn;

                updateTable.CommandText = "SELECT * FROM Books WHERE PubDate LIKE '%" + text + "%';";

                sda.SelectCommand = updateTable;

                conn.Open();
                SqlDataReader read = updateTable.ExecuteReader();
                if (read.Read())
                {
                    read.Close();
                    sda.Fill(dt);
                    gvOutput.DataSource = dt;
                    gvOutput.DataBind();
                }
                else
                {
                    read.Close();
                    updateTable.ExecuteNonQuery();
                }
            }
        }

        protected void title_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand updateTable = new SqlCommand();
                updateTable.Connection = conn;

                updateTable.CommandText = "SELECT * FROM Books WHERE Title LIKE '%" + text + "%';";

                sda.SelectCommand = updateTable;

                conn.Open();
                SqlDataReader read = updateTable.ExecuteReader();
                if (read.Read())
                {
                    read.Close();
                    sda.Fill(dt);
                    gvOutput.DataSource = dt;
                    gvOutput.DataBind();
                }
                else
                {
                    read.Close();
                    updateTable.ExecuteNonQuery();
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand updateTable = new SqlCommand();
                updateTable.Connection = conn;

                updateTable.CommandText = "SELECT * FROM Books;";

                sda.SelectCommand = updateTable;

                conn.Open();
                //SqlDataReader read = updateTable.ExecuteReader();
                //if (read.Read())
                //{
                    //read.Close();
                    sda.Fill(dt);
                    gvOutput.DataSource = dt;
                    gvOutput.DataBind();
                //}
                //else
                //{
                    //read.Close();
                    //updateTable.ExecuteNonQuery();
                //}
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewOrder.aspx");
        }

        protected void btnAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountView.aspx");
        }
    }
}