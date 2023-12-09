using System;

namespace Tennisclub {
    public class Paydata {
        public double payAmount;
        public bool payed;

        public Paydata(double _payAmount, bool _payed) {
            payAmount = _payAmount;
            payed = _payed;
        }

        public string getInfo() {
            return $"\n\tPay Amount: {payAmount}\n\tPayed?: {payed}\n";
        }
    }
}