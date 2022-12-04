using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace Hotel
{
    public partial class Rooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
                var dataSource = NpgsqlDataSource.Create(connectionString);
                var connection = dataSource.OpenConnection();

                var cmd = new NpgsqlCommand("INSERT INTO room (roomnum, beds, bathrooms, rateprice, tv, wifi, bill, payment_status) VALUES ('" + RoomTB.Text + " ', '" + BedsTB.Text + " ', '" + BathroomsTB.Text + " ', '" + RateTB.Text + " ''" + TVTB.Text + " ', '" + wifiTB.Text + " ', '" + BillTB.Text + " ', '" + Payment_StatusTB.Text + " ')", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Insertion Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Insertion Failed";
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
                var dataSource = NpgsqlDataSource.Create(connectionString);
                var connection = dataSource.OpenConnection();

                var cmd = new NpgsqlCommand("Update room Set roomnum = '" + RoomTB.Text + " ', beds = '" + BedsTB.Text + " ', bathrooms = '" + BathroomsTB.Text + " ', rateprice = '" + RateTB.Text + " ', tv = '" + TVTB.Text + " ', wifi = '" + wifiTB.Text + " ', bill = '" + BillTB.Text + " ', payment_status = '" + Payment_StatusTB.Text + " '", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Update Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Upddate Failed";
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
                var dataSource = NpgsqlDataSource.Create(connectionString);
                var connection = dataSource.OpenConnection();

                var cmd = new NpgsqlCommand("Delete from room where roomnum = '" + RoomTB.Text + " '", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Delete Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Delete Failed";
            }
        }
    }
}