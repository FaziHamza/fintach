#pragma checksum "I:\Asecnt V2\fintach\Ascent\Views\UserLogin\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef6eb3ad2ec561b85bcfb55b2434674c4eccb94c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserLogin_Invoice), @"mvc.1.0.view", @"/Views/UserLogin/Invoice.cshtml")]
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
#line 1 "I:\Asecnt V2\fintach\Ascent\Views\_ViewImports.cshtml"
using Fintech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "I:\Asecnt V2\fintach\Ascent\Views\_ViewImports.cshtml"
using Fintech.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6eb3ad2ec561b85bcfb55b2434674c4eccb94c", @"/Views/UserLogin/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5aae6f4c7e1a8225cbab52572462a126df7265b", @"/Views/_ViewImports.cshtml")]
    public class Views_UserLogin_Invoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "I:\Asecnt V2\fintach\Ascent\Views\UserLogin\Invoice.cshtml"
  
    ViewData["Title"] = "Invoice";
    Layout = "~/Views/Shared/_LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .page-item.active .page-link {
        background-color: #283041;
        border-color: #283041;
    }
</style>

<div class=""row"">
    <div class=""col-md-12"">

        <ul class=""nav nav-tabs page-header-tab"">
            <li class=""nav-item""><a class=""nav-link active"" data-toggle=""tab"" href=""#overview"">Overview</a></li>
            <li class=""nav-item""><a class=""nav-link"" data-toggle=""tab"" href=""#create"">Create</a></li>
        </ul>

    </div>
</div>
<br />
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""tab-content"">
            <div class=""tab-pane fade show active"" id=""overview"" role=""tabpanel"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <h4 class=""ml-3"">Invoices Due</h4><br />
                            <table class=""table table-striped table-hover"" id=""save-stage"" style=""width:100%;"">
                                <thead>
   ");
            WriteLiteral(@"                                 <tr>
                                        <th>Invoice ID</th>
                                        <th>Ammount</th>
                                        <th>Customer</th>
                                        <th>Status</th>
                                        <th>Due</th>
                                        <th>Created</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tiger Nixon</td>
                                        <td>System Architect</td>
                                        <td>Edinburgh</td>
                                        <td>61</td>
                                        <td>2011/04/25</td>
                                        <td>$320,800</td>
                                        <td>Edinbur");
            WriteLiteral(@"gh</td>
                                    </tr>
                                    <tr>
                                        <td>Garrett Winters</td>
                                        <td>Accountant</td>
                                        <td>Tokyo</td>
                                        <td>63</td>
                                        <td>2011/07/25</td>
                                        <td>$170,750</td>
                                        <td>Edinburgh</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <br /><br />
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <h4 class=""ml-3"">Invoice Activity</h4><br />
                            <table class=""table table-striped table");
            WriteLiteral(@"-hover"" id=""save-stag"" style=""width:100%;"">
                                <thead>
                                    <tr>
                                        <th>Invoice ID</th>
                                        <th>Ammount</th>
                                        <th>Customer</th>
                                        <th>Status</th>
                                        <th>Due</th>
                                        <th>Created</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tiger Nixon</td>
                                        <td>System Architect</td>
                                        <td>Edinburgh</td>
                                        <td>61</td>
                                        <td>2011/04/25</td>
                     ");
            WriteLiteral(@"                   <td>$320,800</td>
                                        <td>Edinburgh</td>
                                    </tr>
                                    <tr>
                                        <td>Garrett Winters</td>
                                        <td>Accountant</td>
                                        <td>Tokyo</td>
                                        <td>63</td>
                                        <td>2011/07/25</td>
                                        <td>$170,750</td>
                                        <td>Edinburgh</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <br /><br />
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <h4 class=""ml-3"">Custome");
            WriteLiteral(@"r List</h4><br />
                            <table class=""table table-striped table-hover"" id=""save-stagee"" style=""width:100%;"">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Total Payments</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>Tiger Nixon</td>
                                        <td>System Architect</td>
                                        <td>Edinburgh</td>
                                       
                                    </tr>
                                    <tr>
                                        <td>Garrett Winters</td>
                                        <td>Accountant</td>
                     ");
            WriteLiteral(@"                   <td>Tokyo</td>
                                        
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>


            </div>
            <div class=""tab-pane fade show"" id=""create"" role=""tabpanel"">
                <h4>Create</h4>
            </div>
        </div>
    </div>
</div>
");
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
