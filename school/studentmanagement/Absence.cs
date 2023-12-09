using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentmanagement {
    public class Absence {
        public long missedAmount;
        public string? reason;

        public Absence(long _missedAmount, string? _reason) {
            missedAmount = _missedAmount;
            reason = _reason;
        }

        public override string ToString() {
            return $"| Missed Hours: {missedAmount} | Reason: {reason} |";
        }
    }
}