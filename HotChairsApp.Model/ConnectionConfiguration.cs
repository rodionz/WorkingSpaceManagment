using System;

namespace HotChairsApp.Model
{
    public class ConnectionConfigurations : IConnectionConfigurations
    {
        public string MainCollection { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }


    public interface IConnectionConfigurations
    {
        string MainCollection { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

