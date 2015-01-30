namespace Guestbook.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnCreatedAtToMessagesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "CreatedAt");
        }
    }
}
