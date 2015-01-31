namespace Guestbook.Silverlight.Mvvm
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public class ViewModel : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        private bool shouldRaiseProperyChanged;
        private readonly Dictionary<string, List<string>> errors;

        public ViewModel()
        {
            this.errors = new Dictionary<string, List<string>>();
        }

        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }
            set
            {
                this.isBusy = value;
                this.RaisePropertyChanged("IsBusy");
            }
        }

        #region Implementation of INotifyPropertyChanged
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }

            if (shouldRaiseProperyChanged)
            {
                this.Validate();
            }
        }

        #endregion

        #region Implementation of INotifyDataErrorInfo
        
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        public void OnErrorsChanged(string propertyName)
        {
            var handler = ErrorsChanged;
            if (handler != null)
            {
                handler(this, new DataErrorsChangedEventArgs(propertyName));
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            List<string> errorsForName;
            this.errors.TryGetValue(propertyName, out errorsForName);
            return errorsForName;
        }

        public bool HasErrors
        {
            get { return this.errors.Any(kv => kv.Value != null && kv.Value.Count > 0); }
        }

        public void ResetValidation()
        {
            lock (this.@lock)
            {
                this.shouldRaiseProperyChanged = false;

                var errorProperties = this.errors.Select(it => it.Key);
                this.errors.Clear();

                foreach (var errorProperty in errorProperties)
                {
                    ErrorsChanged(this, new DataErrorsChangedEventArgs(errorProperty));
                }
            }
        }

        private readonly object @lock = new object();

        private bool isBusy;

        public void Validate()
        {
            lock (this.@lock)
            {
                var validationContext = new ValidationContext(this, null, null);
                var validationResults = new List<ValidationResult>();
                Validator.TryValidateObject(this, validationContext, validationResults, true);

                foreach (var kv in this.errors.ToList())
                {
                    if (validationResults.All(r => r.MemberNames.All(m => m != kv.Key)))
                    {
                        this.errors.Remove(kv.Key);
                        OnErrorsChanged(kv.Key);
                    }
                }

                var query = validationResults
                    .SelectMany(r => r.MemberNames, (r, m) => new { r, m })
                    .GroupBy(@t => @t.m, @t => @t.r)
                    .Select(g => g);

                foreach (var prop in query)
                {
                    var messages = prop.Select(r => r.ErrorMessage).ToList();

                    if (this.errors.ContainsKey(prop.Key))
                    {
                        this.errors.Remove(prop.Key);
                    }
                    this.errors.Add(prop.Key, messages);
                    OnErrorsChanged(prop.Key);
                }

                this.shouldRaiseProperyChanged = this.HasErrors;
            }
        }

        #endregion
    }
}