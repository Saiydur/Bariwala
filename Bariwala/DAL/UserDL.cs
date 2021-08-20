using Bariwala.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bariwala.DAL
{
    class UserDL : DataAccessLayer
    {
        private int GetUserId()
        {
            string sqlString = $"select userID from UserInformations order by userId desc";
            try
            {
                var data = ExecuteQuery(sqlString);
                int userId = 0;
                if(data.Tables[0].Rows.Count>0)
                {
                    userId = Convert.ToInt32(data.Tables[0].Rows[0][0].ToString());
                    ++userId;
                }
                else
                {
                    ++userId;
                }
                return userId;
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
                return 0;
            }
        }
        public int AddUserDB(User recive)
        {
            string sqlString = $"insert into " +
                $"UserInformations(userID,userName,userFullName,userMailAddress,userPhoneNumber,userPassword,userType," +
                $"activeStatus,userDOB,userSecretCode,userAddress) " +
                $"values('{GetUserId()}','{recive.UserName}','{recive.UserFullName}','{recive.UserMailAddress}','{recive.UserPhoneNumber}'," +
                $"'{recive.UserPassword}','{recive.UserType}','{recive.UserActiveStatus}','{recive.UserDOB}','{recive.UserSecretCode}','{recive.UserAddress}')";

            try
            {
                int number = ExecuteUpdateQuery(sqlString);
                return number;
            }
            catch
            {
                return 0;
            }
        }

        public DataSet GetUserDB(User recive)
        {
            string sqlString = $"select * from UserInformations where userName='{recive.UserName}' and userPassword='{recive.UserPassword}'";
            try
            {
                return ExecuteQuery(sqlString);
            }
            catch
            {
                throw;
            }
        }

        public int UpdateUserDB(User recive,int userId)
        {
            string sqlString = $"update UserInformations set " +
                $"userName='{recive.UserName}',userFullName='{recive.UserFullName}',userMailAddress='{recive.UserMailAddress}',userPhoneNumber='{recive.UserPhoneNumber}'," +
                $"userPassword='{recive.UserPassword}',userType='{recive.UserType}',activeStatus='{recive.UserActiveStatus}',userDOB='{recive.UserDOB}'," +
                $"userSecretCode='{recive.UserSecretCode}',userAddress='{recive.UserAddress}' " +
                $"where userID={userId}";
            try
            {
                int number = ExecuteUpdateQuery(sqlString);
                return number;
            }
            catch
            {
                return 0;
            }
        }

        public int DeteleUserDB(int userId)
        {
            string sqlString = $"delete from UserInformations where userID='{userId}'";
            try
            {
                int number = ExecuteUpdateQuery(sqlString);
                return number;
            }
            catch
            {
                return 0;
            }
        }

        public int AddAnImage(User receive,int userId)
        {
            try
            {
                string sql = @"update UserInformations set userPic=@pictures where userID='"+userId+"'";
                return ImageAdditionQueryExecution(sql, receive.UserPictures);
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
                return 0;
            }
        }

        public DataSet GetAllUserDB()
        {
            string sql = $"select *" +
                $" from UserInformations";
            return ExecuteQuery(sql);
        }

        public DataSet GetUserTypeDB(User recive)
        {
            string sqlString = $"select * from UserInformations where {recive.UserType}='{recive.UserSearchKeyword}'";
            try
            {
                return ExecuteQuery(sqlString);
            }
            catch
            {
                throw;
            }
        }

        public int UpdateUserActiveStatus(int userId,string activeStatus)
        {
            string sqlString = $"update UserInformations set " +
                $"activeStatus='{activeStatus}' where userID='{userId}'";
            try
            {
                return ExecuteUpdateQuery(sqlString);
            }
            catch
            {
                throw;
            }
        }
    }
}
