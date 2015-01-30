namespace Guestbook.Silverlight
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Guestbook.Models;
    using Guestbook.Silverlight.Mvvm;
    using Guestbook.Silverlight.Network;
    using Guestbook.Silverlight.Tools;

    public class MainPageViewModel : ViewModel
    {
        private readonly GuestbookService guestbookService;
        
        public MainPageViewModel()
        {
            this.guestbookService = new GuestbookService();
            this.Messages = new AsyncPagedCollectionView<Message> { FetchData = this.FetchMessages };
            this.Messages.MoveToFirstPage();

            this.PageCountVariants = new List<int> { 10, 15, 20, 25, 50, 100 };
        }

        public List<int> PageCountVariants { get; set; }

        public AsyncPagedCollectionView<Message> Messages { get; set; }

        private async Task<PagedDataResponse<Message>> FetchMessages(int pageIndex)
        {
            var messagesResult = await guestbookService.SearchMessages(new MessageFilter
            {
                PageIndex = pageIndex, 
                PageSize = this.Messages.PageSize
            });

            return new PagedDataResponse<Message> { TotalItemCount = messagesResult.TotalCount, Items = messagesResult.Items.ToList() };
        }
    }
}