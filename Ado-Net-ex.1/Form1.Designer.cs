namespace Ado_Net_ex._1
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
            this.connectDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asyncConnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectDBToolStripMenuItem,
            this.disconnectDBToolStripMenuItem,
            this.asyncConnectToolStripMenuItem,
            this.listConnectionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectDBToolStripMenuItem
            // 
            this.connectDBToolStripMenuItem.Name = "connectDBToolStripMenuItem";
            this.connectDBToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.connectDBToolStripMenuItem.Text = "ConnectDB";
            this.connectDBToolStripMenuItem.Click += new System.EventHandler(this.connectDBToolStripMenuItem_Click);
            // 
            // disconnectDBToolStripMenuItem
            // 
            this.disconnectDBToolStripMenuItem.Name = "disconnectDBToolStripMenuItem";
            this.disconnectDBToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.disconnectDBToolStripMenuItem.Text = "DisconnectDB";
            this.disconnectDBToolStripMenuItem.Click += new System.EventHandler(this.disconnectDBToolStripMenuItem_Click);
            // 
            // asyncConnectToolStripMenuItem
            // 
            this.asyncConnectToolStripMenuItem.Name = "asyncConnectToolStripMenuItem";
            this.asyncConnectToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.asyncConnectToolStripMenuItem.Text = "AsyncConnect";
            this.asyncConnectToolStripMenuItem.Click += new System.EventHandler(this.asyncConnectToolStripMenuItem_Click);
            // 
            // listConnectionsToolStripMenuItem
            // 
            this.listConnectionsToolStripMenuItem.Name = "listConnectionsToolStripMenuItem";
            this.listConnectionsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.listConnectionsToolStripMenuItem.Text = "ListConnections";
            this.listConnectionsToolStripMenuItem.Click += new System.EventHandler(this.listConnectionsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сколько продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество продуктов";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сколько продуктов 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество продуктов";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(727, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Список продуктов 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 285);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(727, 97);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название продукта";
            this.columnHeader1.Width = 280;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Цена";
            this.columnHeader2.Width = 245;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фасовка";
            this.columnHeader3.Width = 169;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(473, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 62);
            this.button4.TabIndex = 7;
            this.button4.Text = "Транзакция";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 526);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.ToolStripMenuItem connectDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asyncConnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listConnectionsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button4;
    }
}

