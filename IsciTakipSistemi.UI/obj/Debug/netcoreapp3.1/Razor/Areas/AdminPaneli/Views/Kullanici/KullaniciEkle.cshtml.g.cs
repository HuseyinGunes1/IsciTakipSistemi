#pragma checksum "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Areas\AdminPaneli\Views\Kullanici\KullaniciEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebbee2bae1dceee6f3a24f58bba9c3b5c828fa7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPaneli_Views_Kullanici_KullaniciEkle), @"mvc.1.0.view", @"/Areas/AdminPaneli/Views/Kullanici/KullaniciEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebbee2bae1dceee6f3a24f58bba9c3b5c828fa7e", @"/Areas/AdminPaneli/Views/Kullanici/KullaniciEkle.cshtml")]
    public class Areas_AdminPaneli_Views_Kullanici_KullaniciEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\hüseyin\source\repos\IsciTakipSistemi\IsciTakipSistemi.UI\Areas\AdminPaneli\Views\Kullanici\KullaniciEkle.cshtml"
  
    ViewData["Title"] = "KullaniciEkle";
    Layout = "~/Areas/AdminPaneli/Views/Shared/Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""d-flex justify-content-center mt-5 ml-3"">
	<form>
		<div class=""form-group"">
			<label for=""exampleInputEmail1"">Kullanıcı Adı</label>
			<input type=""email"" class=""form-control"" placeholder=""Kullanıcı Adı Giriniz"">

		</div>
		<div class=""form-group"">
			<label for=""exampleInputEmail1"">Email adresi</label>
			<input type=""email"" class=""form-control"" "" placeholder=""Email Adresi Giriniz"">

		</div>
		<div class=""form-group"">
			<label for=""exampleInputPassword1"">Parola</label>
			<input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Parola Giriniz"">
		</div>
		<label for=""inputState"">Grup Adı</label>
		<select id=""inputState"" class=""form-control"">
			<option selected>Hüseyin Güneş</option>
			<option>Saliha Güneş</option>
		</select>
		<button type=""submit"" class=""btn btn-primary mt-2"">Kullanıcı Ekle</button>
	</form>
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
