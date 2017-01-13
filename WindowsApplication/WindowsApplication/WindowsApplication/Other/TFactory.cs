using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApplication.Command;
using WindowsApplication.Model;
using WindowsApplication.View;
using WindowsApplication.ViewModel;

namespace WindowsApplication.Other
{
    class TFactory
    {
        public TInfrastructure Create()
        {
            TInfrastructure factory = null;
            TModel          model = null;
            SendCommand     sendCommand = null;
            TView           view = null;
            TViewModel      viewModel = null;

            model = new TModel();
            sendCommand = new SendCommand();
            view = new TView();
            viewModel = new TViewModel(model, sendCommand.getCommand());
            factory = new TInfrastructure(model, view, viewModel);

            return factory;
        }
    }
}
