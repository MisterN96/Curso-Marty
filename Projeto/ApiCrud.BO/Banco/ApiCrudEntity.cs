namespace ApiCrud.BO.Banco
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class ApiCrudEntity : DbContext
	{
		// Your context has been configured to use a 'ApiCrudEntity' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'ApiCrud.BO.Banco.ApiCrudEntity' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'ApiCrudEntity' 
		// connection string in the application configuration file.
		public ApiCrudEntity()
			: base("name=ApiCrudEntity1")
		{
		}

		public virtual DbSet<Pessoa> Pessoa { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity < Pessoa>()
                .Property(e => e.nome_pessoa)
				.IsUnicode(false);

			modelBuilder.Entity < Pessoa>()
                .Property(e => e.telefone_pessoa)
				.IsUnicode(false);
		}
		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		// public virtual DbSet<MyEntity> MyEntities { get; set; }
	}

	//public class MyEntity
	//{
	//    public int Id { get; set; }
	//    public string Name { get; set; }
	//}
}