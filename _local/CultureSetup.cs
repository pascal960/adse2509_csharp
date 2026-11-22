// Local helper (not from the lecturer): makes every program read dates as
// day-month-year (e.g. "25-04-1996" = 25 April), whatever this PC's region is.
namespace LocalSetup
{
    internal static class CultureSetup
    {
        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void UseDayMonthYear()
        {
            var culture = new System.Globalization.CultureInfo("en-GB");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = culture;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = culture;
            System.Globalization.CultureInfo.CurrentCulture = culture;
            System.Globalization.CultureInfo.CurrentUICulture = culture;
        }
    }
}
