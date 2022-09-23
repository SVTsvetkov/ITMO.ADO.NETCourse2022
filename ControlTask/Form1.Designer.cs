namespace ControlTask
{
    partial class Form1
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
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loadCategoriesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.useWindowsAuthCheckbox = new System.Windows.Forms.CheckBox();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.deleteCategoriesButton = new System.Windows.Forms.Button();
            this.categoriesGroup = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            this.categoriesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextbox
            // 
            this.loginTextbox.Location = new System.Drawing.Point(122, 45);
            this.loginTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(155, 31);
            this.loginTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(122, 114);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(155, 31);
            this.passwordTextbox.TabIndex = 1;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(15, 49);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(91, 25);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(15, 114);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(87, 25);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // loadCategoriesButton
            // 
            this.loadCategoriesButton.Location = new System.Drawing.Point(324, 114);
            this.loadCategoriesButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadCategoriesButton.Name = "loadCategoriesButton";
            this.loadCategoriesButton.Size = new System.Drawing.Size(198, 36);
            this.loadCategoriesButton.TabIndex = 4;
            this.loadCategoriesButton.Text = "Connect to LocalDB";
            this.loadCategoriesButton.UseVisualStyleBackColor = true;
            this.loadCategoriesButton.Click += new System.EventHandler(this.loadCategoriesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.useWindowsAuthCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(724, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // useWindowsAuthCheckbox
            // 
            this.useWindowsAuthCheckbox.AutoSize = true;
            this.useWindowsAuthCheckbox.Location = new System.Drawing.Point(319, 55);
            this.useWindowsAuthCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.useWindowsAuthCheckbox.Name = "useWindowsAuthCheckbox";
            this.useWindowsAuthCheckbox.Size = new System.Drawing.Size(263, 29);
            this.useWindowsAuthCheckbox.TabIndex = 0;
            this.useWindowsAuthCheckbox.Text = "Use Windows authentication";
            this.useWindowsAuthCheckbox.UseVisualStyleBackColor = true;
            this.useWindowsAuthCheckbox.CheckedChanged += new System.EventHandler(this.useWindowsAuthCheckbox_CheckedChanged);
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AllowUserToDeleteRows = false;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Location = new System.Drawing.Point(58, 325);
            this.categoriesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.RowHeadersWidth = 51;
            this.categoriesDataGridView.RowTemplate.Height = 29;
            this.categoriesDataGridView.Size = new System.Drawing.Size(611, 569);
            this.categoriesDataGridView.TabIndex = 0;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(319, 32);
            this.saveChangesButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(140, 36);
            this.saveChangesButton.TabIndex = 1;
            this.saveChangesButton.Text = "Save changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.updateCategoriesButton_Click);
            // 
            // deleteCategoriesButton
            // 
            this.deleteCategoriesButton.Location = new System.Drawing.Point(475, 32);
            this.deleteCategoriesButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCategoriesButton.Name = "deleteCategoriesButton";
            this.deleteCategoriesButton.Size = new System.Drawing.Size(140, 36);
            this.deleteCategoriesButton.TabIndex = 2;
            this.deleteCategoriesButton.Text = "Delete selected";
            this.deleteCategoriesButton.UseVisualStyleBackColor = true;
            this.deleteCategoriesButton.Click += new System.EventHandler(this.deleteCategoriesButton_Click);
            // 
            // categoriesGroup
            // 
            this.categoriesGroup.Controls.Add(this.LoadButton);
            this.categoriesGroup.Controls.Add(this.deleteCategoriesButton);
            this.categoriesGroup.Controls.Add(this.saveChangesButton);
            this.categoriesGroup.Location = new System.Drawing.Point(5, 208);
            this.categoriesGroup.Margin = new System.Windows.Forms.Padding(4);
            this.categoriesGroup.Name = "categoriesGroup";
            this.categoriesGroup.Padding = new System.Windows.Forms.Padding(4);
            this.categoriesGroup.Size = new System.Drawing.Size(724, 694);
            this.categoriesGroup.TabIndex = 6;
            this.categoriesGroup.TabStop = false;
            this.categoriesGroup.Text = "Categories";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(146, 32);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(152, 36);
            this.LoadButton.TabIndex = 3;
            this.LoadButton.Text = "Load Categories";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 948);
            this.Controls.Add(this.loadCategoriesButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.categoriesDataGridView);
            this.Controls.Add(this.categoriesGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Northwind category editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            this.categoriesGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox loginTextbox;
        private TextBox passwordTextbox;
        private Label loginLabel;
        private Label passwordLabel;
        private Button loadCategoriesButton;
        private GroupBox groupBox1;
        private CheckBox useWindowsAuthCheckbox;
        private DataGridView categoriesDataGridView;
        private Button saveChangesButton;
        private Button deleteCategoriesButton;
        private GroupBox categoriesGroup;
        private Button LoadButton;
    }
}