namespace Demo_4
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.box_Login = new System.Windows.Forms.TextBox();
            this.box_Password = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.box_Check = new System.Windows.Forms.CheckBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lbl_Visit = new System.Windows.Forms.Label();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // box_Login
            // 
            this.box_Login.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Login.Location = new System.Drawing.Point(231, 182);
            this.box_Login.Name = "box_Login";
            this.box_Login.Size = new System.Drawing.Size(236, 35);
            this.box_Login.TabIndex = 0;
            // 
            // box_Password
            // 
            this.box_Password.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Password.Location = new System.Drawing.Point(230, 265);
            this.box_Password.Name = "box_Password";
            this.box_Password.Size = new System.Drawing.Size(236, 35);
            this.box_Password.TabIndex = 1;
            this.box_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(276, 85);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(146, 33);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Окно входа";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Login.Location = new System.Drawing.Point(230, 155);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(58, 23);
            this.lbl_Login.TabIndex = 3;
            this.lbl_Login.Text = "Логин";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Password.Location = new System.Drawing.Point(230, 240);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(69, 23);
            this.lbl_Password.TabIndex = 4;
            this.lbl_Password.Text = "Пароль";
            // 
            // box_Check
            // 
            this.box_Check.AutoSize = true;
            this.box_Check.Checked = true;
            this.box_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.box_Check.Location = new System.Drawing.Point(470, 275);
            this.box_Check.Name = "box_Check";
            this.box_Check.Size = new System.Drawing.Size(22, 21);
            this.box_Check.TabIndex = 5;
            this.box_Check.UseVisualStyleBackColor = true;
            this.box_Check.CheckedChanged += new System.EventHandler(this.box_Check_CheckedChanged);
            // 
            // btn_Enter
            // 
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Enter.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Enter.Location = new System.Drawing.Point(247, 315);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(205, 55);
            this.btn_Enter.TabIndex = 6;
            this.btn_Enter.Text = "Войти";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lbl_Visit
            // 
            this.lbl_Visit.AutoSize = true;
            this.lbl_Visit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Visit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Visit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Visit.Location = new System.Drawing.Point(267, 380);
            this.lbl_Visit.Name = "lbl_Visit";
            this.lbl_Visit.Size = new System.Drawing.Size(164, 28);
            this.lbl_Visit.TabIndex = 7;
            this.lbl_Visit.Text = "Войти как гость";
            this.lbl_Visit.Click += new System.EventHandler(this.lbl_Visit_Click);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Exit.Location = new System.Drawing.Point(615, 5);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(76, 28);
            this.lbl_Exit.TabIndex = 8;
            this.lbl_Exit.Text = "Выйти";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(698, 464);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.lbl_Visit);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.box_Check);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.box_Password);
            this.Controls.Add(this.box_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 520);
            this.MinimumSize = new System.Drawing.Size(720, 520);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_Login;
        private System.Windows.Forms.TextBox box_Password;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.CheckBox box_Check;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Label lbl_Visit;
        private System.Windows.Forms.Label lbl_Exit;
    }
}

