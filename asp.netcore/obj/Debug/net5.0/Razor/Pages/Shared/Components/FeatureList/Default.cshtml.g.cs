#pragma checksum "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared\Components\FeatureList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39607b62ab4eaf649301236b72ca064f8f91104a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(asp.netcore.Pages.Shared.Components.FeatureList.Pages_Shared_Components_FeatureList_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/FeatureList/Default.cshtml")]
namespace asp.netcore.Pages.Shared.Components.FeatureList
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
#line 1 "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\_ViewImports.cshtml"
using asp.netcore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared\Components\FeatureList\Default.cshtml"
using EntityLayer.Concrate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39607b62ab4eaf649301236b72ca064f8f91104a", @"/Pages/Shared/Components/FeatureList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159aff09b022d6cc45bc63ce374fb93da881ca17", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_Components_FeatureList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Feature>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/images/illustrations/hello3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("hello"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<header>\r\n    <div class=\"cover bg-light\">\r\n        <div class=\"container px-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-6 p-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39607b62ab4eaf649301236b72ca064f8f91104a4625", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                <div class=\"col-lg-6\">\r\n");
#nullable restore
#line 12 "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared\Components\FeatureList\Default.cshtml"
                    foreach (var item in Model)
                   { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mt-5\">\r\n                        <p class=\"lead text-uppercase mb-1\">");
#nullable restore
#line 15 "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared\Components\FeatureList\Default.cshtml"
                                                       Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <h1 class=\"intro-title marker\" data-aos=\"fade-left\" data-aos-delay=\"50\">");
#nullable restore
#line 16 "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared\Components\FeatureList\Default.cshtml"
                                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"lead fw-normal mt-3\" data-aos=\"fade-up\" data-aos-delay=\"100\">");
#nullable restore
#line 17 "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared\Components\FeatureList\Default.cshtml"
                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""social-nav"" data-aos=""fade-up"" data-aos-delay=""200"">
                            <nav role=""navigation"">
                                <ul class=""nav justify-content-left"">
                                    <li class=""nav-item""><a class=""nav-link"" href=""https://twitter.com/templateflip"" title=""Twitter""><i class=""fab fa-twitter""></i><span class=""menu-title sr-only"">Twitter</span></a></li>
                                    <li class=""nav-item""><a class=""nav-link"" href=""https://www.facebook.com/templateflip"" title=""Facebook""><i class=""fab fa-facebook""></i><span class=""menu-title sr-only"">Facebook</span></a></li>
                                    <li class=""nav-item""><a class=""nav-link"" href=""https://www.instagram.com/templateflip"" title=""Instagram""><i class=""fab fa-instagram""></i><span class=""menu-title sr-only"">Instagram</span></a></li>
                                    <li class=""nav-item""><a class=""nav-link"" href=""https://www.linkedin.com/"" title=""Link");
            WriteLiteral(@"edIn""><i class=""fab fa-linkedin""></i><span class=""menu-title sr-only"">LinkedIn</span></a></li>
                                    <li class=""nav-item""><a class=""nav-link"" href=""https://www.behance.net/templateflip"" title=""Behance""><i class=""fab fa-behance""></i><span class=""menu-title sr-only"">Behance</span></a></li>
                                </ul>
                            </nav>
                        </div>
                        <div class=""mt-3"" data-aos=""fade-up"" data-aos-delay=""200""><a class=""btn btn-primary shadow-sm mt-1 hover-effect"" href=""#contact"">Get In Touch <i class=""fas fa-arrow-right""></i></a></div>
                    </div>
");
#nullable restore
#line 31 "C:\Users\Casper\source\repos\asp.netcore\asp.netcore\Pages\Shared\Components\FeatureList\Default.cshtml"

                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"wave-bg\"></div>\r\n</header>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Feature>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
