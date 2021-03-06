#pragma checksum "C:\Users\natsu\source\repos\AspTestPage\AspTestPage\Views\Home\TestPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f79adc683b5113873ce14a5f8fcc141f3b2ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestPage), @"mvc.1.0.view", @"/Views/Home/TestPage.cshtml")]
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
#line 1 "C:\Users\natsu\source\repos\AspTestPage\AspTestPage\Views\_ViewImports.cshtml"
using AspTestPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\natsu\source\repos\AspTestPage\AspTestPage\Views\_ViewImports.cshtml"
using AspTestPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87f79adc683b5113873ce14a5f8fcc141f3b2ca6", @"/Views/Home/TestPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"510b02c1fbbdc9a8a0e9985c43b388d43037e8d8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\natsu\source\repos\AspTestPage\AspTestPage\Views\Home\TestPage.cshtml"
  
    ViewData["Title"] = "Test Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87f79adc683b5113873ce14a5f8fcc141f3b2ca63281", async() => {
                WriteLiteral(@"
    <table class=""table table-striped table-bordered table-hover"">
        <thead>
            <tr><th>Department</th><th>Phone Number</th><th>Extension</th></tr>
        </thead>
        <tbody>
            <tr><td>General</td><td>555-555-5555</td><td>1</td></tr>
            <tr><td>Customer Service</td><td>555-555-5556</td><td>2</td></tr>
            <tr><td>Billing and Accounts</td><td>555-555-5557</td><td>3</td></tr>
        </tbody>
    </table>

    <div>
        <p class=""text-right"">This text is right-aligned.</p>
        <p class=""text-center"">This text is centered.</p>
        <p class=""text-left"">This text is left-aligned.</p>
    </div>

    <button class=""btn-primary"">Primary</button>
    <button class=""btn-secondary"">Secondary</button>
    <button class=""btn-success"">Success</button>
    <button class=""btn-info"">Info</button>
    <button class=""btn-warning"">Warning</button>
    <button class=""btn-danger"">Danger</button>

    <p class=""text-success"">Congratulations! You ");
                WriteLiteral(@"are now registered.</p>

    <p class=""bg-warning p-2 rounded"">
        Warning! Some required fields are empty.
    </p>

    <div class=""btn-group"" role=""group"" aria-label=""Button group"">
        <a href=""/"" class=""btn btn-outline-primary""><span class=""fas fa-home""></span>&nbsp;Home</a>
        <a href=""/cart"" class=""btn btn-outline-primary""><span class=""fas fa-shopping-cart""></span>&nbsp;Cart&nbsp;<span class=""badge badge-primary"">2</span></a>
        <a href=""/products"" class=""btn btn-outline-primary"">Products</a>
        <a href=""/contact-us"" class=""btn btn-outline-primary"">Contact Us</a>
    </div>

    <div class=""btn-toolbar"" role=""toolbar"" aria-label=""Toolbar with groups"">
        <div class=""btn-group mr-2"">
            <a href=""/"" class=""btn btn-outline-primary"">Home</a>
            <a href=""/cart"" class=""btn btn-outline-primary"">Cart</a>
        </div>
        <div class=""btn-group"" role=""group"" aria-label=""Second group"">
            <a href=""/products"" class=""btn btn-outline-pr");
                WriteLiteral(@"imary"">Products</a>
            <a href=""/contact-us"" class=""btn btn-outline-primary"">Contact Us</a>
        </div>
    </div>

    <div class=""dropdown"">
        <button type =""button"" class=""btn btn-primary dropdown-toggle"" id=""productsDropdown"" data-toggle=""dropdown""
                aria-haspopup=""false"" aria-expanded=""false"">
            Products
        </button>
        <div class=""dropdown-menu"" aria-labelledby=""producstDropdown"">
            <a class=""dropdown-item"" href=""/product/list/guitars"">Guitars</a>
            <a class=""dropdown-item"" href=""/product/list/drums"">Drums</a>
    </div>

        <ul class=""list-group"">
            <li class=""list-group-item"">Guitars</li>
            <li class=""list-group-item"">Basses</li>
            <li class=""list-group-item"">Drums</li>
        </ul>

        <div class=""list-group"">
            <a href=""/guitars"" class=""list-group-item active"">Guitars</a>
            <a href=""/basses"" class=""list-group-item"">Basses</a>
            <a href");
                WriteLiteral(@"=""/drums"" class=""list-group-item"">Drums</a>
        </div>

        <div class=""alert alert-success alert-dismissible"">
            <button class=""close"" data-dismiss=""alert"">&times;</button>
            Success! <a href=""#"" class=""alert-link"">Learn More!</a>
        </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
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
