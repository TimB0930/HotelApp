using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;

namespace Hotel
{
    public partial class WebForm2 : System.Web.UI.Page
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

                var cmd = new NpgsqlCommand("INSERT INTO COEMP (empid,password,rule,rank,first_name,middle_name,last_name,address,direct_deposit,mics1) VALUES ('" + EmpIdTB.Text + "', '" + PasswordTB.Text + " ', '" + RuleTB.Text + " ','" + RankTB.Text + " ','" + FNTB.Text + " ','" + MNTB.Text + " ','" + LNTB.Text + " ','" + AddressTB.Text + " ','" + DirectDepositTB.Text + " ','" + Misc1.Text + " ')", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Insert Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Error - Value in already in the database.";
            }
            
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
                var dataSource = NpgsqlDataSource.Create(connectionString);
                var connection = dataSource.OpenConnection();

                var cmd = new NpgsqlCommand("Update COEMP Set empid = '" + EmpIdTB.Text + "', password =  '" + PasswordTB.Text + "', rule = '" + RuleTB.Text + "', rank =  '" + RankTB.Text + "', first_name = '" + FNTB.Text + "', middle_name = '" + MNTB.Text + "', last_name = '" + LNTB.Text + "', address = '" + AddressTB.Text + "', direct_deposit = '" + DirectDepositTB.Text + "',mics1 = '" + Misc1.Text + "'", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Update Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Error - Value in already in the database.";
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=412";
                var dataSource = NpgsqlDataSource.Create(connectionString);
                var connection = dataSource.OpenConnection();

                var cmd = new NpgsqlCommand("Delete from COEMP where empid = '" + EmpIdTB.Text + " '", connection);
                cmd.ExecuteNonQuery();
                Label1.Text = "Delete Complete";
            }
            catch (Exception)
            {
                Label1.Text = "Error - Value in already in the database.";
            }
        }
    }
    }
