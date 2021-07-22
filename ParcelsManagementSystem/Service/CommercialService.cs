using ParcelsManagementSystem.Interface;
using ParcelsManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static ParcelsManagementSystem.Utilities.Utilities;

namespace ParcelsManagementSystem.Service
{
    /// <summary>
    /// Commercial Service for Commercial department
    /// </summary>
    public class CommercialService : Department
    {
        /// <summary>
        /// Forward Parcel to commercial department
        /// </summary>
        /// <param name="objParcel"></param>
        public override void ParcelGoesToDepartment(Parcel objParcel)
        {
            if (objParcel != null)
            {
                objParcel.IsApprovalRequired = IsApprovalRequired(objParcel.Value);
                objParcel.DepartmentType = DepartmentType.Commercial.ToString();
            }
        }
    }
}
