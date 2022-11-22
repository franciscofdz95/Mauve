﻿using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace Mauve.Net.Smtp
{
    /// <summary>
    /// Represents an <see cref="INetworkRequest{T}"/> instance for sending <see cref="MailMessage"/> instances using <see cref="INetworkClient{TRequest, TIn, TOut}"/> implementations.
    /// </summary>
    /// <inheritdoc/>
    public class SmtpNetworkRequest : INetworkRequest<MailMessage>
    {

        #region Properties

        public NetworkCredential Credentials { get; set; }
        public MailMessage Data { get; set; }
        public NetworkRequestMethod Method { get; set; }
        public Dictionary<string, object> Headers { get; set; }
        public int? Port { get; set; }
        public Uri Uri { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new <see cref="SmtpNetworkRequest"/> using the specified <see cref="MailMessage"/>.
        /// </summary>
        /// <param name="message">The message this request is focused on sending.</param>
        public SmtpNetworkRequest(MailMessage message) => Data = message;

        #endregion

    }
}
