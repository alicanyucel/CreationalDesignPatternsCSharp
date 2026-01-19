// See https://aka.ms/new-console-template for more information
using FactoryDesign;

Console.WriteLine("Hello, World!");
WebSiteFactory factory=new WebSiteFactoryEcommerce();
factory.CreateWebSite();
//WebSiteFactory factoryBlog=new WebSiteFactoryBlog();
//factoryBlog.CreateWebSite();