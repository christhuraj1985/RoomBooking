#pragma checksum "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "728ae66728a42381ea8fe9bcf5b7443056aa6813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_ExternalLogins), @"mvc.1.0.view", @"/Views/Manage/ExternalLogins.cshtml")]
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
#line 1 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\_ViewImports.cshtml"
using RoomBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\_ViewImports.cshtml"
using RoomBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
using RoomBooking.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
using RoomBooking.Views.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"728ae66728a42381ea8fe9bcf5b7443056aa6813", @"/Views/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749c322940cc53a837843cecefd1a1ac60843a18", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04524ab4062cc573be2ad78476df71fcef24fd8e", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExternalLoginsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
   ViewData["Title"] = "Manage your external logins";
    ViewData.AddActivePage(ManageNavPages.ExternalLogins); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Registered Logins</h4>\n                <table class=\"table\">\n                    <tbody>\n");
#nullable restore
#line 14 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
                         foreach (var login in Model.CurrentLogins)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 17 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
           Write(login.LoginProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>\n");
#nullable restore
#line 19 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
                 if (Model.ShowRemoveButton)
                {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "728ae66728a42381ea8fe9bcf5b7443056aa68137973", async() => {
                WriteLiteral("\n    <div>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "728ae66728a42381ea8fe9bcf5b7443056aa68138248", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 23 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "728ae66728a42381ea8fe9bcf5b7443056aa681310183", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 24 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <button type=\"submit\" class=\"btn btn-default\"");
                BeginWriteAttribute("title", " title=\"", 910, "\"", 974, 7);
                WriteAttributeValue("", 918, "Remove", 918, 6, true);
                WriteAttributeValue(" ", 924, "this", 925, 5, true);
#nullable restore
#line 25 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 929, login.LoginProvider, 930, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 950, "login", 951, 6, true);
                WriteAttributeValue(" ", 956, "from", 957, 5, true);
                WriteAttributeValue(" ", 961, "your", 962, 5, true);
                WriteAttributeValue(" ", 966, "account", 967, 8, true);
                EndWriteAttribute();
                WriteLiteral(">Remove</button>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
        }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\n");
#nullable restore
#line 31 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 34 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n");
#nullable restore
#line 37 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Add another service to log in.</h4>\n                <hr />\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "728ae66728a42381ea8fe9bcf5b7443056aa681315654", async() => {
                WriteLiteral("\n                                    <div id=\"socialLoginList\">\n                                        <p>\n");
#nullable restore
#line 45 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
                                             foreach (var provider in Model.OtherLogins)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <button type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 1653, "\"", 1675, 1);
#nullable restore
#line 47 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1661, provider.Name, 1661, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1676, "\"", 1731, 6);
                WriteAttributeValue("", 1684, "Log", 1684, 3, true);
                WriteAttributeValue(" ", 1687, "in", 1688, 3, true);
                WriteAttributeValue(" ", 1690, "using", 1691, 6, true);
                WriteAttributeValue(" ", 1696, "your", 1697, 5, true);
#nullable restore
#line 47 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1701, provider.DisplayName, 1702, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1723, "account", 1724, 8, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 47 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
                                                                                                                                                                    Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>");
#nullable restore
#line 47 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
                                                                                                                                                                                                       }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </p>\n                                    </div>\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 51 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
