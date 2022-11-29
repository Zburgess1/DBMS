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
    public partial class ViewOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["user"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                refresh();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        void refresh()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                SqlDataAdapter sda = new SqlDataAdapter();
                DataTable dt = new DataTable();

                SqlCommand updateTable = new SqlCommand();
                updateTable.Connection = conn;

                updateTable.CommandText = "SELECT Orders.OrderId, Orders.OrderValue, Orders.OrderDate, OrderItems.ItemPrice, OrderItems.ISBN FROM Orders JOIN OrderItems ON Orders.OrderId = OrderItems.OrderId WHERE Orders.CustomerId = '" + Session["user"] + "';";

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

        protected void btnAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountView.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookSearch.aspx");
        }

        protected void gvOutput_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DeleteEntry")
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM Orders WHERE OrderId = '" + e.CommandArgument.ToString() + "';";
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();
                    Response.Redirect("ViewOrder.aspx");

                    refresh();
                }
            }
            /**else if(e.CommandName == "DeleteItem")
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBMSProject.Properties.Settings.BookStore"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd.CommandText = "DELETE FROM OrderItems WHERE ISBN = '" + e.CommandArgument.ToString() + "';";
                    cmd2.CommandText = "UPDATE Orders SET OrderValue = (SELECT OrderValue FROM Orders WHERE OrderId = '" + e.Row";
                    cmd.Connection = conn;
                    cmd2.Connection = conn;
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    refresh();
                }
            }**/
        }

        protected void gvOutput_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                /**if(e.Row.FindControl("btnDeleteItem") != null){
                    Button deleteItem = e.Row.FindControl("btnDeleteItem") as Button;
                    deleteItem.CommandArgument = e.Row.Cells[4].Text;
                }**/
                if(e.Row.FindControl("btnDeleteEntry") != null)
                {
                    Button deleteEntry = e.Row.FindControl("btnDeleteEntry") as Button;
                    deleteEntry.CommandArgument = e.Row.Cells[0].Text;
                }
            }
        }
    }
}