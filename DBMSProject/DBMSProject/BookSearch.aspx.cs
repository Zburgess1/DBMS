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

        String text, order;

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
            if (Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            order = orders.SelectedValue;
            updateDropDown();
            
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

        protected void gvOutput_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AddToOrder")
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd.CommandText = "INSERT INTO OrderItems (ItemPrice, ISBN, OrderId) VALUES ((SELECT Price FROM Books WHERE ISBN = '" + e.CommandArgument.ToString() + "'), '" + e.CommandArgument.ToString() + "', '" + order +"');";
                    cmd2.CommandText = "UPDATE Orders SET OrderValue = (SELECT OrderValue FROM Orders WHERE OrderId = '" + order + "') + (SELECT Price FROM Books WHERE ISBN = '" + e.CommandArgument.ToString() + "') WHERE OrderId = '" + order + "';";
                    cmd.Connection = conn;
                    cmd2.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    //Response.Redirect("BookSearch.aspx");
                }
            }
        }

        protected void gvOutput_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                /**if(e.Row.FindControl("btnDeleteItem") != null){
                    Button deleteItem = e.Row.FindControl("btnDeleteItem") as Button;
                    deleteItem.CommandArgument = e.Row.Cells[4].Text;
                }**/
                if (e.Row.FindControl("btnAddToOrder") != null)
                {
                    Button addOrder = e.Row.FindControl("btnAddToOrder") as Button;
                    addOrder.CommandArgument = e.Row.Cells[0].Text;
                }
            }
        }

        protected void newOrder_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Today;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO Orders (OrderValue, OrderDate, CustomerId) VALUES (0, '" + date.ToString("dd/MM/yyyy") + "', '" + Session["user"] + "');";
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            updateDropDown();
        }

        protected void orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            order = orders.SelectedValue;
        }

        void updateDropDown()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Orders WHERE CustomerId = '" + Session["user"] + "';";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.SelectCommand = cmd;
                cmd.Connection = conn;
                conn.Open();

                da.Fill(ds);
                orders.DataTextField = ds.Tables[0].Columns["OrderDate"].ToString();
                orders.DataValueField = ds.Tables[0].Columns["OrderId"].ToString();
                orders.DataSource = ds.Tables[0];
                orders.DataBind();

                cmd.ExecuteNonQuery();
                //Response.Redirect("BookSearch.aspx");
            }
        }
    }
}