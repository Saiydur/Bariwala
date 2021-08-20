using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bariwala.DAL.Entities
{
    class User
    {
        public string UserName { get; set; }
        public string UserFullName { get; set; }
        public string UserMailAddress { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public string UserType { get; set; }
        public string UserActiveStatus { get; set; }
        public string UserDOB { get; set; }
        public string UserSecretCode { get; set; }
        public string UserAddress { get; set; }
        public byte[] UserPictures { get; set; }
        public string UserSearchKeyword{get; set;}
        
    }
}
