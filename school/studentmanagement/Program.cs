using System;

namespace studentmanagement {
    internal class Program {
        static void Main(string[] args) {
            Studentmanager sm = new Studentmanager();

            sm.addStudent("Y2kun", 10, "m", "First Class");
            sm.addAbsence("Y2kun", 5, "Sick");
            Console.WriteLine(sm.returnAbsences("Y2kun"));
            Console.WriteLine(sm.returnAllInfo("Y2kun"));
            Console.WriteLine(sm.returnClassRoomInfo("First Class"));
            Console.WriteLine(sm.returnClassRoomTotalMissingTime("First Class"));
        }
    }
}