using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration1
{
    internal class studentInfoClass
    {
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string text);

        public static string FirstName { get; set; } = "";
        public static string LastName { get; set; } = "";
        public static string MiddleName { get; set; } = "";

        public static string Address { get; set; } = "";
        public static string Program { get; set; } = "";

        public static long Age { get; set; } = 0;
        public static long ContactNo { get; set; } = 0;
        public static long StudentNo { get; set; } = 0;

        public static string GetFirstName(string firstName) {return firstName;}

        public static string GetLastName(string lastName) {return lastName;}

        public static string GetMiddleName(string middleName) { return middleName; }

        public static string GetAddress(string address) { return address;}

        public static string GetProgram(string program) { return program; }

        public static long GetAge(long age) { return age;}

        public static long GetContactNo(long contactNo) { return contactNo; }

        public static long GetStudentNo(long studentNo) {return studentNo;}
    }
}
