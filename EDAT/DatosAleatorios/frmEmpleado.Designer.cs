namespace DatosAleatorios
{
    partial class frmEmpleado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            Seguro = new CheckBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(Seguro);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(33, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(726, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del empleado";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 275);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 10;
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 275);
            label5.Name = "label5";
            label5.Size = new Size(48, 17);
            label5.TabIndex = 9;
            label5.Text = "Sueldo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 239);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 8;
            label4.Text = "Grupo";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(171, 192);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 21);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Femenino";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(171, 165);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(85, 21);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Masculino";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(100, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 125);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 4;
            label3.Text = "Fecha nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 77);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(149, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 25);
            textBox3.TabIndex = 11;
            // 
            // Seguro
            // 
            Seguro.AutoSize = true;
            Seguro.Location = new Point(169, 323);
            Seguro.Name = "Seguro";
            Seguro.Size = new Size(116, 21);
            Seguro.TabIndex = 12;
            Seguro.Text = "Seguro médico";
            Seguro.UseVisualStyleBackColor = true;
            Seguro.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(35, 362);
            button1.Name = "button1";
            button1.Size = new Size(602, 32);
            button1.TabIndex = 13;
            button1.Text = "Generar datos aleatorios";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(149, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(68, 25);
            comboBox1.TabIndex = 14;
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmEmpleado";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label6;
        private CheckBox Seguro;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Button button1;
    }
}
