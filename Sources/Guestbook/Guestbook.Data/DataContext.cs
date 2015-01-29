namespace Guestbook.Data
{
    using System.Data.Entity;

    using Guestbook.Models;

    internal class DataContext : DbContext
    {
        /// <summary>
        /// Default <see cref="DataContext"/> constructor uses 'Guestbook' connection string
        /// which should be provided in Web.config or App.config.
        /// </summary>
        public DataContext() : base("name=Guestbook")
        {
        }
        
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
    }
}