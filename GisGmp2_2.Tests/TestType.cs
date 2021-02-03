using GisGmp;
using GisGmp.Organization;
using System.Xml;
using Xunit;

namespace GisGmp2_2.Tests
{
    public class TestType
    {
        static string pathRoot = $@"..\..\..\XmlDocument\{nameof(TestType)}";

        [Fact]
        public void Org()
        {
            // Arrange

            //Act
            var sType = new OrganizationType("4243534", "1234567890","123456789", "1234567890123");
           
            
             
                

            XmlDocument sDoc = GisGmpBuilder.SerializerObject(sType, true);
            sDoc.Save(@$"{pathRoot}\sType.xml");

            //var dObj = GisGmpBuilder.Deserialize<OrganizationType>(sDoc);
            //XmlDocument dDoc = GisGmpBuilder.SerializerObject(dObj, true);
            //dDoc.Save(@$"{pathRoot}\dType.xml");

            //INNType inn = "1";
            
            //Assert              
            Assert.True(true);
        }      
    }
}