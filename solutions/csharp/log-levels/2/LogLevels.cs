static class LogLine
{
    public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(" ")).Trim();

    public static string LogLevel(string logLine)
    {
        char[] charsToTrim = { '[', ']'};
        return logLine.Substring(logLine.IndexOf("["), logLine.IndexOf("]")).Trim(charsToTrim).ToLower();
    }
        
    public static string Reformat(string logLine)
    {
        string replaceCharacters = logLine.Replace("[", "(").Replace("]", ")");
        string final = "";
        string[] contents = replaceCharacters.Split(":");
  
       for(int i =0; i < contents.Length; i++) 
       {
           final = contents[1].Trim() + " " + contents[0].ToLower();
       }
           return final;
    }
}
