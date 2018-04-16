using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.BO.Banco
{	
	[Table ("tbl_pessoas")]
	public class Pessoa
	{
		[Key]
		public Guid id_pessoa { get; set; }

		[StringLength(30)]
		public string nome_pessoa { get; set; }

		[StringLength(15)]
		public string telefone_pessoa { get; set; }

		[StringLength(30)]
		public string email_pessoa { get; set; }

		
		public bool sexo_pessoa { get; set; }

		
		public int escolaridade { get; set; }
	}
}
