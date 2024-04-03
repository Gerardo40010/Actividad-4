namespace Actividad.VISTA.PedidoVista
{
    partial class PedidoInterfaz
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(27, 328);
            button3.Name = "button3";
            button3.Size = new Size(116, 48);
            button3.TabIndex = 27;
            button3.Text = "ELIMINAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(27, 228);
            button2.Name = "button2";
            button2.Size = new Size(116, 48);
            button2.TabIndex = 26;
            button2.Text = "EDITAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(27, 133);
            button1.Name = "button1";
            button1.Size = new Size(116, 48);
            button1.TabIndex = 25;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 31);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 22;
            label3.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(302, 31);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 21;
            label2.Text = "TOTAL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 20;
            label1.Text = "CLIENTE";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(347, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(68, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(214, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(487, 381);
            dataGridView1.TabIndex = 14;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveCaption;
            dateTimePicker1.Location = new Point(627, 28);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(238, 23);
            dateTimePicker1.TabIndex = 28;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGray;
            button4.Location = new Point(741, 244);
            button4.Name = "button4";
            button4.Size = new Size(98, 32);
            button4.TabIndex = 29;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 74);
            panel1.TabIndex = 30;
            // 
            // PedidoInterfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(878, 493);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "PedidoInterfaz";
            Text = "PedidoInterfaz";
            Load += PedidoInterfaz_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Panel panel1;
    }
}