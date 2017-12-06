using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLConnection
{
    public partial class SQLProcedureTry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


/*
 CREATE PROC sp_GetProduct
 (
 @orderID INT,
 @productName nvarchar(40) =null OUTPUT
 )
 AS
 BEGIN
	SET @productName=(SELECT TOP 1 ProductName 
					    FROM [Order Details] od 
						INNER JOIN Products p ON od.ProductID=p.ProductID WHERE od.OrderID=@orderID)
 END

*/
/*
ALTER PROC sp_KategoriListele
(
@employeeID int
)
 AS
 BEGIN
 	(SELECT FirstName,LastName FROM Employees WHERE EmployeeID=@employeeID)
 END

*/
        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionInfo.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_KategoriListele";
            cmd.Parameters.Add("@employeeID", SqlDbType.Int).Value=Convert.ToInt32(TextBox1.Text);
            cmd.Connection = conn;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataReader reader = cmd.ExecuteReader();
            string result = "";

            while (reader.Read())
            {
                result += reader[0]+" "+reader[1];
            }

            Label1.Text = result;
            reader.Close();
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnectionInfo.ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_GetProduct";
            cmd.Parameters.Add("@orderID", SqlDbType.Int).Value = Convert.ToInt32(TextBox2.Text);
            cmd.Parameters.Add("@productName", SqlDbType.NVarChar, 40);
            cmd.Parameters["@productName"].Direction = ParameterDirection.Output;
            cmd.Connection = conn;

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            cmd.ExecuteNonQuery();
            Label2.Text = cmd.Parameters["@productName"].Value.ToString();

            conn.Close();
        }
    }
}
