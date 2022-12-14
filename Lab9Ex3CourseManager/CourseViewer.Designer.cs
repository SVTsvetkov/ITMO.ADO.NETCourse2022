using System.Drawing;
using System.Windows.Forms;

namespace Lab9Ex3CourseManager
{
    partial class CourseViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.departmentList = new System.Windows.Forms.ComboBox();
            this.closeForm = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentList
            // 
            this.departmentList.FormattingEnabled = true;
            this.departmentList.Location = new System.Drawing.Point(30, 27);
            this.departmentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departmentList.Name = "departmentList";
            this.departmentList.Size = new System.Drawing.Size(151, 24);
            this.departmentList.TabIndex = 0;
            this.departmentList.SelectedIndexChanged += new System.EventHandler(this.departmentList_SelectedIndexChanged);
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(203, 26);
            this.closeForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(94, 23);
            this.closeForm.TabIndex = 1;
            this.closeForm.Text = "Закрыть";
            this.closeForm.UseVisualStyleBackColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Location = new System.Drawing.Point(30, 77);
            this.courseGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseGridView.Name = "courseGridView";
            this.courseGridView.RowHeadersWidth = 51;
            this.courseGridView.RowTemplate.Height = 29;
            this.courseGridView.Size = new System.Drawing.Size(682, 264);
            this.courseGridView.TabIndex = 2;
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(322, 28);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(79, 23);
            this.saveChanges.TabIndex = 3;
            this.saveChanges.Text = "Обновить";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // CourseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.courseGridView);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.departmentList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseViewer";
            this.Text = "Course Viewer";
            this.Load += new System.EventHandler(this.CourseViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox departmentList;
        private Button closeForm;
        private DataGridView courseGridView;
        private Button saveChanges;
    }
}