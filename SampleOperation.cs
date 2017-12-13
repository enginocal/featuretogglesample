using FeatureToggle;

namespace FeatureToggleSample
{
    public class SampleOperation : SimpleFeatureToggle
    {
        public string CalculateBudget(MyEntity entity)
        {
            string formattedStr = "";
            decimal budget = 0;
            if (this.FeatureEnabled)
            {
                budget = (decimal)(entity.Age / 10 + entity.Score * 0.2);
                formattedStr = "Entity Person Name : " + entity.Name + " ,: Budget " + budget;
            }
            else
            {
                budget = (decimal)(entity.Age / 10);
                formattedStr = "Budget " + budget;
            }
            return formattedStr;
        }
    }
}
