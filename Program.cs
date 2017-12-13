using System;

namespace FeatureToggleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyEntity myEntity = new MyEntity();
            myEntity.Name = "Engin İsa";
            myEntity.LastName = "Öcal";
            myEntity.Age = 50;
            myEntity.Budget = 100;
            myEntity.Score = 10;

            SampleOperation sampleOperation = new SampleOperation();
            var result = sampleOperation.CalculateBudget(myEntity);
            Console.WriteLine(result);
        }
    }
}
