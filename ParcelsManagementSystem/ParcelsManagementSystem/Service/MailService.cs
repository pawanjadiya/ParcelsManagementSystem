using ParcelsManagementSystem.Interface;
using ParcelsManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static ParcelsManagementSystem.Utilities.Utilities;

namespace ParcelsManagementSystem.Service
{
    /// <summary>
    /// Mail Service for Mail department
    /// </summary>
    public class MailService : Department
    {
        /// <summary>
        /// Forward Parcel to mail department
        /// </summary>
        /// <param name="objParcel"></param>
        public override void ParcelGoesToDepartment(Parcel objParcel)
        {
            if (objParcel != null)
            {
                objParcel.IsApprovalRequired = IsApprovalRequired(objParcel.Value);
                objParcel.DepartmentType = DepartmentType.Mail.ToString();
            }
        }
    }
}
