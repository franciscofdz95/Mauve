﻿using System.Collections.Generic;
using System.Net.Http;

namespace Mauve.Net
{
    public interface INetworkRequest
    {
        int? Port { get; set; }
        string Uri { get; set; }
        HttpMethod Method { get; set; }
        Dictionary<string, object> Headers { get; set; }
        Dictionary<string, object> Parameters { get; set; }
    }
}
