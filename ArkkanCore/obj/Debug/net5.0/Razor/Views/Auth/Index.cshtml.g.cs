#pragma checksum "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32016681918ddf9bb0e215bd50c17509b0d67359"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
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
#line 1 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\_ViewImports.cshtml"
using ArkkanCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\_ViewImports.cshtml"
using ArkanCore.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32016681918ddf9bb0e215bd50c17509b0d67359", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13ed2a44de2ea8263a7e270fa638be36705fd84", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmLogin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
  
    Layout = "auth/_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("topRight", async() => {
                WriteLiteral("\r\n    <a href=\"page_register.html\" class=\"btn-link text-white ml-auto\">\r\n        ");
#nullable restore
#line 9 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("CreateAccount"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </a>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col col-md-6 col-lg-7 hidden-sm-down\">\r\n");
            WriteLiteral("        <h2 class=\"fs-xxl fw-500 mt-4 text-white\">\r\n            ");
#nullable restore
#line 19 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("AlArkkanTrainingCenter"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <small class=\"h4 fw-300 mt-3 mb-5 text-white opacity-60\">\r\n                ");
#nullable restore
#line 21 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
            Write(Html.Raw(SharedLocalizer.GetLocalizedHtmlString("AboutAlArkkan")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </small>\r\n        </h2>\r\n        <a href=\"http://alarkkan.net/\" target=\"_blank\" class=\"fs-lg fw-500 text-white opacity-70\">");
#nullable restore
#line 24 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                                                                             Write(SharedLocalizer.GetLocalizedHtmlString("LearnMore"));

#line default
#line hidden
#nullable disable
            WriteLiteral("&gt;&gt;</a>\r\n        <div class=\"d-sm-flex flex-column align-items-center justify-content-center d-md-block\">\r\n            <div class=\"px-0 py-1 mt-5 text-white fs-nano opacity-50\">\r\n                ");
#nullable restore
#line 27 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
           Write(SharedLocalizer.GetLocalizedHtmlString("Find_us_on_social_media"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""d-flex flex-row opacity-70"">
                <a href=""#"" class=""mr-2 fs-xxl text-white"">
                    <i class=""fab fa-facebook-square""></i>
                </a>
                <a href=""#"" class=""mr-2 fs-xxl text-white"">
                    <i class=""fab fa-twitter-square""></i>
                </a>
                <a href=""#"" class=""mr-2 fs-xxl text-white"">
                    <i class=""fab fa-google-plus-square""></i>
                </a>
                <a href=""#"" class=""mr-2 fs-xxl text-white"">
                    <i class=""fab fa-linkedin""></i>
                </a>
            </div>
        </div>
    </div>
    <div class=""col-sm-12 col-md-6 col-lg-5 col-xl-4 ml-auto"">

        <h1 class=""text-white fw-300 mb-3 d-sm-block d-md-none"">
            ");
#nullable restore
#line 48 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("UserLogin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n        <div class=\"card p-4 rounded-plus bg-faded\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32016681918ddf9bb0e215bd50c17509b0d673598609", async() => {
                WriteLiteral(@"
                <div class=""text-center"">
                    <img src=""http://alarkkan.net/img/logo.png"" style=""height:120px"" />
                </div>
                <div class=""form-group"">
                    <label class=""form-label"" for=""username"">");
#nullable restore
#line 56 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                                        Write(SharedLocalizer.GetLocalizedHtmlString("Branch"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <select id=\"branch\" name=\"branch\" class=\"form-control form-control-lg\" required>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32016681918ddf9bb0e215bd50c17509b0d673599619", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32016681918ddf9bb0e215bd50c17509b0d6735910933", async() => {
#nullable restore
#line 59 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Jeddah"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32016681918ddf9bb0e215bd50c17509b0d6735912418", async() => {
#nullable restore
#line 60 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Dammam"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32016681918ddf9bb0e215bd50c17509b0d6735913903", async() => {
#nullable restore
#line 61 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                     Write(SharedLocalizer.GetLocalizedHtmlString("Madina"));

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n\r\n\r\n                <div class=\"form-group\">\r\n                    <label class=\"form-label\" for=\"username\">");
#nullable restore
#line 67 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                                        Write(SharedLocalizer.GetLocalizedHtmlString("Username"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <input type=\"text\" id=\"username\" name=\"username\" class=\"form-control form-control-lg\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3329, "\"", 3343, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3344, "\"", 3352, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"form-label\" for=\"password\">");
#nullable restore
#line 71 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                                        Write(SharedLocalizer.GetLocalizedHtmlString("Password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    <input type=\"password\" id=\"password\" name=\"password\" class=\"form-control form-control-lg\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3662, "\"", 3676, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3677, "\"", 3685, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\r\n                </div>\r\n\r\n                <div class=\"row \">\r\n                    <div class=\"col-lg-12 pr-lg-1 my-2\">\r\n                        <button type=\"submit\" class=\"btn btn-primary btn-block btn-lg\">");
#nullable restore
#line 77 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                                                                  Write(SharedLocalizer.GetLocalizedHtmlString("SignIn"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                    </div>\r\n");
                WriteLiteral("                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#frmLogin').submit(function (e) {
            e.preventDefault();

            var frmData = $('#frmLogin').serialize();
            $.ajax({
                url: '/auth/verify',
                type: 'POST',
                data: frmData,
                success: function (response) {
                    var status = response.status;
                    if (status == true) {
                        //showMsg('Login Successfully', 'You have successfully logged into the Lebaitak admin panel !', 'success');
                        //setTimeout(() => {
                            window.location = '");
#nullable restore
#line 128 "D:\Drive_E_Workspace\Workspace\AlArkan\ArkanCore\ArkkanCore\ArkkanCore\ArkkanCore\Views\Auth\Index.cshtml"
                                          Write(Url.Content("~"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/home';
                        //}, 1500);
                    } else {
                        /*showMsg('Login Failed', 'The email or password you entered is incorrect.','error');*/
                        alert('Login Failed!');
                    }
                }
            })
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ArkanCore.MVC.Resources.LocService SharedLocalizer { get; private set; }
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
