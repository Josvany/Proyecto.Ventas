using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa.Presentacion.Common
{
    public abstract class NumberRoundigBase<TNumber> where TNumber : struct
    {
        public NumberRoundingConfiguration defaultNumberRoundingConfiguration
        {
            get
            {
                return new NumberRoundingConfiguration
                {
                    NumberRoundingMode = RoundingMode.None,
                    MidpointRounding = MidpointRounding.ToEven
                };
            }
        }
        public NumberRoundingConfiguration RoundingConfiguration { get; set; }
        public TNumber Value { get; set; }

        protected NumberRoundigBase()
        {
            RoundingConfiguration = defaultNumberRoundingConfiguration;
        }

        protected NumberRoundigBase(TNumber sourceValue)
        {
            Value = sourceValue;
            RoundingConfiguration = defaultNumberRoundingConfiguration;
        }

        protected NumberRoundigBase(TNumber sourceValue, NumberRoundingConfiguration numberRoundingConfiguration)
        {
            Value = sourceValue;
            RoundingConfiguration = numberRoundingConfiguration;
        }

        public TNumber Round(TNumber sourceValue)
        {
            Value = sourceValue;
            return Value;
        }

        public abstract TNumber Round();

        public void SetRoundConfiguration(NumberRoundingConfiguration numberRoundingConfiguration)
        {
            RoundingConfiguration = numberRoundingConfiguration;
        }

        public TNumber Round(TNumber sourceValue, NumberRoundingConfiguration numberRoundingConfiguration)
        {
            Value = sourceValue;
            RoundingConfiguration = numberRoundingConfiguration;
            return Round();
        }
    }
}
