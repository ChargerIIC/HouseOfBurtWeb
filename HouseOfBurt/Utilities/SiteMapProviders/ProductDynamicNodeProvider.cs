using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HouseOfBurt.Models;
using MvcSiteMapProvider;

namespace HouseOfBurt.Utilities.SiteMapProviders
{
    public class ProductDynamicNodeProvider : DynamicNodeProviderBase 
    {
        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var products = DataService.Instance.Database.Products;
            // Create a node for each album 
            foreach (var product in products)
            {
                var dynamicNode = new DynamicNode { Title = product.Name };
                dynamicNode.RouteValues.Add("id", product.Slug);
                //dynamicNode.ParentKey = "Genre_" + album.Genre.Name;

                yield return dynamicNode;
            }
        } 
    }
}