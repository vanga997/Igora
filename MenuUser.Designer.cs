namespace PracticeIgora
{
    partial class MenuUser
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.all_clients = new System.Windows.Forms.Button();
            this.all_requests = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(13, 250);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Старший смены";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Location = new System.Drawing.Point(13, 38);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(35, 13);
            this.fio.TabIndex = 5;
            this.fio.Text = "label2";
            // 
            // all_clients
            // 
            this.all_clients.Location = new System.Drawing.Point(119, 69);
            this.all_clients.Name = "all_clients";
            this.all_clients.Size = new System.Drawing.Size(98, 23);
            this.all_clients.TabIndex = 8;
            this.all_clients.Text = "Все клиенты";
            this.all_clients.UseVisualStyleBackColor = true;
            this.all_clients.Click += new System.EventHandler(this.all_clients_Click);
            // 
            // all_requests
            // 
            this.all_requests.Location = new System.Drawing.Point(225, 69);
            this.all_requests.Name = "all_requests";
            this.all_requests.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.all_requests.Size = new System.Drawing.Size(100, 23);
            this.all_requests.TabIndex = 9;
            this.all_requests.Text = "Все заказы";
            this.all_requests.UseVisualStyleBackColor = true;
            this.all_requests.Click += new System.EventHandler(this.all_requests_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 160);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PracticeIgora.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(225, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // MenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 285);
            this.Controls.Add(this.all_requests);
            this.Controls.Add(this.all_clients);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.MaximumSize = new System.Drawing.Size(353, 324);
            this.MinimumSize = new System.Drawing.Size(353, 324);
            this.Name = "MenuUser";
            this.Text = "Меню пользователя";
            this.Load += new System.EventHandler(this.MenuUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button all_clients;
        private System.Windows.Forms.Button all_requests;
    }
}