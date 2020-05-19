﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Triceratops.Libraries.RouteMapping.Enums
{
    public enum ApiRoutes
    {
        GetServerList,
        GetServerById,
        GetServerBySlug,
        GetServerLogs,

        CreateServer,
        StartServer,
        StopServer,
        RestartServer,
        DeleteServer,
    }
}