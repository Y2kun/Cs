using System;

namespace Tennisclub {
    public class Member : Person {
        Paydata payData;

        public Member(string? _name, long _phonenumber, string? _email, Paydata _payData) : base(_name, _phonenumber, _email) {
            payData = _payData;
        }

        public override string getInfo() {
            return $"{base.getInfo()}Pay Data: {payData.getInfo()}";
        }

        public override void playSound() {
            Console.WriteLine("Ping");
            System.Threading.Thread.Sleep(3000);
        }
    }
}