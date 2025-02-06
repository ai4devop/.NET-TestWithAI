public class DateTimeHelper
{

    public static void Main()
    {
    }

    /// <summary>
    ///  Format a DateTime to yyyy-MM-dd then return a string.
    ///  <param name="date">date Object</param>
    ///  <returns>date string using the format yyyy-MM-dd, ex : "2024-08-31"</returns>
    /// </summary>
    public static string? FormatDate(DateTime date)
    {
        return date.ToString("yyyy-MM-dd");
    }

    /// <summary>
    ///  Parse a string with the format yyyy-MM-dd to create a DateTime
    ///  <param name="dateString">string, ex : "2024-08-31"</param>
    ///  <returns>object DateTime</returns>
    /// </summary>
    public static DateTime? ParseDate(string? dateString)
    {
        if (string.IsNullOrWhiteSpace(dateString))
        {
            return null;
        }
        return DateTime.Parse(dateString);
    }

    /// <summary>
    ///  Format a DateTime to the format designated by the pattern if this format is valid
    ///  <param name="date">date Object DateTime</param>
    ///  <param name="pattern"> pattern date format, ex : yyyy-MM-dd ou dd/MM/YYYY</param>
    ///  <returns>string of the datetime formatted using the pattern</returns>
    /// </summary>
    public static string? FormatDate(DateTime date, string? pattern)
    {
        return date.ToString(pattern);
    }
}
