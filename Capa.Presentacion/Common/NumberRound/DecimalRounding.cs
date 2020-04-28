using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa.Presentacion.Common
{
    public class DecimalRounding : NumberRoundigBase<decimal>, INumberRounding<decimal>
    {
        public DecimalRounding() : base()
        {

        }

        public DecimalRounding(decimal sourcevalue) : base(sourcevalue)
        {

        }

        public DecimalRounding(decimal sourcevalue, NumberRoundingConfiguration numberRounding) : base(sourcevalue, numberRounding)
        {

        }

        public override decimal Round()
        {
            int roundingArgument = (int)RoundingConfiguration.NumberRoundingMode;
            if (RoundingConfiguration.NumberRoundingMode == RoundingMode.ZeroDecimals
                || RoundingConfiguration.NumberRoundingMode == RoundingMode.ToOneDecimals
                || RoundingConfiguration.NumberRoundingMode == RoundingMode.ToTwoDecimals)
            {
                Value = decimal.Round(Value, roundingArgument, RoundingConfiguration.MidpointRounding);
            }
            else if (RoundingConfiguration.NumberRoundingMode == RoundingMode.ToTen
                || RoundingConfiguration.NumberRoundingMode == RoundingMode.ToAHundred
                || RoundingConfiguration.NumberRoundingMode == RoundingMode.ToFiveHoundred
                || RoundingConfiguration.NumberRoundingMode == RoundingMode.ToThousand)
            {
                Value = decimal.Round(Value / roundingArgument, 0 ) * roundingArgument;
            }
            else
            {

            }
            return Value;
        }
    }
}
