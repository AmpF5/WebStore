#pragma checksum "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e20b5619b738298e11be323c9d12932c1e32c168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Keyboard_List), @"mvc.1.0.view", @"/Views/Keyboard/List.cshtml")]
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
#line 1 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e20b5619b738298e11be323c9d12932c1e32c168", @"/Views/Keyboard/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2148a47ff9bbe985e3c99c6c6feb30e3be9baf75", @"/Views/_ViewImports.cshtml")]
    public class Views_Keyboard_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KeyboardListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<h1>");
#nullable restore
#line 5 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 6 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml"
 foreach(var keyboard in Model.Keyboards)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-sm-4\" col-lg-4 col-md-4>\r\n        <div class=\"thumbnail\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 218, "\"", 251, 1);
#nullable restore
#line 10 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml"
WriteAttributeValue("", 224, keyboard.ImageThumbnailUrl, 224, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image for webstore\" />\r\n            <div class=\"caption\">\r\n                <h3 class=\"pull-right\">");
#nullable restore
#line 12 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml"
                                  Write(keyboard.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h3>");
#nullable restore
#line 13 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml"
               Write(keyboard.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <p>");
#nullable restore
#line 14 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml"
              Write(keyboard.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\micha\Source\Repos\WebStore\WebStore\Views\Keyboard\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KeyboardListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591