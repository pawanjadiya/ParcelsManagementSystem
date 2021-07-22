using ParcelsManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelsManagementSystem.Interface
{
    public abstract class Department
    {
        /// <summary>
        /// Check Is Approval Required or not
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool IsApprovalRequired(double Value)
        {
            if (Value > 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Use for diffrenciate the department
        /// </summary>
        /// <param name="objParcel"></param>
        public abstract void ParcelGoesToDepartment(Parcel objParcel);
    }
}
