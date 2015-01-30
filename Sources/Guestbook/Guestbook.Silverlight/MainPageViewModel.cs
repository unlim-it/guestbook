namespace Guestbook.Silverlight
{
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
        }
        
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