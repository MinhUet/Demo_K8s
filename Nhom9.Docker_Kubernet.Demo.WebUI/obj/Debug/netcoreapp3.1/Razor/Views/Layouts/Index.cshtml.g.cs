#pragma checksum "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Layouts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bcb7862bac9e9d49a381c51deb9873df1924021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layouts_Index), @"mvc.1.0.view", @"/Views/Layouts/Index.cshtml")]
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
#line 1 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\_ViewImports.cshtml"
using Nhom9.Docker_Kubernet.Demo.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\_ViewImports.cshtml"
using Nhom9.Docker_Kubernet.Demo.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcb7862bac9e9d49a381c51deb9873df1924021", @"/Views/Layouts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e631c1a90fb2f777ff4053fe313c2c9a6aa1d4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Layouts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid img-shadow"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/dashboard4_2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/dashboard4_1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/full_height.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/off_canvas.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Layouts\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Layouts</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 256, "\"", 303, 1);
#nullable restore
#line 11 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Layouts\Index.cshtml"
WriteAttributeValue("", 263, Url.Action("Dashboard_1", "Dashboards"), 263, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Layouts</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-content text-center p-md"">

                    <h2>
                        <span class=""text-navy"">INSPINIA - Responsive Admin Theme</span>
                        is provided with two main layouts <br />three skins and separate configure options.
                    </h2>

                    <p>
                        All config options you can trun on/off from the theme box configuration (green icon on the left side of page).
                    </p>


                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=");
            WriteLiteral(@"""ibox "">
                <div class=""ibox-content text-center p-md"">

                    <h4 class=""m-b-xxs"">Top navigation, centered content layout</h4>
                    <small>(optional layout)</small>
                    <p>Available configure options</p>
                    <span class=""simple_tag"">Scroll navbar</span>
                    <span class=""simple_tag"">Top fixed navbar</span>
                    <span class=""simple_tag"">Boxed layout</span>
                    <span class=""simple_tag"">Scroll footer</span>
                    <span class=""simple_tag"">Fixed footer</span>
                    <div class=""m-t-md"">
                        <p>Check the Dashboard v.4 with top navigation layout</p>
                        <div class=""p-lg "">
                            <a");
            BeginWriteAttribute("href", " href=\"", 2133, "\"", 2180, 1);
#nullable restore
#line 58 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Layouts\Index.cshtml"
WriteAttributeValue("", 2140, Url.Action("Dashboard_4", "Dashboards"), 2140, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bcb7862bac9e9d49a381c51deb9873df19240218583", async() => {
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
            WriteLiteral(@"</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-content text-center p-md"">

                    <h4 class=""m-b-xxs"">Basic left side navigation layout </h4><small>(main layout)</small>
                    <p>Available configure options</p>
                    <span class=""simple_tag"">Collapse menu</span>
                    <span class=""simple_tag"">Fixed sidebar</span>
                    <span class=""simple_tag"">Scroll navbar</span>
                    <span class=""simple_tag"">Top fixed navbar</span>
                    <span class=""simple_tag"">Boxed layout</span>
                    <span class=""simple_tag"">Scroll footer</span>
                    <span class=""simple_tag"">Fixed footer</span>
                    <div class=""m-t-md"">
                        <p>Check the Dashboard v.4 with basic layout</p>
               ");
            WriteLiteral("         <div class=\"p-lg\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3338, "\"", 3387, 1);
#nullable restore
#line 82 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Layouts\Index.cshtml"
WriteAttributeValue("", 3345, Url.Action("Dashboard_4_1", "Dashboards"), 3345, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bcb7862bac9e9d49a381c51deb9873df192402111338", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>


    </div>
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-content text-center p-md"">

                    <h4 class=""m-b-xxs"">Full height - Outlook view <span class=""label label-primary"">NEW</span></h4>
                    <small>(optional layout)</small>
                    <p>Available configure options</p>
                    <span class=""simple_tag"">Scroll navbar</span>
                    <span class=""simple_tag"">Boxed layout</span>
                    <span class=""simple_tag"">Scroll footer</span>
                    <span class=""simple_tag"">Fixed footer</span>
                    <div class=""m-t-md"">
                        <p>Check the Outlook view in in full height page</p>
                        <div class=""p-lg "">
                            <a");
            BeginWriteAttribute("href", " href=\"", 4446, "\"", 4491, 1);
#nullable restore
#line 107 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Layouts\Index.cshtml"
WriteAttributeValue("", 4453, Url.Action("OutlookView", "AppViews"), 4453, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bcb7862bac9e9d49a381c51deb9873df192402113957", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-content text-center p-md"">

                    <h4 class=""m-b-xxs"">Off canvas menu <span class=""label label-primary"">NEW</span></h4>
                    <small>(optional layout)</small>
                    <p>Available configure options</p>
                    <span class=""simple_tag"">Collapse menu</span>
                    <span class=""simple_tag"">Fixed sidebar</span>
                    <span class=""simple_tag"">Top fixed navbar</span>
                    <span class=""simple_tag"">Boxed layout</span>
                    <span class=""simple_tag"">Scroll footer</span>
                    <span class=""simple_tag"">Fixed footer</span>
                    <div class=""m-t-md"">
                        <p>Check the off canvas menu on example article page</p>
                      ");
            WriteLiteral("  <div class=\"p-lg\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 5641, "\"", 5683, 1);
#nullable restore
#line 131 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Layouts\Index.cshtml"
WriteAttributeValue("", 5648, Url.Action("OffCanvas", "Layouts"), 5648, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bcb7862bac9e9d49a381c51deb9873df192402116700", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n\r\n</div>");
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