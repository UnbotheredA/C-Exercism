public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimeter)  => (delimeter.Length == 1) ? str.Substring(str.IndexOf(delimeter) + 1) : str.Split(delimeter)[1];

    public static string SubstringBetween(this string str, string delimeter1, string delimeter2) =>  (delimeter1.Length == 1 && delimeter2.Length == 1) ? str.Substring(str.IndexOf(delimeter1) + 1 , str.IndexOf(delimeter2) - 1) : str.Substring(str.IndexOf(delimeter1), str.IndexOf(delimeter2)).Split(" ")[1];

    public static string Message(this string Message) => SubstringAfter(Message, " ");
    
    public static string LogLevel(this string str) => SubstringBetween(str, "[", "]");
}