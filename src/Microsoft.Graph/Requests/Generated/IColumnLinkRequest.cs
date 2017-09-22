// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IColumnLinkRequest.
    /// </summary>
    public partial interface IColumnLinkRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ColumnLink using PUT.
        /// </summary>
        /// <param name="columnLinkToCreate">The ColumnLink to create.</param>
        /// <returns>The created ColumnLink.</returns>
        System.Threading.Tasks.Task<ColumnLink> CreateAsync(ColumnLink columnLinkToCreate);        /// <summary>
        /// Creates the specified ColumnLink using PUT.
        /// </summary>
        /// <param name="columnLinkToCreate">The ColumnLink to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ColumnLink.</returns>
        System.Threading.Tasks.Task<ColumnLink> CreateAsync(ColumnLink columnLinkToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ColumnLink.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ColumnLink.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ColumnLink.
        /// </summary>
        /// <returns>The ColumnLink.</returns>
        System.Threading.Tasks.Task<ColumnLink> GetAsync();

        /// <summary>
        /// Gets the specified ColumnLink.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ColumnLink.</returns>
        System.Threading.Tasks.Task<ColumnLink> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ColumnLink using PATCH.
        /// </summary>
        /// <param name="columnLinkToUpdate">The ColumnLink to update.</param>
        /// <returns>The updated ColumnLink.</returns>
        System.Threading.Tasks.Task<ColumnLink> UpdateAsync(ColumnLink columnLinkToUpdate);

        /// <summary>
        /// Updates the specified ColumnLink using PATCH.
        /// </summary>
        /// <param name="columnLinkToUpdate">The ColumnLink to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ColumnLink.</returns>
        System.Threading.Tasks.Task<ColumnLink> UpdateAsync(ColumnLink columnLinkToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IColumnLinkRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IColumnLinkRequest Expand(Expression<Func<ColumnLink, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IColumnLinkRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IColumnLinkRequest Select(Expression<Func<ColumnLink, object>> selectExpression);

    }
}