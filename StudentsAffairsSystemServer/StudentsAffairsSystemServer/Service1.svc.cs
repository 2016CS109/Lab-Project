using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
        public void StudentRegister(string username, string password, string emailid, string contactnumber, string registerationnumber, string studentcategory, string section, string secretquestions, string answer)
        {
            Students obj = new Students();
            obj.UserName = username;
            obj.Password = password;
            obj.EmailId = emailid;
            obj.ContactNumber = contactnumber;
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
    }
}
