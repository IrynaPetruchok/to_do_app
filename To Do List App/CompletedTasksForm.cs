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

namespace To_Do_List_App
{
    public partial class CompletedTasksForm : Form
    {
        DataTable completedTasksList = new DataTable();

        public CompletedTasksForm()
        {
            InitializeComponent();
        }

        private void CompletedTasksForm_Load(object sender, EventArgs e)
        {
            // Create columns
            completedTasksList.Columns.Add("Title");
            completedTasksList.Columns.Add("Description");

            // Point our datagridview to our datasource
            compleatedTasksListView.DataSource = completedTasksList;
            SaveLoad.LoadData(completedTasksList, SaveLoad.jsonCompletedTasksListName);
        }
    }
}