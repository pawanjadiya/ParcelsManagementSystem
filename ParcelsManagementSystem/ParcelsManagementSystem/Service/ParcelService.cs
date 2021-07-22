using ParcelsManagementSystem.Interface;
using ParcelsManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Text;
using static ParcelsManagementSystem.Utilities.Utilities;

namespace ParcelsManagementSystem.Service
{
    public sealed class ParcelService
    {
        /// <summary>
        /// private variable to hold class object reference
        /// </summary>
        private static ParcelService objInstance = null;

        /// <summary>
        /// private constructor for preventing object initialization
        /// </summary>
        private ParcelService()
        {

        }

        /// <summary>
        /// Get instance of this class
        /// </summary>
        /// <returns>Get new Instance of this class if obj not initialized other wise return old instance</returns>
        public static ParcelService GetInstance()
        {
            if (objInstance == null)
            {
                return new ParcelService();
            }
            else
            {
                return objInstance;
            }
        }

        /// <summary>
        /// Get Percel details
        /// </summary>
        /// <param name="parcel"></param>
        /// <returns></returns>
        public string PrepareParcelDetails(Parcel parcel)
        {
            StringBuilder objParcelDetail = new StringBuilder();

            objParcelDetail.AppendLine("Parcel goes to department : " + parcel.DepartmentType);
            objParcelDetail.AppendLine("Parcel Value : " + parcel.Value);
            objParcelDetail.AppendLine("Parcel Weight : " + parcel.Weight);

            if (parcel.Sender != null)
            {
                objParcelDetail.AppendLine("Sender Details");
                objParcelDetail.AppendLine("Sender Name : " + parcel.Sender.Name);
                objParcelDetail.AppendLine("Sender Address : " + parcel.Sender.Address.HouseNumber + ", "
                    + parcel.Sender.Address.Street + ", " + parcel.Sender.Address.PostalCode + ", " + parcel.Sender.Address.City);
                objParcelDetail.AppendLine("");
            }
            else
            {
                objParcelDetail.AppendLine("Sender Details not available. Please connect with department.");
                objParcelDetail.AppendLine("");
            }

            if (parcel.Receipient != null)
            {
                objParcelDetail.AppendLine("Receipient Details");
                objParcelDetail.AppendLine("Receipient Name : " + parcel.Receipient.Name);
                objParcelDetail.AppendLine("Receipient Address : " + parcel.Receipient.Address.HouseNumber + ", "
                    + parcel.Receipient.Address.Street + ", " + parcel.Receipient.Address.PostalCode + ", " + parcel.Receipient.Address.City);
                objParcelDetail.AppendLine("");
            }
            else
            {
                objParcelDetail.AppendLine("Receipient Details not available. Please connect with department.");
                objParcelDetail.AppendLine("");
            }

            objParcelDetail.AppendLine("Parcel approval required : " + (parcel.IsApprovalRequired ? "Yes" : "No"));

            return objParcelDetail.ToString();
        }

        /// <summary>
        /// Get Container details
        /// </summary>
        /// <param name="container"></param>
        /// <returns></returns>
        public string PrepareContainerDetails(Container container)
        {
            StringBuilder objContainerDetail = new StringBuilder();

            objContainerDetail.AppendLine("\t\tContainer ID : " + container.Id);
            objContainerDetail.AppendLine("\t\tContainer Shiping Date : " + container.ShippingDate);
            objContainerDetail.AppendLine("\t\tParcels Details");
            objContainerDetail.AppendLine("\t\t********************");

            return objContainerDetail.ToString();
        }
    }
}
