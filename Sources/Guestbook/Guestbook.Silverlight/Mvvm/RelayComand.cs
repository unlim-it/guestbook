namespace Guestbook.Silverlight.Mvvm
{
    using System;
    using System.Windows.Input;

    public class RelayCommand : ICommand
    {
        private readonly Predicate<object> canExecute;
        private readonly Action<object> execute;
        private readonly Action noParamsExecute;
        private readonly bool noParams;

        public RelayCommand(Action execute)
        {
            //TODO: what's this initialization do?
            this.canExecute = param => true;
            this.noParams = true;
            this.noParamsExecute = execute;
        }

        public RelayCommand(Action<object> execute)
        {
            //TODO: what's this initialization do?
            this.canExecute = param => true;
            this.execute = execute;
        }

        public RelayCommand(Predicate<object> canExecute, Action<object> execute)
        {
            this.canExecute = canExecute;
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            if (this.noParams)
                this.noParamsExecute();
            else
                this.execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}