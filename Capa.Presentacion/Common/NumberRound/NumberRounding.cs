using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa.Presentacion.Common
{
    public class NumberRounding<TNumber> : NumberRoundigBase<TNumber> where TNumber : struct
    {
        INumberRounding<TNumber> numberRounding = null;

        public NumberRounding() :base()
        {
            numberRounding = GetInstance(typeof(TNumber));
        }
        public NumberRounding(TNumber sourceValue) : base(sourceValue)
        {

        }
        public NumberRounding(TNumber sourceValue, NumberRoundingConfiguration numberRoundingConfiguration) : base(sourceValue, numberRoundingConfiguration)
        {

        }

        private INumberRounding<TNumber> GetInstance(Type numberType)
        {
            if (numberType == typeof(decimal))
            {
                numberRounding = (INumberRounding<TNumber>)(new DecimalRounding(Convert.ToDecimal(Value), RoundingConfiguration));
            }
            return numberRounding;
        }

        public override TNumber Round()
        {
            if (numberRounding == null)
            {
                throw new NotImplementedException("");
            }
            else
            {
                return numberRounding.Round(Value, RoundingConfiguration);
            }
            
        }
    }
}
