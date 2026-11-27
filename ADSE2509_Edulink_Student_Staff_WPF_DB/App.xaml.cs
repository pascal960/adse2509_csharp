using System.Globalization;
using System.Windows;
using System.Windows.Markup;

namespace ADSE2509_Edulink_Student_Staff_WPF_DB
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // WPF bindings use US dates (MM-dd-yyyy) by default. Make them use day-month-year
            // so typing 25-04-1996 in a date box works, like the rest of the course code.
            FrameworkElement.LanguageProperty.OverrideMetadata(
                typeof(FrameworkElement),
                new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(new CultureInfo("en-GB").IetfLanguageTag)));

            base.OnStartup(e);
        }
    }
}
