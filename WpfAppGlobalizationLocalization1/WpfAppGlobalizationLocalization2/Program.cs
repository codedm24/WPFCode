using System.Collections;
using System.Globalization;
using System.Resources;
using System.Reflection;
using static System.Console;

[assembly:NeutralResourcesLanguage("en")]

namespace WpfAppGlobalizationLocalization2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //SortAndDisplayCountryName();
            //CreateResource();
            //ReadResource();
            ResxFileUse();
            Console.ReadLine();
        }

        static void ResxFileUse() {
            var resources = new ResourceManager("WpfAppGlobalizationLocalization2.Messages", Assembly.GetEntryAssembly());
            //var resources = new ResourceManager(typeof(Program));
            //string? text = resources.GetString("Already",new CultureInfo("fr-FR"));
            //WriteLine(text);
            //text = resources.GetString("There", new CultureInfo("fr-FR"));
            //WriteLine(text);
            var text1 = resources.GetString("Young", new CultureInfo("fr-FR"));
            WriteLine(text1);
            string? text = resources.GetString("Good Morning", new CultureInfo("en-US"));
            WriteLine(text);
        }

        static void CreateResource()
        {
            string resourceFile = "Demo.resources";
            using(var writer = new ResourceWriter(resourceFile))
            {
                writer.AddResource("Title", "Professional C#");
                writer.AddResource("Author", "Christian Nagel");
                writer.AddResource("Publisher", "Wrox Press");
            }
        }

        static void ReadResource() {
            string resourceFile = "Demo.resources";
            FileStream stream = File.OpenRead(resourceFile);

            using(var reader = new ResourceReader(resourceFile))
            {
                foreach (DictionaryEntry resource in reader)
                {
                    Console.WriteLine($"{resource.Key} {resource.Value}");
                }
            }
        }

        static void SortAndDisplayCountryName()
        {
            string[] names = { "Alabama", "Texas", "Washington", "Virginia", "Wisconsin", "Wyoming","Kentucky","Missouri",
            "Utah","Hawaii","Kansas","Louisiana","Alaska","Arizona"};

            CultureInfo.CurrentCulture = new CultureInfo("fi-FI");
            Array.Sort(names);
            DisplayNames("Sorted using the Finnish culture", names);
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
        }

        static void DisplayNames(string title, IEnumerable<string> e)
        { 
            Console.WriteLine(title);
            Console.WriteLine(string.Join("-", e));
            Console.WriteLine();
        }
    }
}
