using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARC_13_Task_Performance_1
{
    internal class Functions
    {
        public static string? Create(string txtCreate)
        {
            try
            {
                using var saveFileDialog = new System.Windows.Forms.SaveFileDialog
                {
                    Title = "Create Attendance File",
                    //Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                    Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    FileName = "attendance.txt",
                    DefaultExt = "txt"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        // Write some initial content to the file
                        file.WriteLine("Test File");
                        //txtCreate.Text = saveFileDialog.FileName; no textbox yet
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the file: " + ex.Message);
            }
            return null;
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
