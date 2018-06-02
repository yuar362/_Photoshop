using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter : IFilter
    {
        IParameters parameters;
        public ParametrizedFilter(IParameters parameters_)
        {
            this.parameters = parameters_;
        }

        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDescription();
        }

        public Photo Process(Photo original, double[] parameters_)
        {
            this.parameters.SetValues(parameters_);
            return Process(original, parameters);
        }

        public abstract Photo Process(Photo original, IParameters parameters_);
    }
}
