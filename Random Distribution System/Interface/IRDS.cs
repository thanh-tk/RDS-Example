using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Distribution_System
{
    public interface IRDSObj
    {
        double rdsProbability {  get; set; } // The chance for this item to drop
        bool rdsUnique { get; set; } // Only drops once per query
        bool rdsAlways { get; set; } // Drops always
        bool rdsEnabled { get; set; } // Can it drop now?

        event EventHandler rdsPreResultEvaluation;
        event EventHandler rdsHit;
        event EventHandler rdsPosReultEvaluation;

        void onRDSPreResultEvaluation(EventArgs e);

        void onRDSHit(EventArgs e);
        void onRDSPosResultEvaluation(EventArgs e);
    }
    public interface IRDSValue<T> : IRDSObj
    {
        T rdsValue { get; }
    }
    public interface IRDSTable : IRDSObj
    {
        int rdsCount { get; set; }
        IEnumerable<IRDSObj> rdsContents { get; }
        IEnumerable<IRDSObj> rdsResult { get; }
    }

}
