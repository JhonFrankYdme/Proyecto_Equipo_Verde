#pragma checksum "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da19a2d0ef08a1a9d0ecb699be4fb67a1915b09c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orden_Carrito), @"mvc.1.0.view", @"/Views/Orden/Carrito.cshtml")]
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
#line 1 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\_ViewImports.cshtml"
using TiendaRopa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\_ViewImports.cshtml"
using TiendaRopa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da19a2d0ef08a1a9d0ecb699be4fb67a1915b09c", @"/Views/Orden/Carrito.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d1bdf0d949c0491370ba4b469a0250dc5d178f", @"/Views/_ViewImports.cshtml")]
    public class Views_Orden_Carrito : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TiendaRopa.Models.OrdenDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: center;border-radius: 4px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Proceso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
  
    ViewData["Title"] = "Carrito de Compras";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""catalogue"" class=""catalogue section-bg"" style=""text-align: center;"">
      <div class=""container"">

        <div class=""section-title"">
          <h2 data-aos=""fade-in"">Carrito de Compras</h2>
          <p data-aos=""fade-in"">Los producto seleccionados apareceran aca</p>
        </div>


    <div class=""row catalogue-container"" data-aos=""fade-up"">

    <table class=""table table-hover"">
    <thead class=""tables"">
        <tr>
                <th scope=""col"">
                    ");
#nullable restore
#line 21 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
               Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 24 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
               Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
               Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 31 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
     foreach (var item in Model)
	{
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
         if (item.Email == @User.Identity.Name)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
           Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\jhon\Documents\2022\Proyecto_Equipo_Verde\TiendaRopa\Views\Orden\Carrito.cshtml"
         
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>    \r\n</table>\r\n           \r\n            </div>\r\n    </section>\r\n\r\n      <div class=\"get-started\" style=\"text-align: center;\">\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da19a2d0ef08a1a9d0ecb699be4fb67a1915b09c8273", async() => {
                WriteLiteral("Confirmar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
      </div>
      <br>

<footer id=""footer"">

    <div class=""footer-top"">

      <div class=""container"" data-aos=""fade-up"">

        <div class=""row  justify-content-center"">
          <div class=""col-lg-6"">
            <h3>Topitop</h3>
            <p>Dirección: Av La Molina, 305 Las gardenias </p>
            <p>Telefono: +51 996644587</p>
          </div>
        </div>

        

        <div class=""social-links"">
          <a href=""#"" class=""twitter""><i class=""bx bxl-twitter""></i></a>
          <a href=""#"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
          <a href=""#"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
          <a href=""#"" class=""google-plus""><i class=""bx bxl-skype""></i></a>
          <a href=""#"" class=""linkedin""><i class=""bx bxl-linkedin""></i></a>
 
    </div>

    <div class=""container footer-bottom clearfix"">
      <div class=""copyright"">
        &copy; Copyright <strong><span> Copyright</span></strong>. Todos los derechos reservador
 ");
            WriteLiteral("     </div>\r\n      <div class=\"credits\">\r\n        Diseñado por <a href=\"#\"> Topitop</a>\r\n      </div>\r\n    </div>\r\n  </footer>\t");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TiendaRopa.Models.OrdenDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
