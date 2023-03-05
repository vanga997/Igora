namespace PracticeIgora
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_request = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.adm_label = new System.Windows.Forms.Label();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.igoraDataSet = new PracticeIgora.igoraDataSet();
            this.igoraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new PracticeIgora.igoraDataSetTableAdapters.clientTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_employee
            // 
            this.btn_employee.Location = new System.Drawing.Point(250, 57);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(75, 23);
            this.btn_employee.TabIndex = 0;
            this.btn_employee.Text = "Сотрудники";
            this.btn_employee.UseVisualStyleBackColor = true;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // btn_client
            // 
            this.btn_client.Location = new System.Drawing.Point(250, 86);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(75, 23);
            this.btn_client.TabIndex = 0;
            this.btn_client.Text = "Клиенты";
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_request
            // 
            this.btn_request.Location = new System.Drawing.Point(250, 115);
            this.btn_request.Name = "btn_request";
            this.btn_request.Size = new System.Drawing.Size(75, 23);
            this.btn_request.TabIndex = 0;
            this.btn_request.Text = "Заказы";
            this.btn_request.UseVisualStyleBackColor = true;
            this.btn_request.Click += new System.EventHandler(this.btn_request_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 249);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // adm_label
            // 
            this.adm_label.AutoSize = true;
            this.adm_label.Location = new System.Drawing.Point(9, 31);
            this.adm_label.Name = "adm_label";
            this.adm_label.Size = new System.Drawing.Size(0, 13);
            this.adm_label.TabIndex = 3;
            this.adm_label.Click += new System.EventHandler(this.adm_label_Click);
            // 
            // btn_service
            // 
            this.btn_service.Location = new System.Drawing.Point(250, 144);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(75, 23);
            this.btn_service.TabIndex = 0;
            this.btn_service.Text = "Услуги";
            this.btn_service.UseVisualStyleBackColor = true;
            this.btn_service.Click += new System.EventHandler(this.btn_service_Click);
            // 
            // btn_history
            // 
            this.btn_history.Location = new System.Drawing.Point(250, 173);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(75, 23);
            this.btn_history.TabIndex = 4;
            this.btn_history.Text = "История входа";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PracticeIgora.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(250, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PracticeIgora.Properties.Resources.Федоров;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // igoraDataSet
            // 
            this.igoraDataSet.DataSetName = "igoraDataSet";
            this.igoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // igoraDataSetBindingSource
            // 
            this.igoraDataSetBindingSource.DataSource = this.igoraDataSet;
            this.igoraDataSetBindingSource.Position = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.igoraDataSetBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Администратор";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.adm_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.btn_request);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_employee);
            this.MaximumSize = new System.Drawing.Size(353, 324);
            this.MinimumSize = new System.Drawing.Size(353, 324);
            this.Name = "Menu";
            this.Text = "Меню администратора";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igoraDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_request;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label adm_label;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource igoraDataSetBindingSource;
        private igoraDataSet igoraDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private igoraDataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}