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
        public void Admin()
        {
            bool isAdmin = false;
            //if (isAdmin == true)
            //{
                Console.WriteLine("\nADMIN MENU");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Create(); break;
                    case "2": Read(); break;
                    case "3": Update(); break;
                    case "4": Delete(); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid."); break;
                }
            //}
        }

        public void Create()
        {
            string name, ingredients, instructions, recipeText;
            Console.Write("Enter Recipe Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Ingredients: ");
            ingredients = Console.ReadLine();
            Console.Write("Enter Instructions: ");
            instructions = Console.ReadLine();
            recipeText = $"Recipe: {name}\nIngredients: {ingredients}\nInstructions: {instructions}";
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand(
                    "INSERT INTO Recipes (Title, RecipeText) VALUES (@ttl, @txt)", con);
                cmd.Parameters.AddWithValue("@ttl", name);
                cmd.Parameters.AddWithValue("@txt", recipeText);
                cmd.ExecuteNonQuery();
            }
            Console.WriteLine("Recipe Added");
        }
        public List<Recipe> Read()
        {
            List<Recipe> recipes = new List<Recipe>();
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand("SELECT Id, Title, RecipeText FROM Recipes", con);
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
        public void Update()
        {
            int id;
            string name, ingredients, instructions, recipeText;
            Console.Write("Enter Recipe ID to Update: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter New Recipe Name: ");
            name = Console.ReadLine();
            Console.Write("Enter New Ingredients: ");
            ingredients = Console.ReadLine();
            Console.Write("Enter New Instructions: ");
            instructions = Console.ReadLine();
            recipeText = $"Recipe: {name}\nIngredients: {ingredients}\nInstructions: {instructions}";
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand(
                    "UPDATE Recipes SET Title = @ttl, RecipeText = @txt WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@ttl", name);
                cmd.Parameters.AddWithValue("@txt", recipeText);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete()
        {
            Console.Write("Enter Recipe ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();
                var cmd = new SqlCommand(
                    "DELETE FROM Recipes WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Recipe Deleted");
                }
                else
                {
                    Console.WriteLine("Recipe Not Found");
                }
            }
        }
    }
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string RecipeText { get; set; }
    }
}
