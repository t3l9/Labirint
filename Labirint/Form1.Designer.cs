namespace Labirint
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_optimal_way = new System.Windows.Forms.Button();
            this.set_random_grid = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.search_optimal_way);
            this.groupBox1.Location = new System.Drawing.Point(236, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 301);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(17, 125);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(150, 160);
            this.lbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Оптимальный путь";
            // 
            // search_optimal_way
            // 
            this.search_optimal_way.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_optimal_way.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_optimal_way.Location = new System.Drawing.Point(17, 19);
            this.search_optimal_way.Name = "search_optimal_way";
            this.search_optimal_way.Size = new System.Drawing.Size(150, 80);
            this.search_optimal_way.TabIndex = 7;
            this.search_optimal_way.Text = "Найти оптимальный путь";
            this.search_optimal_way.UseVisualStyleBackColor = true;
            this.search_optimal_way.Click += new System.EventHandler(this.search_optimal_way_Click_1);
            // 
            // set_random_grid
            // 
            this.set_random_grid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.set_random_grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.set_random_grid.Location = new System.Drawing.Point(12, 44);
            this.set_random_grid.Name = "set_random_grid";
            this.set_random_grid.Size = new System.Drawing.Size(194, 51);
            this.set_random_grid.TabIndex = 6;
            this.set_random_grid.Text = "Создать лабиринт";
            this.set_random_grid.UseVisualStyleBackColor = true;
            this.set_random_grid.Click += new System.EventHandler(this.set_random_grid_Click_1);
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Location = new System.Drawing.Point(12, 123);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.Size = new System.Drawing.Size(194, 187);
            this.grid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.set_random_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search_optimal_way;
        private System.Windows.Forms.Button set_random_grid;
        private System.Windows.Forms.DataGridView grid;
    }
}

