namespace ApiCrud.BO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteracaoTipoEscolaridade : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tbl_pessoas", "escolaridade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_pessoas", "escolaridade", c => c.String());
        }
    }
}
