using System.Collections.Generic;

namespace XmlConfiguration
{
    public class TestConfig
    {
        public TestOptions TestOptions { get; set; }

        public List<ApplicationTestSettings> Applications { get; set; }

        public TestConfig()
        {
            TestOptions = new TestOptions();
            Applications = new List<ApplicationTestSettings>();
        }
    }

    public class TestOptions
    {
        public string Id { get; set; }
        public string Secret { get; set; }
        public string Scope { get; set; }
        public string ResponseType { get; set; }
        public string[] EndpointAddresses { get; set; }
        public string IssuerAddress { get; set; }
        public string TestName { get; set; }
    }

    public class ApplicationTestSettings
    {
        public string ClientName { get; set; }
        public string Url { get; set; }
        public TestOptions TestOptions { get; set; }
    }
}
