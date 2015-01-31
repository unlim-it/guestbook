namespace Guestbook.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AddInsertMessageStoredProcedure : DbMigration
    {
        public override void Up()
        {
            this.CreateStoredProcedure("spInsertMessage",
                p => new
                {
                    userName = p.String(),
                    email = p.String(),
                    homePage = p.String(),
                    text = p.String(),
                    createdAt = p.DateTime(),
                    ipAddress = p.String(),
                    webBrowser = p.String()
                },
                @"INSERT INTO [dbo].[Messages]
                       ([UserName]
                       ,[Email]
                       ,[Homepage]
                       ,[Text]
                       ,[CreatedAt]
                       ,[IPAddress]
                       ,[WebBrowser])
                 VALUES (@userName,
                         @email,
                         @homePage,
                         @text,
                         @createdAt,
                         @ipAddress,
                         @webBrowser);");
        }

        public override void Down()
        {
            this.DropStoredProcedure("spInsertMessage");
        }
    }
}
