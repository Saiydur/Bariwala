using Bariwala.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bariwala.DAL
{
    class FlatsDL : DataAccessLayer

    {
        public int GetFlatId()
        {
            string sqlString = $"select flatDetailsId from FlatDetails order by flatDetailsId desc";

            var data=ExecuteQuery(sqlString);
            int tableToFlatId=0;
            if (data.Tables[0].Rows.Count > 0)
            {
                tableToFlatId = Convert.ToInt32(data.Tables[0].Rows[0][0]);
                ++tableToFlatId;
            }
            else
            {
                ++tableToFlatId;
            }
            return tableToFlatId;
        }
        public int AddFlatDB(FlatDetails flatDetails)
        {
            string sqlString = $"insert into FlatDetails(flatDetailsId, flatNumber, flatLocation, flatBedRoom, flatDinningRoom, flatDrawingRoom, flatWashRoom, flatKitchen"+
                                $", flatBalcony, flatMonthlyGasCharge, flatMonthlyWaterCharge, flatMonthlyElectricCharge, flatMonthlyUtilities,"+
                                $"flatMonthlyRent, flatSize, flatOwnerId)"+
                                $"values('{flatDetails.FlatDetailsId}', '{flatDetails.FlatNumber}', '{flatDetails.FlatLocation}', '{flatDetails.FlatBedRoom}', " +
                                $"'{flatDetails.FlatDinningRoom}', '{flatDetails.FlatDrawingRoom}', '{flatDetails.FlatWashRoom}', '{flatDetails.FlatKitchen}', " +
                                $"'{flatDetails.FlatBalcony}', '{flatDetails.FlatMonthlyGasCharge}', '{flatDetails.FlatMonthlyWaterCharge}', '{flatDetails.FlatMonthlyElectricCharge}', '{flatDetails.FlatMonthlyUtilitiesCharge}', " +
                                $"'{flatDetails.FlatMonthlyRent}', '{flatDetails.FlatSize}', '{flatDetails.FlatOwnerId}')";
            string sqlStringForMarket = $"insert into AssigneeFlatDetails(assigneeFlatId,flatDetails) values('{flatDetails.FlatNumber}','{flatDetails.FlatDetailsId}')";


            try
            {
                int row = ExecuteUpdateQuery(sqlString);
                ExecuteUpdateQuery(sqlStringForMarket);
                return row;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        public int UpdateFlat(FlatDetails flatDetails)
        {
            string sqlString = $"update FlatDetails set " +
                                $"flatMonthlyGasCharge = '{flatDetails.FlatMonthlyGasCharge}'," +
                                $"flatMonthlyWaterCharge = '{flatDetails.FlatMonthlyWaterCharge}'," +
                                $"flatMonthlyElectricCharge = '{flatDetails.FlatMonthlyElectricCharge}'," +
                                $"flatMonthlyUtilities = '{flatDetails.FlatMonthlyUtilitiesCharge}', " +
                                $"flatMonthlyRent='{flatDetails.FlatMonthlyRent}' " +
                                $"where flatDetailsId='{flatDetails.FlatDetailsId}'";

            try
            {
                return ExecuteUpdateQuery(sqlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                return 0;
            }
        }

        public int DeleteFlat(FlatDetails flatDetails)
        {
            string sqlString = $"delete from FlatDetails where flatDetailsId='{flatDetails.FlatDetailsId}'";
            string sqlStringMarket = $"delete from AssigneeFlatDetails where flatDetails='{flatDetails.FlatDetailsId}'";
            try
            {
                ExecuteUpdateQuery(sqlStringMarket);
                return ExecuteUpdateQuery(sqlString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                return 0;
            }
        }

        public DataSet GetAFlat(FlatDetails flatDetails)
        {
            string sqlString = $"select * from FlatDetails where flatNumber='{flatDetails.FlatNumber}' and flatOwnerId='{flatDetails.FlatOwnerId}'";

            try
            {
                return ExecuteQuery(sqlString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                return null;
            }
        }
        public DataSet GetAllFlats()
        {
            string sqlString = $"select * from FlatDetails";

            try
            {
                return ExecuteQuery(sqlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                return null;
            }
        }

        public DataSet GetParticularOwnerFlats(FlatDetails flatDetails)
        {
            string sqlString = $"select * from FlatDetails where flatOwnerId='{flatDetails.FlatOwnerId}'";

            try
            {
                return ExecuteQuery(sqlString);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                return null;
            }
        }

        public DataSet GetParticularOwnerFlatsEmptyStatus(FlatDetails flatDetails)
        {
            string sqlString = $"select * from FlatDetails as fd inner join AssigneeFlatDetails as ad on "+
                                $"fd.flatDetailsId = ad.flatDetails where flatOwnerId = '{flatDetails.FlatOwnerId}' and assigneeTenantId is null; ";

            try
            {
                return ExecuteQuery(sqlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                return null;
            }
        }

        public DataSet GetParticularOwnerFlatsAssigneeStatus(FlatDetails flatDetails)
        {
            string sqlString = $"select * from FlatDetails as fd inner join AssigneeFlatDetails as ad on " +
                                $"fd.flatDetailsId = ad.flatDetails where flatOwnerId = '{flatDetails.FlatOwnerId}' and assigneeTenantId is not null; ";

            try
            {
                return ExecuteQuery(sqlString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                return null;
            }
        }

        public DataSet GetAllFlatDetailsForTenantDB()
        {
            string sqlString = @"select * from FlatDetails as fd inner join AssigneeFlatDetails as ad on fd.flatDetailsId=ad.flatDetails where  assigneeTenantId is null;";

            try
            {
                var data = ExecuteQuery(sqlString);
                if(data.Tables[0].Rows.Count>0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message.ToString()+" Occured");
                return null;
            }
        }

        public int UpdateAssignFlat(FlatDetails flatDetails)
        {
            string sqlString = $"update AssigneeFlatDetails set " +
                $"assigneeTenantId='{flatDetails.FlatTenantId}' where flatDetails='{flatDetails.FlatDetailsId}'";

            try
            {
                int row = ExecuteUpdateQuery(sqlString);
                if(row==1)
                {
                    return row;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message.ToString() + " Occured");
                return 0;
            }
        }

        public DataSet AssignFlatSearchByType(string type,string keyword)
        {
            string sqlString ="";
            if (type == "Location")
            {
                sqlString = $"select * from FlatDetails as fd inner join AssigneeFlatDetails as ad on fd.flatDetailsId=ad.flatDetails where  assigneeTenantId is null and fd.flatLocation='{keyword}';";
            }
            if (type == "FlatSize")
            {
                sqlString = $"select * from FlatDetails as fd inner join AssigneeFlatDetails as ad on fd.flatDetailsId=ad.flatDetails where  assigneeTenantId is null and fd.flatSize='{Convert.ToInt32(keyword)}';";
            }
            if (type == "Monthly Rent")
            {
                sqlString = $"select * from FlatDetails as fd inner join AssigneeFlatDetails as ad on fd.flatDetailsId=ad.flatDetails where  assigneeTenantId is null and fd.flatMonthlyRent='{Convert.ToDecimal(keyword)}';";
            }

            try
            {
                var data= ExecuteQuery(sqlString);
                if(data.Tables[0].Rows.Count>0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message.ToString() + " Occured");
                return null;
            }
        }

        public DataSet GetParticularTenantFlatsDB(FlatDetails flatDetails)
        {
            string sqlString = $"select * from FlatDetails as fd inner join AssigneeFlatDetails as ad on fd.flatDetailsId=ad.flatDetails where ad.assigneeTenantId='{flatDetails.FlatTenantId}';";
            try
            {
                var data = ExecuteQuery(sqlString);
                if (data.Tables[0].Rows.Count > 0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString() + " Occured");
                return null;
            }
        }

        public int LeaveFlatUpdate(FlatDetails flatDetails)
        {
            string sqlString = $"update AssigneeFlatDetails set assigneeTenantId=null where flatDetails='{flatDetails.FlatDetailsId}';";

            try
            {
                int row=ExecuteUpdateQuery(sqlString);
                if(row==1)
                {
                    return row;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString() + " Occured");
                return 0;
            }
        }

        public DataSet GetAllFlatDetailsWithTeantInfoDB(FlatDetails flatDetails)
        {
            string sqlString = $"select * from AssigneeFlatDetails as afd inner join UserInformations as ui " +
                $"on afd.assigneeTenantId=ui.userID inner join FlatDetails as fd on " +
                $"afd.flatDetails=fd.flatDetailsId where fd.flatOwnerId='{flatDetails.FlatOwnerId}';";
            try
            {
                var data = ExecuteQuery(sqlString);
                if(data!=null && data.Tables[0].Rows.Count>0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
                return null;
            }
        }
    }
}
