using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Distribution_System.Class
{
    public class RDSNullValue : IRDSValue<object>
    {
        public RDSNullValue(double probablity) : base(null, probablity, false, false, true) { }
    }
}
