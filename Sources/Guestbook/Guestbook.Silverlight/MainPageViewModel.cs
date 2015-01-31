namespace Guestbook.Silverlight
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Input;

    using Guestbook.Models;
    using Guestbook.Silverlight.Mvvm;
    using Guestbook.Silverlight.Network;
    using Guestbook.Silverlight.Tools;

    public class MainPageViewModel : ViewModel
    {
        private readonly GuestbookService guestbookService;

        private bool isAdding;
        private string userName;
        private string email;
        private string homepage;
        private string captcha;
        private string text;

        private string captchUrl;

        public MainPageViewModel()
        {
            this.guestbookService = new GuestbookService();
            this.Messages = new AsyncPagedCollectionView<Message> { FetchData = this.FetchMessages };
            this.Messages.MoveToFirstPage();

            this.PageCountVariants = new List<int> { 10, 15, 20, 25, 50, 100 };

            this.AddCommentCommand = new RelayCommand(AddComment);
            this.CancelCommand = new RelayCommand(Cancel);
            this.PostCommand = new RelayCommand(Post);
            this.SetDefaultValues();
        }
        
        public ICommand AddCommentCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ICommand PostCommand { get; set; }

        [Required]
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        [Required]
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
                this.RaisePropertyChanged("Email");
            }
        }
        public string Homepage
        {
            get
            {
                return this.homepage;
            }
            set
            {
                this.homepage = value;
                this.RaisePropertyChanged("Homepage");
            }
        }
        [Required]
        public string Captcha
        {
            get
            {
                return this.captcha;
            }
            set
            {
                this.captcha = value;
                this.RaisePropertyChanged("Captcha");
            }
        }
        [Required]
        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
                this.RaisePropertyChanged("Text");
            }
        }
        
        public List<int> PageCountVariants { get; set; }

        public AsyncPagedCollectionView<Message> Messages { get; set; }

        public bool IsAdding
        {
            get
            {
                return this.isAdding;
            }
            set
            {
                this.isAdding = value;
                this.RaisePropertyChanged("IsAdding");
            }
        }

        public string CaptchaUrl
        {
            get
            {
                return this.captchUrl;
            }
            set
            {
                this.captchUrl = value;
                this.RaisePropertyChanged("CaptchaUrl");
            }
        }

        private async Task<PagedDataResponse<Message>> FetchMessages(int pageIndex)
        {
            var messagesResult = await guestbookService.SearchMessages(new MessageFilter
            {
                PageIndex = pageIndex, 
                PageSize = this.Messages.PageSize
            });

            return new PagedDataResponse<Message> { TotalItemCount = messagesResult.TotalCount, Items = messagesResult.Items.ToList() };
        }

        private async void Post()
        {
            this.Validate();
            if (this.HasErrors)
            {
                return;
            }

            try
            {
                this.IsBusy = true;

                var message = new Message
                {
                    UserName = this.UserName,
                    Email = this.Email,
                    Homepage = this.Homepage,
                    Text = this.Text,
                    CreatedAt = DateTime.Now
                };

                await guestbookService.CreateMessage(message);
                this.Messages.MoveToPage(this.Messages.PageIndex);

                this.Cancel();
            }
            finally
            {
                this.IsBusy = true;
            }
        }

        private void SetDefaultValues()
        {
            this.UserName = "";
            this.Email = "";
            this.Homepage = "";
            this.Text = "";
            this.CaptchaUrl = "http://localhost:3090/api/captcha?" + Guid.NewGuid();
        }

        private void Cancel()
        {
            this.SetDefaultValues();
            this.IsAdding = false;
            
            this.ResetValidation();
        }

        private void AddComment()
        {
            this.IsAdding = true;
        }
    }
}