﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using GenericOperations;
    using Models.Subscriptions;
    using System;

    /// <summary>
    /// Defines the operations available on a customer's subscription registration status.
    /// </summary>
    public interface ISubscriptionRegistrationStatus : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<SubscriptionRegistrationStatus>
    {
    }
}