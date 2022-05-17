namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_addwriterstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterStatus", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterStatus");
        }
    }
}
