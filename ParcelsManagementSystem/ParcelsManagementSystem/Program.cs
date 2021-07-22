using ParcelsManagementSystem.Interface;
using ParcelsManagementSystem.Model;
using ParcelsManagementSystem.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Serialization;
using ParcelsManagementSystem.Utilities;
using System.Text;

namespace ParcelsManagementSystem
{
    class Program
    {
        /// <summary>
        /// Mail method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Container container = ReadXML.ReadXMLToModel(@"../../../XmlFile/Container_68465468.xml");

                if (container != null)
                {
                    ProcessAllParcel(container);
                }
                else
                {
                    Console.WriteLine("Container not found. Please connect with department.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred in program. Please see the below details.");
                Console.WriteLine(ex.StackTrace);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Process All parcel
        /// </summary>
        /// <param name="container"></param>
        public static void ProcessAllParcel(Container container)
        {
            Console.WriteLine(ParcelService.GetInstance().PrepareContainerDetails(container));

            // Process each parcel
            foreach (var item in container.Parcels.Parcel)
            {
                if (item.Weight > 1 && item.Weight <= 2)
                {
                    MailService objMail = new MailService();
                    objMail.ParcelGoesToDepartment(item);
                }

                if (item.Weight > 1 && item.Weight < 10)
                {
                    RegulerService objReguler = new RegulerService();
                    objReguler.ParcelGoesToDepartment(item);
                }

                if (item.Weight > 10)
                {
                    HeavyService objHeavy = new HeavyService();
                    objHeavy.ParcelGoesToDepartment(item);
                }

                if (item.Weight < 1)
                {
                    CommercialService objCommercial = new CommercialService();
                    objCommercial.ParcelGoesToDepartment(item);
                }

                if (item != null)
                {
                    Console.WriteLine(ParcelService.GetInstance().PrepareParcelDetails(item));
                }

                Console.WriteLine("-----------------------------");
            }
        }

        /// <summary>
        /// Read Model data from XML
        /// </summary>
        /// <param name="sPath"></param>
        /// <returns></returns>
       
    }
}
