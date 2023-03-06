Make your strings more nerdy: Replace all 'a'/'A' with 4, 'e'/'E' with 3 and 'l' with 1 e.g. "Fundamentals" --> "Fund4m3nt41s"

Documentation:
Kata.Nerdify Method (String)
Nerdifies a string. Returns a copy of the original string with 'a'/'A' characters replaced with '4', 'e'/'E' characters replaced with '3', and 'l' characters replaced with '1'.

Syntax

public static string Nerdify(
string str
  )

Parameters
str
Type: System.String
The string to be nerdified.

Return Value
Type: System.String
The nerdified string.


Exceptions

Exception	Condition
ArgumentNullException	str is null.

solutions

return string.Concat(str.Select(x => "aelAE".Contains(x) ? "43143"["aelAE".IndexOf(x)] : x));

return Regex.Replace(str, "[aelAE]", m => $"{"43143"["aelAE".IndexOf(m.Value[0])]}");

return str.Replace(new Regex("l"), "1")
              .Replace(new Regex("a", RegexOptions.IgnoreCase), "4")
              .Replace(new Regex("e", RegexOptions.IgnoreCase), "3");

return string.Concat(str.Select(x => char.ToLower(x) == 'a' ? '4' : char.ToLower(x) == 'e' ? '3' : x == 'l' ? '1' : x));