﻿using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VaultSharp.V1.SystemBackend
{
    /// <summary>
    /// Represents the request headers.
    /// </summary>
    public class RequestHeaderSet
    {
        /// <summary>
        /// Gets or sets a value.
        /// </summary>
        [JsonProperty("headers")]
        public IList<RequestHeader> Headers { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public RequestHeaderSet()
        {
            Headers = new List<RequestHeader>();
        }
    }
}