namespace To_Do_List_App
{
    partial class DeletedTasksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deletedTasksListView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deletedTasksListView)).BeginInit();
            this.SuspendLayout();
            // 
            // deletedTasksListView
            // 
            this.deletedTasksListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deletedTasksListView.BackgroundColor = System.Drawing.Color.White;
            this.deletedTasksListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deletedTasksListView.Location = new System.Drawing.Point(12, 185);
            this.deletedTasksListView.Name = "deletedTasksListView";
            this.deletedTasksListView.RowHeadersWidth = 51;
            this.deletedTasksListView.RowTemplate.Height = 24;
            this.deletedTasksListView.Size = new System.Drawing.Size(794, 296);
            this.deletedTasksListView.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Deleted Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 493);
            this.Controls.Add(this.deletedTasksListView);
            this.Controls.Add(this.label1);
            this.Name = "DeletedTasksForm";
            this.Text = "DeletedTasksForm";
            this.Load += new System.EventHandler(this.DeletedTasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletedTasksListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView deletedTasksListView;
        private System.Windows.Forms.Label label1;
    }
}