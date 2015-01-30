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
                var skipCount = filter.PageIndex * filter.PageSize;
                var takeCount = skipCount + filter.PageSize;

                var selectedMessages = await context.Database
                    .SqlQuery<Message>("EXEC spSearchMessages @skipCount, @takeCount",
                    new SqlParameter("skipCount", skipCount),
                    new SqlParameter("takeCount", takeCount))
                    .ToListAsync();

                var count = context.Messages.Count();

                return new MessageSearchResult { Items = selectedMessages, TotalCount =  count };
            }
        }
    }
}