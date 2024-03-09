using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace To_Do_List_App
{
    public static class SaveLoad
    {
        public static string jsonTODOListName = "JsonData";
        public static string jsonCompletedTasksListName = "jsonCompletedTasksListName";
        public static string jsonDeletedTasksListName = "jsonDeletedTasksListName";
        //Save dataTable
        public static void SaveData(DataTable dataTable, string jsonName)
        {
            try
            {
                var path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, jsonName);
                var data = new List<Task>();
                for (var i = 0; i < dataTable.Rows.Count; i++)
                {
                    data.Add(new Task
                    {
                        Title = dataTable.Rows[i]["Title"].ToString(),
                        Description = dataTable.Rows[i]["Description"].ToString()
                    });
                }
                string json = JsonSerializer.Serialize(data);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        //Load dataTable
        public static void LoadData(DataTable dataTable, string jsonName)
        {
            var path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, jsonName);

            if (File.Exists(path))
            {
                FileStream stream = File.OpenRead(path);
                try
                {
                    var read = JsonSerializer.Deserialize<List<Task>>(stream);
                    dataTable.Clear();
                    foreach (var row in read)
                    {
                        dataTable.Rows.Add(row.Title, row.Description);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                stream.Close();
            }
        }

        //Save List<Row>
        public static void SaveData(List<Task> rowList, string jsonName)
        {
            try
            {
                var path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, jsonName);
                var data = new List<Task>();
                foreach (var row in rowList)
                {
                    data.Add(new Task
                    {
                        Title = row.Title,
                        Description = row.Description
                    });
                }
                string json = JsonSerializer.Serialize(data);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        //Load List<Row>
        public static void LoadData(List<Task> rowList, string jsonName)
        {
            var path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, jsonName);
            if (File.Exists(path))
            {
                FileStream stream = File.OpenRead(path);
                try
                {
                    var read = JsonSerializer.Deserialize<List<Task>>(stream);
                    rowList.Clear();
                    foreach (var row in read)
                    {
                        rowList.Add(new Task
                        {
                            Title = row.Title,
                            Description = row.Description,
                        });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                stream.Close();
            }
        }
    }
}
