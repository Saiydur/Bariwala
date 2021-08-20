using Bariwala.DAL;
using Bariwala.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bariwala.BAL
{
    class FlatsLayer
    {
        private FlatsDL flatsDL;
        internal FlatsDL FlatsDL {
            set { flatsDL = value; }
            get { return flatsDL; }
        }

        public FlatsLayer()
        {
            try
            {
                flatsDL = new FlatsDL();
            }
            catch (Exception exe)
            {
                Console.WriteLine(exe.Message + " Connection Problem");
            }
        }

        public int AddFlat(string flatNumber, string flatLocation,int flatSize, int flatBedRoom, int flatDinningRoom,int flatDrawingRoom, int flatWashRoom,
                            int flatKitchen, int flatBalcony, decimal flatMonthlyGasCharge, decimal flatMonthlyWaterCharge,
                            decimal flatMonthlyElectricCharge,decimal flatMonthlyUtilities,decimal flatMonthlyRent,int flatOwnerId)
        {
            int flatId = FlatsDL.GetFlatId();
            FlatDetails flatDetails = new FlatDetails()
            {
                FlatDetailsId=flatId,
                FlatBalcony = flatBalcony,
                FlatBedRoom = flatBedRoom,
                FlatDinningRoom = flatDinningRoom,
                FlatDrawingRoom=flatDrawingRoom,
                FlatKitchen=flatKitchen,
                FlatLocation=flatLocation,
                FlatMonthlyElectricCharge=flatMonthlyElectricCharge,
                FlatMonthlyGasCharge=flatMonthlyElectricCharge,
                FlatMonthlyRent=flatMonthlyRent,
                FlatMonthlyUtilitiesCharge=flatMonthlyUtilities,
                FlatMonthlyWaterCharge=flatMonthlyWaterCharge,
                FlatNumber=flatNumber,
                FlatOwnerId=flatOwnerId,
                FlatSize=flatSize,
                FlatWashRoom=flatWashRoom,
            };
                int row = FlatsDL.AddFlatDB(flatDetails);
            return row;
        }

        public DataSet GetAFlat(int flatId)
        {
            FlatDetails flatDetails = new FlatDetails() { FlatDetailsId = flatId };

            return FlatsDL.GetAFlat(flatDetails);
        }

        public DataSet GetOwnerFlats(int ownerId)
        {
            FlatDetails flatDetails = new FlatDetails() { FlatOwnerId=ownerId};
            try
            {
                var data = FlatsDL.GetParticularOwnerFlats(flatDetails);
                if(data.Tables[0].Rows.Count>0)
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + " Occured");
                throw;
            }
            
        }

        public int UpdateFlats(int flatsId,decimal flatRent,decimal flatGasCharge,decimal flatElectricCharge,decimal flatWaterCharge,decimal flatUtilitiesCharge)
        {
            FlatDetails flatDetails = new FlatDetails()
            {
                FlatDetailsId=flatsId,
                FlatMonthlyRent = flatRent,
                FlatMonthlyGasCharge = flatGasCharge,
                FlatMonthlyElectricCharge=flatElectricCharge,
                FlatMonthlyWaterCharge=flatWaterCharge,
                FlatMonthlyUtilitiesCharge=flatUtilitiesCharge,
            };

            try
            {
                int row = FlatsDL.UpdateFlat(flatDetails);
                if (row == 1)
                {
                    return row;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        public int DeleteFlats(int flatsId)
        {
            FlatDetails flatDetails = new FlatDetails()
            {
                FlatDetailsId = flatsId,
            };
            try
            {
                int row = FlatsDL.DeleteFlat(flatDetails);
                if (row == 1)
                {
                    return row;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return 0;
            }
        }

        public DataSet SearchFlats(string flatNumber,int flatOwnerId)
        {
            FlatDetails flatDetails = new FlatDetails()
            {
                FlatNumber=flatNumber,
                FlatOwnerId = flatOwnerId
            };
            try
            {
                var data = FlatsDL.GetAFlat(flatDetails);
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
                MessageBox.Show(exe.Message.ToString());
                return null;
            }
        }

        public DataSet GetAllFlatsStatus(int ownerId,string status)
        {
            FlatDetails flatDetails = new FlatDetails() { FlatOwnerId=ownerId,};
            DataSet dataSet=null;
            try
            {
                if (status == "empty")
                {
                    dataSet = FlatsDL.GetParticularOwnerFlatsEmptyStatus(flatDetails);
                    
                }
                if(status == "assign")
                {
                    dataSet= FlatsDL.GetParticularOwnerFlatsAssigneeStatus(flatDetails);
                }

                if (dataSet != null && dataSet.Tables[0].Rows.Count > 0)
                {
                    return dataSet;
                }
                else
                {
                    return null;
                }
                
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
                return null;
            }
        }

        public DataSet GetAllFlatDetailsForTenant()
        {
            try
            {
                var data = FlatsDL.GetAllFlatDetailsForTenantDB();
                if (data != null)
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

        public int SetAssigneFlats(int tenantId,int flatId)
        {
            FlatDetails flatDetails = new FlatDetails()
            {
                FlatTenantId=tenantId,
                FlatDetailsId=flatId
            };
            try
            {
                int row = FlatsDL.UpdateAssignFlat(flatDetails);
                return row;
            }
            catch(Exception exe) { MessageBox.Show(exe.Message.ToString()); return 0; }
        }

        public DataSet GetTeantFlatByType(string type,string keyWord)
        {
            var data = FlatsDL.AssignFlatSearchByType(type, keyWord);
            if(data!=null)
            {
                return data;
            }
            else
            {
                return null;
            }
        }
        public DataSet  GetParticularTenantFlats(int tenantId)
        {
            FlatDetails flatDetails = new FlatDetails() { FlatTenantId = tenantId };
            var data = FlatsDL.GetParticularTenantFlatsDB(flatDetails);

            if (data != null)
            {
                return data;
            }
            else
            {
                return null;
            }
        }
        public int LeaveFlatUpdate(int flatId)
        {
            FlatDetails flatDetails = new FlatDetails() { FlatDetailsId = flatId };
            int row = FlatsDL.LeaveFlatUpdate(flatDetails);

            if(row == 1)
            {
                return row;
            }
            else
            {
                return 0;
            }
        }

        public DataSet GetAllFlatDetailsWithTeantInfo(int ownerId)
        {
            FlatDetails flatDetails = new FlatDetails() { FlatOwnerId = ownerId };
            var data = FlatsDL.GetAllFlatDetailsWithTeantInfoDB(flatDetails);
            if(data!=null && data.Tables[0].Rows.Count>0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }
    }

}
