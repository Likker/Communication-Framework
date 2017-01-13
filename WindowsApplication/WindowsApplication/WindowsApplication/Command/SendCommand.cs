using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsApplication.ViewModel;

namespace WindowsApplication.Command
{
    class SendCommand
    {
        private Command     _command;
        private TViewModel  _viewModel;

        public SendCommand()
        {
            _command = new Command(this.ExecuteSave, this.CanSave);
        }

        public void ExecuteSave(object unused) { }

        public bool CanSave(object unused)
        {
            return true;
        }

        private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            _command.RaiseCanExecuteChanged();
        }

        public TViewModel getViewModel() { return _viewModel; }
        public void setViewModel(TViewModel viewModel)
        {
            if (_viewModel != viewModel)
            { 
                if (_viewModel != null)
                   _viewModel.PropertyChanged -= this.OnViewModelPropertyChanged;
                _viewModel = viewModel;
                _viewModel.PropertyChanged += this.OnViewModelPropertyChanged;
            }
        }

        public Command getCommand() { return _command; }
    }
}