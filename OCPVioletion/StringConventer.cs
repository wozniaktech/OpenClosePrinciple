public class StringConverter
{
    public string ConvertToString(object value)
    {
        if (value is int)
        {
            return ((int)value).ToString();
        }
        else if (value is double)
        {
            return ((double)value).ToString();
        }
        // Adding new type requires modifying existing code
        else if (value is DateTime)
        {
            return ((DateTime)value).ToString();
        }
        // More types require more checks and break OCP

        return "Unsupported Type";
    }
}
