using ParcelsManagementSystem.Interface;
using ParcelsManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static ParcelsManagementSystem.Utilities.Utilities;

namespace ParcelsManagementSystem.Service
{
    /// <summary>
    /// Reguler Service for reguler department
    /// </summary>
    public class RegulerService : Department
    {
        /// <summary>
        /// Forward Parcel to reguler department
        /// </summary>
        /// <param name="objParcel"></param>
        public override void ParcelGoesToDepartment(Parcel objParcel)
        {
            if (objParcel != null)
            {
                objParcel.IsApprovalRequired = IsApprovalRequired(objParcel.Value);
                objParcel.DepartmentType = DepartmentType.Reguler.ToString();
            }
        }
    }
}
