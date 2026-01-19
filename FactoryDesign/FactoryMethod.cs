namespace FactoryDesign;

public abstract class Website
{
    public abstract void CreatePages();
}
public class WebSiteEcommerce :Website
{
    public override void CreatePages()
    {
        // E-ticaret sitesi sayfalarını oluşturma işlemleri
    }
}
public class WebSiteBlog : Website
{
    public override void CreatePages()
    {
        // blog sayfası 
    }
}
public abstract class WebSiteFactory
{
    public abstract Website CreateWebSite();
}
public class WebSiteFactoryEcommerce : WebSiteFactory
{
    public override Website CreateWebSite()
    {
        return new WebSiteEcommerce();
    }
}
public class WebSiteFactoryBlog : WebSiteFactory
{
    public override Website CreateWebSite()
    {
        return new WebSiteBlog();
    }
}