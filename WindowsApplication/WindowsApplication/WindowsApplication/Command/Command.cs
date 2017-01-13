using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WindowsApplication.Command
{
    class Command : ICommand
    {
        private Predicate<object>   _canExecute;
        public event EventHandler   CanExecuteChanged;
        private Action<object>      _execute;

        public Command(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null || canExecute == null)
                return;

            _execute = execute;
            _canExecute = canExecute;
        }

        public Command(Action<object> execute)
        {
            if (execute == null)
                return;

            _execute = execute;
        }

        public bool CanExecute(object param)
        {
            if (_canExecute == null)
                return true;
            else
                return _canExecute(param);
        }

        public void Execute(object param)
        {
            _execute(param);
        }

        public void RaiseCanExecuteChanged()
        {
            this.OnCanExecuteChanged();
        }

        protected virtual void OnCanExecuteChanged()
        {
            EventHandler handler = null;

            handler = this.CanExecuteChanged;
            if (handler != null)
                handler.Invoke(this, EventArgs.Empty);
        }
    }
}