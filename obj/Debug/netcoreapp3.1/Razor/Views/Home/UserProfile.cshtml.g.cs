#pragma checksum "/Users/cassandraholmes/Desktop/MyGram 11-41-07-650/Views/Home/UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6f0403ba3e046ebf45c2390350b9ab25b9fad4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserProfile), @"mvc.1.0.view", @"/Views/Home/UserProfile.cshtml")]
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
#line 1 "/Users/cassandraholmes/Desktop/MyGram 11-41-07-650/Views/_ViewImports.cshtml"
using MyGram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cassandraholmes/Desktop/MyGram 11-41-07-650/Views/_ViewImports.cshtml"
using MyGram.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6f0403ba3e046ebf45c2390350b9ab25b9fad4d", @"/Views/Home/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03436bc665f1d74e611f06357016a07baccd8dbd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6f0403ba3e046ebf45c2390350b9ab25b9fad4d3263", async() => {
                WriteLiteral(@"
    <fieldset>
        <legend>User Personal Information</legend>
        <table>
            <tbody>
                <tr>
                    <td>
                        <label for=""FirstName"">First Name:</label>
                    </td>
                    <td>
                        <input type=""text"" id=""FirstName""/>
                    </td>
                    <td>
                        <label for=""LastName"">Last Name:</label>
                    </td>
                    <td>
                        <input type=""text"" id=""LastName"" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Gender:</label>
                    </td>
                    <td colspan=""3"">
                        <input type=""radio"" id=""MaleGender"" name=""gender"" />
                        <label for=""MaleGender"">Male</label>

                        <input type=""radio"" id=""FemaleGender"" name=""gender"" />
                        <label for=""FemaleGender");
                WriteLiteral(@""">Female</label>

                        <input type=""radio"" id=""NoResponseGender"" name=""gender"" />
                        <label for=""NoResponseGender"">Prefer not to respond</label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Choose favorite color</label>
                    </td>
                    <td>
                        <input type=""color"" id=""Favoritecolor""/>
                    </td>
                    <td>
                        <label for=""Birthday"">Birthday</label>
                    </td>
                    <td>
                        <input type=""date"" id=""Birthday""/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for=""EmailAdress"">Email Adress:</label>
                    </td>
                    <td>
                        <input type=""email"" id=""email"" placeholder=""Add your email here""/>
                    </td>
           ");
                WriteLiteral("     </tr>\n                <tr>\n                    <td colspan=\"3\">\n                        <label>Country of Residence:</label>\n                        <select>\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6f0403ba3e046ebf45c2390350b9ab25b9fad4d5887", async() => {
                    WriteLiteral("USA");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6f0403ba3e046ebf45c2390350b9ab25b9fad4d6910", async() => {
                    WriteLiteral("Other");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </select>
                    </td>
                </tr>
                <tr>
                    <td colspan=""1"">
                        <label for=""ProfilePicture"">Select Profile Picture:</label>
                    </td>
                    <td>
                        <input type=""file"" id=""ProfilePicture""/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <button>Update User Information</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </fieldset>
");
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
