﻿namespace Lab9Ex1CustomerManager
{
    partial class CustomerViewer
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
            this.customerList = new System.Windows.Forms.ComboBox();
            this.orderlistBox = new System.Windows.Forms.ListBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.textBoxage = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderradioButton = new System.Windows.Forms.RadioButton();
            this.CustomerradioButton = new System.Windows.Forms.RadioButton();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.vipOrderRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerList
            // 
            this.customerList.FormattingEnabled = true;
            this.customerList.Location = new System.Drawing.Point(11, 23);
            this.customerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(167, 24);
            this.customerList.TabIndex = 0;
            // 
            // orderlistBox
            // 
            this.orderlistBox.FormattingEnabled = true;
            this.orderlistBox.ItemHeight = 16;
            this.orderlistBox.Location = new System.Drawing.Point(11, 63);
            this.orderlistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderlistBox.Name = "orderlistBox";
            this.orderlistBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.orderlistBox.Size = new System.Drawing.Size(167, 132);
            this.orderlistBox.TabIndex = 1;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(266, 23);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(101, 22);
            this.textBoxname.TabIndex = 2;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(266, 49);
            this.textBoxlastname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(101, 22);
            this.textBoxlastname.TabIndex = 3;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(266, 74);
            this.textBoxmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(101, 22);
            this.textBoxmail.TabIndex = 4;
            // 
            // textBoxage
            // 
            this.textBoxage.Location = new System.Drawing.Point(266, 104);
            this.textBoxage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxage.Name = "textBoxage";
            this.textBoxage.Size = new System.Drawing.Size(101, 22);
            this.textBoxage.TabIndex = 5;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(266, 138);
            this.buttonFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(100, 57);
            this.buttonFile.TabIndex = 6;
            this.buttonFile.Text = "Выберете файл..";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Возраст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Фото";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(385, 22);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 47);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить данные";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(484, 23);
            this.buttonOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(87, 46);
            this.buttonOut.TabIndex = 13;
            this.buttonOut.Text = "Показать данные";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(577, 25);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(124, 21);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(577, 50);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(124, 19);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vipOrderRadioButton);
            this.groupBox1.Controls.Add(this.OrderradioButton);
            this.groupBox1.Controls.Add(this.CustomerradioButton);
            this.groupBox1.Location = new System.Drawing.Point(385, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(316, 80);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            // 
            // OrderradioButton
            // 
            this.OrderradioButton.AutoSize = true;
            this.OrderradioButton.Location = new System.Drawing.Point(134, 32);
            this.OrderradioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderradioButton.Name = "OrderradioButton";
            this.OrderradioButton.Size = new System.Drawing.Size(69, 20);
            this.OrderradioButton.TabIndex = 1;
            this.OrderradioButton.TabStop = true;
            this.OrderradioButton.Text = "Orders";
            this.OrderradioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerradioButton
            // 
            this.CustomerradioButton.AutoSize = true;
            this.CustomerradioButton.Location = new System.Drawing.Point(25, 32);
            this.CustomerradioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerradioButton.Name = "CustomerradioButton";
            this.CustomerradioButton.Size = new System.Drawing.Size(92, 20);
            this.CustomerradioButton.TabIndex = 0;
            this.CustomerradioButton.TabStop = true;
            this.CustomerradioButton.Text = "Customers";
            this.CustomerradioButton.UseVisualStyleBackColor = true;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(385, 183);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(20, 16);
            this.labelid.TabIndex = 17;
            this.labelid.Text = "ID";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(424, 183);
            this.textBoxCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(277, 22);
            this.textBoxCustomer.TabIndex = 18;
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 226);
            this.GridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridView.Name = "GridView";
            this.GridView.RowHeadersWidth = 62;
            this.GridView.RowTemplate.Height = 28;
            this.GridView.Size = new System.Drawing.Size(711, 232);
            this.GridView.TabIndex = 19;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // vipOrderRadioButton
            // 
            this.vipOrderRadioButton.AutoSize = true;
            this.vipOrderRadioButton.Location = new System.Drawing.Point(222, 32);
            this.vipOrderRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vipOrderRadioButton.Name = "vipOrderRadioButton";
            this.vipOrderRadioButton.Size = new System.Drawing.Size(93, 20);
            this.vipOrderRadioButton.TabIndex = 2;
            this.vipOrderRadioButton.TabStop = true;
            this.vipOrderRadioButton.Text = "VIP Orders";
            this.vipOrderRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustomerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 458);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxage);
            this.Controls.Add(this.textBoxmail);
            this.Controls.Add(this.textBoxlastname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.orderlistBox);
            this.Controls.Add(this.customerList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerViewer";
            this.Text = "Customer Viewer";
            this.Load += new System.EventHandler(this.CustomerViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerList;
        private System.Windows.Forms.ListBox orderlistBox;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.TextBox textBoxage;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton OrderradioButton;
        private System.Windows.Forms.RadioButton CustomerradioButton;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.RadioButton vipOrderRadioButton;
    }
}

