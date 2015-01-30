namespace Guestbook.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreateSearchMessagesStoredProcedure : DbMigration
    {
        public override void Up()
        {
            this.CreateStoredProcedure("spSearchMessages", 
                p => new
                {
                    skipCount = p.Int(),
                    takeCount = p.Int()
                }, 
                @"WITH ResultMessages AS
	            (
	            	SELECT m.*,
	            	ROW_NUMBER() OVER (ORDER BY CreatedAt DESC) AS 'RowNumber'
	            	FROM Messages m 
	            ) 
	            SELECT * 
	            FROM ResultMessages 
	            WHERE RowNumber BETWEEN @skipCount AND @takeCount;" );
        }
        
        public override void Down()
        {
            this.DropStoredProcedure("spSearchMessages");
        }
    }
}
