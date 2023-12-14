namespace Demo_4.Forms
{
    partial class ProductForm
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
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.lbl_Sort = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Order = new System.Windows.Forms.Button();
            this.lbl_Exit = new System.Windows.Forms.Label();
            this.box_Search = new System.Windows.Forms.TextBox();
            this.box_Filter = new System.Windows.Forms.ComboBox();
            this.box_Sort = new System.Windows.Forms.ComboBox();
            this.pnl_Product = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Search.Location = new System.Drawing.Point(462, 33);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(60, 23);
            this.lbl_Search.TabIndex = 26;
            this.lbl_Search.Text = "Поиск";
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Filter.Location = new System.Drawing.Point(237, 33);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(101, 23);
            this.lbl_Filter.TabIndex = 25;
            this.lbl_Filter.Text = "Фильтрация";
            // 
            // lbl_Sort
            // 
            this.lbl_Sort.AutoSize = true;
            this.lbl_Sort.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Sort.Location = new System.Drawing.Point(12, 33);
            this.lbl_Sort.Name = "lbl_Sort";
            this.lbl_Sort.Size = new System.Drawing.Size(98, 23);
            this.lbl_Sort.TabIndex = 24;
            this.lbl_Sort.Text = "Сортировка";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Title.Location = new System.Drawing.Point(915, 5);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(193, 33);
            this.lbl_Title.TabIndex = 23;
            this.lbl_Title.Text = "Список товаров";
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Remove.Location = new System.Drawing.Point(1051, 127);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(160, 45);
            this.btn_Remove.TabIndex = 22;
            this.btn_Remove.Text = "Сбросить";
            this.btn_Remove.UseVisualStyleBackColor = true;
            // 
            // btn_Order
            // 
            this.btn_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Order.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Order.Location = new System.Drawing.Point(1051, 57);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(160, 55);
            this.btn_Order.TabIndex = 21;
            this.btn_Order.Text = "Заказ";
            this.btn_Order.UseVisualStyleBackColor = true;
            // 
            // lbl_Exit
            // 
            this.lbl_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Exit.AutoSize = true;
            this.lbl_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Exit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Exit.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Exit.Location = new System.Drawing.Point(1121, 7);
            this.lbl_Exit.Name = "lbl_Exit";
            this.lbl_Exit.Size = new System.Drawing.Size(92, 28);
            this.lbl_Exit.TabIndex = 20;
            this.lbl_Exit.Text = "<--Назад";
            this.lbl_Exit.Click += new System.EventHandler(this.lbl_Exit_Click);
            // 
            // box_Search
            // 
            this.box_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Search.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Search.Location = new System.Drawing.Point(461, 57);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(585, 30);
            this.box_Search.TabIndex = 19;
            this.box_Search.TextChanged += new System.EventHandler(this.box_Search_TextChanged);
            // 
            // box_Filter
            // 
            this.box_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Filter.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.box_Filter.FormattingEnabled = true;
            this.box_Filter.Items.AddRange(new object[] {
            "15%-55%",
            "55%-89%"});
            this.box_Filter.Location = new System.Drawing.Point(237, 58);
            this.box_Filter.Name = "box_Filter";
            this.box_Filter.Size = new System.Drawing.Size(215, 31);
            this.box_Filter.TabIndex = 18;
            this.box_Filter.SelectedIndexChanged += new System.EventHandler(this.box_Filter_SelectedIndexChanged);
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
            this.box_Sort.Location = new System.Drawing.Point(11, 57);
            this.box_Sort.Name = "box_Sort";
            this.box_Sort.Size = new System.Drawing.Size(215, 31);
            this.box_Sort.TabIndex = 17;
            this.box_Sort.SelectedIndexChanged += new System.EventHandler(this.box_Sort_SelectedIndexChanged);
            // 
            // pnl_Product
            // 
            this.pnl_Product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Product.AutoScroll = true;
            this.pnl_Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Product.Location = new System.Drawing.Point(6, 97);
            this.pnl_Product.Name = "pnl_Product";
            this.pnl_Product.Size = new System.Drawing.Size(1040, 560);
            this.pnl_Product.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Клиент/менеджер";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.lbl_Filter);
            this.Controls.Add(this.lbl_Sort);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Order);
            this.Controls.Add(this.lbl_Exit);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.box_Filter);
            this.Controls.Add(this.box_Sort);
            this.Controls.Add(this.pnl_Product);
            this.MinimumSize = new System.Drawing.Size(1240, 720);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.Label lbl_Sort;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.TextBox box_Search;
        private System.Windows.Forms.ComboBox box_Filter;
        private System.Windows.Forms.ComboBox box_Sort;
        private System.Windows.Forms.FlowLayoutPanel pnl_Product;
        private System.Windows.Forms.Label label1;
    }
}