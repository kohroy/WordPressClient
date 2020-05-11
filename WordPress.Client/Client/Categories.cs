﻿using WordPress.Client.Models;
using WordPress.Client.Utility;

namespace WordPress.Client.Client
{
    /// <summary>
    /// Client class for interaction with Categories endpoint WP REST API
    /// </summary>
    public class Categories : CRUDOperation<Category, CategoriesQueryBuilder>
    {
        #region Init

        private const string _methodPath = "categories";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="HttpHelper">reference to HttpHelper class for interaction with HTTP</param>
        /// <param name="defaultPath">path to site, EX. http://demo.com/wp-json/ </param>
        public Categories(ref HttpHelper HttpHelper, string defaultPath) : base(ref HttpHelper, defaultPath, _methodPath, true)
        {
        }

        #endregion Init
    }
}