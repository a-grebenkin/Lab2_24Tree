namespace Lab2_24Tree
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
            this.button_test = new System.Windows.Forms.Button();
            this.button_redrav = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.iterInfo = new System.Windows.Forms.Label();
            this.renderBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(893, 659);
            this.button_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(179, 102);
            this.button_test.TabIndex = 18;
            this.button_test.Text = "Тест";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // button_redrav
            // 
            this.button_redrav.Location = new System.Drawing.Point(13, 744);
            this.button_redrav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_redrav.Name = "button_redrav";
            this.button_redrav.Size = new System.Drawing.Size(268, 36);
            this.button_redrav.TabIndex = 17;
            this.button_redrav.Text = "Обновить";
            this.button_redrav.UseVisualStyleBackColor = true;
            this.button_redrav.Click += new System.EventHandler(this.button_redrav_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 708);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(276, 29);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Показывать пустые эл.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(485, 660);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Значение";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(412, 689);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 31);
            this.textBox1.TabIndex = 14;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(672, 659);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(197, 42);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(672, 710);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(197, 42);
            this.button_delete.TabIndex = 19;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(672, 760);
            this.load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(197, 36);
            this.load.TabIndex = 20;
            this.load.Text = "Загрузить";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(439, 725);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Кол-во чисел (n)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(412, 758);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 31);
            this.textBox2.TabIndex = 22;
            // 
            // iterInfo
            // 
            this.iterInfo.Location = new System.Drawing.Point(13, 784);
            this.iterInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterInfo.Name = "iterInfo";
            this.iterInfo.Size = new System.Drawing.Size(391, 29);
            this.iterInfo.TabIndex = 23;
            this.iterInfo.Text = "Кол-во итераций: 0";
            // 
            // renderBox
            // 
            this.renderBox.Location = new System.Drawing.Point(13, 666);
            this.renderBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(187, 30);
            this.renderBox.TabIndex = 24;
            this.renderBox.Text = "Рендерить?";
            this.renderBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 824);
            this.Controls.Add(this.renderBox);
            this.Controls.Add(this.iterInfo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.load);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_redrav);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_add);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "howto_generic_treenode";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.CheckBox renderBox;

        private System.Windows.Forms.Label iterInfo;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button load;

        #endregion

        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button_redrav;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
    }
}

