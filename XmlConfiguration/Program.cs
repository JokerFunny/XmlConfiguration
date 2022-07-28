using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.IO;

namespace XmlConfiguration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddXmlFile(Path.Combine(Environment.CurrentDirectory, "..\\TestConfig.xml"), optional: false, reloadOnChange: true)
                //.AddJsonFile(Path.Combine(Environment.CurrentDirectory, "..\\TestConfig.json"), optional: false, reloadOnChange: true)
                .Build();

            ServiceCollection sc = new ServiceCollection();

            sc.AddOptions();
            sc.Configure<TestConfig>(options => configuration.Bind(options));

            ServiceProvider sp = sc.BuildServiceProvider();

            IOptions<TestConfig> test = sp.GetService<IOptions<TestConfig>>();
        }
    }
}
