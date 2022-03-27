using Lab1.Models;
namespace Lab1.Services
{
    public class CalcService
    {
        Random rand = new Random();
        public WebCalcModel GetCalcModel()
        {
            int first = rand.Next() % 11;
            int second = rand.Next() % 11;

            WebCalcModel model = new WebCalcModel()
            {
                FirstValue = first,
                SecondValue = second,
                CalcResults = new List<CalcResult>()
            };

            model.CalcResults.Add(new CalcResult(first, second, "Add", "+"));
            model.CalcResults.Add(new CalcResult(first, second, "Sub", "-"));
            model.CalcResults.Add(new CalcResult(first, second, "Mult", "*"));
            model.CalcResults.Add(new CalcResult(first, second, "Div", "/"));

            return model;
        }
    }
}
