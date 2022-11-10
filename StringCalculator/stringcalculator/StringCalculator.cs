namespace stringcalculator;
public class StringCalculator
{
    public int Add(string numbersToAdd)
    {
        if (String.IsNullOrEmpty(numbersToAdd))
        {
            return 0;
        }

        var delimeters = FindDelimeters(numbersToAdd);

        var numbers = numbersToAdd.Split(delimeters);
        int result = 0;
        foreach (var number in numbers)
        {
            int addition;
            bool successfullyParsed = int.TryParse(number, out addition);
            if (successfullyParsed)
            {
                result += addition;
            }
        }
        return result;
    }

    public char[] FindDelimeters(string numbersToAdd)
    {
        var findDelimiters = numbersToAdd.Split('\n');
        char[] delimeters;
        if (findDelimiters.Count() > 1 && findDelimiters[0].Contains("//"))
        {
            var test = findDelimiters[0].Substring(2, 1);
            delimeters = new char[] { test[0], '\n' };
        }
        else
        {
            delimeters = new char[] { ',', '\n' };
        }
        return delimeters;
    }
}
