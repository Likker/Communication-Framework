using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication.Model
{
    class TModel
    {
        private string _history;
        private string _message;

        public TModel() { }

        public string getHistory() { return _history; }
        public string getMessage() { return _message; }
        public void setHistory(string history) { _history = history; }
        public void setMessage(string message) { _message = message; }
    }
}
