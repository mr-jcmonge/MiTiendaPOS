using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTiendaPOS.Services
{
    public class CategoriaService
    {
        //Metodo para traer todas las categorias que coincidan con el filtro
        public List<Categoria> Listar(string filtro="")
        {
            using var ctx = new MiTiendaPOSContext();
            IQueryable<Categoria> consulta = ctx.Categorias.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(filtro))
                consulta = consulta.Where(c => c.Nombre.Contains(filtro.Trim()));
            return consulta.OrderBy(c=>c.Nombre).ToList();
        }
        //READ
        public Categoria? ObtenerPorId(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Categorias.Find(id);
        }
        //CREATE
        public void Crear(Categoria categoria)
        {
            using var ctx = new MiTiendaPOSContext();
            Validar(ctx, categoria);
            ctx.Categorias.Add(categoria);
            ctx.SaveChanges();
        }
        //UPDATE
        public void Actualizar(Categoria categoria)
        {
            using var ctx = new MiTiendaPOSContext();
            Categoria existente = ctx.Categorias.Find(categoria.Id)
                ?? throw new InvalidOperationException("La categoria ya no existe");
            Validar(ctx, categoria);
            existente.Nombre = categoria.Nombre;
            ctx.SaveChanges();
        }
        //DELETE
        public void Eliminar(int id) {
            using var ctx = new MiTiendaPOSContext();
            Categoria categoria = ctx.Categorias.Find(id)
                ?? throw new InvalidOperationException("La categoria ya no existe");
            //validamos si ya tiene productos asociados
            if (ctx.Productos.Any(p => p.CategoriaId == id))
                throw new InvalidOperationException("No se puede eliminar: esta" +
                    "categoria tiene productos asociados");

            ctx.Categorias.Remove(categoria);
            ctx.SaveChanges();
        }
        //Reglas del negocio 
        private static void Validar(MiTiendaPOSContext ctx, Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new ArgumentException("El nombre es obligatorio.");
            categoria.Nombre = categoria.Nombre.Trim();

            bool duplicado = ctx.Categorias.Any(c=>c.Nombre == categoria.Nombre
            && c.Id == categoria.Id);

            if (duplicado)
                throw new InvalidOperationException("Ya existe una categoria con" +
                    "ese nombre.");
        }

    }
}
