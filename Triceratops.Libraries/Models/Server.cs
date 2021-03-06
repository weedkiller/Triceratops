﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Triceratops.Libraries.Helpers;
using Triceratops.Libraries.Models.ServerConfiguration;

namespace Triceratops.Libraries.Models
{
    public class Server
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Slug = ServerHelper.CreateServerNameSlug(_name);
            }
        }

        public string JsonConfiguration { get; set; }

        public string ConfigurationTypeName { get; set; }

        public List<Container> Containers { get; set; } = new List<Container>();

        [JsonIgnore]
        public bool HasVolumes => Containers.Any(c => c.Volumes.Any());

        [JsonIgnore]
        public ushort[] HostPorts => Containers.SelectMany(c => c.ServerPorts.Select(b => b.HostPort)).ToArray();

        [JsonIgnore]
        public Type ConfigurationType
        {
            get => typeof(AbstractServerConfiguration).Assembly.GetType(ConfigurationTypeName);
            set => ConfigurationTypeName = value.FullName;
        }

        [JsonIgnore]
        public string Slug { get; private set; }

        private string _name;

        public AbstractServerConfiguration DeserialiseConfiguration()
        {
            return JsonHelper.Deserialise(JsonConfiguration, ConfigurationType) as AbstractServerConfiguration;
        }

        public void SetConfiguration(AbstractServerConfiguration configuration)
        {
            ConfigurationType = configuration.GetType();
            JsonConfiguration = JsonHelper.Serialise(configuration);
        }
    }
}
