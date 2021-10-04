#pragma checksum "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f7e7b5e24baaa8aa42fbd5973aa4aa0794d8c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Index), @"mvc.1.0.view", @"/Views/Ticket/Index.cshtml")]
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
#line 1 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using SampleTemplate.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using SampleTemplate.Web.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f7e7b5e24baaa8aa42fbd5973aa4aa0794d8c48", @"/Views/Ticket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b5046220eb9d9df7c3ddff4f7fffc987958cb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SampleTemplate.Entities.Domain.Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
	<div class=""row"">
		<div class=""col-md-10 col-md-offset-1"">

			<div class=""panel panel-default panel-table"">
				<div class=""panel-heading"">
					<div class=""row"">
						<div class=""col col-xs-6"">
							<h3 class=""panel-title"">
								Ticket Listesi
							</h3>
						</div>
						<div class=""col col-xs-6 text-right"">
							<button type=""button""
									class=""btn btn-sm btn-primary btn-create""");
            BeginWriteAttribute("onclick", "\r\n\t\t\t\t\t\t\t\t\tonclick=\"", 495, "\"", 562, 3);
            WriteAttributeValue("", 515, "location.href=\'", 515, 15, true);
#nullable restore
#line 18 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
WriteAttributeValue("", 530, Url.Action("Create", "Ticket"), 530, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 561, "\'", 561, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" >
								Create New
							</button>
						</div>
					</div>
				</div>
				<div class=""panel-body"">
					<table class=""table table-striped table-bordered table-list"">
						<thead>
							<tr>
								<th><em class=""fa fa-cog""></em></th>
								<th class=""hidden-xs"">ID</th>
								<th>Title</th>
								<th>Description</th>
								<th>TicketStatus</th>
								<th>Priority</th>
							</tr>
						</thead>
						<tbody>
");
#nullable restore
#line 37 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
                              
								foreach (var ticket in Model)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"									<tr>
										<td align=""center"">
											<a class=""btn btn-default"">
												<em class=""fa fa-pencil""></em>
											</a>
											<a class=""btn btn-danger"">
												<em class=""fa fa-trash""></em>
											</a>
										</td>
										<td class=""hidden-xs"">");
#nullable restore
#line 49 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
                                                         Write(ticket.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 50 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
                                       Write(ticket.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 51 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
                                       Write(ticket.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 52 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
                                       Write(ticket.TicketStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 53 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
                                       Write(ticket.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 55 "C:\Users\mehme\OneDrive\Masaüstü\SampleTemplate\SampleTemplate.Web.Mvc\Views\Ticket\Index.cshtml"
								}

							

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\r\n\t\t\t\t</div>\r\n\r\n\t\t\t</div>\r\n\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SampleTemplate.Entities.Domain.Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591