using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Distribution_System.Class
{
    public class RDSNullValue : IRDSValue<object>
    {
        public RDSNullValue(double probablity) 
            : base(null, probablity, false, false, true) { }

        public object rdsValue => throw new NotImplementedException();

        public double rdsProbability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool rdsUnique { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool rdsAlways { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool rdsEnabled { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler rdsPreResultEvaluation;
        public event EventHandler rdsHit;
        public event EventHandler rdsPosReultEvaluation;

        public void onRDSHit(EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void onRDSPosResultEvaluation(EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void onRDSPreResultEvaluation(EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
