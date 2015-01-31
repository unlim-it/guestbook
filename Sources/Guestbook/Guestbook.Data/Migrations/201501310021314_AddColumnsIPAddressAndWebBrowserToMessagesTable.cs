namespace Guestbook.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnsIPAddressAndWebBrowserToMessagesTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "IPAddress", c => c.String());
            AddColumn("dbo.Messages", "WebBrowser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "WebBrowser");
            DropColumn("dbo.Messages", "IPAddress");
        }
    }
}
