using System;

namespace Tennisclub {
    public class ClubmemberList {
        List<Person> people = new List<Person>();

        public void addPerson(Person person) {
            people.Insert(0, person);
        }

        public void getInfo(bool member = true, bool sponsor = true) {
            people.Reverse();
            foreach(Person person in people) {
                if (member && person is Member || sponsor && person is Sponsor) {
                    Console.WriteLine(person.getInfo());
                }
            }
            people.Reverse();
        }

        public void playSound() {
            foreach(Person person in people) {
                person.playSound();
            }
        }
    }
}