using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TechNightMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Livros",
                url: "livros/",
                defaults: new { controller = "Home", action = "Index"}
            );

            routes.MapRoute(
                name: "NovoLivro",
                url: "livros/Novo",
                defaults: new { controller = "Home", action = "NovoLivro" }
            );

            routes.MapRoute(
                name: "EditarLivro",
                url: "livros/Editar/{codigo}",
                defaults: new { controller = "Home", action = "EditarLivro", codigo = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{codigo}",
                defaults: new { controller = "Home", action = "Index", codigo = UrlParameter.Optional }
            );
        }
    }
}
