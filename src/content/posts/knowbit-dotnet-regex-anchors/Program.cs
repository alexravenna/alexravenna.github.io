using System.Text.RegularExpressions;

string multilineString = "This is a line of text\nAnd this is another line.";

string pattern = @"^(\w+){2,}";

MatchCollection matches = Regex.Matches(multilineString, pattern, RegexOptions.Multiline);

Console.WriteLine(matches.Count);
