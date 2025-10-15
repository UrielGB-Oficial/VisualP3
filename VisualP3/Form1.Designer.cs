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
            button1p = new Button();
            button1 = new Button();
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
            // button1p
            // 
            button1p.Location = new Point(259, 132);
            button1p.Margin = new Padding(3, 4, 3, 4);
            button1p.Name = "button1p";
            button1p.Size = new Size(267, 197);
            button1p.TabIndex = 1;
            button1p.Text = "boton pgn";
            button1p.UseVisualStyleBackColor = true;
            button1p.Click += button1p_Click;
            // 
            // button1
            // 
            button1.Location = new Point(581, 226);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button1);
            Controls.Add(button1p);
            Controls.Add(CargarASM);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CargarASM;
        private Button button1p;
        private Button button1;
    }
}
