using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WindowsApplication.Model;

namespace WindowsApplication.ViewModel
{
    class TViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler    PropertyChanged;

        private string                              _history;
        private string                              _message;
        private TModel                              _model;
        private ICommand                            _sendCommand;

        public TViewModel(TModel model, ICommand sendCommand)
        {
            _model = model;
            _sendCommand = sendCommand;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var func = PropertyChanged;

            if (func != null)
            {
                func(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string getHistory() { return _model.getHistory(); }
        public string getMessage() { return _model.getMessage(); }
        public ICommand getSendCommand() { return _sendCommand; }

        public void setHistory(string history)
        {
            if (_model.getHistory() != null)
                _model.setHistory(_model.getHistory() + "\n" + history);
            else
                _model.setHistory(history);

            this.OnPropertyChanged("History");
        }

        public void setMessage(string message)
        {
            if (_model.getMessage() != null)
                _model.setMessage(_model.getMessage() + "\n" + message);
            else
                _model.setMessage(message);

            this.OnPropertyChanged("Message");
        }

        public void setSendCommand(ICommand sendCommand) { _sendCommand = sendCommand; }
    }
}