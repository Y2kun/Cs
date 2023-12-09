using System;

namespace Tennisclub {
    internal class Program {
        static void Main(string[] args) {
            ClubmemberList clubmemberList = new ClubmemberList();
            clubmemberList.addPerson(new Sponsor("Y2kun", 6330, "me@y2kun.dev", Status.Gold));
            clubmemberList.addPerson(new Member("Y2kun, yes he Sponsors himself", 5330, "me@y2kun.dev" , new Paydata(100, false)));
            clubmemberList.getInfo(true, true); // Member, Sponsor || Person
            clubmemberList.playSound();
        }
    }
}
