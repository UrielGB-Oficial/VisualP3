namespace VisualP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarASM_Click(object sender, EventArgs e)
        {
            // Crear el cuadro de diálogo
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Configurar filtros para mostrar solo .asm o .txt
            openFileDialog.Filter = "Archivos ASM (*.asm)|*.asm|Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Selecciona un archivo ASM o TXT";

            // Mostrar el cuadro de diálogo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = openFileDialog.FileName;

                // Leer el contenido del archivo
                string contenido = File.ReadAllText(rutaArchivo);

                // Mostrar el contenido (por ejemplo, en un TextBox o en un MessageBox)
                MessageBox.Show("Archivo cargado:\n" + rutaArchivo);

                // Si tienes un TextBox donde mostrar el contenido:
                // textBox1.Text = contenido;
            }
        }

        private void button1p_Click(object sender, EventArgs e)
        {

        }
    }
}
