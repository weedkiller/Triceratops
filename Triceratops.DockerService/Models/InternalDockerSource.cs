﻿using System.IO;
using System.IO.Abstractions;
using System.Linq;
using Triceratops.DockerService.Structs;

namespace Triceratops.DockerService.Models
{
    public class InternalDockerSource
    {
        public IDirectoryInfo Directory { get; }

        public ImageConfig Config { get; }

        public InternalDockerSource(IDirectoryInfo directory, ImageConfig config)
        {
            Directory = directory;
            Config = config;
        }

        public bool Matches(DockerImageId imageId)
        {
            return Config.Name == imageId.Name && Config.Versions.Any(v => v.Tag == imageId.Tag);
        }
    }
}
