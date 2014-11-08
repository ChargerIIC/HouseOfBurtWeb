using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseOfBurt.Models;
using MvcSiteMapProvider;

namespace HouseOfBurt.Utilities.SiteMapProviders
{
    public class ArticleDynamicNodeProvider : DynamicNodeProviderBase 
    {
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var articles = DataService.Instance.Database.Articles;
                // Create a node for each album 
                foreach (var article in articles)
                {
                    var dynamicNode = new DynamicNode {Title = article.Title};
                    dynamicNode.RouteValues.Add("id", article.Slug);
                    //dynamicNode.ParentKey = "Genre_" + album.Genre.Name;

                    yield return dynamicNode;
                }
        } 
    }
}