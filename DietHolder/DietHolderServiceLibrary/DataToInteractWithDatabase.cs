using System.Runtime.Serialization;

namespace DietHolderServiceLibrary
{
    [DataContract]
    public class DataToInteractWithDatabase     //rename
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string TableName { get; set; }
    }
}
