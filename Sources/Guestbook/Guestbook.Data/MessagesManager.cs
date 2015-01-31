namespace Guestbook.Data
{
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;

    using Guestbook.Models;

    public class MessagesManager
    {
        public async Task<MessageSearchResult> SearchMessages(MessageFilter filter)
        {
            using (var context = new DataContext())
            {
                var skipCount = filter.PageIndex * filter.PageSize + 1;
                var takeCount = skipCount + filter.PageSize - 1;

                var selectedMessages = await context.Database
                    .SqlQuery<Message>("EXEC spSearchMessages @skipCount, @takeCount",
                    new SqlParameter("skipCount", skipCount),
                    new SqlParameter("takeCount", takeCount))
                    .ToListAsync();

                var count = context.Messages.Count();

                return new MessageSearchResult { Items = selectedMessages, TotalCount =  count };
            }
        }

        public async Task InsertMessage(Message message)
        {
            using (var context = new DataContext())
            {
                await context.Database.ExecuteSqlCommandAsync("spInsertMessage @userName, @email, @homePage, @text, @createdAt, @ipAddress, @webBrowser",
                    new SqlParameter("@userName", message.UserName),
                    new SqlParameter("@email", message.Email),
                    new SqlParameter("@homePage", message.Homepage),
                    new SqlParameter("@text", message.Text),
                    new SqlParameter("@createdAt", message.CreatedAt),
                    new SqlParameter("@ipAddress", message.IPAddress),
                    new SqlParameter("@webBrowser", message.WebBrowser));
            }
        }
    }
}