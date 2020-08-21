﻿using System.Threading.Tasks;
using EZNEW.Cache.String.Response;

namespace EZNEW.Cache.String.Request
{
    /// <summary>
    /// String decrement option
    /// </summary>
    public class StringDecrementOption : CacheRequestOption<StringDecrementResponse>
    {
        /// <summary>
        /// Gets or sets the cache key
        /// </summary>
        public CacheKey Key { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// Gets or sets the cache entry expiration
        /// When the specified cache item is not found, the cache item is created with the change expiration information 
        /// </summary>
        public CacheExpiration Expiration { get; set; }

        /// <summary>
        /// Execute cache operation
        /// </summary>
        /// <param name="cacheProvider">Cache provider</param>
        /// <param name="server">Cache server</param>
        /// <returns>Return string decrement response</returns>
        protected override async Task<StringDecrementResponse> ExecuteCacheOperationAsync(ICacheProvider cacheProvider, CacheServer server)
        {
            return await cacheProvider.StringDecrementAsync(server, this).ConfigureAwait(false);
        }
    }
}