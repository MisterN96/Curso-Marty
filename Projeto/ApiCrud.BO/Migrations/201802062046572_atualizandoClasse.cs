namespace ApiCrud.BO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizandoClasse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_pessoas",
                c => new
                    {
                        id_pessoa = c.Guid(nullable: false),
                        nome_pessoa = c.String(maxLength: 30, unicode: false),
                        telefone_pessoa = c.String(maxLength: 15, unicode: false),
                        email_pessoa = c.String(maxLength: 30),
                        sexo_pessoa = c.Boolean(nullable: false),
                        escolaridade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_pessoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_pessoas");
        }
    }
}
