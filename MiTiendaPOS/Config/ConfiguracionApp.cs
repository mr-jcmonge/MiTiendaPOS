using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaPOS.Config
{
    public static class ConfiguracionApp
    {
        private const string Archivo = "appsettings.json";

        public static string ObtenerCadenaConexion(
            string nombre = "MiTiendaPOSDb")
        {
            string rutaExe = Path.Combine(AppContext.BaseDirectory, Archivo);
            string rutaBase = File.Exists(rutaExe)
                ? AppContext.BaseDirectory
                : Directory.GetCurrentDirectory();

            IConfigurationRoot configuracion = new ConfigurationBuilder()
                .SetBasePath(rutaBase)
                .AddJsonFile(Archivo, optional: false, reloadOnChange: false)
                .Build();

            return configuracion.GetConnectionString(nombre)
                ?? throw new InvalidOperationException(
                    $"Falta la cadena '{nombre}' en {Archivo}.");

        }
    }
}
