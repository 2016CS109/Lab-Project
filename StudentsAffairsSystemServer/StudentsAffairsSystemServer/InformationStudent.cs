using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace StudentsAffairsSystemServer
{
    [DataContract]
    public class InformationStudent
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
        private string section;
        [DataMember]
        public string Section
        {
            get
            {
                return section;
            }

            set
            {
                section = value;
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
        private string registerationNumber;
        [DataMember]
        public string RegisterationNumber
        {
            get
            {
                return registerationNumber;
            }

            set
            {
                registerationNumber = value;
            }
        }
        private string studentCategory;
        [DataMember]
        public string StudentCategory
        {
            get
            {
                return studentCategory;
            }

            set
            {
                studentCategory = value;
            }
        }
    }
}