namespace Tiempo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            A = new TextBox();
            B = new TextBox();
            VC = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(287, 24);
            label1.Name = "label1";
            label1.Size = new Size(233, 40);
            label1.TabIndex = 0;
            label1.Text = "Calcular tiempo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(123, 108);
            label2.Name = "label2";
            label2.Size = new Size(153, 40);
            label2.TabIndex = 1;
            label2.Text = "PUNTO A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(514, 108);
            label3.Name = "label3";
            label3.Size = new Size(152, 40);
            label3.TabIndex = 2;
            label3.Text = "PUNTO B:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(82, 256);
            label4.Name = "label4";
            label4.Size = new Size(288, 40);
            label4.TabIndex = 3;
            label4.Text = "VELOCIDAD CONST:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(514, 256);
            label5.Name = "label5";
            label5.Size = new Size(134, 40);
            label5.TabIndex = 4;
            label5.Text = "TIEMPO:";
            label5.Click += label5_Click;
            // 
            // A
            // 
            A.Location = new Point(123, 161);
            A.Name = "A";
            A.Size = new Size(180, 23);
            A.TabIndex = 5;
            A.TextChanged += A_TextChanged;
            // 
            // B
            // 
            B.Location = new Point(514, 161);
            B.Name = "B";
            B.Size = new Size(180, 23);
            B.TabIndex = 6;
            B.TextChanged += B_TextChanged;
            // 
            // VC
            // 
            VC.Location = new Point(123, 311);
            VC.Name = "VC";
            VC.Size = new Size(180, 23);
            VC.TabIndex = 7;
            VC.TextChanged += VC_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(360, 348);
            button1.Name = "button1";
            button1.Size = new Size(156, 60);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(VC);
            Controls.Add(B);
            Controls.Add(A);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox A;
        private TextBox B;
        private TextBox VC;
        private Button button1;
    }
}
