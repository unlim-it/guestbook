namespace Guestbook.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    using Guestbook.Models;

    public class MessagesManager
    {
        public async Task<MessageSearchResult> SearchMessages(MessageFilter filter)
        {
            using (var context = new DataContext())
            {
                //return await context.Database.SqlQuery<IEnumerable<Message>>("EXEC spMessages_get_ProjectsByManager @employeeCode", 
                //    new SqlParameter("employeeCode", employeeCode)).ToListAsync();

                throw new NotImplementedException();
            }
        }
    }
}