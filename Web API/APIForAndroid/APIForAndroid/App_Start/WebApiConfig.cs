using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace APIForAndroid
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
            json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "LoginApi",
                routeTemplate: "api-login",
                defaults: new { controller="Account", action="Login" }
            );

            config.Routes.MapHttpRoute(
                name: "getCate",
                routeTemplate: "api-getCategory",
                defaults: new { controller = "Category", action = "getCategory" }
            );

            config.Routes.MapHttpRoute(
                name: "getNew",
                routeTemplate: "api-getNewProduct",
                defaults: new { controller = "Product", action = "getNewProduct" }
            );

            config.Routes.MapHttpRoute(
                name: "getProduct",
                routeTemplate: "api-getProduct",
                defaults: new { controller = "Product", action = "Get" }
            );

            config.Routes.MapHttpRoute(
                name: "getProbyCate",
                routeTemplate: "api-getProbyCate/{idCate}",
                defaults: new {controller = "Product", action = "getProbyCate", idCate = RouteParameter.Optional }
            );
        }
    }
}
