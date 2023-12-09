using System;

namespace Tennisclub {
    public class Person {
        public string? name;
        public long phonenumber;
        public string? email;

        public Person(string? _name, long _phonenumber, string? _email) {
            name = _name;
            phonenumber = _phonenumber;
            email = _email;
        }

        public virtual string getInfo() {
            return $"Name: {name}\nPhonenumber: {phonenumber}\nE-mail: {email}\n";
        }

        public virtual void playSound() {
            Console.WriteLine("I am a real Human being!");
            System.Threading.Thread.Sleep(3000);
        }
    }
}