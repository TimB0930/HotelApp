using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Hotel
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void RoomNumSearch_Click(object sender, EventArgs e)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
            //var dataSource = NpgsqlDataSource.Create(connectionString);

            DataTable ourDataTable = null;

            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    ourDataTable = new DataTable();
                    Npgsql.NpgsqlDataAdapter ourAdaptor = new NpgsqlDataAdapter(@"customerList1", connection);

                    ourAdaptor.SelectCommand.CommandText = ("Select * from room where roomnum = '" + RoomNumTB.Text + " '");
                    ourAdaptor.Fill(ourDataTable);

                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());

                }

                RoomNumGrid.DataSource = ourDataTable;
                RoomNumGrid.DataBind();
            }
        }

        protected void MemberNumSearch_Click(object sender, EventArgs e)
        {
            var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
            //var dataSource = NpgsqlDataSource.Create(connectionString);

            DataTable ourDataTable = null;

            using (Npgsql.NpgsqlConnection connection = new Npgsql.NpgsqlConnection(connectionString))
            {
                try
                {
                    ourDataTable = new DataTable();
                    Npgsql.NpgsqlDataAdapter ourAdaptor = new NpgsqlDataAdapter(@"customerList1", connection);

                    ourAdaptor.SelectCommand.CommandText = ("Select * from guests where guestid = '" + MemberNumTB.Text + "'");
                    ourAdaptor.Fill(ourDataTable);

                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());

                }

                MemberNumGrid.DataSource = ourDataTable;
                MemberNumGrid.DataBind();
            }
        }
    }
}

