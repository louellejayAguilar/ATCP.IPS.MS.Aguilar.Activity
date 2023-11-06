namespace ATCP.IPS.MS.Aguilar.Core.Helpers
{
    public static class StringUtility
    {
        public static string Concatenate(string s1, string s2, string delimiter)
        {
            string returnVal;
            if (string.IsNullOrEmpty(delimiter))
            {
                returnVal = $"{s1} {s2}";
            }
            else
            {
                returnVal = $"{s2}{delimiter} {s1}";
            }               
            return returnVal;
        }
    }
}
