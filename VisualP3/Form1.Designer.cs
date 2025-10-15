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
            SuspendLayout();
            // 
            // CargarASM
            // 
            CargarASM.Location = new Point(262, 22);
            CargarASM.Margin = new Padding(3, 2, 3, 2);
            CargarASM.Name = "CargarASM";
            CargarASM.Size = new Size(166, 50);
            CargarASM.TabIndex = 0;
            CargarASM.Text = "Cargar ASM";
            CargarASM.UseVisualStyleBackColor = true;
            CargarASM.Click += CargarASM_Click;
            // 
            // button1p
            // 
            button1p.Location = new Point(393, 122);
            button1p.Name = "button1p";
            button1p.Size = new Size(75, 23);
            button1p.TabIndex = 1;
            button1p.Text = "boton p";
            button1p.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1p);
            Controls.Add(CargarASM);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CargarASM;
        private Button button1p;
    }
}
