namespace VisualP3
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
            CargarASM = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // CargarASM
            // 
            CargarASM.Location = new Point(299, 29);
            CargarASM.Name = "CargarASM";
            CargarASM.Size = new Size(190, 67);
            CargarASM.TabIndex = 0;
            CargarASM.Text = "Cargar ASM";
            CargarASM.UseVisualStyleBackColor = true;
            CargarASM.Click += CargarASM_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 163);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 249);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 163);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(378, 249);
            textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(CargarASM);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CargarASM;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
