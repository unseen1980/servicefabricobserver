﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.AzureCat.Samples.ObserverPattern.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AzureCat.Samples.ObserverPattern.Entities;

    public interface IClientObserverActor : IEntityIdActor
    {
        /// <summary>
        /// Registers an observer actor. 
        /// This method is called by a client component.
        /// </summary>
        /// <param name="topic">The topic.</param>
        /// <param name="filterExpressions">Specifies filter expressions.</param>
        /// <param name="entityId">The entity id of the observable.</param>
        /// <returns>The asynchronous result of the operation.</returns>
        Task RegisterObserverActorAsync(string topic, IEnumerable<string> filterExpressions, EntityId entityId);

        /// <summary>
        /// Unregisters an observer actor.
        /// This method is called by a client component.
        /// </summary>
        /// <param name="topic">The topic.</param>
        /// <param name="entityId">The entity id of the observable.</param>
        /// <returns>The asynchronous result of the operation.</returns>
        Task UnregisterObserverActorAsync(string topic, EntityId entityId);

        /// <summary>
        /// Unregisters an observer actor from all observables on all topics.
        /// </summary>
        /// <returns>The asynchronous result of the operation.</returns>
        Task ClearSubscriptionsAsync();

        /// <summary>
        /// Reads the messages for the observer actor from its messagebox.
        /// </summary>
        /// <returns>The messages for the current observer actor.</returns>
        Task<IEnumerable<Message>> ReadMessagesFromMessageBoxAsync();
    }
}