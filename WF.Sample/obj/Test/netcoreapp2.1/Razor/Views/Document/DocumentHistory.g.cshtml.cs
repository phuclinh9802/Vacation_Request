#pragma checksum "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21e0b3ecf70de0734f72ec849087051c031698b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Document_DocumentHistory), @"mvc.1.0.view", @"/Views/Document/DocumentHistory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Document/DocumentHistory.cshtml", typeof(AspNetCore.Views_Document_DocumentHistory))]
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
#line 1 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\_ViewImports.cshtml"
using WF.Sample;

#line default
#line hidden
#line 2 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\_ViewImports.cshtml"
using WF.Sample.Models;

#line default
#line hidden
#line 3 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\_ViewImports.cshtml"
using WF.Sample.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e0b3ecf70de0734f72ec849087051c031698b7", @"/Views/Document/DocumentHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6adbc898d946f89c000cdc3dda990ecfc1361cc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Document_DocumentHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WF.Sample.Models.DocumentHistoryModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
 if (Model != null && Model.Items != null && Model.Items.Count > 0)
{

#line default
#line hidden
            BeginContext(118, 357, true);
            WriteLiteral(@"    <h1>Document's Transition History</h1>
    <table class=""table"">
        <tbody>
            <tr class=""table-header"">
                <th>From</th>
                <th>To</th>
                <th>Command</th>
                <th>Executor</th>
                <th>TransitionTime</th>
                <th>Availiable for</th>
            </tr>
");
            EndContext();
#line 15 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
             foreach (var item in Model.Items)
            {

#line default
#line hidden
            BeginContext(538, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(585, 29, false);
#line 18 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                   Write(Html.Label(item.InitialState));

#line default
#line hidden
            EndContext();
            BeginContext(614, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(646, 33, false);
#line 19 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                   Write(Html.Label(item.DestinationState));

#line default
#line hidden
            EndContext();
            BeginContext(679, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(711, 24, false);
#line 20 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                   Write(Html.Label(item.Command));

#line default
#line hidden
            EndContext();
            BeginContext(735, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(767, 59, false);
#line 21 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                   Write(Html.Label(item.Employee != null ? item.Employee.Name : ""));

#line default
#line hidden
            EndContext();
            BeginContext(826, 33, true);
            WriteLiteral("</td>\r\n                    <td>\r\n");
            EndContext();
#line 23 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                         if (item.TransitionTime.HasValue)
                        {
                            

#line default
#line hidden
            BeginContext(975, 118, false);
#line 25 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                       Write(Html.Raw(string.Format("{0}",
                            item.TransitionTime.Value.ToString("yyyy-MM-dd HH:mm:ss"))));

#line default
#line hidden
            EndContext();
#line 26 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                                                                                       
                        }

#line default
#line hidden
            BeginContext(1122, 51, true);
            WriteLiteral("                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1174, 39, false);
#line 29 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
                   Write(Html.Label(item.AllowedToEmployeeNames));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
            }

#line default
#line hidden
            BeginContext(1258, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 34 "C:\Users\Owner\Desktop\New folder (3)\MSSQL\WF.Sample\Views\Document\DocumentHistory.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WF.Sample.Models.DocumentHistoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
