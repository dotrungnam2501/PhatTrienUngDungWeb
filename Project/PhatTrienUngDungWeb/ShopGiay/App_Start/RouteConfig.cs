using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopGiay
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
             name: "Register",
             url: "register",
             defaults: new { controller = "Register", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "Single",
             url: "single",
             defaults: new { controller = "Single", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
              name: "Login",
              url: "login",
              defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
          );
            routes.MapRoute(
               name: "GioHang",
               url: "gio-hang",
               defaults: new { controller = "GioHang", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "SanPhamShop",
               url: "san-pham-shop",
               defaults: new { controller = "SanPhamShop", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "LienHe",
               url: "lien-he",
               defaults: new { controller = "LienHe", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Site", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
