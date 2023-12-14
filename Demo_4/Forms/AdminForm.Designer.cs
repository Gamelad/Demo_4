namespace Demo_4.Forms
{
    partial class AdminForm
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
            this.pnl_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.box_Sort = new System.Windows.Forms.ComboBox();
            this.box_Filter = new System.Windows.Forms.ComboBox();
            this.box_Search = new System.Windows.Forms.TextBox();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Sort = new System.Windows.Forms.Label();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_Product
            // 
            this.pnl_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Product.AutoScroll = true;
            this.pnl_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Product.Location = new System.Drawing.Point(5, 95);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.Size = new System.Drawing.Size(1040, 560);
            this.pnl_Product.TabIndex = 0;
            // 
            // box_Sort
            // 
            this.box_Sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Sort.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Sort.FormattingEnabled = true;
            this.box_Sort.Items.AddRange(new object[] {
            "Без сортировки",
            "По возрастанию",
            "По убыванию"});
            this.box_Sort.Location = new System.Drawing.Point(10, 55);
            this.box_Sort.Name = "box_Sort";
            this.box_Sort.Size = new System.Drawing.Size(215, 31);
            this.box_Sort.TabIndex = 1;
            this.box_Sort.SelectedIndexChanged += new System.EventHandler(this.box_Sort_SelectedIndexChanged);
            // 
            // box_Filter
            // 
            this.box_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Filter.FormattingEnabled = true;
            this.box_Filter.Items.AddRange(new object[] {
            "15%-55%",
            "55%-89%"});
            this.box_Filter.Location = new System.Drawing.Point(236, 56);
            this.box_Filter.Name = "box_Filter";
            this.box_Filter.Size = new System.Drawing.Size(215, 31);
            this.box_Filter.TabIndex = 2;
            this.box_Filter.SelectedIndexChanged += new System.EventHandler(this.box_Filter_SelectedIndexChanged);
            // 
            // box_Search
            // 
            this.box_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Search.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Search.Location = new System.Drawing.Point(460, 55);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(585, 30);
            this.box_Search.TabIndex = 3;
            this.box_Search.TextChanged += new System.EventHandler(this.box_Search_TextChanged);
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Exit.Location = new System.Drawing.Point(1120, 5);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(92, 28);
            this.lbl_Exit.TabIndex = 9;
            this.lbl_Exit.Text = "<--Назад";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Enter.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Enter.Location = new System.Drawing.Point(1050, 55);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(160, 55);
            this.btn_Enter.TabIndex = 10;
            this.btn_Enter.Text = "Добавить";
            this.btn_Enter.UseVisualStyleBackColor = true;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Remove.Location = new System.Drawing.Point(1050, 125);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(160, 45);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Сбросить";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(840, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(265, 33);
            this.lbl_Title.TabIndex = 12;
            this.lbl_Title.Text = "Окно администратора";
            // 
            // lbl_Sort
            // 
            this.lbl_Sort.AutoSize = true;
            this.lbl_Sort.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Sort.Location = new System.Drawing.Point(11, 31);
            this.lbl_Sort.Name = "lbl_Sort";
            this.lbl_Sort.Size = new System.Drawing.Size(98, 23);
            this.lbl_Sort.TabIndex = 13;
            this.lbl_Sort.Text = "Сортировка";
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Filter.Location = new System.Drawing.Point(236, 31);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(101, 23);
            this.lbl_Filter.TabIndex = 14;
            this.lbl_Filter.Text = "Фильтрация";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Search.Location = new System.Drawing.Point(461, 31);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(60, 23);
            this.lbl_Search.TabIndex = 15;
            this.lbl_Search.Text = "Поиск";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 664);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.lbl_Sort);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.box_Filter);
            this.Controls.Add(this.box_Sort);
            this.Controls.Add(this.pnl_Product);
            this.MinimumSize = new System.Drawing.Size(1240, 720);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администрирование";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_Product;
        private System.Windows.Forms.ComboBox box_Sort;
        private System.Windows.Forms.ComboBox box_Filter;
        private System.Windows.Forms.TextBox box_Search;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Sort;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.Label lbl_Search;
    }
}