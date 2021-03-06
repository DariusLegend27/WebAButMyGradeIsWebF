#pragma checksum "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35432c85a2973eb9b2f08c63132346dffa644b0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductList), @"mvc.1.0.view", @"/Views/Product/ProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductList.cshtml", typeof(AspNetCore.Views_Product_ProductList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35432c85a2973eb9b2f08c63132346dffa644b0e", @"/Views/Product/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc416c721b0cf169e86691be7600b04fc3df7efa", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\TheRealSEP\WebAButMyGradeIsWebF\WebAAssign\WebAAssign\Views\Product\ProductList.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
            BeginContext(37, 817, true);
            WriteLiteral(@"<div class=""HeaderMS"">
    <h1 id=""TitleAC"">Manage Product</h1>
</div>
<table class=""TableCL"">
    <colgroup>
        <col style=""width:5%"">
        <col style=""width:10%"">
        <col style=""width:5%"">
        <col style=""width:10%"">
        <col style=""width:10%"">
        <col style=""width:10%"">
        <col style=""width:10%"">
        <col style=""width:10%"">
        <col style=""width:10%"">
        <col style=""width:10%"">
    </colgroup>

    <tr class=""TableHeaderCL"">
        <th>ID</th>
        <th>Image</th>
        <th>Code</th>
        <th>Name</th>
        <th>Created At</th>
        <th>Created By</th>
        <th>Updated At</th>
        <th>Updated By</th>
        <th>Return Home</th>
        <th>Update</th>
    </tr>

    <tbody id=""tableBody""></tbody>
</table>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(871, 5751, true);
                WriteLiteral(@"
    <script>
        let table = '.TableCL';
        let tableBody = '#tableBody';
        let visibility = true;

        // AJAX GET to output into table
        $.ajax({
            url: '/API/Product/GetAllProd',
            method: 'GET'

        }).done(function (data) {
            let $tableBodyElement = $('#tableBody');

            for (let index = 0; index < data.length; index++) {
                let $rowElement = null;
                let $cellElement = null;
                let $hyperlinkElement = null;

                $rowElement = $('<tr></tr>');

                //Id
                var prodId = data[index].prodId;
                console.log(prodId);
                $cellElement = $('<td>' + prodId + '</td>')
                $rowElement.append($cellElement);

                //Image
                prodImgUrl = data[index].prodImgUrl;
                console.log(prodImgUrl);
                $cellElement = $('<td><img src=""' + prodImgUrl + '"" class=""img-fluid"">");
                WriteLiteral(@"</td>');
                $rowElement.append($cellElement);

                //Code
                prodCode = data[index].prodCode;
                console.log(prodCode);
                $cellElement = $('<td>' + prodCode + '</td>');
                $rowElement.append($cellElement);
                
                //Name
                prodName = data[index].prodName;
                console.log(prodName);
                $cellElement = $('<td>' + prodName + '</td>');
                $rowElement.append($cellElement);

                //Created At
                createdAt = data[index].createdAt;
                console.log(createdAt);
                $cellElement = $('<td>' + createdAt + '</td>');
                $rowElement.append($cellElement);

                //Created By
                var createdBy = data[index].createdBy;
                console.log(createdBy);
                $cellElement = $('<td>' + createdBy + '</td>')
                $rowElement.append($cellElement);
");
                WriteLiteral(@"
                //Updated At
                var updatedAt = data[index].updatedAt;
                console.log(updatedAt);
                $cellElement = $('<td>' + updatedAt + '</td>')
                $rowElement.append($cellElement);

                //Updated By
                var updatedBy = data[index].updatedBy;
                console.log(updatedBy);
                $cellElement = $('<td>' + updatedBy + '</td>')
                $rowElement.append($cellElement);
                

                //Manage Brand
                var brandButton = """";
                console.log(brandButton);
                $cellElement = $('<td><button type=""button"" onclick=""myFunction()"">Home</button></td>')
                $rowElement.append($cellElement);


                //Update
                var brandButton = """";
                console.log(brandButton);
                $cellElement = $('<td><button type=""button""><a href=""/Product/UpdateProduct/' + data[index].prodId + '"">Update</a></bu");
                WriteLiteral(@"tton></td>')
                $rowElement.append($cellElement);
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
        // Set defaults
        jQuery.validator.setDefaults({
            errorElement: 'div',
            errorClass: 'is-invalid'
        });
        // Validate and submit form using AJAX PUT
        $('#dataForm').validate({
            rules: {
                customerAccount: {
                    required: true
                }
            },
            messages: {
                customerAccount: {
                    required: 'Please enter valid name with alphanumerical characters or \'_\',\'-\' or \'\'\' '
                }
            },
            errorPlacement: function (error,");
                WriteLiteral(@" element) {
                if (element.is(':radio')) {
                    error.appendTo(element.parent().parent().next('div'))
                } else {
                    error.appendTo(element.next('div'));
                }
            },
            submitHandler: function () {
                let collectedAccountName = $('#customerAccount').val();
                let collectedVisibility = visibility;
                let webFormData = new WebFormData(collectedAccountName, collectedVisibility);
                let id = $('#submitButton').attr('data-id');

                $.ajax({
                    method: 'PUT',
                    url: '/API/CustomerAccounts/' + id,
                    data: webFormData,
                    datatype: 'json',
                    contentType: 'application/x-www-form-urlencoded'
                }).done(function (data) {
                    new Noty({
                        text: data.message,
                        type: 'success',
             ");
                WriteLiteral(@"           layout: 'center',
                        timer: 1500
                    }).show();

                    renderDataWithId(id, ""UPDATE"");
                    $('#updateModal').modal('hide');
                }).fail(function (data) {
                    new Noty({
                        text: data.responseJSON.message, type: 'error',
                        layout: 'center',
                        timer: 2500
                    }).show();
                })
            }
        });

        function myFunction() {
            location.replace(""/Home/adminPanel"")
        }


    </script>
");
                EndContext();
            }
            );
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
