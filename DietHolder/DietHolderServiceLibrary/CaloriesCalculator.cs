using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace DietHolderServiceLibrary
{
    public class CaloriesCalculator : ICaloriesCalculator
    {
        public double GetDailyCaloriesToEatValue(Person person)
        {
            var argumentNullException = new ArgumentNullException();
            if(IsPersonFieldsNullOrEmpty(person))
            {
                throw argumentNullException;
            }

            double dailyCaloriesToEatValue = 0;

            switch(person.DailyActivity)
            {
                case "Mała":
                    dailyCaloriesToEatValue = 1.2 * GetBmrValue(person);
                    break;
                case "Średnia":
                    dailyCaloriesToEatValue = 1.4 * GetBmrValue(person);
                    break;
                case "Duża":
                    dailyCaloriesToEatValue = 1.7 * GetBmrValue(person);
                    break;
                case "Bardzo duża":
                    dailyCaloriesToEatValue = 2 * GetBmrValue(person);
                    break;
            }
            switch(person.GoalToRealize)
            {
                case "Redukcja wagi":
                    switch(person.KindOfPosture)
                    {
                        case "Ektomorfik":
                            dailyCaloriesToEatValue -= 0.1 * dailyCaloriesToEatValue;
                            break;
                        case "Mezomorfik":
                            dailyCaloriesToEatValue -= 0.15 * dailyCaloriesToEatValue;
                            break;
                        case "Endomorfik":
                            dailyCaloriesToEatValue -= 0.2 * dailyCaloriesToEatValue;
                            break;
                    }
                    break;
                case "Zyskanie wagi":
                    switch(person.KindOfPosture)
                    {
                        case "Ektomorfik":
                            dailyCaloriesToEatValue += 0.2 * dailyCaloriesToEatValue;
                            break;
                        case "Mezomorfik":
                            dailyCaloriesToEatValue += 0.15 * dailyCaloriesToEatValue;
                            break;
                        case "Endomorfik":
                            dailyCaloriesToEatValue += 0.1 * dailyCaloriesToEatValue;
                            break;
                    }
                    break;
            }
            return dailyCaloriesToEatValue;
        }
        public double GetBmrValue(Person person)
        {
            var argumentNullException = new ArgumentNullException();
            if(IsPersonFieldsNullOrEmpty(person))
            {
                throw argumentNullException;
            }
            double bmrValue = 0;
            if(person.Sex == "Mezczyzna")
            {
                bmrValue = 66.5 + 13.7 * person.Weight + 5 * person.Height - 6.8 * person.Age;
            }
            if(person.Sex == "Kobieta")
            {
                bmrValue = 655 + 9.6 * person.Weight + 1.85 * person.Height - 4.7 * person.Age;
            }
            return bmrValue;
        }
        public Dictionary<string, double> GetMacrosDistribution(Calorify calorifyToEat)
        {
            var macrosDistribution = new Dictionary<string, double>();

            var carbohydrates = 0.55 * calorifyToEat.Calories / 4;
            var protein = 0.15 * calorifyToEat.Calories / 4;
            var fat = 0.3 * calorifyToEat.Calories / 9;

            macrosDistribution.Add("Węglowodany", carbohydrates);
            macrosDistribution.Add("Białko", protein);
            macrosDistribution.Add("Tłuszcze", fat);

            return macrosDistribution;
        }
        private static bool IsPersonFieldsNullOrEmpty(Person person)
        {
            var properties = person.GetType().GetProperties(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.NonPublic);

            foreach(var property in properties)
            {
                var value = property.GetValue(property.GetGetMethod().IsStatic ? null : person);

                if(ReferenceEquals(null, value))
                    return true;

                var valueToString = value.ToString();

                if(valueToString.Equals(""))
                    return true;
                if(valueToString.Equals("0"))
                    return true;

            }
            return false;
        }
    }
    [DataContract]
    public class Calorify
    {
        [DataMember]
        public double Calories;
    }
}
