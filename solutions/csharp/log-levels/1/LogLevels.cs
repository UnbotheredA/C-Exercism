static class LogLine
{
    public static string Message(string logLine) => logLine.Substring(logLine.IndexOf(" ")).Trim();
    
      
       
     
    

    public static string LogLevel(string logLine)
    {
        char[] charsToTrim = { '[', ']'};
        Console.WriteLine(logLine);
        return logLine.Substring(logLine.IndexOf("["), logLine.IndexOf("]")).Trim(charsToTrim).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
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
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
