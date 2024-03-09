using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.Json.Nodes;
using System.Runtime.InteropServices.ComTypes;

namespace To_Do_List_App
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        List<Task> completedTasksList = new List<Task>();
        List<Task> deletedTasksList = new List<Task>();
        bool isEditing = false;

        private void ToDoList_Load(object sender, EventArgs e)
        {
            // Create columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // Point our datagridview to our datasource
            toDoListView.DataSource = todoList;
            //Load (active tasks, completed tasks and deleted tasks)
            SaveLoad.LoadData(todoList, SaveLoad.jsonTODOListName);
            SaveLoad.LoadData(deletedTasksList, SaveLoad.jsonDeletedTasksListName);
            SaveLoad.LoadData(completedTasksList, SaveLoad.jsonCompletedTasksListName);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            titleTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                deletedTasksList.Add(new Task
                {
                    Title = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"].ToString(),
                    Description = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"].ToString()
                });
                if (deletedTasksList.Count > 10)
                {
                    deletedTasksList.Remove(deletedTasksList.First());
                }
                SaveLoad.SaveData(deletedTasksList, SaveLoad.jsonDeletedTasksListName);
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
                SaveLoad.SaveData(todoList, SaveLoad.jsonTODOListName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;
            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
                SaveLoad.SaveData(todoList, SaveLoad.jsonTODOListName);
            }

            // Clear fields
            isEditing = false;
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";

        }

        private void completedTaskButton_Click(object sender, EventArgs e)
        {
            try
            {
                completedTasksList.Add(new Task
                {
                    Title = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"].ToString(),
                    Description = todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"].ToString()
                });
                if (completedTasksList.Count > 10)
                {
                    completedTasksList.Remove(completedTasksList.First());
                }
                SaveLoad.SaveData(completedTasksList, SaveLoad.jsonCompletedTasksListName);
                todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
                SaveLoad.SaveData(todoList, SaveLoad.jsonTODOListName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

        }

        private void openDeletedTaskFormButton_Click(object sender, EventArgs e)
        {
            var form = new CompletedTasksForm();
            form.ShowDialog();
        }

        private void openCompletedTaskFormButton_Click(object sender, EventArgs e)
        {
            var form = new DeletedTasksForm();
            form.ShowDialog();
        }
    }

    [Serializable]
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}