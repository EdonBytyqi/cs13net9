using System.Globalization;

partial class Program : object
{
    #region Fields: Data or state for this person
    public string? Name;
    public DateTimeOffset Born;
    #endregion
    private static void ConfigureConsole(
        string culture = "en-US",
        bool useComputerCulture = false,
        bool showCulture = true)
    {
        OutputEncoding = System.Text.Encoding.UTF8;

        if (!useComputerCulture)
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo(culture);
        }

        if (showCulture)
        {
            WriteLine($"Current Culture: {CultureInfo.CurrentCulture.DisplayName}");
        }
    }
}