#pragma checksum "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa1d65f2b26923b4494f38632b0d2baaa7ec42b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
using Messege.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
using Messege.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa1d65f2b26923b4494f38632b0d2baaa7ec42b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c64ae2d1cd4f2d04742915b75c64e31bf59d044", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FriendNMessage>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/message.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 152, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-3 col-sm-0\"></div>\r\n        <div class=\"col-md-6 col-sm-12\">\r\n\r\n            <div id=\"frnmsg_update\">\r\n");
            EndContext();
#line 9 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                 if (Model != null)
                {
                    

#line default
#line hidden
#line 11 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                     foreach (var friend in Model)
                    {
                        

#line default
#line hidden
#line 13 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                         if (friend.Friend != null)
                        {

#line default
#line hidden
            BeginContext(442, 56, true);
            WriteLiteral("                            <div class=\"container mb-1 \"");
            EndContext();
            BeginWriteAttribute("id", " id=", 498, "", 519, 1);
#line 15 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
WriteAttributeValue("", 502, friend.Friend.Id, 502, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(519, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(554, 1690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa1d65f2b26923b4494f38632b0d2baaa7ec42b6361", async() => {
                BeginContext(662, 371, true);
                WriteLiteral(@"
                                    <div class=""row"">
                                        <table class=""table"">
                                            <tbody>
                                                <tr class="""">

                                                    <td class=""col-sm-3 "" style=""width:auto;height:auto;border:none;padding:1px""><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1033, "\"", 1070, 2);
                WriteAttributeValue("", 1039, "/", 1039, 1, true);
#line 22 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
WriteAttributeValue("", 1040, friend.Friend.Profile_Picture, 1040, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1071, 235, true);
                WriteLiteral(" height=\"60 \" width=\"60\" class=\"rounded-circle ml-3 mr-1\" /></td>\r\n                                                    <td class=\"col-sm-7 \" style=\"margin:auto;padding:5px\">\r\n                                                        <h5>");
                EndContext();
                BeginContext(1307, 24, false);
#line 24 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                       Write(friend.Friend.First_Name);

#line default
#line hidden
                EndContext();
                BeginContext(1331, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1333, 23, false);
#line 24 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                                                 Write(friend.Friend.Last_Name);

#line default
#line hidden
                EndContext();
                BeginContext(1356, 7, true);
                WriteLiteral("</h5>\r\n");
                EndContext();
#line 25 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                         if (friend.Message != null)
                                                        {

#line default
#line hidden
                BeginContext(1508, 83, true);
                WriteLiteral("                                                            <div><div class=\"ml-1\">");
                EndContext();
                BeginContext(1592, 13, false);
#line 27 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                                              Write(friend.Sender);

#line default
#line hidden
                EndContext();
                BeginContext(1605, 4, true);
                WriteLiteral("  : ");
                EndContext();
                BeginContext(1610, 14, false);
#line 27 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                                                                Write(friend.Message);

#line default
#line hidden
                EndContext();
                BeginContext(1624, 14, true);
                WriteLiteral("</div></div>\r\n");
                EndContext();
#line 28 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
                BeginContext(1818, 69, true);
                WriteLiteral("                                                            <p></p>\r\n");
                EndContext();
#line 32 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(1946, 294, true);
                WriteLiteral(@"                                                    </td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                                                                                WriteLiteral(friend.Friend.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2244, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 40 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#line 40 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#line 41 "C:\Users\dev\source\repos\Messanger-Angular\Messege\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2351, 91, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"col-md-3 col-sm-0\"></div>\r\n        ");
            EndContext();
            BeginContext(2442, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa1d65f2b26923b4494f38632b0d2baaa7ec42b14088", async() => {
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
            EndContext();
            BeginContext(2478, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(2490, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aa1d65f2b26923b4494f38632b0d2baaa7ec42b15281", async() => {
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
            EndContext();
            BeginContext(2526, 16, true);
            WriteLiteral("\r\n    </div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FriendNMessage>> Html { get; private set; }
    }
}
#pragma warning restore 1591
