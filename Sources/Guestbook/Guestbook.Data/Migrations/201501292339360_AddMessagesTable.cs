namespace Guestbook.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddMessagesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Email = c.String(),
                        Homepage = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
        }
    }
}
