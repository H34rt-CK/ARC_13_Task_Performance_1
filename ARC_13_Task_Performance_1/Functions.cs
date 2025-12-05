using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ARC_13_Task_Performance_1
{
    internal class Functions
    {
        
        string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = RecipeDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False";
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

        public void Create()
        {
            string name, ingredients, instructions;
            Console.Write("Enter Recipe Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Ingredients: ");
            ingredients = Console.ReadLine();
            Console.Write("Enter Instructions: ");
            instructions = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Recipes (Title, Ingredients, Instructions) VALUES (@ttl, @ing, @ins)", con);
                cmd.Parameters.AddWithValue("@ttl", name);
                cmd.Parameters.AddWithValue("@ing", ingredients);
                cmd.Parameters.AddWithValue("@ins", instructions);
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
