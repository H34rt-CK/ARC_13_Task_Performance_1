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
        
        string conn = "Data Source=(localdb)\\ProjectModels;Initial Catalog=Recipes;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void Create(string name, string recipeText)
        {

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Recipes (Title, Ingredients) VALUES (@ttl, @txt)", con);
                cmd.Parameters.AddWithValue("@ttl", name);
                cmd.Parameters.AddWithValue("@txt", recipeText);
                cmd.ExecuteNonQuery();
            }
        }
        public List<Recipe> Read()
        {
            List<Recipe> recipes = new List<Recipe>();
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT ID, Title, Ingredients FROM Recipes", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    recipes.Add(new Recipe
                    {
                        Id = reader.GetInt32(0),
                        Title = reader.GetString(1),
                        RecipeText = reader.GetString(2)
                    });
                }
            }
            return recipes;
        }
        public void Update(int id, string name, string ingredients)
        {
            
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand(
                    "UPDATE Recipes SET Title = @ttl, Ingredients = @txt WHERE ID = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ttl", name);
                cmd.Parameters.AddWithValue("@txt", ingredients);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM Recipes WHERE ID = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                int result = cmd.ExecuteNonQuery();
                
            }
        }
    }
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string RecipeText { get; set; }

        public override string ToString()
        {
            return Title; // Show only Title in the ListBox
        }
    }
}
