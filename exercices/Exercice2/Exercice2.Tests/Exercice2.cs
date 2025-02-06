public class DateTimeHelperTest
{
    [Fact]
  public void TestFormatDateValidDate()
    {
        var date = new DateTime(2024, 10, 28);
        string? formattedDate = DateTimeHelper.FormatDate(date);
        Assert.Equal("2024-10-28", formattedDate);
    }

    [Fact]
    public void TestParseDateValidDate()
    {
        var date = DateTimeHelper.ParseDate("2024-10-11");
        Assert.Equal(new DateTime(2024, 10, 11), date);
    }

    [Fact]
    public void TestParseDateInvalidDate()
    {
        Assert.Throws<FormatException>(() =>
            DateTimeHelper.ParseDate("invalid-date")
        );
    }

    [Fact]
    public void TestFormatDateWithPattern()
    {
        var date = new DateTime(2024, 10, 28);
        string? formattedDate1 = DateTimeHelper.FormatDate(date, "dd/MM/yyyy");
        string? formattedDate2 = DateTimeHelper.FormatDate(date, "yyyy-MM-dd");
        Assert.Equal("28/10/2024", formattedDate1);
        Assert.Equal("2024-10-28", formattedDate2);

    }
}

