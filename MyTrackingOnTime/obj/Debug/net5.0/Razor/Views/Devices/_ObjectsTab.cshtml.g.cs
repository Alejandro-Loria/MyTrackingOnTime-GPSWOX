#pragma checksum "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "572d60866f9ad05401a96150bf92c1729673fbcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Devices__ObjectsTab), @"mvc.1.0.view", @"/Views/Devices/_ObjectsTab.cshtml")]
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
#line 1 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\_ViewImports.cshtml"
using MyTrackingOnTime;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\_ViewImports.cshtml"
using MyTrackingOnTime.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572d60866f9ad05401a96150bf92c1729673fbcd", @"/Views/Devices/_ObjectsTab.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fe9cd2b0b113bffb4efa16b4bf444242b01c37", @"/Views/_ViewImports.cshtml")]
    public class Views_Devices__ObjectsTab : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyTrackingOnTime.Models.DevicesModel.Root>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""tab-pane fade show active"" id=""objects"" role=""tabpanel"" aria-labelledby=""objects-tab"">
    <div class=""input-group mb-3 mt-3"">
        <input type=""text"" class=""form-control"" placeholder=""Búsqueda"" aria-label=""Búsqueda"" aria-describedby=""button-search"">
        <button class=""btn"" type=""button"" id=""button-search"" title=""Buscar""><i class=""fas fa-search""></i></button>
        <button class=""btn"" type=""button"" id=""button-list"" title=""Lista"" data-bs-toggle=""modal"" data-bs-target=""#ObjectListModal""><i class=""fas fa-bars""></i></button>
    </div>
    <div class=""list-group-item list-group-item-action rounded-top"" id=""collapseHeader"">
        <div class=""input-group"">
            <div class=""form-check form-switch"" id=""allCheckboxContainer"">
                <input class=""form-check-input selectAllcheckbox"" type=""checkbox"">
                <label class=""form-check-label"" for=""allCheckbox""></label>
            </div>
");
#nullable restore
#line 15 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"btn list-group-item list-group-item-action\" id=\"collapseTitleGroup\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseObjects\" aria-expanded=\"true\" aria-controls=\"collapseObjects\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                   Write(Html.LabelFor(modelItem => item.Title, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 20 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                                                                                              Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 22 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a class=""btn"" id=""button-devices-groups-create"" data-bs-toggle=""modal"" data-bs-target=""#DevicesGroupsCreateModal""><i class=""fas fa-ellipsis-v""></i></a>
        </div>
    </div>
    <div class=""collapse show"" id=""collapseObjects"">
        <ul class=""list-group"">
");
#nullable restore
#line 29 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                 foreach (var item in Model)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                     if (item.Items != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                         foreach (var itm in item.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""list-group-item list-group-item-action"">
                                <div class=""input-group"">
                                    <div class=""form-check form-switch"" id=""checkboxContainer"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""checkboxItem"">
                                        <label class=""form-check-label"" for=""checkboxItem""></label>
                                    </div>
                                    <div class=""btn list-group-item list-group-item-action"" id=""nameItem"">
                                        <span data-device=""name""");
            BeginWriteAttribute("title", " title=\"", 2753, "\"", 2801, 1);
#nullable restore
#line 44 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
WriteAttributeValue("", 2761, Html.DisplayFor(modelItem => @itm.Name), 2761, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem => @itm.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span data-device=\"time\"");
            BeginWriteAttribute("title", " title=\"", 2916, "\"", 2964, 1);
#nullable restore
#line 45 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
WriteAttributeValue("", 2924, Html.DisplayFor(modelItem => @itm.Time), 2924, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem => @itm.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span data-device=\"speed\"");
            BeginWriteAttribute("title", " title=\"", 3080, "\"", 3133, 2);
#nullable restore
#line 46 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
WriteAttributeValue("", 3088, Html.DisplayFor(modelItem => @itm.Speed), 3088, 41, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3129, "kph", 3130, 4, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                                                                                                                   Write(Html.DisplayFor(modelItem => @itm.Speed));

#line default
#line hidden
#nullable disable
            WriteLiteral(" kph</span>\r\n                                        <span data-device=\"status\"");
            BeginWriteAttribute("style", " style=\"", 3255, "\"", 3325, 2);
            WriteAttributeValue("", 3263, "background-color:", 3263, 17, true);
#nullable restore
#line 47 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
WriteAttributeValue(" ", 3280, Html.DisplayFor(modelItem => itm.IconColor), 3281, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3326, "\"", 3447, 2);
#nullable restore
#line 47 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
WriteAttributeValue("", 3334, Html.DisplayName(@itm.Online).First().ToString().ToUpper(), 3334, 59, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
WriteAttributeValue("", 3393, Html.DisplayName(@itm.Online).ToString().Substring(1), 3393, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"tooltip\" data-bs-placement=\"top\">");
#nullable restore
#line 47 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                                                                                                                                                                                                                                                                                                                Write(Html.DisplayName(@itm.Online).First().ToString().ToUpper());

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                                                                                                                                                                                                                                                                                                                                                                           Write(Html.DisplayName(@itm.Online).ToString().Substring(1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    <div class=""details"">
                                        <div class=""btn-group dropend"">
                                            <i class=""btn fas fa-ellipsis-v"" id=""button-details"" data-bs-toggle=""dropdown"" aria-expanded=""false"" title=""Detalles""></i>
                                            <ul class=""dropdown-menu"">
                                                <li>
                                                    <a href=""#"" class=""dropdown-item"" onclick=""app.history.device('8', 'last_hour');"">
                                                        <i class=""far fa-clock""></i>
                                                        <span class=""text"">Mostrar historial (ultima hora)</span>
                                                    </a>
                                                </li>
                                                <li>
                                         ");
            WriteLiteral(@"           <a href=""#"" class=""dropdown-item"" onclick=""app.history.device('8', 'today');"">
                                                        <i class=""fas fa-calendar-day""></i>
                                                        <span class=""text"">Mostrar historial (hoy)</span>
                                                    </a>
                                                </li>
                                                <li>
                                                    <a href=""#"" class=""dropdown-item"" onclick=""app.history.device('8', 'yesterday');"">
                                                        <i class=""fas fa-history""></i>
                                                        <span class=""text"">Mostrar historial (ayer)</span>
                                                    </a>
                                                </li>
                                                <li><hr class=""dropdown-divider""></li>
                                 ");
            WriteLiteral(@"               <li>
                                                    <a href=""#"" class=""dropdown-item"" data-url=""https://admin.mytrackingontime.com/devices/follow_map/8"" data-id=""8"" onclick=""app.devices.follow(8);"" data-name=""Seguir (6551 TK110-EN3 (9994920087)-7825)"">
                                                        <i class=""fas fa-location-arrow""></i>
                                                        <span class=""text"">Seguir</span>
                                                    </a>
                                                </li>

                                                <li>
                                                    <a href=""#"" class=""dropdown-item"" data-url=""https://admin.mytrackingontime.com/send_command/create"" data-modal=""send_command"" data-id=""8"">
                                                        <i class=""fas fa-terminal""></i>
                                                        <span class=""text"">Enviar comando</span>
                ");
            WriteLiteral(@"                                    </a>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </li>
");
#nullable restore
#line 90 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\alejandro.loria\source\repos\MyTrackingOnTime-GPSWOX\MyTrackingOnTime\Views\Devices\_ObjectsTab.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyTrackingOnTime.Models.DevicesModel.Root>> Html { get; private set; }
    }
}
#pragma warning restore 1591
