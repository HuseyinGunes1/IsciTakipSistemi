#pragma checksum "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01f8be454d92f30ede970485ccb6a87d8376a5fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Isci_IsciDetay), @"mvc.1.0.view", @"/Views/Isci/IsciDetay.cshtml")]
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
#line 1 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\_ViewImports.cshtml"
using IsciTakipSistemi.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\_ViewImports.cshtml"
using IsciTakipSistemi.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01f8be454d92f30ede970485ccb6a87d8376a5fc", @"/Views/Isci/IsciDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8e498a870c4e08559b9d7c1f855ed5a5b91fe2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Isci_IsciDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ITS.CORE.Dto.CreateIsciBilgiDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
  
	ViewData["Title"] = "IsciDetay";
	Layout = "~/Views/Shared/View.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row d-flex justify-content-center mt-2"">
	

	<div class=""col-sm-3 p-2 m-2"">
		<div class=""card bg-warning rounded "">
			<div class=""card-body"">
				<h5 class=""card-title""></h5>
				<h5 class=""card-text text-white""><i class='bx bx-money ' style='color:#f7f4f4; font-size: 1.5rem;'></i> TOPLAM YÖVMİYE</h5><br>
				<h4 class=""card-text text-white""> <i class='bx bx-lira ' style='color:#f7f4f4; font-size: 1.5rem;'> ");
#nullable restore
#line 14 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                                                                                                               Write(ViewBag.Yövmiye);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i></h4>

			</div>
		</div>
	</div>

	<div class=""col-sm-3 p-2 m-2"">
		<div class=""card bg-danger rounded "">
			<div class=""card-body"">
				<h5 class=""card-title""></h5>
				<h5 class=""card-text text-white""><i class='bx bx-money ' style='color:#f7f4f4; font-size: 1.5rem;'></i> ÜCRET</h5><br>
				<h4 class=""card-text text-white""> <i class='bx bx-lira ' style='color:#f7f4f4; font-size: 1.5rem;'> ");
#nullable restore
#line 25 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                                                                                                               Write(ViewBag.Ucret);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i></h4>


			</div>
		</div>
	</div>

	<div class=""col-sm-3 p-2 m-2"">
		<div class=""card bg-primary rounded "">
			<div class=""card-body"">
				<h5 class=""card-title""></h5>
				<h5 class=""card-text text-white""><i class='bx bx-calendar ' style='color:#f7f4f4; font-size: 1.5rem;'></i>TOPLAM ÜCRET</h5><br>
				<h4 class=""card-text text-white""> ");
#nullable restore
#line 37 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                                             Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

			</div>
		</div>
	</div>





</div>
<div class=""table-wrapper"">
	<div class=""table-title"">
		<div class=""row"">
			<div class=""col-sm-12 "">

				<h4 style=""padding:1rem;color:white; font-size: 1.5rem; float: left;"">İşçi Bilgileri</h4>

			</div>

		</div>
	</div>
	<div class=""table-responsive"">
		<table class=""table table-striped"">
			<thead>
				<tr>

					<th scope=""col"">İş Adı</th>
					<th scope=""col"">Tarih</th>
					<th scope=""col"">Yövmiye</th>
					<th scope=""col"">İşveren Adı</th>
					<th scope=""col"">İşveren Soyadı</th>

				</tr>
			</thead>
			<tbody>
");
#nullable restore
#line 73 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                 foreach (var i in Model)
				{



#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\r\n\t\t\t\t\t<td>");
#nullable restore
#line 79 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                   Write(i.IsAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 80 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                   Write(i.Tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 81 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                   Write(i.Yövmiye);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 82 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                   Write(i.IsverenAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 83 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
                   Write(i.IsverenSoyadi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 87 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Views\Isci\IsciDetay.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n\t</div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ITS.CORE.Dto.CreateIsciBilgiDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
