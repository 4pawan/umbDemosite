using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace umbDemosite.Implementation
{
    public static class UmbracoExtensions
    {
        private static UmbracoHelper _umbHelper;
        public static UmbracoHelper UmbHelper
        {
            get { return _umbHelper ?? (_umbHelper = Umbraco.Web.Composing.Current.UmbracoHelper); }
        }

        public static string ToMediaUrl(this object content)
        {
            return UmbHelper.Media(content).Url;
        }

        /// <summary>
        /// Aliases of doctypes that should be excluded from navigation etc.
        /// </summary>
        private readonly static string[] ExcludedAliases = new string[]
        {
            "ExampleAlias", "AnotherExampleAlias"
        };



        /// <summary>
        /// Gets the home page relative to the current content
        /// </summary>
        /// <param name="content">The current content</param>
        /// <returns>The root node of the site</returns>
        public static IPublishedContent HomePage(this IPublishedContent content)
        {
            return content.AncestorOrSelf(1);
        }

        /// <summary>
        /// Gets whether this content has a template associated with it
        /// </summary>
        /// <param name="content">The content to check</param>
        /// <returns>Returns true if it has a template otherwise false</returns>
        public static bool HasTemplate(this IPublishedContent content)
        {
            return content.TemplateId > 0;
        }

        /// <summary>
        /// Gets whether this document should be excluded based on it's DocumentTypeAlias
        /// </summary>
        /// <param name="content">The content to check</param>
        /// <returns>True if it should be excluded otherwise false</returns>
        //public static bool IsExcluded(this IPublishedContent content)
        //{
        //    return ExcludedAliases.Contains(content.DocumentTypeAlias);
        //}

        /// <summary>
        /// Gets whether this document should appear in the menu
        /// </summary>
        /// <param name="content">The content to check</param>
        /// <returns>True if it should otherwise false</returns>
        //public static bool IsInMenu(this IPublishedContent content)
        //{
        //    return content.HasTemplate() && content.IsVisible() && !content.IsExcluded();
        //}
    }
}