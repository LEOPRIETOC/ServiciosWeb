namespace ServiciosWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cliente : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            AlterColumn("dbo.Cliente", "Nombres", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cliente", "Apellidos", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cliente", "Direccion", c => c.String(maxLength: 20));
            AlterColumn("dbo.Cliente", "Celular", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Cliente", "Estrato", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cliente", "Estrato", c => c.String());
            AlterColumn("dbo.Cliente", "Celular", c => c.Int(nullable: false));
            AlterColumn("dbo.Cliente", "Direccion", c => c.String());
            AlterColumn("dbo.Cliente", "Apellidos", c => c.String());
            AlterColumn("dbo.Cliente", "Nombres", c => c.String());
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
        }
    }
}
