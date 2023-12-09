using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentmanagement {
    public class Studentmanager {
        List<Student> students = new List<Student>();

        public void addStudent(string? name, long age, string? gender, string? classRoom) {
            students.Add(new Student($"{name}|{age}|{gender}|{classRoom}"));
        }

        public void addAbsence(string? name, long missedAmount, string? reason) {
            foreach (Student student in students) {
                if (student.name == name) {
                    student.addAbsence(missedAmount, reason);
                }
            }
        }

        public long returnTotalAbsenceTime(string? name) {
            long totalAbsenceTime = 0;
            foreach (Student student in students) {
                if (student.name == name) {
                    totalAbsenceTime = student.calculateTotalAbsence();
                }
            }
            return totalAbsenceTime;
        }

        public string returnAbsences(string? name) {
            string? allAbsences = "";
            foreach (Student student in students) {
                if (student.name == name) {
                    allAbsences = student.returnAbsences();
                }
            }
            return allAbsences;
        }

        public string returnAllInfo(string? name) {
            string? allInfo = "";
            foreach (Student student in students) {
                if (student.name == name) {
                    allInfo = $"{student.ToString()} Total Absence Time: {returnTotalAbsenceTime(name)}|";
                }
            }
            return allInfo;
        }

        public string returnClassRoomInfo(string? classRoom) {
            string? allClassRoomInfo = "";
            foreach (Student student in students) {
                if (student.classRoom == classRoom) {
                    allClassRoomInfo += $"{returnAllInfo(student.name)}\n";
                }
            }
            return allClassRoomInfo;
        }

        public long returnClassRoomTotalMissingTime(string? classRoom) {
            long classRoomTotalMissingTime = 0;
            foreach (Student student in students) {
                if (student.classRoom == classRoom) {
                    classRoomTotalMissingTime += returnTotalAbsenceTime(student.name);
                }
            }
            return classRoomTotalMissingTime;
        }
    }
}