#pragma checksum "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c224b07af2e24b29bbbba52c6132926a871c9c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Suppliers_ProductBySupplierID), @"mvc.1.0.view", @"/Views/Suppliers/ProductBySupplierID.cshtml")]
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
#line 1 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\_ViewImports.cshtml"
using SuppliersAndProduct.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\_ViewImports.cshtml"
using SuppliersAndProduct.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c224b07af2e24b29bbbba52c6132926a871c9c1", @"/Views/Suppliers/ProductBySupplierID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d662e7e40ec48e39baf78833b446a9358d83918", @"/Views/_ViewImports.cshtml")]
    public class Views_Suppliers_ProductBySupplierID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SuppliersAndProducts.Models.Classes.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
  
    ViewData["Title"] = "ProductBySupplierID";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ProductBySupplierID</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c224b07af2e24b29bbbba52c6132926a871c9c13915", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayNameFor(model => model.SupplierID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayFor(modelItem => item.SupplierID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 53 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 54 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Emre\source\repos\SuppliersAndProducts\SuppliersAndProduct.MVC\Views\Suppliers\ProductBySupplierID.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SuppliersAndProducts.Models.Classes.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
