﻿using System;

namespace Mauve.Net
{
    /// <summary>
    /// Represents connection information for various forms of network communication.
    /// </summary>
    public class NetworkConnectionInformation
    {
        /// <summary>
        /// Should default crednetials be utilized for the connection?
        /// </summary>
        public bool UseDefaultCredentials { get; set; }
        /// <summary>
        /// The port this connection uses.
        /// </summary>
        public int? Port { get; set; }
        /// <summary>
        /// The host of the connection (e.g. the IP Address, Server Name, Base URL, etc).
        /// </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// The credential to be utilized for connection.
        /// </summary>
        public NetworkCredential Credential { get; set; }
    }
}
