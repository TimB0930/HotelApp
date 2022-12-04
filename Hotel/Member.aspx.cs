using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace Hotel
{
    public partial class WebForm3 : System.Web.UI.Page
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

                var cmd = new NpgsqlCommand("INSERT INTO guests (guestid, payment_type, payment, status, points, first_name, middle_name, last_name, date_signed) VALUES ('" + GuestIdTB.Text + " ', '" + Payment_TypeTB.Text + " ','" + PaymentTB.Text + " ', '" + StatusTB.Text + " ','" + PointsTB.Text + " ','" + FNTB.Text + " ', '" + MNTB.Text + " ','" + LNTB.Text + " ','" + DateSignedTB.Text + " ')", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Insert Complete.";
            }
            catch (Exception)
            {
                Label1.Text = "Error already been inserted.";
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
                var dataSource = NpgsqlDataSource.Create(connectionString);
                var connection = dataSource.OpenConnection();

                var cmd = new NpgsqlCommand("Update guests Set payment_type = '" + Payment_TypeTB.Text + "', payment = '" + PaymentTB.Text + "' status =  '" + StatusTB.Text + "', points =  '" + PointsTB.Text + "', first_name = '" + FNTB.Text + "', middle_name = '" + MNTB.Text + "', last_name = '" + LNTB.Text + "' where guestid = '" + GuestIdTB.Text + "' ", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Update Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Update unable to be complete.";
            }

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
                var dataSource = NpgsqlDataSource.Create(connectionString);
                var connection = dataSource.OpenConnection();

                var cmd = new NpgsqlCommand("Delete from guests where guestid = '" + GuestIdTB.Text + " '", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Delete Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Delete can not be preformed.";
            }
        }
    }
}