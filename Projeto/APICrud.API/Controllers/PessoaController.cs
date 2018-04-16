using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Http;
using System.Net.Http;
using ApiCrud.BO.Negocio;
using ApiCrud.BO.Banco;

namespace APICrud.API.Controllers
{
	public class PessoaController : ApiController
	{
		public HttpResponseMessage Get()
		{

			try
			{
				return Request.CreateResponse(HttpStatusCode.OK, PessoaNegocio.listarTodos());
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
				throw;
			}
		}

		public HttpResponseMessage Get(Guid id)
		{
			try
			{
				var b = PessoaNegocio.filtrarPorId(id);
				return Request.CreateResponse(HttpStatusCode.OK, b);
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
				throw;
			}
		}

		public HttpResponseMessage Post([FromBody]Pessoa pessoa)
		{
			try
			{

				PessoaNegocio.cadastrarPessoa(pessoa);
				return Request.CreateResponse(HttpStatusCode.OK,"Cadastrado");
			}
			catch (Exception ex)
			{

				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
				throw;
			}

		}

		public HttpResponseMessage Put(Guid id, [FromBody]Pessoa pessoa)
		{
			try
			{
				PessoaNegocio.alterarPessoa(id, pessoa);
				return Request.CreateResponse(HttpStatusCode.OK, "Editado");
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
				throw;
			}
		}

		public HttpResponseMessage Delete(Guid id)
		{
			try
			{
				PessoaNegocio.deletarPessoa(id);
				return Request.CreateResponse(HttpStatusCode.OK, "Deletou");
			}
			catch (Exception ex)
			{
				return Request.CreateResponse(HttpStatusCode.InternalServerError, ex);
				throw;
			}
		}
	}
}