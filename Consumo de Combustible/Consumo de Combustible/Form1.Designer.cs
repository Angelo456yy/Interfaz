namespace Consumo_de_Combustible
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            distancia = new TextBox();
            rendimiento = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            Gas = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(293, 26);
            label1.Name = "label1";
            label1.Size = new Size(192, 26);
            label1.TabIndex = 0;
            label1.Text = "Consumo de Gas";
            label1.Click += label1_Click;
            // 
            // distancia
            // 
            distancia.Location = new Point(169, 164);
            distancia.Name = "distancia";
            distancia.Size = new Size(142, 23);
            distancia.TabIndex = 1;
            distancia.TextChanged += distancia_TextChanged;
            // 
            // rendimiento
            // 
            rendimiento.Location = new Point(445, 164);
            rendimiento.Name = "rendimiento";
            rendimiento.Size = new Size(142, 23);
            rendimiento.TabIndex = 2;
            rendimiento.TextChanged += rendimiento_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 64);
            label2.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(189, 114);
            label2.Name = "label2";
            label2.Size = new Size(122, 26);
            label2.TabIndex = 3;
            label2.Text = "Distancia";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Stencil", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(313, 217);
            button1.Name = "button1";
            button1.Size = new Size(143, 60);
            button1.TabIndex = 5;
            button1.Text = "Calcular Gas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 64);
            label3.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(435, 114);
            label3.Name = "label3";
            label3.Size = new Size(164, 26);
            label3.TabIndex = 4;
            label3.Text = "Rendimiento ";
            // 
            // Gas
            // 
            Gas.AutoSize = true;
            Gas.BackColor = Color.White;
            Gas.BorderStyle = BorderStyle.FixedSingle;
            Gas.Font = new Font("Segoe UI Symbol", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gas.ForeColor = SystemColors.ActiveCaptionText;
            Gas.Location = new Point(360, 299);
            Gas.Name = "Gas";
            Gas.Size = new Size(58, 30);
            Gas.TabIndex = 6;
            Gas.Text = "Gass";
            Gas.Click += Gas_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 64);
            label4.Font = new Font("Showcard Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(229, 301);
            label4.Name = "label4";
            label4.Size = new Size(105, 26);
            label4.TabIndex = 7;
            label4.Text = "Galones";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 95);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(Gas);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rendimiento);
            Controls.Add(distancia);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(192, 64, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox distancia;
        private TextBox rendimiento;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label Gas;
        private Label label4;
        private PictureBox pictureBox1;
    }
}
