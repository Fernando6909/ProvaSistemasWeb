namespace ProvaCliente.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteModels",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ClienteModels");
        }
    }
}
