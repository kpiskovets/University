using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using System.Xml;
using System.Data.SqlClient;
using System.Data.Entity;
using Npgsql;


public class SimpleDataSet : DataSet
{





    public SimpleDataSet()
        : base()
    {


        CreateDummyData();
    }

    private void CreateDummyData()
    {




        /*var sConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Сивоок\Dropbox\vovk\univ.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable dt = new DataTable();
        if (sConnection != null && sConnection.State == ConnectionState.Closed)
        {

            sConnection.Open();
        }
        using (SqlDataAdapter ad = new SqlDataAdapter())
        {
            SqlDataAdapter com = new SqlDataAdapter("Select * from dbo.UObject", sConnection);
            com.Fill(dt);
        }
        sConnection.Close();


        

        this.Tables.Add(dt);*/
        OleDbConnection dbCon = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\orodr_000\Documents\GitHub\University\UniversityDb\Database1.accdb");
        dbCon.Open();
        OleDbDataAdapter dbAdapter1 = new OleDbDataAdapter(@"SELECT * FROM UObject", dbCon);
        DataTable dataTable = new DataTable();
        dbAdapter1.Fill(dataTable);
        dbCon.Close();
        /*
         DataSet ds = new DataSet();
         DataTable dt = new DataTable();
        
            
            string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                "User Id=postgres;Password=postgres;Database=bd_g;");
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string sql = "SELECT * FROM uobject";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
        */
       

        

        this.Tables.Add(dataTable);
       // this.Tables.Add(dt);
        
        

        
    }
    
}

