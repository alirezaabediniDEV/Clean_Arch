#pragma checksum "C:\Users\Alireza\Documents\GitHub\CleanArch\Clean_Arch\CleanArch\CleanArch.Mvc\Views\Account\SuccessRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5243c076077f782ed5a785232ecc261e67f3ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SuccessRegister), @"mvc.1.0.view", @"/Views/Account/SuccessRegister.cshtml")]
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
#line 1 "C:\Users\Alireza\Documents\GitHub\CleanArch\Clean_Arch\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alireza\Documents\GitHub\CleanArch\Clean_Arch\CleanArch\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5243c076077f782ed5a785232ecc261e67f3ec9", @"/Views/Account/SuccessRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad188cbe7dd57a8794ff436f3b6d4e994ac68bef", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SuccessRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CleanArch.Application.ViewModels.RegisterViewModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"alert alert-success\">\r\n    <h2>");
#nullable restore
#line 5 "C:\Users\Alireza\Documents\GitHub\CleanArch\Clean_Arch\CleanArch\CleanArch.Mvc\Views\Account\SuccessRegister.cshtml"
   Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h2>\r\n    <p>Your Register Is Success</p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CleanArch.Application.ViewModels.RegisterViewModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
