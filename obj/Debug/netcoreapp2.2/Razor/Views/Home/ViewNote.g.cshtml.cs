#pragma checksum "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d2fd2b47f43a627e34837db8eed00217d21b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewNote), @"mvc.1.0.view", @"/Views/Home/ViewNote.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewNote.cshtml", typeof(AspNetCore.Views_Home_ViewNote))]
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
#line 1 "/Users/user/coding dojo/job/projects/Jot/Views/_ViewImports.cshtml"
using Jot;

#line default
#line hidden
#line 2 "/Users/user/coding dojo/job/projects/Jot/Views/_ViewImports.cshtml"
using Jot.Models;

#line default
#line hidden
#line 4 "/Users/user/coding dojo/job/projects/Jot/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d2fd2b47f43a627e34837db8eed00217d21b75", @"/Views/Home/ViewNote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b458213ce08824149f96002730252e4c670b8bd6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewNote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<allFoldersModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewFolder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-between each selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-between each"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 88, true);
            WriteLiteral("<div class=\"container\">\n\n<div class=\"row\">\n    <div class=\"folderList smallScreen col\">\n");
            EndContext();
#line 6 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
         foreach (var f in Model.allFolders)
        {
            

#line default
#line hidden
#line 8 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
             if(f.FolderId == HttpContextAccessor.HttpContext.Session.GetInt32("folderId"))
            {


#line default
#line hidden
            BeginContext(273, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(289, 415, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d2fd2b47f43a627e34837db8eed00217d21b755544", async() => {
                BeginContext(453, 51, true);
                WriteLiteral("\n                    <div>\n                        ");
                EndContext();
                BeginContext(505, 12, false);
#line 13 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                   Write(f.FolderName);

#line default
#line hidden
                EndContext();
                BeginContext(517, 103, true);
                WriteLiteral("\n                    </div>\n                    <div style=\"font-size: 15px \">\n                        ");
                EndContext();
                BeginContext(621, 13, false);
#line 16 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                   Write(f.Notes.Count);

#line default
#line hidden
                EndContext();
                BeginContext(634, 66, true);
                WriteLiteral(" \n                    </div>\n                    \n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-folderID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                                                                         WriteLiteral(f.FolderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["folderID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-folderID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["folderID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(704, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 20 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
            }
            else{


#line default
#line hidden
            BeginContext(738, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(754, 385, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28d2fd2b47f43a627e34837db8eed00217d21b759394", async() => {
                BeginContext(909, 51, true);
                WriteLiteral("\n                    <div>\n                        ");
                EndContext();
                BeginContext(961, 12, false);
#line 25 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                   Write(f.FolderName);

#line default
#line hidden
                EndContext();
                BeginContext(973, 103, true);
                WriteLiteral("\n                    </div>\n                    <div style=\"font-size: 15px \">\n                        ");
                EndContext();
                BeginContext(1077, 13, false);
#line 28 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                   Write(f.Notes.Count);

#line default
#line hidden
                EndContext();
                BeginContext(1090, 45, true);
                WriteLiteral(" \n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-folderID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                                                                         WriteLiteral(f.FolderId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["folderID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-folderID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["folderID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1139, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 31 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
            }

#line default
#line hidden
#line 31 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1164, 166, true);
            WriteLiteral("    </div>\n\n    <div class=\"noteList smallScreen col\">\n        <div class=\"row notes\">\n\n                <span class=\"col sm md lg noteCard\" >\n                    <h2>");
            EndContext();
            BeginContext(1331, 19, false);
#line 39 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                   Write(Model.note.NoteName);

#line default
#line hidden
            EndContext();
            BeginContext(1350, 29, true);
            WriteLiteral("</h2>\n                    <p>");
            EndContext();
            BeginContext(1380, 18, false);
#line 40 "/Users/user/coding dojo/job/projects/Jot/Views/Home/ViewNote.cshtml"
                  Write(Model.note.Details);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 70, true);
            WriteLiteral("</p>\n                </span>\n        </div>\n\n    </div>\n</div>\n\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<allFoldersModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
