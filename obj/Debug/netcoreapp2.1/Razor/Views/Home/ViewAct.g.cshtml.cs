#pragma checksum "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f7e241fa5493ead4d464e5a57a8cb3fb5235acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewAct), @"mvc.1.0.view", @"/Views/Home/ViewAct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewAct.cshtml", typeof(AspNetCore.Views_Home_ViewAct))]
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
#line 1 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\_ViewImports.cshtml"
using exam;

#line default
#line hidden
#line 2 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\_ViewImports.cshtml"
using exam.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f7e241fa5493ead4d464e5a57a8cb3fb5235acf", @"/Views/Home/ViewAct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecb2a55d59d82a6188c718c6158103bf5dc00b82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewAct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 142, true);
            WriteLiteral("<p ALIGN=RIGHT><a href=\"/dashboard\">\r\n   <button>Dashboard</button> </a>\r\n  <a href=\"../logout\">\r\n   <button>Logout</button> </p> </a>\r\n\r\n<h1>");
            EndContext();
            BeginContext(143, 20, false);
#line 6 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
Write(ViewBag.Activity.Act);

#line default
#line hidden
            EndContext();
            BeginContext(163, 32, true);
            WriteLiteral("</h1>\r\n\r\n   Event Coordinator:  ");
            EndContext();
            BeginContext(196, 25, false);
#line 8 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
                  Write(ViewBag.theUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(221, 38, true);
            WriteLiteral(" <br><br>\r\n\r\n   <h2>Description:</h2> ");
            EndContext();
            BeginContext(260, 28, false);
#line 10 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
                    Write(ViewBag.Activity.Description);

#line default
#line hidden
            EndContext();
            BeginContext(288, 37, true);
            WriteLiteral("</h2>\r\n\r\n   <h2>Partcipants:</h2>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
    foreach (var x in @ViewBag.People.ActRSVP)   
{

#line default
#line hidden
            BeginContext(379, 18, true);
            WriteLiteral("    <li>\r\n        ");
            EndContext();
            BeginContext(398, 20, false);
#line 17 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
   Write(x.RSVPUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(418, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(420, 19, false);
#line 17 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
                         Write(x.RSVPUser.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(439, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 19 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
} 

#line default
#line hidden
            BeginContext(456, 7, true);
            WriteLiteral("</ul>\r\n");
            EndContext();
#line 21 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
  
    bool temp = false;
    foreach(var something in @ViewBag.People.ActRSVP)
        {   
            if ( @ViewBag.User == @something.RSVPUser.UserId)
            {
             temp = true;
            }
        }
        if (temp ==false)
        {

#line default
#line hidden
            BeginContext(729, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(741, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a1f1a62747f4ebabeeee717b59bb444", async() => {
                BeginContext(805, 107, true);
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"btn btn-primary\">Join</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 755, "/RSVP/", 755, 6, true);
#line 32 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
AddHtmlAttributeValue("", 761, ViewBag.Activity.ActivityId, 761, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(919, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(957, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(969, 189, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3261963f8f547b3801fbccbc64f7ca0", async() => {
                BeginContext(1035, 116, true);
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-primary\">Leave</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 983, "/unRSVP/", 983, 8, true);
#line 38 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
AddHtmlAttributeValue("", 991, ViewBag.Activity.ActivityId, 991, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1158, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 41 "C:\Users\rober\Desktop\Code Dojo\CSharp\exam\Views\Home\ViewAct.cshtml"
        }

#line default
#line hidden
            BeginContext(1174, 38, true);
            WriteLiteral("\r\n\r\n             \r\n        \r\n     \r\n\r\n");
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
