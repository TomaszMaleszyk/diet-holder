using System.Runtime.Serialization;

namespace DietHolderServiceLibrary
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public double Height { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public string Sex { get; set; }
        [DataMember]
        public string KindOfPosture { get; set; }
        [DataMember]
        public string DailyActivity { get; set; }
        [DataMember]
        public string GoalToRealize { get; set; }
    }
}
