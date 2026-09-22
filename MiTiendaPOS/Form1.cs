using Microsoft.EntityFrameworkCore;
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
            /* using var contexto = new MiTiendaPOSContext();
             MessageBox.Show("Contexto creado correctamente.");*/

            try
            {
                using var contexto = new MiTiendaPOSContext();

                bool conecta = contexto.Database.CanConnect();
                int categorias = contexto.Categorias.Count();
                int usuarios = contexto.Usuarios.Count();
                int pendientes = contexto.Database.GetPendingMigrations().Count();

                MessageBox.Show(
                    $"Conexión a MiTiendaPOSDb: {(conecta ? "OK" : "FALLÓ")}\n" +
                    $"Categorías registradas: {categorias}\n" +
                    $"Usuarios registrados: {usuarios}\n" +
                    $"Migraciones pendientes: {pendientes}",
                    "MiTiendaPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }   // <- al salir del bloque try se ejecuta Dispose() del contexto
                // El manejo de excepciones se profundiza en la Unidad 4
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "MiTiendaPOS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
