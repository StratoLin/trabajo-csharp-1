#pragma checksum "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3706b110fec03b6805a0d843dd1ef3dbd83831f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LinaresEC01_PapeletasPoliciaFecha), @"mvc.1.0.view", @"/Views/LinaresEC01/PapeletasPoliciaFecha.cshtml")]
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
#line 1 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\_ViewImports.cshtml"
using Evaluacion01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\_ViewImports.cshtml"
using Evaluacion01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3706b110fec03b6805a0d843dd1ef3dbd83831f", @"/Views/LinaresEC01/PapeletasPoliciaFecha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8b977f7452b45694edbd548d40fe5199780f1f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LinaresEC01_PapeletasPoliciaFecha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Evaluacion01.Models.Papeleta>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
  
    ViewData["Title"] = "PapeletasPoliciaFecha";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Papeletas por policia y fecha</h1>\r\n\r\n");
#nullable restore
#line 9 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        Seleccione al policia: ");
#nullable restore
#line 12 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
                          Write(Html.DropDownList("pol",
                                     ViewBag.ListaPolicias as SelectList,""));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n        Seleccione la fecha: ");
#nullable restore
#line 14 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
                        Write(Html.TextBox("fecha"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\r\n        <button class=\"btn btn-info\">Consultar</button> |\r\n        ");
#nullable restore
#line 16 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
   Write(Html.ActionLink("Regresar","Index","MenuLinaresEC01"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n    </div>\r\n");
#nullable restore
#line 19 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<div>\r\n    El total de registros es: ");
#nullable restore
#line 22 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
                         Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    <br />\r\n    La suma de los importes es: ");
#nullable restore
#line 24 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
                           Write(ViewBag.suma);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</div>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3706b110fec03b6805a0d843dd1ef3dbd83831f5955", async() => {
                WriteLiteral("Create New");
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
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Nropap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Fechapap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Nropla));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.CodinfNavigation.Descrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.CodinfNavigation.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Codpol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayNameFor(model => model.Fechapago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>            \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 57 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nropap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fechapap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nropap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodinfNavigation.Descrip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayFor(modelItem => item.CodinfNavigation.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayFor(modelItem => item.Codpol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fechapago));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 82 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 83 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 84 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 87 "E:\PryectosC#\SlnEvaluacion01\Evaluacion01\Views\LinaresEC01\PapeletasPoliciaFecha.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Evaluacion01.Models.Papeleta>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591