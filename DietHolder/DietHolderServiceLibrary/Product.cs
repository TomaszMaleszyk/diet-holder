using System.Runtime.Serialization;

namespace DietHolderServiceLibrary
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public double ProductProteinValue { get; set; }
        [DataMember]
        public double ProductCarboValue { get; set; }
        [DataMember]
        public double ProductFatValue { get; set; }
    }
}
