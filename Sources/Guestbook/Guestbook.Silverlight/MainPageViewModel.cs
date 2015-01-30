namespace Guestbook.Silverlight
{
    using System.Threading.Tasks;
    using System.Windows.Data;

    using Guestbook.Silverlight.Mvvm;
    using Guestbook.Silverlight.Network;

    public class MainPageViewModel : ViewModel
    {
        private readonly GuestbookService guestbookService;

        private PagedCollectionView messages;

        public MainPageViewModel()
        {
            this.guestbookService = new GuestbookService();
        }

        public PagedCollectionView Messages
        {
            get
            {
                return this.messages;
            }
            set
            {
                this.messages = value;
                this.RaisePropertyChanged("Messages");
            }
        }

        public async Task Initialize()
        {
            var newMessages = await guestbookService.GetMessages();
            this.Messages = new PagedCollectionView(newMessages);
        }
    }
}