#pragma checksum "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Product\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbc03b4b5ddfb64c688aed675d782a8f8669de32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddProduct), @"mvc.1.0.view", @"/Views/Product/AddProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/AddProduct.cshtml", typeof(AspNetCore.Views_Product_AddProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbc03b4b5ddfb64c688aed675d782a8f8669de32", @"/Views/Product/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc416c721b0cf169e86691be7600b04fc3df7efa", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "kg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "g", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "lbs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "L", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("productForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-100 m-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Product\AddProduct.cshtml"
  
    Layout = "_LayoutProduct";

#line default
#line hidden
            BeginContext(39, 2254, true);
            WriteLiteral(@"
<div class=""w-75 m-5"">
    <div class=""row"">
        <div class=""h1"">Add Brand</div>
    </div>

    <div class=""row"">
        <div class=""form-group w-100"">
            <div class=""col-md-12"">
                <div class=""text-center"">
                    <div class="""">
                        <div class=""btn-group btn-group-lg bg-dark-3EB"" data-toggle=""buttons"">
                            <label class=""btn btn-secondary active "">
                                <input type=""checkbox"" data-toggle=""collapse"" data-target=""#descInput"" name=""optInputs"" id=""rb1""> Description
                            </label>
                            <label class=""btn btn-secondary"">
                                <input type=""checkbox"" data-toggle=""collapse"" data-target=""#ingInput"" name=""optInputs"" id=""rb2""> Ingredients
                            </label>
                            <label class=""btn btn-secondary"">
                                <input type=""checkbox"" data-toggle=""collapse"" data-targ");
            WriteLiteral(@"et=""#pubInput"" name=""optInputs"" id=""rb3""> Published
                            </label>
                            <label class=""btn btn-secondary"">
                                <input type=""checkbox"" data-toggle=""collapse"" data-target=""#qtyInput"" name=""optInputs"" id=""rb3""> Quantity
                            </label>
                            <label class=""btn btn-secondary"">
                                <input type=""checkbox"" data-toggle=""collapse"" data-target=""#GAInput"" name=""optInputs"" id=""rb3""> Guaranteed Analysis
                            </label>
                            <label class=""btn btn-secondary"">
                                <input type=""checkbox"" data-toggle=""collapse"" data-target=""#priceInput"" name=""optInputs"" id=""rb3""> Price
                            </label>
                            <label class=""btn btn-secondary"">
                                <input type=""checkbox"" data-toggle=""collapse"" data-target=""#discountInput"" name=""optInputs"" id=""rb3""> Discoun");
            WriteLiteral("t\r\n                            </label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(2293, 8440, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f7b4a8e96bb48ba97f250c3eb250ab3", async() => {
                BeginContext(2334, 1985, true);
                WriteLiteral(@"
            <div class=""card card-body"">
                <div class=""row"">
                    <div class=""col"">
                        <div class=""form-group w-75"">
                            <label for=""brandId"">Brand</label>
                            <select class=""form-control"" id=""brandId""></select>
                        </div>
                    </div>
                    <div class=""col"" id=""nameInput"">
                        <div class=""form-group w-75 "">
                            <label for=""productName"">Product Name</label>
                            <input type=""text"" id=""productName"" class=""form-control"" name=""productName"" />
                            <div class=""invalid-feedback""></div>
                        </div>
                    </div>

                    <div class=""col"">
                        <div class=""form-group w-75 "">
                            <label for=""productCode"">Product Code</label>
                            <input type=""text"" id=""prod");
                WriteLiteral(@"uctCode"" class=""form-control"" name=""productCode"" />
                            <div class=""invalid-feedback""></div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col collapse"" id=""priceInput"">
                        <div class=""form-group w-75 "">
                            <label for=""productWA"">Weight Amount</label>
                            <input type=""text"" id=""productWA"" class=""form-control"" name=""productWA"" />
                            <div class=""invalid-feedback""></div>
                        </div>
                    </div>
                    <div class=""col collapse"" id=""priceInput"">
                        <div class=""form-group w-75"">
                            <label for=""productWU"">Weight Unit</label>
                            <select class=""form-control"" id=""productWU"">
                                ");
                EndContext();
                BeginContext(4319, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1601ef1e51b9407cbffe0f3608280142", async() => {
                    BeginContext(4336, 2, true);
                    WriteLiteral("kg");
                    EndContext();
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
                EndContext();
                BeginContext(4347, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4381, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f9c434aea4749a29dc549fb5fad0c2b", async() => {
                    BeginContext(4397, 1, true);
                    WriteLiteral("g");
                    EndContext();
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
                EndContext();
                BeginContext(4407, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4441, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de728550c9e240ad95408c725ffaee5f", async() => {
                    BeginContext(4459, 3, true);
                    WriteLiteral("lbs");
                    EndContext();
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
                EndContext();
                BeginContext(4471, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4505, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d52accfb7f9421681076e41cb8d66f3", async() => {
                    BeginContext(4521, 1, true);
                    WriteLiteral("L");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4531, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(4565, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77b61503d70f414f8a5749e552a593d2", async() => {
                    BeginContext(4582, 2, true);
                    WriteLiteral("ml");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4593, 527, true);
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <div class=""col collapse"" id=""priceInput"">
                        <div class=""form-group w-75 "">
                            <label for=""productPrice"">Price</label>
                            <input type=""text"" id=""productPrice"" class=""form-control "" name=""productPrice"" />
                            <div class=""invalid-feedback""></div>
                        </div>
                    </div>
");
                EndContext();
                BeginContext(5342, 354, true);
                WriteLiteral(@"                </div>

                <div class=""row"">
                    <div class=""col collapse"" id=""pubInput"">
                        <div class=""form-group w-75"">
                            <label for=""published"">Published</label>
                            <select class=""form-control"" id=""published"">
                                ");
                EndContext();
                BeginContext(5696, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df3ede34982e46c7b33de7200bfb06c0", async() => {
                    BeginContext(5712, 3, true);
                    WriteLiteral("Yes");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5724, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(5758, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47ef71b94a7e84f16f8661296748", async() => {
                    BeginContext(5774, 2, true);
                    WriteLiteral("No");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5785, 4941, true);
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>

                    <div class=""col collapse"" id=""qtyInput"">
                        <div class=""form-group w-100"">
                            <label for=""productMinQty"">Minimum Quantity</label>
                            <input type=""text"" class=""form-control"" id=""productMinQty"" name=""productMinQty"">
                            <div class=""invalid-feedback""> </div>
                        </div>
                    </div>

                    <div class=""col collapse"" id=""qtyInput"">
                        <div class=""form-group w-100"">
                            <label for=""productQty"">Quantity</label>
                            <input type=""text"" class=""form-control"" id=""productQty"" name=""productQty"">
                            <div class=""invalid-feedback""> </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
   ");
                WriteLiteral(@"                 <div class=""col"">
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text"" id=""inputGroupFileAddon01"">Upload</span>
                            </div>
                            <div class=""custom-file"">
                                <input type=""file"" class=""custom-file-input"" id=""inputGroupFile01""
                                       aria-describedby=""inputGroupFileAddon01"">
                                <label class=""custom-file-label"" for=""inputGroupFile01"">Choose picture</label>
                            </div>
                            <div class=""invalid-feedback""> </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col collapse"" id=""discountInput"">
                        <div class=""form-group w-75 "">
                            <label fo");
                WriteLiteral(@"r=""discountName"">Discount Name</label>
                            <input type=""text"" id=""discountName"" class=""form-control"" name=""discountName"" />
                            <div class=""invalid-feedback""></div>
                        </div>
                    </div>
                    <div class=""col collapse"" id=""discountInput"">
                        <div class=""form-group w-75 "">
                            <label for=""discountRate"">Discount Rate</label>
                            <input type=""text"" id=""discountRate"" class=""form-control"" name=""discountRate"" />
                            <div class=""invalid-feedback""></div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col collapse"" id=""descInput"">
                        <div class=""form-group w-100"">
                            <label for=""productDesc"">Description</label>
                            <textarea class=""form-control""");
                WriteLiteral(@" id=""productDesc"" name=""productDesc"" rows=""3""></textarea>
                            <div class=""invalid-feedback""> </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col collapse"" id=""ingInput"">
                        <div class=""form-group w-100"">
                            <label for=""productIng"">Ingredients</label>
                            <textarea class=""form-control"" id=""productIng"" name=""productIng"" rows=""3""></textarea>
                            <div class=""invalid-feedback""> </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col collapse"" id=""GAInput"">
                        <div class=""form-group w-100"">
                            <label for=""productGA"">Guaranteed Analysis</label>
                            <textarea class=""form-control"" id=""productGA"" name=""produc");
                WriteLiteral(@"tGA"" rows=""3""></textarea>
                            <div class=""invalid-feedback""> </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""card card-footer text-center bg-dark"">
                <div class=""row"">
                    <div class=""col"">
                        <button class=""btn btn-outline-primary w-50"" data-toggle=""collapse"" data-target=""#addModuleCollapse"" type=""button"">
                            Cancel
                        </button>
                    </div>
                    <div class=""col"">
                        <button class=""btn btn-primary w-50"" type=""submit"">
                            Submit
                        </button>
                    </div>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10733, 9721, true);
            WriteLiteral(@"
    </div>
</div>

<script>

    //Setting default validate message
    jQuery.validator.setDefaults({
        errorElement: 'div',
        errorClass: 'is-invalid'
    });


    //Upload file

    //jQuery('#saveButton').on('click', function () {
    //    /*
    //     The following code was prepared in a very fast and furious manner.
    //     Which means, I quickily ""scanned"" articles at https://forum.jquery.com/topic/upload-a-file-using-jquery-ajax-function
    //     to find out how others use JavaScript to ""programatically"" submit the data
    //     by using FormData class.
    //      */
    //    let collectedDescription = $('#descriptionInput').jqxEditor('val');//Don't use .val(), it will add unusual ? character in front of your text.
    //    var fileToUpload = new FormData();
    //    fileToUpload.append('fileInput', $('#fileInput')[0].files[0]);
    //    fileToUpload.append('description', collectedDescription);
    //    $.ajax({
    //        url: '/API/LogManage");
            WriteLiteral(@"r/SaveFiles',
    //        data: fileToUpload,
    //        processData: false,
    //        contentType: false,
    //        type: 'POST'

    //    }).done(function (data) {
    //        console.dir(data);
    //        new Noty({ text: data.message, type: 'success', layout: 'center' }).show();
    //        let record = data.record;
    //        let $tableBodyRecordElement = $('#tableBodyRecord');
    //        $tableBodyRecordElement.empty();//Clear the child elements in the tbody
    //        $tableBodyRecordElement.append($('<tr><td>id</td><td>' + record.id + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>studentId</td><td>' + record.studentId + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>createdAt</td><td>' + record.createdAt + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td> description</td><td>' + record.description + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>fileExtension</td");
            WriteLiteral(@"><td>' + record.fileExtension + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>fileName</td><td>' + record.fileName + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>format</td><td>' + record.format + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>height</td><td>' + record.height + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>width</td><td>' + record.width + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>imageSize</td><td>' + record.imageSize + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>version</td><td>' + record.version + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>publicCloudinaryId</td><td>' + record.publicCloudinaryId + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>resourceType</td><td>' + record.resourceType + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>secureUrl</td><td>");
            WriteLiteral(@"' + record.secureUrl + '</td><tr>'));
    //        $tableBodyRecordElement.append($('<tr><td>url</td><td>' + record.url + '</td><tr>'));


    //    }).fail(function (data) {
    //        if (data.responseJSON) {
    //            new Noty({ text: data.responseJSON.message, type: 'error', layout: 'center' }).show();
    //        } else {
    //            new Noty({ text: 'Unable to save file.', type: 'error', layout: 'center' }).show();
    //        }
    //    })
    //}//end of anonymous function



    //// AJAX GET to output into brand Dropdown
    $.ajax({
        url: '/API/Brand/GetAllBrand',
        method: 'GET'

    }).done(function (data) {
        let $tableBodyElement = $('#brandId');

        for (let index = 0; index < data.length; index++) {
            let $rowElement = null;

            //Update
            var brandName = data[index].brandName;
            var brandId = data[index].brandId;
            console.log(brandName + "" "" + brandId);
            $");
            WriteLiteral(@"rowElement = $('<option value=' + brandId + '>' + brandName + '</option>');
            $tableBodyElement.append($rowElement);
        }
    }).fail(function (data) {
        console.dir(""HELLO"" + data);
        new Noty({
            text: data.responseJSON.message, type: 'error',
            layout: 'center',
            timeout: 2500
        }).show();
    })

    //Validate Form
    //Validation
    $('#productForm').validate({
        rules: {
            productName: {
                required: true
            },
            productCode: {
                required: true
            }
        },
        messages: {
            productName: {
                required: ""Please enter a name""
            },
            productCode: {
                required: ""Please enter a code""
            }
        },
        errorPlacement: function (error, element) {
            if (element.is(':radio')) {
                error.appendTo(element.parent().parent().next('div'))
         ");
            WriteLiteral(@"   } else {
                error.appendTo(element.next('div'));
            }
        },
        submitHandler: function () {
            console.log(""You've clicked submit !"");

            //Required Fields
            let collectedBrand = $('#brandId').val();
            let collectedProdName = $('#productName').val();
            let collectedProdCode = $('#productCode').val();

            //Optional Fields
            let collectedProductDesc = $('#productDesc').val();
            let collectedProdIng = $('#productIng').val();
            let collectedPublished = $('#published').val();
            let collectedProductMinQty = $('#productMinQty').val();
            let collectedProductQty = $('#productQty').val();
            let collectedProductGA = $('#productGA').val();

            //Array of Price Arrays
            let collectedProductWA = $('#productWA').val();
            let collectedProductWU = $('#productWU').val();
            let collectedProductPrice = $('#productPri");
            WriteLiteral(@"ce').val();
            var collectedPrice = [collectedProductWA, collectedProductWU, collectedProductPrice];
            var collectedPriceArray = [collectedPrice];

            //Array of Discount Arrays
            let collectedDiscountName = $('#discountName').val();
            let collectedDiscountRate = $('#discountRate').val();
            var collectedDiscount = [collectedDiscountName, collectedDiscountRate];
            var collectedDiscountArray = [collectedDiscount];

            //function WebFormData(inBrand, inProdName, inProdCode, inProdDesc, inProdIng, inPublished, inProductMinQty, inProductQty, inProductGA, inPrice, inDiscount) {
            //    this.brandId = inBrand;
            //    this.prodName = inProdName;
            //    this.prodCode = inProdCode;
            //    this.prodDesc = inProdDesc;
            //    this.prodIng = inProdIng;
            //    this.published = inPublished;
            //    this.minQty = inProductMinQty;
            //    this.prodQt");
            WriteLiteral(@"y = inProductQty;
            //    this.GA = inProductGA;
            //    this.price = inPrice;
            //    this.discount = inDiscount;
            //}

            var formData = new FormData();
            formData.append('fileInput', $('#inputGroupFile01')[0].files[0]);
            formData.append('brandId', collectedBrand);
            formData.append('prodName', collectedProdName);
            formData.append('prodCode', collectedProdCode);
            formData.append('prodDesc', collectedProductDesc);
            formData.append('prodIng', collectedProdIng);
            formData.append('published', collectedPublished);
            formData.append('minQty', collectedProductMinQty);
            formData.append('prodQty', collectedProductQty);
            formData.append('GA', collectedProductGA);
            formData.append('price', collectedPriceArray);
            formData.append('discount', collectedDiscountArray);

            console.log(""Collected Data: "" + collectedBran");
            WriteLiteral(@"d + "" "" + collectedProdName + "" "" + collectedProdCode + "" "" + collectedProductDesc
                + "" "" + collectedProdIng + "" "" + collectedPublished + "" "" + collectedProductMinQty + "" "" + collectedProductQty + "" "" + collectedPriceArray
                + "" "" + collectedDiscountArray);
            //let webFormData = new WebFormData(collectedBrand, collectedProdName, collectedProdCode, collectedProductDesc, collectedProdIng, collectedPublished,
            //    collectedProductMinQty, collectedProductQty, collectedProductGA, collectedPriceArray, collectedDiscountArray);
            

            $.ajax({
                method: 'post',
                url: '/API/Product/AddProduct',
                data: formData,
                contentType: false,
                processData: false,
                traditional: true,
            }).done(function (data) {
                new Noty({
                    text: data.message, layout: 'center',
                    type: 'success',
              ");
            WriteLiteral(@"      callbacks: {
                        onClose: function () { window.location.href = ""/Product/ProductList"" }
                    }
                }).show();
            }).fail(function (data) {
                console.log(data);
                new Noty({
                    text: data.responseJSON.message,
                    type: 'error',
                    layout: 'center'
                }).show();
            });//end of $ajax().done().fail();
        }
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
