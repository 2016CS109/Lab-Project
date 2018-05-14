using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace StudentsAffairsSystemServer
{
    [DataContract]
    public class InformationTeacher
    {
        private string userName;
        [DataMember]
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
        private string emailId;
        [DataMember]
        public string EmailId
        {
            get
            {
                return emailId;
            }

            set
            {
                emailId = value;
            }
        }
        private string contactNumber;
        [DataMember]
        public string ContactNumber
        {
            get
            {
                return contactNumber;
            }

            set
            {
                contactNumber = value;
            }
        }
        private string department;
        [DataMember]
        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }




    }
}