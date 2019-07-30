﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Factories
{
    using RequestContext;
    using System.Net.Http;

    /// <summary>
    /// Creates instances of partner operations object.
    /// </summary>
    internal interface IPartnerFactory
    {
        /// <summary>
        /// Builds a <see cref="IPartner" /> instance and configures it using the provided partner credentials.
        /// </summary>
        /// <param name="credentials">The partner credentials.</param>
        /// <returns>A configured partner object.</returns>
        IPartner Build(IPartnerCredentials credentials);

        /// <summary>
        /// Builds a <see cref="IPartner" /> instance and configures it using the provided partner credentials.
        /// </summary>
        /// <param name="credentials">The partner credentials.</param>
        /// <param name="requestContext">The context used to perform operations.</param>
        /// <param name="requestContext">An operation context object.</param>
        /// <returns>A configured partner object.</returns>
        IPartner Build(IPartnerCredentials credentials, IRequestContext requestContext);

        /// <summary>
        /// Builds a <see cref="IPartner" /> instance and configures it using the provided partner credentials.
        /// </summary>
        /// <param name="credentials">The partner credentials.</param>
        /// <param name="handlers">List of handlers from top to bottom (outer handler is the first in the list).</param>
        /// <returns>A configured partner object.</returns>
        IPartner Build(IPartnerCredentials credentials, params DelegatingHandler[] handlers);

        /// <summary>
        /// Builds a <see cref="IPartner" /> instance and configures it using the provided partner credentials.
        /// </summary>
        /// <param name="credentials">The partner credentials.</param>
        /// <param name="requestContext">The context used to perform operations.</param>
        /// <param name="handlers">List of handlers from top to bottom (outer handler is the first in the list).</param>
        /// <returns>A configured partner object.</returns>
        IPartner Build(IPartnerCredentials credentials, IRequestContext requestContext, params DelegatingHandler[] handlers);

        /// <summary>
        /// Builds a <see cref="IPartner" /> instance and configures it using the provided partner credentials.
        /// </summary>
        /// <param name="credentials">The partner credentials.</param>
        /// <param name="httpClient">The client used to perform HTTP operations.</param>
        /// <returns>A configured partner object.</returns>
        IPartner Build(IPartnerCredentials credentials, HttpClient httpClient);

        /// <summary>
        /// Builds a <see cref="IPartner" /> instance and configures it using the provided partner credentials.
        /// </summary>
        /// <param name="credentials">The partner credentials.</param>
        /// <param name="requestContext">The context used to perform operations.</param>
        /// <param name="httpClient">The client used to perform HTTP operations.</param>
        /// <returns>A configured partner object.</returns>
        IPartner Build(IPartnerCredentials credentials, IRequestContext requestContext, HttpClient httpClient);
    }
}