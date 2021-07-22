using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcelsManagementSystem.Model;
using ParcelsManagementSystem.Service;
using ParcelsManagementSystem.Utilities;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Container container = ReadXML.ReadXMLToModel(@"../../../XmlFile/Container_68465468.xml");
            // Process each parcel
            foreach (var item in container.Parcels.Parcel)
            {
                if (item.Weight > 1 && item.Weight <= 2)
                {
                    MailService objMail = new MailService();
                    objMail.ParcelGoesToDepartment(item);
                    Assert.IsNotNull(item);
                }

                if (item.Weight > 1 && item.Weight < 10)
                {
                    RegulerService objReguler = new RegulerService();
                    objReguler.ParcelGoesToDepartment(item);
                    Assert.IsNotNull(item);
                }

                if (item.Weight > 10)
                {
                    HeavyService objHeavy = new HeavyService();
                    objHeavy.ParcelGoesToDepartment(item);
                    Assert.IsNotNull(item);
                }

                if (item.Weight < 1)
                {
                    CommercialService objCommercial = new CommercialService();
                    objCommercial.ParcelGoesToDepartment(item);
                    Assert.IsNotNull(item);
                }

              
            }
        }
    }
}
