namespace To_Do_List_App
{
    partial class CompletedTasksForm
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
            this.compleatedTasksListView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compleatedTasksListView)).BeginInit();
            this.SuspendLayout();
            // 
            // compleatedTasksListView
            // 
            this.compleatedTasksListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.compleatedTasksListView.BackgroundColor = System.Drawing.Color.White;
            this.compleatedTasksListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.compleatedTasksListView.Location = new System.Drawing.Point(3, 195);
            this.compleatedTasksListView.Name = "compleatedTasksListView";
            this.compleatedTasksListView.RowHeadersWidth = 51;
            this.compleatedTasksListView.RowTemplate.Height = 24;
            this.compleatedTasksListView.Size = new System.Drawing.Size(794, 296);
            this.compleatedTasksListView.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "Compleated Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 509);
            this.Controls.Add(this.compleatedTasksListView);
            this.Controls.Add(this.label1);
            this.Name = "CompletedTasksForm";
            this.Text = "CompletedTasksForm";
            this.Load += new System.EventHandler(this.CompletedTasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compleatedTasksListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView compleatedTasksListView;
        private System.Windows.Forms.Label label1;
    }
}