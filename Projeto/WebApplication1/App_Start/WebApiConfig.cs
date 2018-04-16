using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApplication1
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services

			// Web API routes
			config.MapHttpAttributeRoutes();

			var cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(cors);

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			config.Routes.MapHttpRoute(
				name: "DefaultApiName",
				routeTemplate: "api/{controller}/{id}/{nome}",
				defaults: new { id = RouteParameter.Optional, nome = RouteParameter.Optional }
			);

			//Enable Cors
			cors = new EnableCorsAttribute("*", "*", "*");
			config.EnableCors(cors);

			//Config return JSON
			var json = config.Formatters.JsonFormatter;
			json.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
			json.Indent = true;

			//Disable return XML
			config.Formatters.Remove(config.Formatters.XmlFormatter);

		}
	}
}
