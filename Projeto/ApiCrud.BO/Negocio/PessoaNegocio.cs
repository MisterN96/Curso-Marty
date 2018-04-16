using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiCrud.BO.Banco;
namespace ApiCrud.BO.Negocio
{
	public class PessoaNegocio
	{
		public static List<Pessoa> listarTodos()
		{
			using (var context = new ApiCrudEntity())
			{
				var listaPessoasBanco = context.Pessoa.ToList();
				return listaPessoasBanco;
			}

		}

		public static Pessoa filtrarPorId(Guid guid)
		{
			using (var context = new ApiCrudEntity())
			{

				var ObjPessoa = from pessoa in context.Pessoa
								where pessoa.id_pessoa == guid
								select pessoa;
				return ObjPessoa.FirstOrDefault();
			}
		}

		public static void cadastrarPessoa(Pessoa pessoa)
		{

			using (var context = new ApiCrudEntity())
			{

				pessoa.id_pessoa = Guid.NewGuid();
				context.Pessoa.Add(pessoa);
				context.SaveChanges();
			}
		}

		public static void alterarPessoa(Guid id, Pessoa pessoa)
		{
			using (var context = new ApiCrudEntity())
			{
				pessoa.id_pessoa = id;
				context.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
				context.SaveChanges();
			}
		}

		public static void deletarPessoa(Guid id)
		{
			using (var context = new ApiCrudEntity())
			{
				var result = from r in context.Pessoa
							 where r.id_pessoa == id
							 select r;
				var objPessoa = result.FirstOrDefault();

				if (objPessoa != null)
				{
					context.Pessoa.Remove(objPessoa);
					context.SaveChanges();
				}

			}
		}


	}
}
