using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa.Presentacion.Common
{
    public interface INumberRounding<TNumber> where TNumber : struct
    {
        TNumber Round();
        TNumber Round(TNumber sourceValue);
        TNumber Round(TNumber sourceValue, NumberRoundingConfiguration numberRoundingConfiguration);
    }
}