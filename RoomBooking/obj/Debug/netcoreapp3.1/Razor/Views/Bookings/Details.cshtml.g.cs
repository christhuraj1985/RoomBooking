#pragma checksum "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c7194f66aafc38aea90d88a273aba481bb8ce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Details), @"mvc.1.0.view", @"/Views/Bookings/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c7194f66aafc38aea90d88a273aba481bb8ce4", @"/Views/Bookings/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"749c322940cc53a837843cecefd1a1ac60843a18", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoomBooking.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-option3 btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<!-- Start Page Header -->\n<div class=\"page-header\">\n    <h1 class=\"title\">Booking Details</h1>\n    <ol class=\"breadcrumb\">\n        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7c7194f66aafc38aea90d88a273aba481bb8ce44480", async() => {
                WriteLiteral("Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n        <li class=\"active\">Details</li>\n    </ol>\n    <!-- Start Page Header Right Div -->\n    <div class=\"right\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7c7194f66aafc38aea90d88a273aba481bb8ce45770", async() => {
                WriteLiteral("Edit Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<!-- End Page Header -->
<!-- START CONTAINER -->
<div class=""container-padding"">
    <div class=""row"">
        <div class="" col-md-12 col-lg-6"">
            <div class=""row"">
                <div class=""panel panel-default col-md-12"">
                    <div class=""panel-title"">
                        Booking Details

                    </div>
                    <div class=""panel-body"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Date Created: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 36 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.DateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>


                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Check In: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 46 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.CheckIn);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>

                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Check Out: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 55 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.CheckOut);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Guests Expected: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 63 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Guests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Customer Request: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 71 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.OtherRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Total Amount: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 79 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.TotalFee);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Paid: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 87 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Paid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>

                        </div>
                    </div>
                </div>
                <div class=""panel panel-default col-md-12"">
                    <div class=""panel-title"">
                        Room Details

                    </div>
                    <div class=""panel-body"">
                        <div class=""row"">
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Room Number: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 106 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Room.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>


                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Room Category: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 116 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Room.RoomType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>

                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Price: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 125 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Room.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Description: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 133 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Room.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Customer Request: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 141 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.OtherRequests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Maximum Guests: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 149 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Room.MaximumGuests);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""col-sm-12"">
                                <p class=""col-sm-4"">
                                    <b>Paid: </b>
                                </p>
                                <p class=""col-sm-8"">
                                    ");
#nullable restore
#line 157 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                               Write(Model.Paid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="" col-md-12 col-lg-6"">
            <div class=""panel panel-default"">
                <div class=""panel-title"">
                    Customer Details

                </div>
                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <p class=""col-sm-4"">
                                <b> Name: </b>
                            </p>
                            <p class=""col-sm-8"">
                                ");
#nullable restore
#line 180 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                           Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>


                        <div class=""col-sm-12"">
                            <p class=""col-sm-4"">
                                <b>Email: </b>
                            </p>
                            <p class=""col-sm-8"">
                                ");
#nullable restore
#line 190 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                           Write(Model.CustomerEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>

                        <div class=""col-sm-12"">
                            <p class=""col-sm-4"">
                                <b>Phone Number: </b>
                            </p>
                            <p class=""col-sm-8"">
                                ");
#nullable restore
#line 199 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                           Write(Model.CustomerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                        <div class=""col-sm-12"">
                            <p class=""col-sm-4"">
                                <b>Address: </b>
                            </p>
                            <p class=""col-sm-8"">
                                ");
#nullable restore
#line 207 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                           Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                        <div class=""col-sm-12"">
                            <p class=""col-sm-4"">
                                <b>City: </b>
                            </p>
                            <p class=""col-sm-8"">
                                ");
#nullable restore
#line 215 "C:\ChristhuRaj\Projects\Room Booking\RoomBooking\RoomBooking\Views\Bookings\Details.cshtml"
                           Write(Model.CustomerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoomBooking.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
