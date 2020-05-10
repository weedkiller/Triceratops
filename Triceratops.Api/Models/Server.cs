﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triceratops.Api.Models
{
    public class Server
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public string JsonConfiguration { get; set; }

        public string ConfigurationTypeName { get; set; }

        [JsonIgnore]
        [BsonIgnore]
        public Type ConfigurationType
        {
            get => Type.GetType(ConfigurationTypeName);
            set => ConfigurationTypeName = value.FullName;
        }

        [BsonIgnore]
        public List<Container> Containers { get; set; } = new List<Container>();

        public object DeserialiseConfiguration()
        {
            return JsonConvert.DeserializeObject(JsonConfiguration, ConfigurationType);
        }

        public void SetConfiguration(object configuration)
        {
            ConfigurationType = configuration.GetType();
            JsonConfiguration = JsonConvert.SerializeObject(configuration);
        }
    }
}
