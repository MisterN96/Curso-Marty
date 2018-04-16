using ApiCrud.BO.Banco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebApplication1.Negocio
{
	public class PessoaNegocio
	{
	/// <summary>
	/// Retornar todas pessoas cadastradas no banco
	/// </summary>
	/// <returns></returns>
		public static List<pessoa> ListarTodos()
		{
			using (var context = new ApiCrudEntity())
			{
				var listaPessoasBanco = context.pessoa.ToList();
				return listaPessoasBanco;
			}
		}

		/// <summary>
		/// Retornar pessoa do id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static pessoa ListarPorID(Guid id)
		{
			using (var context = new ApiCrudEntity())
			{
				var PessoasBanco = context.pessoa.Where(p => p.id_pessoa == id).FirstOrDefault();
				return PessoasBanco;
			}
		}
	}
}