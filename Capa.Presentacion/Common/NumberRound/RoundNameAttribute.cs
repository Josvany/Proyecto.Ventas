
using System;

namespace Capa.Presentacion.Common
{
    public class RoundNameAttribute : Attribute
    {
        public string RoundName { get; private set; }

        public RoundNameAttribute (string name)
        {
            RoundName = name;
        }
    }
}
