#pragma checksum "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Category\AddCat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e154dbdfa1f67b5d0bbadbcb6b663c171526a29a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_AddCat), @"mvc.1.0.view", @"/Views/Category/AddCat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/AddCat.cshtml", typeof(AspNetCore.Views_Category_AddCat))]
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
#line 1 "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\_ViewImports.cshtml"
using WebAAssign;

#line default
#line hidden
#line 2 "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\_ViewImports.cshtml"
using WebAAssign.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e154dbdfa1f67b5d0bbadbcb6b663c171526a29a", @"/Views/Category/AddCat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc416c721b0cf169e86691be7600b04fc3df7efa", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_AddCat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAC"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Category\AddCat.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(37, 105, true);
            WriteLiteral("\r\n<div class=\"HeaderMS\">\r\n    <h1 id=\"TitleAC\">Add Category</h1>\r\n</div>\r\n<div class=\"containerAS\">\r\n    ");
            EndContext();
            BeginContext(142, 1659, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73036f11500b40e79d18b33d2ec79f42", async() => {
                BeginContext(160, 1634, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-25"">
                <label for=""catName"">Name</label>
            </div>
            <div class=""col-100"">
                <input type=""text"" id=""catName"" name=""catname"" placeholder=""Category name.."">
            </div>
        </div>

        <div class=""row"" id=""visbilityAC"">
            <div class=""col-25"">
                <input class=""radioInputAC"" type=""radio"" id=""visID"" name=""vis"" value=""1"">
            </div>
            <label for=""visID"">Visible (Ignore start and end date)</label><br>

            <div class=""col-25"">
                <input class=""radioInputAC"" type=""radio"" id=""visID2"" name=""vis"" value=""2"">
            </div>
            <label for=""visID2"">Visible (With start and end date)</label><br>

            <div class=""col-25"">
                <input class=""radioInputAC"" type=""radio"" id=""visID3"" name=""vis"" value=""3"">
            </div>
            <label for=""visID3"">Hidden</label><br><br>
        </div>

    ");
                WriteLiteral(@"    <div class=""row"">
            <div class=""col-25"">
                <label for=""SDAC"">Start Date</label>
            </div>
            <div class=""col-75"">
                <input type=""date"" id=""SDAC"" class=""dateAC"" name=""startDateAC"">
            </div>
            <div class=""col-25"">
                <label for=""EDAC"">End Date</label>
            </div>
            <div class=""col-75"">
                <input type=""date"" id=""EDAC"" class=""dateAC"" name=""endDateAC"">
            </div>
        </div>
        <input type=""button"" onclick=""myFunction()"" value=""Save"" id=""saveButton"" />
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1801, 1760, true);
            WriteLiteral(@"
</div>

<script>
    console.log(""You're in scripts!"")


    function myFunction() {
        console.log(""You've clicked submit !"");

        let collectedCatName = $('#catName').val();
        let collectedStartDate = $('#SDAC').val();
        let collectedEndDate = $('#EDAC').val();
        let collectedVisId = $(""input[name='vis']:checked"").val();

        function WebFormData(inCatName, inStartDate, inEndDate, inVisId) {
            this.catName = inCatName;
            this.startDate = inStartDate;
            this.endDate = inEndDate;
            this.visId = inVisId;
        }

        console.log(""Collected Data: "" + collectedCatName + "" "" + collectedEndDate + "" "" + collectedStartDate + "" "" + collectedVisId);
        //Create a JavaScript object from the collected data
        //Create an ""object of information"" which consists of name-value pairs
        let webFormData = new WebFormData(collectedCatName, collectedStartDate,
            collectedEndDate, collectedVisId);

");
            WriteLiteral(@"        $.ajax({
            method: 'post',
            url: '/api/Category/AddCat',
            datatype: 'json',
            contenttype: 'application/x-www-form-urlencoded',
            data: webFormData
        }).done(function (data) {
            new Noty({
                text: data.message, layout: 'center',
                type: 'success',
            }).show();
            }).fail(function (data) {
                console.log(data);
            new Noty({
                text: data.responseJSON.message,
                type: 'error', layout: 'center',
            }).show();
        });//end of $ajax().done().fail();
    };//end of the annonymous function for the saveButton click handler.
</script>");
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
