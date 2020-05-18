﻿using Newtonsoft.Json;
using System.Linq;

namespace Triceratops.Libraries.Models.Storage
{
    public class ServerDirectory
    {
        public string Name { get; set; }

        public string RelativePath { get; set; }

        public ServerDirectory[] Directories { get; set; }

        public ServerFile[] Files { get; set; }

        [JsonIgnore]
        public bool IsEmpty => !Directories.Any() && !Files.Any();
    }
}