using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public interface IParameters
    {
        /// <summary>
        /// Этот метод должен возвращать информацию о настройках
        /// </summary>
        /// <returns></returns>
        ParameterInfo[] GetDescription();

        /// <summary>
        /// Этот метод должен устанавливать поля класса в соответствие с массивом переданных величин
        /// </summary>
        /// <param name="original"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        void SetValues(double[] values);
    }
}
