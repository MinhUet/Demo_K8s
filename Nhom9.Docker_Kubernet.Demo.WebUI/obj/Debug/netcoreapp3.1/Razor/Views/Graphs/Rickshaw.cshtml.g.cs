#pragma checksum "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Graphs\Rickshaw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054676ad4a6e841d93648f8b076296b880e57a8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Graphs_Rickshaw), @"mvc.1.0.view", @"/Views/Graphs/Rickshaw.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054676ad4a6e841d93648f8b076296b880e57a8d", @"/Views/Graphs/Rickshaw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e631c1a90fb2f777ff4053fe313c2c9a6aa1d4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Graphs_Rickshaw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/d3/d3.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/rickshaw/rickshaw.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/d3/d3.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/rickshaw/rickshaw.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Graphs\Rickshaw.cshtml"
  
    ViewData["Title"] = "Rickshaw";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>Rickshaw Charts</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 265, "\"", 312, 1);
#nullable restore
#line 10 "D:\C#\DataPrivate\Nhom9.Docker_Kubernet.Demo\Nhom9.Docker_Kubernet.Demo.WebUI\Views\Graphs\Rickshaw.cshtml"
WriteAttributeValue("", 272, Url.Action("Dashboard_1", "Dashboards"), 272, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Graphs</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Rickshaw Charts</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Simple area example <small>With custom colors.</small></h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
    ");
            WriteLiteral(@"                        <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div id=""chart"" class=""rickshaw_graph""></div>

                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Multiple Area</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
               ");
            WriteLiteral(@"         </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div id=""rickshaw_multi"" class=""rickshaw_graph""></div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-l");
            WriteLiteral(@"g-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>One line Example</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                   ");
            WriteLiteral(@"     </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div id=""rickshaw_line"" class=""rickshaw_graph""></div>

                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Multiple Line Example</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
   ");
            WriteLiteral(@"                             <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div id=""rickshaw_multi_line"" class=""rickshaw_graph""></div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Bars</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrenc");
            WriteLiteral(@"h""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div id=""rickshaw_bars"" class=""rickshaw_graph""></div>

                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Stacked Bars</h5>
                    <div class=""ibox-tools"">
            ");
            WriteLiteral(@"            <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div id=""rickshaw_bars_stacked"" class=""rickshaw_graph""></div");
            WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Scatterplot</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
     ");
            WriteLiteral(@"                   <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div id=""rickshaw_scatterplot"" class=""rickshaw_graph""></div>

                </div>
            </div>
        </div>

    </div>

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054676ad4a6e841d93648f8b076296b880e57a8d16593", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054676ad4a6e841d93648f8b076296b880e57a8d16875", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054676ad4a6e841d93648f8b076296b880e57a8d18035", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054676ad4a6e841d93648f8b076296b880e57a8d20168", async() => {
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054676ad4a6e841d93648f8b076296b880e57a8d20450", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "054676ad4a6e841d93648f8b076296b880e57a8d21610", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            var graph = new Rickshaw.Graph({
                element: document.querySelector(""#chart""),
                series: [{
                    color: '#1ab394',
                    data: [
                        { x: 0, y: 40 },
                        { x: 1, y: 49 },
                        { x: 2, y: 38 },
                        { x: 3, y: 30 },
                        { x: 4, y: 32 }]
                }]
            });
            graph.render();

            var graph2 = new Rickshaw.Graph({
                element: document.querySelector(""#rickshaw_multi""),
                renderer: 'area',
                stroke: true,
                series: [{
                    data: [{ x: 0, y: 40 }, { x: 1, y: 49 }, { x: 2, y: 38 }, { x: 3, y: 20 }, { x: 4, y: 16 }],
                    color: '#1ab394',
                    stroke: '#17997f'
                }, {
                    data: [{ x: 0, y");
                WriteLiteral(@": 22 }, { x: 1, y: 25 }, { x: 2, y: 38 }, { x: 3, y: 44 }, { x: 4, y: 46 }],
                    color: '#eeeeee',
                    stroke: '#d7d7d7'
                }]
            });
            graph2.renderer.unstack = true;
            graph2.render();

            var graph3 = new Rickshaw.Graph({
                element: document.querySelector(""#rickshaw_line""),
                renderer: 'line',
                series: [{
                    data: [{ x: 0, y: 40 }, { x: 1, y: 49 }, { x: 2, y: 38 }, { x: 3, y: 30 }, { x: 4, y: 32 }],
                    color: '#1ab394'
                }]
            });
            graph3.render();

            var graph4 = new Rickshaw.Graph({
                element: document.querySelector(""#rickshaw_multi_line""),
                renderer: 'line',
                series: [{
                    data: [{ x: 0, y: 40 }, { x: 1, y: 49 }, { x: 2, y: 38 }, { x: 3, y: 30 }, { x: 4, y: 32 }],
                    color: '#1ab394'
                }, ");
                WriteLiteral(@"{
                    data: [{ x: 0, y: 20 }, { x: 1, y: 24 }, { x: 2, y: 19 }, { x: 3, y: 15 }, { x: 4, y: 16 }],
                    color: '#d7d7d7'
                }]
            });
            graph4.render();

            var graph5 = new Rickshaw.Graph({
                element: document.querySelector(""#rickshaw_bars""),
                renderer: 'bar',
                series: [{
                    data: [{ x: 0, y: 40 }, { x: 1, y: 49 }, { x: 2, y: 38 }, { x: 3, y: 30 }, { x: 4, y: 32 }],
                    color: '#1ab394'
                }]
            });
            graph5.render();

            var graph6 = new Rickshaw.Graph({
                element: document.querySelector(""#rickshaw_bars_stacked""),
                renderer: 'bar',
                series: [
                    {
                        data: [{ x: 0, y: 40 }, { x: 1, y: 49 }, { x: 2, y: 38 }, { x: 3, y: 30 }, { x: 4, y: 32 }],
                        color: '#1ab394'
                    }, {
         ");
                WriteLiteral(@"               data: [{ x: 0, y: 20 }, { x: 1, y: 24 }, { x: 2, y: 19 }, { x: 3, y: 15 }, { x: 4, y: 16 }],
                        color: '#d7d7d7'
                    }]
            });
            graph6.render();

            var graph7 = new Rickshaw.Graph({
                element: document.querySelector(""#rickshaw_scatterplot""),
                renderer: 'scatterplot',
                stroke: true,
                padding: { top: 0.05, left: 0.05, right: 0.05 },
                series: [{
                    data: [{ x: 0, y: 15 },
                        { x: 1, y: 18 },
                        { x: 2, y: 10 },
                        { x: 3, y: 12 },
                        { x: 4, y: 15 },
                        { x: 5, y: 24 },
                        { x: 6, y: 28 },
                        { x: 7, y: 31 },
                        { x: 8, y: 22 },
                        { x: 9, y: 18 },
                        { x: 10, y: 16 }
                    ],
                    co");
                WriteLiteral("lor: \'#1ab394\'\r\n                }]\r\n            });\r\n            graph7.render();\r\n\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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