using Exercice1;

public class StringHelperTest
{

    [Fact]
    public void IsPalindromeTest()
    {
        Assert.True(StringHelper.IsPalindrome("radar"));
        Assert.True(StringHelper.IsPalindrome("racecar"));
        Assert.False(StringHelper.IsPalindrome("hello"));
        Assert.True(StringHelper.IsPalindrome(""));
        Assert.True(StringHelper.IsPalindrome(null));
    }

    [Fact]
    public void IsAnagramTest()
    {
        // simple cases
        Assert.True(StringHelper.IsAnagram("listen", "silent"));
        Assert.True(StringHelper.IsAnagram("triangle", "integral"));
        Assert.False(StringHelper.IsAnagram("abc", "abcd"));
        Assert.False(StringHelper.IsAnagram("hello", "world"));

        // anagram not case sensitive
        Assert.True(StringHelper.IsAnagram("Listen", "Silent"));

        // anagram with sentences
        Assert.True(StringHelper.IsAnagram("a gentleman", "elegant man"));
        Assert.False(StringHelper.IsAnagram("ohello world", "world hello o"));

        // corner cases
        Assert.False(StringHelper.IsAnagram("", ""));
        Assert.False(StringHelper.IsAnagram("test", null));
        Assert.False(StringHelper.IsAnagram(null, null));

    }

    [Fact]
    public void ToCamelCaseTest()
    {
        // simple cases
        Assert.Equal("HelloWorld", StringHelper.ToCamelCase("hello world"));
        Assert.Equal("JavaProgramming", StringHelper.ToCamelCase("java programming"));

        // one word
        Assert.Equal("Hello", StringHelper.ToCamelCase("hello"));
        Assert.Equal("World", StringHelper.ToCamelCase("WORLD"));

        // multiple cases
        Assert.Equal("HelloWorld", StringHelper.ToCamelCase("Hello World"));
        Assert.Equal("JavaProgramming", StringHelper.ToCamelCase("JAVA programming"));

        // spaces
        Assert.Equal("HelloWorld", StringHelper.ToCamelCase("   hello   world   "));

        // corner cases
        Assert.Null(StringHelper.ToCamelCase(null));
        Assert.Equal("", StringHelper.ToCamelCase(""));

    }
}
