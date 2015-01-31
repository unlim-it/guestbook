namespace Guestbook.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class AlterSearchStoredProcedure : DbMigration
    {
        public override void Up()
        {
            this.AlterStoredProcedure("spSearchMessages", 
                p => new
                {
                    skipCount = p.Int(),
                    takeCount = p.Int(),
                    orderBy = p.String(),
                    orderDirection = p.Boolean()
                },
                @"WITH ResultMessages AS
                (
                	SELECT m.*,
                	ROW_NUMBER() OVER (ORDER BY 
                		CASE WHEN @orderBy = 'CreatedAt' AND @orderDirection = 0 THEN CreatedAt END ASC ,
                		CASE WHEN @orderBy = 'CreatedAt' AND @orderDirection = 1 THEN CreatedAt END DESC, 
                		CASE WHEN @orderBy = 'UserName' AND @orderDirection = 0 THEN UserName END ASC ,
                		CASE WHEN @orderBy = 'UserName' AND @orderDirection = 1 THEN UserName END DESC,
                		CASE WHEN @orderBy = 'Email' AND @orderDirection = 0 THEN Email END ASC ,
                		CASE WHEN @orderBy = 'Email' AND @orderDirection = 1 THEN Email END DESC) AS 'RowNumber'
                	FROM Messages m
                ) 
                SELECT * 
                FROM ResultMessages 
	            WHERE RowNumber BETWEEN @skipCount AND @takeCount;" );
        }
        
        public override void Down()
        {
            this.AlterStoredProcedure("spSearchMessages",
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
	            WHERE RowNumber BETWEEN @skipCount AND @takeCount;");
        }
    }
}
