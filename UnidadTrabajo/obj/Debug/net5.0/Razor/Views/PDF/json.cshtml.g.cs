#pragma checksum "/Users/infwilliam/Documents/repos/netcore/UnytofWork/UnidadTrabajo/Views/PDF/json.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b02b8f6226c3afcc0f25bc0dbe27afb0661a5b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PDF_json), @"mvc.1.0.view", @"/Views/PDF/json.cshtml")]
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
#line 1 "/Users/infwilliam/Documents/repos/netcore/UnytofWork/UnidadTrabajo/Views/_ViewImports.cshtml"
using UnidadTrabajo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/infwilliam/Documents/repos/netcore/UnytofWork/UnidadTrabajo/Views/_ViewImports.cshtml"
using UnidadTrabajo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02b8f6226c3afcc0f25bc0dbe27afb0661a5b37", @"/Views/PDF/json.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbd5cdb2e10daa0ea50125206b7a5c0bf0e8757b", @"/Views/_ViewImports.cshtml")]
    public class Views_PDF_json : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<input onclick=""Obten()"" type=""button"" value=""Obtener"" />
 
    <div class=""card"">
        <div class=""card-header"">
            <div id=""cabecera"">

            </div>
            esta es una prueba
        </div>
            <div class=""card-body"">
                <div id=""MiDiv"">
                    <div id=""res"">                        
                        <table class=""table ttable-striped table-bordered table-secondary"">
                            <thead>
                                <tr>
                                    <th>Cantidad</th>
                                    <th>Articulo</th>
                                    <th>Descuento</th>
                                    <th>Precio</th>
                                    <th>Total</th>
                                </tr>
                            </thead>
                            <tbody id=""tabla"">

                            </tbody>
                        </table>                       
                    </div>
       ");
            WriteLiteral("         </div>\n            </div>\n        </div>\n    </div>\n\n<script>\n\n    function Obten() {\n        fetch(\"");
#nullable restore
#line 41 "/Users/infwilliam/Documents/repos/netcore/UnytofWork/UnidadTrabajo/Views/PDF/json.cshtml"
          Write(Url.Content("~/PDF/jsonFactura"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""")
            .then(function (res) {
                return res.json();
            })
            .then(function (mijson) {
                let detaller = document.querySelector('#cabecera')
                console.log(""Cabecera"");
                console.log(mijson.facSer);
                console.log(mijson.facNum);
                console.log(mijson.fechAlt);
                console.log(mijson.facHoraAlt);
                console.log(mijson.facANit);
                console.log(mijson.facANomDe);
                console.log(mijson.facDirRent);
                console.log(""nivel detalle"");

                var prueba = mijson.facNum;
                detaller.innerHTML = `<p> ${prueba}</p>`;
                detaller.innerHTML = `<p> ${mijson.facANomDe}</p>`;
                console.log(""un ciclo for"");
                let Resultado = document.querySelector('#tabla');

                var total;
                //Resultado.innerHTML += `<p> ${console.log(mijson.facDirRent)}</p>`;
                //Resultado");
            WriteLiteral(@" = '';
                var resul ;

                for (let i = 0; i < mijson.detalle.length; i++)
                {
                    console.log(mijson.detalle[i].facCanFac + "" "" + mijson.detalle[i].artCod + "" "" + mijson.detalle[i].facDes + "" "" + mijson.detalle[i].facPreFac )
                    Resultado.innerHTML += `
                    <tr> 
                        <td>${mijson.detalle[i].facCanFac}</td>
                        <td>${mijson.detalle[i].artCod}</td>
                        <td>${mijson.detalle[i].facDes}</td>
                        <td>${mijson.detalle[i].facPreFac}</td>
                        <td> ${resul = (parseInt(mijson.detalle[i].facCanFac)) * (parseInt(mijson.detalle[i].facPreFac))} </td>
                    </tr>
                    `;
                }
                //console.log(miResultado)
                //document.getElementById(""#res"").innerHTML = Resultado;
            })
    }
</script>
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
