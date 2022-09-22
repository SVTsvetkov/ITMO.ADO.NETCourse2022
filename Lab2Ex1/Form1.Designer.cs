namespace Lab2Ex1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dBConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьСоединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBConnectionToolStripMenuItem,
            this.отключитьСоединениеToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dBConnectionToolStripMenuItem
            // 
            this.dBConnectionToolStripMenuItem.Name = "dBConnectionToolStripMenuItem";
            this.dBConnectionToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.dBConnectionToolStripMenuItem.Text = "DBConnection";
            this.dBConnectionToolStripMenuItem.Click += new System.EventHandler(this.dBConnectionToolStripMenuItem_Click);
            // 
            // отключитьСоединениеToolStripMenuItem
            // 
            this.отключитьСоединениеToolStripMenuItem.Name = "отключитьСоединениеToolStripMenuItem";
            this.отключитьСоединениеToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.отключитьСоединениеToolStripMenuItem.Text = "отключить соединение";
            this.отключитьСоединениеToolStripMenuItem.Click += new System.EventHandler(this.отключитьСоединениеToolStripMenuItem_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // списокПодключенийToolStripMenuItem1
            // 
            this.списокПодключенийToolStripMenuItem1.Name = "списокПодключенийToolStripMenuItem1";
            this.списокПодключенийToolStripMenuItem1.Size = new System.Drawing.Size(140, 20);
            this.списокПодключенийToolStripMenuItem1.Text = "Список подключений";
            this.списокПодключенийToolStripMenuItem1.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сколько продуктов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьСоединениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

