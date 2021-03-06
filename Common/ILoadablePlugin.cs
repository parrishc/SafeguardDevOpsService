﻿using System.Collections.Generic;
using Serilog;

namespace OneIdentity.Common
{
    public interface ILoadablePlugin
    {
        string Name { get; }
        string Description { get; }
        Dictionary<string, string> GetPluginInitialConfiguration();
        void SetPluginConfiguration(Dictionary<string, string> configuration);
        bool SetPassword(string account, string password);
        void SetLogger(ILogger logger);
    }
}
