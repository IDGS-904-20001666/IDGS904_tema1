using IDGS904_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS904_tema1.Services
{
    public class ProductServices
    {
        public List<Productos> ObtenerProducto()
        {
            var productoUno = new Productos()
            {
                Nombre = "Pulque Uno",
                Descripcion = "Frutos Rojos",
                Cantidad = 10,
                Produccion = new DateTime(2023, 11, 5)
            };

            var productoDos = new Productos()
            {
                Nombre = "Pulque Dos",
                Descripcion = "Mango Coco",
                Cantidad = 35,
                Produccion = new DateTime(2023, 10, 2)
            };

            return new List<Productos> { productoUno, productoDos };
        }

    }
}