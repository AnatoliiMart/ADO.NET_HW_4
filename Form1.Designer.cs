namespace ADO.NET_HW_4
{
    partial class Form1
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
            this.dataGrid_Books = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_SearchValue = new System.Windows.Forms.TextBox();
            this.lbl_ValueInputPresenter = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Books)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Books
            // 
            this.dataGrid_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Books.Location = new System.Drawing.Point(12, 0);
            this.dataGrid_Books.Name = "dataGrid_Books";
            this.dataGrid_Books.RowHeadersWidth = 51;
            this.dataGrid_Books.RowTemplate.Height = 24;
            this.dataGrid_Books.Size = new System.Drawing.Size(944, 262);
            this.dataGrid_Books.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 325);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите тип поиска";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_SearchValue
            // 
            this.txtBox_SearchValue.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBox_SearchValue.Location = new System.Drawing.Point(12, 397);
            this.txtBox_SearchValue.Name = "txtBox_SearchValue";
            this.txtBox_SearchValue.Size = new System.Drawing.Size(362, 23);
            this.txtBox_SearchValue.TabIndex = 3;
            // 
            // lbl_ValueInputPresenter
            // 
            this.lbl_ValueInputPresenter.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ValueInputPresenter.Location = new System.Drawing.Point(16, 365);
            this.lbl_ValueInputPresenter.Name = "lbl_ValueInputPresenter";
            this.lbl_ValueInputPresenter.Size = new System.Drawing.Size(358, 29);
            this.lbl_ValueInputPresenter.TabIndex = 4;
            this.lbl_ValueInputPresenter.Text = "lbl_ValueInputPresenter";
            this.lbl_ValueInputPresenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Search.Location = new System.Drawing.Point(508, 351);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(211, 73);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Найти";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 452);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_ValueInputPresenter);
            this.Controls.Add(this.txtBox_SearchValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGrid_Books);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Books;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_SearchValue;
        private System.Windows.Forms.Label lbl_ValueInputPresenter;
        private System.Windows.Forms.Button btn_Search;
    }
}

