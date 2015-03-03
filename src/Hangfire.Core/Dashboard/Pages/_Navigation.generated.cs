﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\_Navigation.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\_Navigation.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class Navigation : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





            
            #line 5 "..\..\Dashboard\Pages\_Navigation.cshtml"
 if (DashboardMenu.Items.Count > 0)
{
    var monitoringApi = Storage.GetMonitoringApi();
    var statistics = monitoringApi.GetStatistics();

    var context = new RazorPageContext(this, statistics);
    

            
            #line default
            #line hidden
WriteLiteral("    <ul class=\"nav navbar-nav\">\r\n");


            
            #line 13 "..\..\Dashboard\Pages\_Navigation.cshtml"
         foreach (var item in DashboardMenu.Items)
        {
            var itemValue = item(context);

            
            #line default
            #line hidden
WriteLiteral("            <li class=\"");


            
            #line 16 "..\..\Dashboard\Pages\_Navigation.cshtml"
                   Write(itemValue.Active ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                <a href=\"");


            
            #line 17 "..\..\Dashboard\Pages\_Navigation.cshtml"
                    Write(itemValue.Url);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    ");


            
            #line 18 "..\..\Dashboard\Pages\_Navigation.cshtml"
               Write(itemValue.Text);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 19 "..\..\Dashboard\Pages\_Navigation.cshtml"
                     if (itemValue.Metric != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <span class=\"metric ");


            
            #line 21 "..\..\Dashboard\Pages\_Navigation.cshtml"
                                       Write(itemValue.Metric.Style.ToClassName());

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 21 "..\..\Dashboard\Pages\_Navigation.cshtml"
                                                                              Write(itemValue.Metric.Highlighted ? "highlighted" : null);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 21 "..\..\Dashboard\Pages\_Navigation.cshtml"
                                                                                                                                      Write(new NonEscapedString(String.Join("&nbsp;/&nbsp;", itemValue.Metric.Values)));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 22 "..\..\Dashboard\Pages\_Navigation.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </a>\r\n            </li>\r\n");


            
            #line 25 "..\..\Dashboard\Pages\_Navigation.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n");


            
            #line 27 "..\..\Dashboard\Pages\_Navigation.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
