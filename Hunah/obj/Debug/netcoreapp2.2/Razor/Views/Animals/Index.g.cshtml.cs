#pragma checksum "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa362badf38a072ade15921ac49e1a4d317fcbb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animals_Index), @"mvc.1.0.view", @"/Views/Animals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animals/Index.cshtml", typeof(AspNetCore.Views_Animals_Index))]
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
#line 1 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
using Hunah.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa362badf38a072ade15921ac49e1a4d317fcbb6", @"/Views/Animals/Index.cshtml")]
    public class Views_Animals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hunah.Models.Animal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 19, true);
            WriteLiteral("\n<h1>Animals</h1>\n\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(100, 43, true);
            WriteLiteral("  <h3>No animals have been added yet!</h3>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(146, 6, true);
            WriteLiteral("\n<ul>\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
   foreach(Animal animal in Model)
  {

#line default
#line hidden
            BeginContext(191, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(202, 74, false);
#line 14 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
     Write(Html.ActionLink($"{animal.Name}", "Details", new { id = animal.AnimalId }));

#line default
#line hidden
            EndContext();
            BeginContext(276, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(286, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(297, 43, false);
#line 18 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
Write(Html.ActionLink("Add new animal", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(340, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(349, 53, false);
#line 19 "/Users/Guest/Desktop/Hunah.Solution/Hunah/Views/Animals/Index.cshtml"
Write(Html.ActionLink("Back to Main Page", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(402, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hunah.Models.Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
