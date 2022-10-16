using Portafolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Cormerce realizado en ASP.NET Core",
                    Link = "https://amazon.com",
                    ImagenURL =""
                },
                new Proyecto
                {
                    Titulo = "Ebay",
                    Descripcion = "E-Cormerce realizado en ASP.NET Core",
                    Link = "https://ebay.com",
                    ImagenURL =""
                },
                new Proyecto
                {
                    Titulo = "Ebay 2",
                    Descripcion = "E-Cormerce realizado en ASP.NET Core",
                    Link = "https://ebay.com",
                    ImagenURL =""
                }
            };
        }
    }
}
