namespace Guestbook.Silverlight.Tools
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Threading.Tasks;

    /// <summary>
    /// A paged collection view that uses a asynchronously retrieve paged data from a server.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class AsyncPagedCollectionView<T> : ObservableCollection<T>, IPagedCollectionView
    {
        private int pageSize;
        private bool canChangedPage = true;
        private bool isPageChanging;
        private int itemCount;
        private int totalItemCount;
        private int pageIndex;
        
        public AsyncPagedCollectionView()
        {
            this.PageSize = 10;
        }
        
        public bool CanChangePage
        {
            private set
            {
                this.SetField(ref this.canChangedPage, value, "CanChangePage");
            }
            get
            {
                return this.canChangedPage;
            }
        }

        public bool IsPageChanging
        {
            private set
            {
                this.SetField(ref this.isPageChanging, value, "IsPageChanging");
            }
            get
            {
                return this.isPageChanging;
            }
        }

        public int ItemCount
        {
            private set
            {
                this.SetField(ref this.itemCount, value, "ItemCount");
            }
            get
            {
                return this.itemCount;
            }
        }

        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling((double)this.TotalItemCount / (double)this.PageSize);
            }
        }

        public int PageIndex
        {
            private set
            {
                this.SetField(ref this.pageIndex, value, "PageIndex");
            }
            get
            {
                return this.pageIndex;
            }
        }

        public int PageSize
        {
            set
            {
                this.SetField(ref this.pageSize, value, "PageSize");
                this.RefreshData(0);
            }
            get
            {
                return this.pageSize;
            }
        }

        public int TotalItemCount
        {
            private set
            {
                this.SetField(ref this.totalItemCount, value, "TotalItemCount");
            }
            get
            {
                return this.totalItemCount;
            }
        }
        
        public bool MoveToFirstPage()
        {
            this.RefreshData(0);
            return true;
        }

        public bool MoveToLastPage()
        {
            this.RefreshData(this.TotalPages - 1);
            return true;
        }

        public bool MoveToNextPage()
        {
            this.RefreshData(this.PageIndex + 1);
            return true;
        }

        public bool MoveToPage(int pageIndex)
        {
            this.RefreshData(pageIndex);
            return true;
        }

        public bool MoveToPreviousPage()
        {
            this.RefreshData(this.PageIndex - 1);
            return true;
        }

        public Func<int, Task<PagedDataResponse<T>>> FetchData;

        public event EventHandler<EventArgs> PageChanged;

        public event EventHandler<PageChangingEventArgs> PageChanging;

        protected void OnPageChanged()
        {
            if (this.PageChanged != null)
            {
                this.PageChanged(this, EventArgs.Empty);
            }
        }

        protected void OnPageChanging(int newPageIndex)
        {
            if (this.PageChanging != null)
            {
                this.PageChanging(this, new PageChangingEventArgs(newPageIndex));
            }
        }

        /// <summary>
        /// Fetches the data for the given page
        /// </summary>
        private async void RefreshData(int newPageIndex)
        {
            // set the pre-fetch state
            this.CanChangePage = false;
            this.OnPageChanging(newPageIndex);

            if (this.FetchData == null)
            {
                return;
            }

            var result = await this.FetchData(newPageIndex);

            // process the received data
            this.DataReceived(result);

            // set the post-fetch state
            this.PageIndex = newPageIndex;
            this.OnPageChanged();
            this.CanChangePage = true;
        }

        /// <summary>
        /// Updates the items exposed by this view with the given data
        /// </summary>
        private void DataReceived(PagedDataResponse<T> response)
        {
            this.TotalItemCount = this.ItemCount = response.TotalItemCount;
            this.ClearItems();

            foreach (var item in response.Items)
            {
                this.Add(item);
            }
        }

        /// <summary>
        /// Sets the given field, raising a PropertyChanged event
        /// </summary>
        private void SetField<T>(ref T field, T value, string propertyName)
        {
            if (Equals(field, value))
                return;

            field = value;
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
    }
}