using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentmanagement {
    public class Student {
        public string? name;
        public long age;
        public string? gender;
        public string? classRoom;
        List<Absence> absences =  new List<Absence>();

        public Student(string? studentInfo) {
            string[] info = studentInfo.Split("|");
            name = info[0];
            age = Convert.ToInt64(info[1]);
            gender = info[2];
            classRoom = info[3];
        }

        public void addAbsence(long missedAmount, string? reason) {
            absences.Add(new Absence(missedAmount, reason));
        }

        public string returnAbsences() {
            string totalAbsences = "";
            foreach (Absence absence in absences) {
                totalAbsences += $"{absence.ToString()}\n";
            }
            return totalAbsences;
        }

        public long calculateTotalAbsence() {
            long totalAbsence = 0;
            foreach (Absence absence in absences) {
                totalAbsence += absence.missedAmount;
            }
            return totalAbsence;
        }

        public override string ToString() {
            return $"| Name: {name} | Age: {age} | Gender: {gender} | Class: {classRoom}|";
        }
    }
}