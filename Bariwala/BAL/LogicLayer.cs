using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bariwala.DAL;
using Bariwala.DAL.Entities;

namespace Bariwala.BAL
{
    class LogicLayer
    {
        private UserDL userDL;
        public UserDL UserDL
        {
            set { userDL = value; }
            get { return userDL; }
        }

        public LogicLayer()
        {
            try
            {
                UserDL = new UserDL();
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message+" Connection Problem");
            }
        }

        public int AddUser(string userName, string userFullName, string userMailAddress,
            string userPhoneNumber, string userPassword, string userType, string userActiveStatus,
            string userDOB, string userSecretCode, string userAddress)
        {
            if(userActiveStatus=="")
            {
                userActiveStatus = "no";
            }
            User user = new User()
            {
                UserName = userName,
                UserFullName = userFullName,
                UserMailAddress = userMailAddress,
                UserPhoneNumber = userPhoneNumber,
                UserPassword = userPassword,
                UserType = userType,
                UserActiveStatus = userActiveStatus,
                UserDOB = userDOB,
                UserSecretCode = userSecretCode,
                UserAddress = userAddress,
            };

            int row = UserDL.AddUserDB(user);

            if (row == 1)
            {
                return row;
            }
            else
                return 0;
        }

        public DataSet GetLoginUser(string userName,string userPassword)
        {
            User user = new User()
            {
                UserName = userName,
                UserPassword = userPassword,
            };

            var data = UserDL.GetUserDB(user);

            int rowCount = data.Tables[0].Rows.Count;
            if (rowCount == 1)
            {
                return data;
            }
            else
            {
                return data=null;
            }
        }

        public int UpdateUser(int userId,string userName, string userFullName, string userMailAddress,
            string userPhoneNumber, string userPassword, string userType, string userActiveStatus,
            string userDOB, string userSecretCode, string userAddress)
        {
            User user = new User()
            {
                UserName = userName,
                UserFullName = userFullName,
                UserMailAddress = userMailAddress,
                UserPhoneNumber = userPhoneNumber,
                UserPassword = userPassword,
                UserType = userType,
                UserActiveStatus = userActiveStatus,
                UserDOB = userDOB,
                UserSecretCode = userSecretCode,
                UserAddress = userAddress,
            };

            int row = UserDL.UpdateUserDB(user,userId);

            if (row == 1)
            {
                return row;
            }
            else
                return 0;
        }

        public int UpdateProfilePicture(int userId,byte[] userImageLocations)
        {
            
            User user = new User()
            {
                UserPictures = userImageLocations,
            };
            int row = UserDL.AddAnImage(user,userId);

            if (row == 1)
            {
                return row;
            }
            else
                return 0;
        }

        public int DeleteUser(int userId)
        {
            int row = UserDL.DeteleUserDB(userId);
            if(row>0)
            {
                return row;
            }
            else
            {
                return 0;
            }
        }

        public DataSet GetAllUser()
        {
            var user = UserDL.GetAllUserDB();
            if(user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        public DataSet GetUserByType(string typeName,string searchKeyword)
        {
            User user = new User
            {
                UserType = typeName,
                UserSearchKeyword = searchKeyword,
            };
            var row = UserDL.GetUserTypeDB(user);
            if (row != null)
            {
                return row;
            }
            else
                return null;
        }

        public int UpdateUserActiveStatus(string activeStatus, int userId)
        {
            int row = UserDL.UpdateUserActiveStatus(userId, activeStatus);
            if (row > 0)
            {
                return row;
            }
            else
                return 0;
        }
    }
}
