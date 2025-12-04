using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC_13_Task_Performance_1
{
    internal class Functions
    {
        
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        void Admin()
        {
            bool isAdmin = false;
            if (isAdmin == true)
            {
                Create();
                Read();
                Update();
                Delete();
            }
        }

        void Create()
        {
        using (SqlConnection con = new SqlConnection(conn))
            {
                string query = "INSERT INTO Recipes (Title, Ingredients, Instructions) VALUES (@t, @i, @s)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@t", "Sample Recipe");
                cmd.Parameters.AddWithValue("@i", "Sample Ingredients");
                cmd.Parameters.AddWithValue("@s", "Sample Instructions");
                con.Open();
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Recipe Added");
        }
        void Read()
        {

        }
        void Update()
        {

        }
        void Delete()
        {

        }
    }
}
