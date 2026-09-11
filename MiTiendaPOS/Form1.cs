using MiTiendaPOS.Data;

namespace MiTiendaPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using var contexto = new MiTiendaPOSContext();
            MessageBox.Show("Contexto creado correctamente.");
        }
    }
}
