#pragma checksum "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f7020bbf73be3af7410787e454e089c0d8b35c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\_ViewImports.cshtml"
using IoCLifeCycle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\_ViewImports.cshtml"
using IoCLifeCycle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f7020bbf73be3af7410787e454e089c0d8b35c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e796465097b1c9ecc2424289b5b5867c4aa71b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Guid değerlerini inceleyin</h1>\r\n    <p>Transient: ");
#nullable restore
#line 7 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml"
             Write(ViewBag.Transient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Scoped: ");
#nullable restore
#line 8 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml"
          Write(ViewBag.Scoped);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Singleton: ");
#nullable restore
#line 9 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml"
             Write(ViewBag.Singleton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr />\r\n    <p>Transient: ");
#nullable restore
#line 11 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml"
             Write(ViewBag.ServiceTransient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Scoped: ");
#nullable restore
#line 12 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml"
          Write(ViewBag.ServiceScoped);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Singleton: ");
#nullable restore
#line 13 "C:\Users\turka\source\repos\Kurumsal\PamukkaleEDU\IoCLifeCycle\IoCLifeCycle\Views\Home\Index.cshtml"
             Write(ViewBag.ServiceSingleton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
