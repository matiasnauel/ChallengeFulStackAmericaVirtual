#pragma checksum "C:\Users\ayala\source\repos\ClimateExam\ClimateExam\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ed60e6d1bdf35581994f341467bf27d52db397"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ayala\source\repos\ClimateExam\ClimateExam\Views\_ViewImports.cshtml"
using ClimateExam;

#line default
#line hidden
#line 2 "C:\Users\ayala\source\repos\ClimateExam\ClimateExam\Views\_ViewImports.cshtml"
using ClimateExam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ed60e6d1bdf35581994f341467bf27d52db397", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d503defd1acae9a37e6f811d6dbaab4b7d50a32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select-disable"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ayala\source\repos\ClimateExam\ClimateExam\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 482, true);
            WriteLiteral(@"
<main class=""container "">
    <div class="" section-title container-card mb-5"">

        <h1>SERVICIO DEL CLIMA</h1>
        <hr class=""line"">

    </div>
    <section class=""select-weather-location "">
        <div class=""row  "">
            <div class=""col-12 col-sm-6 col-md-6 col-lg-6 mt-2"">
                <div class=""card p-4 text-center shadow-sm "">
                    <h3>Seleccioná la zona</h3>
                    <hr class=""line-card"">
                    ");
            EndContext();
            BeginContext(527, 837, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83c6f89c5e1b4b9fa36812097a2ec4c1", async() => {
                BeginContext(533, 257, true);
                WriteLiteral(@"
                        <div class=""form-group mt-1"">
                            <label class=""form-inline"">País</label>
                            <select class=""form-control"" id=""exampleFormControlSelect1"" disabled>
                                ");
                EndContext();
                BeginContext(790, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6f403fe9887427f9d073097d2a4bbeb", async() => {
                    BeginContext(832, 18, true);
                    WriteLiteral("Seleccioná un pais");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(859, 332, true);
                WriteLiteral(@"

                            </select>
                        </div>
                        <div class=""form-group mt-1"">
                            <label class=""form-inline"">Ciudad</label>
                            <select class=""form-control"" id=""exampleFormControlSelect2"" disabled>
                                ");
                EndContext();
                BeginContext(1191, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48ec94318e2d436f8fb1a6c824dea451", async() => {
                    BeginContext(1232, 21, true);
                    WriteLiteral("Seleccioná una ciudad");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1262, 95, true);
                WriteLiteral("\r\n\r\n                            </select>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1364, 2761, true);
            WriteLiteral(@"
                    <button class=""btn btn-block btn-modif-search mt-5 mb-3"" id=""Search""  type=""submit"" ><span class=""btn-title-search"">BUSCAR</span> </button>
                </div>
            </div>
            <div class=""col-12  col-sm-6 col-md-6 col-lg-6 mt-2 "">
                <div class=""card p-4 shadow-sm "">
                    <div class=""text-center"">
                        <h3>Reporte</h3>
                        <hr class=""line-card"">
                    </div>


                    <div class=""row"">
                        <div class=""col-6 col-sm-12 col-md-6 col-lg-6"">
                            <div class=""col-lg-12"">
                                <label class=""country"" id=""country""></label>
                            </div>
                            <div class=""col-lg-12"">
                                <label class=""province"" id=""province""></label>
                            </div>
                            <div class=""col-lg-12"">
                            ");
            WriteLiteral(@"    <label class=""feature-title"" id=""day""></label>
                            </div>
                            <div class=""col-lg-12"">
                                <label class=""feature-title"" id=""sky"" translate=""yes""></label>
                            </div>
                            <div class=""col-lg-12"">
                                <div class=""d-flex flex-column"">
                                    <span class=""temperature""> <span id=""temperature""></span> <span class=""temperature-celsius"">°C</span> </span>
                                    <span class=""Fahrenheit""> <span id=""Fahrenheit""></span>°F</span>
                                </div>

                            </div>
                         
                           
                           

                        </div>
                        <div class="" col-6 col-sm-12 col-md-6 col-lg-6"">
                            <img src=""/images/dom.svg"" class=""sun-icons"" id=""imag-main"">
                      ");
            WriteLiteral(@"      <div class=""text-right"">
                                <p>Prob. de precipitaciones: <span>0</span>%</p>
                                <p>Humedad: <span id=""humidity"" >54</span>%</p>
                                <p>Viento: a <span id=""wind"">10</span>km/h.</p>
                            </div>

                        </div>
                    </div>

                </div>
            </div>

        </div>
    </section>
    <section class=""list-weather mt-4  "">
        <div class=""jumbotron bg-white shadow-sm d-flex justify-content-between "">
            <div class=""row  ml-auto mr-auto "" id=""listCard"">

            </div>
        </div>
    </section>


</main>

");
            EndContext();
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