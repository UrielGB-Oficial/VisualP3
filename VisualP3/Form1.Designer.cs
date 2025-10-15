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
            SuspendLayout();
            // 
            // CargarASM
            // 
            CargarASM.Location = new Point(299, 30);
            CargarASM.Name = "CargarASM";
            CargarASM.Size = new Size(190, 67);
            CargarASM.TabIndex = 0;
            CargarASM.Text = "Cargar ASM";
            CargarASM.UseVisualStyleBackColor = true;
            CargarASM.Click += CargarASM_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CargarASM);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CargarASM;
    }
}
