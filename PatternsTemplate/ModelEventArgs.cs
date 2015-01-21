using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTemplate
{
    public delegate void ModelHandler<IModel>(IModel model, ModelEventArgs e);
    public class ModelEventArgs : EventArgs
    {
        readonly Flight flight;
        internal Flight Flight
        {
            get{ return flight; }
        }

        public ModelEventArgs(Flight flight)
        {
            this.flight = flight;
        }
    }
}
