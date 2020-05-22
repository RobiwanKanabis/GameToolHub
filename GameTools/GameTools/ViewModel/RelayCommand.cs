using System;
using System.Windows.Input;

namespace GameTools.ViewModel
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        private Action methodToExecute;
        private Func<bool> canExecuteEvaluator;
        public RelayCommand(Action methodToExecute, Func<bool> canExecuteEvaluator)
        {
            this.methodToExecute = methodToExecute;
            this.canExecuteEvaluator = canExecuteEvaluator;
        }

        public RelayCommand(Action methodToExecute) : this(methodToExecute, null) { }

        public bool CanExecute(object parameter)
        {
            if (this.canExecuteEvaluator == null)
                return true;
            else
                return this.canExecuteEvaluator.Invoke();
        }

        public void Execute(object parameter)
        {
            this.methodToExecute.Invoke();
        }
    }
}
