#pragma checksum "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d65fa0e5d40fb940478e95a51f2ea4993e8f3ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderUser_Index), @"mvc.1.0.view", @"/Views/OrderUser/Index.cshtml")]
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
#line 1 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d65fa0e5d40fb940478e95a51f2ea4993e8f3ab2", @"/Views/OrderUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Domain.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
  
    ViewData["Title"] = "OrderUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>VIEW ORDERS</h1>\n\n<div>");
#nullable restore
#line 9 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 9 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
                                              Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div>");
#nullable restore
#line 11 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 11 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
                                                 Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div>");
#nullable restore
#line 13 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 13 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
                                                Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div>");
#nullable restore
#line 15 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
Write(Html.DisplayNameFor(model => model.UserAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 15 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
                                                   Write(Html.DisplayFor(model => model.UserAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<div>\n");
#nullable restore
#line 18 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
   foreach (var item in Model.Orders)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>OrderId : ");
#nullable restore
#line 20 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
              Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 21 "/Users/jeremychheav/Desktop/revature_projects/p1-Descritorio/p1-project/PizzaBox.Client/Views/OrderUser/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Domain.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
