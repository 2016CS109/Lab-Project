using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StudentsAffairsSystemServer
{
    public class DataClass
    {
        public static List<Students> studentslist = new List<Students>();
        public static List<Teachers> teacherslist = new List<Teachers>();
        public static List<InformationTeacher> Infoteacherlist = new List<InformationTeacher>();
        public static List<InformationStudent> Infostudentlist = new List<InformationStudent>();
        public static List<InformationTeacher> StudentDpetTeacherlist = new List<InformationTeacher>();
        public static List<InformationStudent> TeachersDeptStudentslist = new List<InformationStudent>();
        public static List<InformationTeacher> AddApproveTeacherstoList = new List<InformationTeacher>();
        public static List<InformationStudent> AddApproveStudentstoList = new List<InformationStudent>();
        public static List<InformationTeacher> ProfileTeachersList = new List<InformationTeacher>();
        public static List<InformationStudent> ProfileStudentsList = new List<InformationStudent>();
        public static List<Teachers> ResetPasswordTeachers = new List<Teachers>();
        public static List<Students> ResetPasswordStudents = new List<Students>();
        public static List<String> addannoucementlist = new List<String>();
        public static ArrayList imageslist = new ArrayList();
    }
}