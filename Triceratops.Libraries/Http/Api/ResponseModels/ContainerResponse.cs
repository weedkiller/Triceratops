﻿using System;
using Triceratops.Libraries.Enums;
using Triceratops.Libraries.Models;

namespace Triceratops.Libraries.Http.Api.ResponseModels
{
    public class ContainerResponse
    {
        public Guid Id { get; set; }

        public string DockerId { get; set; }

        public string Name { get; set; }

        public ServerContainerState State { get; set; }

        public DateTime CreationDate { get; set; }

        public ContainerResponse()
        {
        }

        public ContainerResponse(Container container, ServerContainerState state, DateTime creationDate)
        {
            Id = container.Id;
            DockerId = container.DockerId;
            Name = container.Name;
            State = state;
            CreationDate = creationDate;
        }
    }
}
