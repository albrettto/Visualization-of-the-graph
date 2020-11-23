namespace Visualization_of_the_graph
{
    partial class Main_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Canvas_Panel = new System.Windows.Forms.Panel();
            this.Clear_Button = new System.Windows.Forms.Button();
            this.Instruct_Label = new System.Windows.Forms.Label();
            this.Numb_TextBox = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Result_TextBox = new System.Windows.Forms.TextBox();
            this.Matrica_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Matrica_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas_Panel
            // 
            this.Canvas_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Canvas_Panel.BackColor = System.Drawing.Color.LightBlue;
            this.Canvas_Panel.Location = new System.Drawing.Point(12, 12);
            this.Canvas_Panel.Name = "Canvas_Panel";
            this.Canvas_Panel.Size = new System.Drawing.Size(416, 397);
            this.Canvas_Panel.TabIndex = 0;
            this.Canvas_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_Panel_MouseDown);
            // 
            // Clear_Button
            // 
            this.Clear_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Clear_Button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Clear_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear_Button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Clear_Button.Location = new System.Drawing.Point(148, 415);
            this.Clear_Button.Name = "Clear_Button";
            this.Clear_Button.Size = new System.Drawing.Size(127, 23);
            this.Clear_Button.TabIndex = 1;
            this.Clear_Button.Text = "Очистить";
            this.Clear_Button.UseVisualStyleBackColor = false;
            this.Clear_Button.Click += new System.EventHandler(this.Clear_Button_Click);
            // 
            // Instruct_Label
            // 
            this.Instruct_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Instruct_Label.AutoSize = true;
            this.Instruct_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instruct_Label.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Instruct_Label.Location = new System.Drawing.Point(519, 262);
            this.Instruct_Label.Name = "Instruct_Label";
            this.Instruct_Label.Size = new System.Drawing.Size(203, 16);
            this.Instruct_Label.TabIndex = 3;
            this.Instruct_Label.Text = "Введите начальную вершину:";
            // 
            // Numb_TextBox
            // 
            this.Numb_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Numb_TextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.Numb_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Numb_TextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.Numb_TextBox.Location = new System.Drawing.Point(594, 281);
            this.Numb_TextBox.Name = "Numb_TextBox";
            this.Numb_TextBox.Size = new System.Drawing.Size(53, 20);
            this.Numb_TextBox.TabIndex = 4;
            this.Numb_TextBox.Text = "1";
            // 
            // Search_Button
            // 
            this.Search_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search_Button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Search_Button.Location = new System.Drawing.Point(554, 349);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(127, 23);
            this.Search_Button.TabIndex = 5;
            this.Search_Button.Text = "Поиск в Ширину";
            this.Search_Button.UseVisualStyleBackColor = false;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Result_TextBox
            // 
            this.Result_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result_TextBox.BackColor = System.Drawing.Color.AliceBlue;
            this.Result_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result_TextBox.Enabled = false;
            this.Result_TextBox.ForeColor = System.Drawing.Color.DarkBlue;
            this.Result_TextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Result_TextBox.Location = new System.Drawing.Point(434, 389);
            this.Result_TextBox.Name = "Result_TextBox";
            this.Result_TextBox.ReadOnly = true;
            this.Result_TextBox.Size = new System.Drawing.Size(354, 20);
            this.Result_TextBox.TabIndex = 6;
            // 
            // Matrica_DataGridView
            // 
            this.Matrica_DataGridView.AllowUserToDeleteRows = false;
            this.Matrica_DataGridView.AllowUserToResizeColumns = false;
            this.Matrica_DataGridView.AllowUserToResizeRows = false;
            this.Matrica_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Matrica_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Matrica_DataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Matrica_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Matrica_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Matrica_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.Matrica_DataGridView.Enabled = false;
            this.Matrica_DataGridView.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.Matrica_DataGridView.Location = new System.Drawing.Point(434, 12);
            this.Matrica_DataGridView.Name = "Matrica_DataGridView";
            this.Matrica_DataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Matrica_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Matrica_DataGridView.ShowCellErrors = false;
            this.Matrica_DataGridView.ShowCellToolTips = false;
            this.Matrica_DataGridView.ShowEditingIcon = false;
            this.Matrica_DataGridView.ShowRowErrors = false;
            this.Matrica_DataGridView.Size = new System.Drawing.Size(354, 229);
            this.Matrica_DataGridView.TabIndex = 7;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Matrica_DataGridView);
            this.Controls.Add(this.Result_TextBox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Numb_TextBox);
            this.Controls.Add(this.Instruct_Label);
            this.Controls.Add(this.Clear_Button);
            this.Controls.Add(this.Canvas_Panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main_Form";
            this.Text = "Лабораторная работа 4";
            ((System.ComponentModel.ISupportInitialize)(this.Matrica_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Canvas_Panel;
        private System.Windows.Forms.Button Clear_Button;
        private System.Windows.Forms.Label Instruct_Label;
        private System.Windows.Forms.TextBox Numb_TextBox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.TextBox Result_TextBox;
        private System.Windows.Forms.DataGridView Matrica_DataGridView;
    }
}

