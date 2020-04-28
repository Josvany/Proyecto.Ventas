using System.Runtime.InteropServices;

namespace Capa.Presentacion.Common
{
	[ComVisible(true)]
	public enum RoundingMode : int
	{
		[RoundName("Ninguno")]
		None = -1,

		[RoundName("Redondeo a la unidad")]
		ZeroDecimals = 0,

		[RoundName("Redondeo a 1 decimal")]
		ToOneDecimals = 1,

		[RoundName("Redondeo a 2 decimales")]
		ToTwoDecimals = 2,

		[RoundName("Redondeo a la decena")]
		ToTen = 10,

		[RoundName("Redondeo a la centena")]
		ToAHundred = 100,

		[RoundName("Redondeo al 500")]
		ToFiveHoundred = 500,

		[RoundName("Redondeo al millar")]
		ToThousand = 100
	}
}
