namespace Strings
{
    using System.Text.RegularExpressions;

    public class StringsService : IStringsService
    {
        public int CountHowManyTimesIsContained(string text, string textToSearch)
        {
            return Regex.Matches(text, textToSearch).Count;
        }
    }
}
