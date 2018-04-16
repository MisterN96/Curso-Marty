using ApiCrud.BO.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Negocio;

namespace WebApplication1.Controllers
{
	public class PessoaController : ApiController
	{
		// GET: api/Pessoa
		public HttpResponseMessage Get()
		{
			try
			{
				return Request.CreateResponse(HttpStatusCode.OK, PessoaNegocio.ListarTodos());
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
			}
		}

		// GET: api/Pessoa/5
		public HttpResponseMessage Get(Guid id)
		{
			try
			{
				return Request.CreateResponse(HttpStatusCode.OK);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
			}
		}

		

		// POST: api/Pessoa
		//public HttpResponseMessage Post([FromBody]pessoa value)
		//{
		//	try
		//	{
		//		pessoa.AddPessoa(value);
		//		return Request.CreateResponse(HttpStatusCode.OK);
		//	}
		//	catch (Exception ex)
		//	{
		//		return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
		//	}
		//}

		//// PUT: api/Pessoa/5
		//public HttpResponseMessage Put(Guid id, [FromBody]pessoa value)
		//{
		//	try
		//	{
		//		pessoa.EditarPessoa(id, value);
		//		return Request.CreateResponse(HttpStatusCode.OK);
		//	}
		//	catch (Exception ex)
		//	{
		//		return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
		//	}
		//}

		//// DELETE: api/Pessoa/5
		//public HttpResponseMessage Delete(Guid id)
		//{
		//	try
		//	{
		//		pessoa.RemoverPessoa(id);
		//		return Request.CreateResponse(HttpStatusCode.OK);
		//	}
		//	catch (Exception ex)
		//	{
		//		return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
		//	}
		//}
	}
}
