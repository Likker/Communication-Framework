using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsApplication.Model;
using WindowsApplication.View;
using WindowsApplication.ViewModel;

namespace WindowsApplication.Other
{
    class TInfrastructure
    {
        private TModel      _model;
        private TView       _view;
        private TViewModel  _viewModel;

        public TInfrastructure(TModel model, TView view, TViewModel viewModel)
        {
            _model = model;
            _view = view;
            _viewModel = viewModel;
        }

        public TModel getModel() { return _model; }
        public TView getView() { return _view; }
        public TViewModel getViewModel() { return _viewModel; }

        public void setModel(TModel model) { _model = model; }
        public void setView(TView view) { _view = view; }
        public void setViewModel(TViewModel viewModel) { _viewModel = viewModel; }
    }
}
