﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace OneIdentity.SafeguardDevOpsService.Data
{
    public class Configuration : Registration
    {
        [JsonIgnore]
        public int Id { get; set; } = 1;
        public IEnumerable<AccountMapping> AccountMapping { get; set; }
    }
}
