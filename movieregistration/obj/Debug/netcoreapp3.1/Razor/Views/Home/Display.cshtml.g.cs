#pragma checksum "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31bb699eb3b1de84feda5addf3aa0e1d997b41af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Display), @"mvc.1.0.view", @"/Views/Home/Display.cshtml")]
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
#line 1 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/_ViewImports.cshtml"
using movieregistration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/_ViewImports.cshtml"
using movieregistration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bb699eb3b1de84feda5addf3aa0e1d997b41af", @"/Views/Home/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed7c5ccd4abd76e441c19fc47c4842bd985dc6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
  
    ViewData["Title"] = "Movie Registration Display";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h5>Here\'s what you entered:</h5>\r\n\r\n<p>ID: ");
#nullable restore
#line 9 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
  Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    Title: ");
#nullable restore
#line 11 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    Genre: ");
#nullable restore
#line 13 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
      Write(Model.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    Year: ");
#nullable restore
#line 15 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
     Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\nActors:<br/>\r\n");
#nullable restore
#line 18 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
     foreach( var actor in @Model.Actors)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
   Write(actor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\n");
#nullable restore
#line 21 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("Directors:<br/>\r\n");
#nullable restore
#line 23 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
     foreach(var director in @Model.Directors)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
   Write(director);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br/>\n");
#nullable restore
#line 26 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br/>\r\n    <h3>");
#nullable restore
#line 28 "/Users/simon/Documents/GrandCircus/movieregistrationlab/movieregistration/Views/Home/Display.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has been registered.</h3>\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
