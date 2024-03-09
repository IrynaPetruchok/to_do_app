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
    public partial class DeletedTasksForm : Form
    {
        DataTable deletedTasksList = new DataTable();

        public DeletedTasksForm()
        {
            InitializeComponent();
        }

        private void DeletedTasksForm_Load(object sender, EventArgs e)
        {
            // Create columns
            deletedTasksList.Columns.Add("Title");
            deletedTasksList.Columns.Add("Description");

            // Point our datagridview to our datasource
            deletedTasksListView.DataSource = deletedTasksList;
            SaveLoad.LoadData(deletedTasksList, SaveLoad.jsonDeletedTasksListName);
        }
    }
}