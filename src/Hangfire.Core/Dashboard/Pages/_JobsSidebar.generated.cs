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
    
    #line 2 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class JobsSidebar : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





            
            #line 5 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
 if (JobsSidebarMenu.Items.Count > 0)
{
    var monitoringApi = Storage.GetMonitoringApi();
    var statistics = monitoringApi.GetStatistics();

    var context = new RazorPageContext(this, statistics);


            
            #line default
            #line hidden
WriteLiteral("    <div id=\"stats\" class=\"list-group\">\r\n");


            
            #line 13 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
         foreach (var item in JobsSidebarMenu.Items)
        {
            var itemValue = item(context);

            
            #line default
            #line hidden
WriteLiteral("            <a href=\"");


            
            #line 16 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
                Write(itemValue.Url);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"list-group-item ");


            
            #line 16 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
                                                        Write(itemValue.Active ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                ");


            
            #line 17 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
           Write(itemValue.Text);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 18 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
                 if (itemValue.Metric != null)
                {
                    var metricClass = itemValue.Metric.Style.ToClassName();
                    var highlighted = itemValue.Metric.Highlighted ? "highlighted" : null;
                    

            
            #line default
            #line hidden
WriteLiteral("                    <span class=\"pull-right metric ");


            
            #line 23 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
                                              Write(metricClass);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 23 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
                                                           Write(highlighted);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 23 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
                                                                          Write(new NonEscapedString(String.Join("&nbsp;/&nbsp;", itemValue.Metric.Values)));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 24 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </a>\r\n");


            
            #line 26 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");


            
            #line 28 "..\..\Dashboard\Pages\_JobsSidebar.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
