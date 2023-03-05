namespace PracticeIgora
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.pas = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_off = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Горнолыжный курорт \"Игора\"";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(28, 98);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(38, 13);
            this.login.TabIndex = 1;
            this.login.Text = "Логин";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(27, 124);
            this.password.Name = "password";
            this.password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.password.Size = new System.Drawing.Size(45, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Пароль";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(81, 95);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(100, 20);
            this.log.TabIndex = 3;
            this.log.TextChanged += new System.EventHandler(this.log_TextChanged);
            // 
            // pas
            // 
            this.pas.Location = new System.Drawing.Point(81, 121);
            this.pas.Name = "pas";
            this.pas.PasswordChar = '*';
            this.pas.Size = new System.Drawing.Size(100, 20);
            this.pas.TabIndex = 3;
            this.pas.TextChanged += new System.EventHandler(this.pas_TextChanged);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(180, 202);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(75, 23);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "Вход";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(12, 202);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(119, 23);
            this.btn_off.TabIndex = 5;
            this.btn_off.Text = "Завершение работы";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 247);
            this.Controls.Add(this.btn_off);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.pas);
            this.Controls.Add(this.log);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(286, 286);
            this.MinimumSize = new System.Drawing.Size(286, 286);
            this.Name = "Auth";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox pas;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_off;
    }
}

