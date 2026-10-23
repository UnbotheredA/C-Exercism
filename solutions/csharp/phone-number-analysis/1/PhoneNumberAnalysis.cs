public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string firstThreeDigits = phoneNumber.Substring(0,3);
        string fakeNumber = phoneNumber.Substring(4,3);
        bool newYork = firstThreeDigits == "212" ? true : false; 
        bool isFakeNumber = fakeNumber == "555" ? true : false;
        string endOfNumber = phoneNumber.Substring(8,4);                               
        return (newYork, isFakeNumber, endOfNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
