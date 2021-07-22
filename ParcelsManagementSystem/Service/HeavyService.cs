using ParcelsManagementSystem.Interface;
using ParcelsManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static ParcelsManagementSystem.Utilities.Utilities;

namespace ParcelsManagementSystem.Service
{
    /// <summary>
    /// Heavy Service for Heavy department
    /// </summary>
    public class HeavyService : Department
    {
        /// <summary>
        /// Forward Parcel to Heavy department
        /// </summary>
        /// <param name="objParcel"></param>
        public override void ParcelGoesToDepartment(Parcel objParcel)
        {
            if (objParcel != null)
            {
                objParcel.IsApprovalRequired = IsApprovalRequired(objParcel.Value);
                objParcel.DepartmentType = DepartmentType.Heavy.ToString();
            }
        }
    }
}
