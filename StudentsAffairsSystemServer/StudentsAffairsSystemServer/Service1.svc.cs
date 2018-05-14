using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;
using System.Drawing;

namespace StudentsAffairsSystemServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public void StudentRegister(string username, string password, string emailid, string contactnumber, string department, string registerationnumber, string studentcategory, string section, string secretquestions, string answer)
        {
            Students obj = new Students();
            obj.UserName = username;
            obj.Password = password;
            obj.EmailId = emailid;
            obj.ContactNumber = contactnumber;
            obj.Department = department;
            obj.RegisterationNumber = registerationnumber;
            obj.StudentCategory = studentcategory;
            obj.Section = section;
            obj.SecretQuestions = secretquestions;
            obj.Answer = answer;
            DataClass.studentslist.Add(obj);
        }
        public void TeacherRegister(string username, string password, string emailid, string contactnumber, string department, string secretquestions, string answer)
        {
            Teachers obj = new Teachers();
            obj.UserName = username;
            obj.Password = password;
            obj.EmailId = emailid;
            obj.ContactNumber = contactnumber;
            obj.Department = department;
            obj.SecretQuestions = secretquestions;
            obj.Answer = answer;
            DataClass.teacherslist.Add(obj);
        }
        public void TeacherInfo(string username, string emailid, string contactnumber, string department)
        {
            InformationTeacher obj = new InformationTeacher();
            obj.UserName = username;
            obj.EmailId = emailid;
            obj.ContactNumber = contactnumber;
            obj.Department = department;
            DataClass.Infoteacherlist.Add(obj);
        }
        public void StudentInfo(string username, string emailid, string contactnumber, string section, string department, string registerationnumber, string studentcategory)
        {
            InformationStudent obj = new InformationStudent();
            obj.UserName = username;
            obj.EmailId = emailid;
            obj.ContactNumber = contactnumber;
            obj.Section = section;
            obj.Department = department;
            obj.RegisterationNumber = registerationnumber;
            obj.StudentCategory = studentcategory;
            DataClass.Infostudentlist.Add(obj);
        }
        public List<InformationTeacher> SearchDeptteacher(string department)
        {
            List<InformationTeacher> temp = new List<InformationTeacher>();
            foreach(InformationTeacher obj in DataClass.Infoteacherlist)
            {
                if(obj.Department == department)
                {
                    temp.Add(obj);
                }
            }
            return temp;
        }
        public List<InformationStudent> SearchDeptstudent(string department)
        {
            List<InformationStudent> temp = new List<InformationStudent>();
            foreach(InformationStudent obj in DataClass.Infostudentlist)
            {
                if(obj.Department == department)
                {
                    temp.Add(obj);
                }
            }
            return temp;
        }
        public void AddAnnoucementstolist(string annoucementtext)
        { 
            DataClass.addannoucementlist.Add(annoucementtext);
        }
        public string viewannoucements()
        {
            return string.Join(Environment.NewLine, DataClass.addannoucementlist);

        }
        public int isvalidstudent(string username, string password)
        {
            int isfound = 0;
            foreach (Students obj in DataClass.studentslist)
            {
                if (obj.UserName == username && obj.Password == password && obj.StudentCategory == "CR/GR")
                {
                    isfound = 2;
                }
                if (obj.UserName == username && obj.Password == password && obj.StudentCategory == "OnlyStudent")
                {
                    isfound = 3;
                }

            }
            return isfound;
        }
        public int isvalidteacher(string username, string password)
        {
            int isfound = 0;
            foreach (Teachers obj in DataClass.teacherslist)
            {
                if (obj.UserName == username && obj.Password == password)
                {
                    isfound = 1;
                }
            }
            return isfound;
        }
        public void addimages(byte[] img)
        {
            DataClass.imageslist.Add(img);
        }
        public ArrayList listofimages()
        {
            return DataClass.imageslist;
        }
        public void AddStudentDeptTeacherstoList(string username)
        {
            List<InformationTeacher> temp = new List<InformationTeacher>();
            string department = "None";
            foreach(InformationStudent obj in DataClass.Infostudentlist)
            {
                if(obj.UserName == username)
                {
                    department = obj.Department;
                }
            }
            foreach(InformationTeacher obj1 in DataClass.Infoteacherlist)
            {
                if(obj1.Department == department)
                {
                    temp.Add(obj1);
                    DataClass.StudentDpetTeacherlist = temp;
                }
            }
        }
        public List<InformationTeacher> ShowStudentDeptTeachers()
        {
            return DataClass.StudentDpetTeacherlist;
        }
        public void AddTeachersDeptStudentstoList(string username)
        {
            List<InformationStudent> temp = new List<InformationStudent>();
            string department = "None";
            foreach(InformationTeacher obj in DataClass.Infoteacherlist)
            {
                if(obj.UserName == username)
                {
                    department = obj.Department;
                }
            }
            foreach(InformationStudent obj1 in DataClass.Infostudentlist)
            {
                if(obj1.Department == department && obj1.StudentCategory == "CR/GR")
                {
                    temp.Add(obj1);
                    DataClass.TeachersDeptStudentslist = temp;
                }
            }
        }
        public List<InformationStudent> ShowTeachersDeptStudents()
        {
            return DataClass.TeachersDeptStudentslist;
        }
        public void AddApproveTeacherstoList(string username)
        {
            foreach(InformationTeacher obj in DataClass.Infoteacherlist)
            {
                if(obj.UserName == username)
                {
                    DataClass.AddApproveTeacherstoList.Add(obj);
                }
            }
        }
        public bool CheckApproveTeachers(string username)
        {
            bool isfound = false;
            foreach(InformationTeacher obj in DataClass.AddApproveTeacherstoList)
            {
                if(obj.UserName == username)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public void AddApproveStudentstoList(string username)
        {
            foreach(InformationStudent obj in DataClass.Infostudentlist)
            {
                if(obj.UserName == username)
                {
                    DataClass.AddApproveStudentstoList.Add(obj);
                }
            }
        }
        public bool CheckApproveStudents(string username)
        {
            bool isfound = false;
            foreach(InformationStudent obj in DataClass.AddApproveStudentstoList)
            {
                if(obj.UserName == username)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public void ResetTeachersPasswordList(string username)
        {
            List<Teachers> temp = new List<Teachers>();
            foreach(Teachers obj in DataClass.teacherslist)
            {
                if(obj.UserName == username)
                {
                    temp.Add(obj);
                    DataClass.ResetPasswordTeachers = temp;
                }
            }
        }
        public void ResetStudentsPasswordList(string username)
        {
            List<Students> temp = new List<Students>();
            foreach(Students obj in DataClass.studentslist)
            {
                if(obj.UserName == username)
                {
                    temp.Add(obj);
                    DataClass.ResetPasswordStudents = temp;
                }
            }
        }
        public bool ChkTeachersSecretQuest(string secretquestions, string answer)
        {
            bool isfound = false;
            foreach(Teachers obj in DataClass.ResetPasswordTeachers)
            {
                if(obj.SecretQuestions == secretquestions && obj.Answer == answer)
                {
                    isfound = true;
                }           
            }
            return isfound;
        }
        public bool ChkStudentsSecretQuest(string secretquestions, string answer)
        {
            bool isfound = false;
            foreach(Students obj in DataClass.ResetPasswordStudents)
            {
                if(obj.SecretQuestions == secretquestions && obj.Answer == answer)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public void NewTeachersPassword(string newpassword)
        {
            string username = "None";
            foreach(Teachers obj in DataClass.ResetPasswordTeachers)
            {
                username = obj.UserName;
            }
            foreach(Teachers obj1 in DataClass.teacherslist)
            {
                if(obj1.UserName == username)
                {
                    obj1.Password = newpassword;
                }
            }
        }
        public void NewStudentsPassword(string newpassword)
        {
            string username = "None";
            foreach (Students obj in DataClass.ResetPasswordStudents)
            {
                username = obj.UserName;
            }
            foreach (Students obj1 in DataClass.studentslist)
            {
                if (obj1.UserName == username)
                {
                    obj1.Password = newpassword;
                }
            }
        }
        public void AddTeacherstoProfileList(string username)
        {
            List<InformationTeacher> temp = new List<InformationTeacher>();
            foreach(InformationTeacher obj in DataClass.Infoteacherlist)
            {
                if(obj.UserName == username)
                {
                    temp.Add(obj);
                    DataClass.ProfileTeachersList = temp;
                }
            }
        }
        public void AddStudentstoProfileList(string username)
        {
            List<InformationStudent> temp = new List<InformationStudent>();
            foreach (InformationStudent obj in DataClass.Infostudentlist)
            {
                if (obj.UserName == username)
                {
                    temp.Add(obj);
                    DataClass.ProfileStudentsList = temp;
                }
            }
        }
        public List<InformationTeacher> SpecificTeachersProfile()
        {
            return DataClass.ProfileTeachersList;
        }
        public List<InformationStudent> SpecificStudentsProfile()
        {
            return DataClass.ProfileStudentsList;
        }
    }
}
