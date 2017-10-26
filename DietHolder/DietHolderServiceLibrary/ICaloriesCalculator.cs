using System.Collections.Generic;
using System.ServiceModel;

namespace DietHolderServiceLibrary
{
    [ServiceContract]
    public interface ICaloriesCalculator
    {
        [OperationContract]
        double GetBmrValue(Person person);
        [OperationContract]
        double GetDailyCaloriesToEatValue(Person person);
        [OperationContract]
        Dictionary<string, double> GetMacrosDistribution(Calorify kalorie);
    }
}
