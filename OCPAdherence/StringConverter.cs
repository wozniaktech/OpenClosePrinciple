public class IntConverter : IStringConverter
{
    public string ConvertToString(object value)
    {
        if (value is int intValue)
        {
            return intValue.ToString();
        }

        throw new InvalidOperationException("Invalid conversion");
    }
}

public class DoubleConverter : IStringConverter
{
    public string ConvertToString(object value)
    {
        if (value is double doubleValue)
        {
            return doubleValue.ToString();
        }

        throw new InvalidOperationException("Invalid conversion");
    }
}

// Adding a new type without modifying existing classes
public class DateTimeConverter : IStringConverter
{
    public string ConvertToString(object value)
    {
        if (value is DateTime dateTimeValue)
        {
            return dateTimeValue.ToString();
        }

        throw new InvalidOperationException("Invalid conversion");
    }
}
