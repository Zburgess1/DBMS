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
            if(Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            refresh();
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
    }
}