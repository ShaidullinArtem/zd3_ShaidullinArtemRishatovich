namespace zd3_Shaidullin
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
            this.stallsDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.salesCount_box = new System.Windows.Forms.NumericUpDown();
            this.salesTotal_box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.p_box = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.daySpProduct_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.hitProduct_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stallsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesCount_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTotal_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).BeginInit();
            this.SuspendLayout();
            // 
            // stallsDataGrid
            // 
            this.stallsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stallsDataGrid.Location = new System.Drawing.Point(1, 289);
            this.stallsDataGrid.Name = "stallsDataGrid";
            this.stallsDataGrid.RowTemplate.Height = 24;
            this.stallsDataGrid.Size = new System.Drawing.Size(797, 162);
            this.stallsDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(25, 43);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(139, 22);
            this.name_box.TabIndex = 2;
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(25, 100);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(139, 22);
            this.address_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество продаж";
            // 
            // salesCount_box
            // 
            this.salesCount_box.Location = new System.Drawing.Point(25, 158);
            this.salesCount_box.Name = "salesCount_box";
            this.salesCount_box.Size = new System.Drawing.Size(139, 22);
            this.salesCount_box.TabIndex = 6;
            // 
            // salesTotal_box
            // 
            this.salesTotal_box.Location = new System.Drawing.Point(25, 224);
            this.salesTotal_box.Name = "salesTotal_box";
            this.salesTotal_box.Size = new System.Drawing.Size(139, 22);
            this.salesTotal_box.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Общая выручка";
            // 
            // error
            // 
            this.error.Location = new System.Drawing.Point(479, 17);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(309, 80);
            this.error.TabIndex = 9;
            // 
            // p_box
            // 
            this.p_box.Location = new System.Drawing.Point(223, 43);
            this.p_box.Name = "p_box";
            this.p_box.Size = new System.Drawing.Size(139, 22);
            this.p_box.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(223, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество покупателей";
            // 
            // daySpProduct_box
            // 
            this.daySpProduct_box.Location = new System.Drawing.Point(223, 100);
            this.daySpProduct_box.Name = "daySpProduct_box";
            this.daySpProduct_box.Size = new System.Drawing.Size(139, 22);
            this.daySpProduct_box.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(223, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Товар по акции";
            // 
            // hitProduct_box
            // 
            this.hitProduct_box.Location = new System.Drawing.Point(223, 158);
            this.hitProduct_box.Name = "hitProduct_box";
            this.hitProduct_box.Size = new System.Drawing.Size(139, 22);
            this.hitProduct_box.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(223, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Хит продаж";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(223, 198);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(134, 48);
            this.add_btn.TabIndex = 16;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(379, 198);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(134, 48);
            this.remove_btn.TabIndex = 17;
            this.remove_btn.Text = "Удалить";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(654, 198);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(134, 48);
            this.exit_btn.TabIndex = 18;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.hitProduct_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.daySpProduct_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.p_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.error);
            this.Controls.Add(this.salesTotal_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salesCount_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stallsDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stallsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesCount_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTotal_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button exit_btn;

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button remove_btn;

        private System.Windows.Forms.TextBox daySpProduct_box;
        private System.Windows.Forms.TextBox hitProduct_box;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.NumericUpDown p_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label error;

        private System.Windows.Forms.NumericUpDown salesTotal_box;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.NumericUpDown salesCount_box;

        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox address_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView stallsDataGrid;

        #endregion
    }
}