using System;

namespace Tennisclub {
    public class Sponsor : Person {
        public Status status;

        public Sponsor(string? _name, long _phonenumber, string? _email, Status _status) : base(_name, _phonenumber, _email) {
            status = _status;
        }

        public override string getInfo() {
            return $"{base.getInfo()}Status: {status}\n";
        }

        public override void playSound() {
            Console.WriteLine("Klimp, Klimp");
            System.Threading.Thread.Sleep(3000);
        }
    }
}