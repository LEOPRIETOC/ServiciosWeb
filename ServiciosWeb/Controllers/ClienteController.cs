using ServiciosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServiciosWeb.Controllers
{
    public class ClienteController : ApiController
    {
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            using (var context = new ProductoContext())
            {
                return context.Cliente.ToList();
            }

        }

        [HttpGet]
        public Cliente Get(int id)
        {
            using (var context = new ProductoContext())
            {
                return context.Cliente.FirstOrDefault(X => X.Id == id);
            }

        }
        [HttpPost]
        public Cliente Post(Cliente cliente)
        {
            using (var context = new ProductoContext())
            {
                context.Cliente.Add(cliente);
                context.SaveChanges();
                return cliente;
            }

        }
        [HttpPut]
        public Cliente Put(Cliente cliente)
        {
            using (var context = new ProductoContext())
            {
                var ClienteActualizar = context.Cliente.FirstOrDefault(x => x.Id == cliente.Id);
                ClienteActualizar.Nombres = cliente.Nombres;
                ClienteActualizar.Apellidos = cliente.Apellidos;
                ClienteActualizar.Direccion = cliente.Direccion;
                ClienteActualizar.Celular = cliente.Celular;
                ClienteActualizar.Estrato = cliente.Estrato;
                ClienteActualizar.FechaNacimiento = cliente.FechaNacimiento;
                context.SaveChanges();
                return cliente;
            }
        }

        [HttpDelete]
        public bool Delete(int Id)
        {
            using (var context = new ProductoContext())
            {
                var productoEliminar = context.Productos.FirstOrDefault(x => x.Id == Id);
                context.Productos.Remove(productoEliminar);
                context.SaveChanges();
                return true;
            }
        }
    }
}