#pragma checksum "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Category\UpdateCat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1220f6378d994ed8f54ce996d839863a0bf3dedc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_UpdateCat), @"mvc.1.0.view", @"/Views/Category/UpdateCat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/UpdateCat.cshtml", typeof(AspNetCore.Views_Category_UpdateCat))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1220f6378d994ed8f54ce996d839863a0bf3dedc", @"/Views/Category/UpdateCat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc416c721b0cf169e86691be7600b04fc3df7efa", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_UpdateCat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Category\UpdateCat.cshtml"
  
    Layout = "_LayoutAdmin";



#line default
#line hidden
            BeginContext(41, 108, true);
            WriteLiteral("\r\n<div class=\"HeaderMS\">\r\n    <h1 id=\"TitleAC\">Update Category</h1>\r\n</div>\r\n<div class=\"containerAS\">\r\n    ");
            EndContext();
            BeginContext(149, 1830, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a02dda65765410a8412e4e17642f0e1", async() => {
                BeginContext(167, 1805, true);
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
        <input type=""button"" class=""btn btn-primary"" value=""Soft Delete"" id=""SD"" />
        <input type=""button"" class=""btn btn-primary"" value=""Hard Delete"" id=""HD"" />
        <input type=""button"" class=""btn btn-primary"" value=""Save"" id=""saveButton"" />
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
            BeginContext(1979, 4047, true);
            WriteLiteral(@"
</div>

<script>
    console.log(""You're in scripts!"")

    const ID = getIdFromAddressBar();

    console.log(""Here's your ID ! "" + ID)

    loadCategoryData();

    function getIdFromAddressBar() {
        let urlArray = window.location.href.split('/');
        let id = urlArray[urlArray.length - 1];
        return id;
    }

    function loadCategoryData() {
        console.log(""You're in LoadCategory Data!"");

        $.ajax({
            method: 'GET',
            url: '/API/Category/GetOneCat/' + ID,
        }).done(function (data) {
            console.log(data)

            let category = data;
            let catName = category.catName;
            let startDate = category.startDate;
            let endDate = category.endDate;
            let visId = category.visibility;

            console.log(""Here's your name! "" + catName);
            console.log(""Here's your name! "" + startDate);

            $('#catName').val(catName);

            //Getting Date from dat");
            WriteLiteral(@"etime variables
            var sd = startDate;
            sd = sd.split('T')[0];
            var ed = endDate;
            ed = ed.split('T')[0];

            $('#SDAC').val(sd);
            $('#EDAC').val(ed);
            $(""input:radio[name='vis'][value="" + visId + ""]"").attr('checked', true);
        }).fail(function (data) {
            console.log(""You failed your ajax :D"")
            new noty({
                text: data.responsejson.message,
                type: 'error', layout: 'center',
            }).show();
        });//end of $ajax().done().fail();
    }


    function WebFormData(inCatName, inStartDate, inEndDate, inVisId) {
        this.catName = inCatName;
        this.startDate = inStartDate;
        this.endDate = inEndDate;
        this.visId = inVisId;
    }

    $('#saveButton').on('click', function () {
        let collectedCatName = $('#catName').val();
        let collectedStartDate = $('#SDAC').val();
        let collectedEndDate = $('#EDAC').val();
   ");
            WriteLiteral(@"     let collectedVisId = $(""input[name='vis']:checked"").val();

        let webFormData = new WebFormData(collectedCatName, collectedStartDate, collectedEndDate, collectedVisId);

        $.ajax({
            method: 'PUT',
            url: '/API/Category/UpdateCat/' + ID,
            dataType: 'json',
            contentType: 'application/x-www-form-urlencoded;',
            data: webFormData
        }).done(function (data) {
            new Noty({
                text: data.message,
                type: 'success',
                layout: 'center'
            }).show();
        }).fail(function (data) {
            new Noty({
                text: data.responseJSON.message,
                type: 'error',
                layout: 'center'
            }).show();
        });
    });

    //Soft Delete Category Record
    $('#SD').on('click', function () {
        $.ajax({
            method: 'PUT',
            url: '/API/Category/SoftDelete/' + ID,
        }).done(function (data) ");
            WriteLiteral(@"{
            new Noty({
                text: data.message,
                type: 'success',
                layout: 'center'
            }).show();
        }).fail(function (data) {
            new Noty({
                text: data.responseJSON.message,
                type: 'error',
                layout: 'center'
            }).show();
        });
    });


    //Hard Delete Category Record
    $('#HD').on('click', function () {
        $.ajax({
            method: 'DELETE',
            url: '/API/Category/HardDelete/' + ID,
        }).done(function (data) {
            new Noty({
                text: data.message,
                type: 'success',
                layout: 'center'
            }).show();
        }).fail(function (data) {
            new Noty({
                text: data.responseJSON.message,
                type: 'error',
                layout: 'center'
            }).show();
        });
    });
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
