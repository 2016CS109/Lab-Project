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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void StudentRegister(string username, string password, string emailid, string contactnumber, string department, string registerationnumber, string studentcategory, string section, string secretquestions, string answer);
        [OperationContract]
        void TeacherRegister(string username, string password, string emailid, string contactnumber, string department, string secretquestions, string answer);
        [OperationContract]
        void TeacherInfo(string username, string emailid, string contactnumber, string department);
        [OperationContract]
        void StudentInfo(string username, string emailid, string contactnumber, string section, string department, string registerationnumber, string studentcategory);
        [OperationContract]
        List<InformationTeacher> SearchDeptteacher(string department);
        [OperationContract]
        List<InformationStudent> SearchDeptstudent(string department);
        [OperationContract]
        void AddAnnoucementstolist(string annoucementtext);
        [OperationContract]
        string viewannoucements();
        [OperationContract]
        int isvalidstudent(string username, string password);
        [OperationContract]
        int isvalidteacher(string username, string password);
        [OperationContract]
        void addimages(byte[] img);
        [OperationContract]
        ArrayList listofimages();
        [OperationContract]
        void AddStudentDeptTeacherstoList(string username);
        [OperationContract]
        List<InformationTeacher> ShowStudentDeptTeachers();
        [OperationContract]
        void AddTeachersDeptStudentstoList(string username);
        [OperationContract]
        List<InformationStudent> ShowTeachersDeptStudents();
        [OperationContract]
        void AddApproveTeacherstoList(string username);
        [OperationContract]
        bool CheckApproveTeachers(string username);
        [OperationContract]
        void AddApproveStudentstoList(string username);
        [OperationContract]
        bool CheckApproveStudents(string username);
        [OperationContract]
        void ResetTeachersPasswordList(string username);
        [OperationContract]
        void ResetStudentsPasswordList(string username);
        [OperationContract]
        bool ChkTeachersSecretQuest(string secretquestions, string answer);
        [OperationContract]
        bool ChkStudentsSecretQuest(string secretquestions, string answer);
        [OperationContract]
        void NewTeachersPassword(string newpassword);
        [OperationContract]
        void NewStudentsPassword(string newpassword);
        [OperationContract]
        void AddTeacherstoProfileList(string username);
        [OperationContract]
        void AddStudentstoProfileList(string username);
        [OperationContract]
        List<InformationTeacher> SpecificTeachersProfile();
        [OperationContract]
        List<InformationStudent> SpecificStudentsProfile();
        [OperationContract]
        string GetData(int value);
        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
