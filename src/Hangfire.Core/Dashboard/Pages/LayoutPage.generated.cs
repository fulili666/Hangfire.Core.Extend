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
    
    #line 2 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 3 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Dashboard\Pages\LayoutPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class LayoutPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");





WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <title>");


            
            #line 9 "..\..\Dashboard\Pages\LayoutPage.cshtml"
      Write(Title);

            
            #line default
            #line hidden
WriteLiteral(" - Hangfire</title>\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n " +
"   <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-wid" +
"th, initial-scale=1.0\">\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 13 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                            Write(LinkTo("/css"));

            
            #line default
            #line hidden
WriteLiteral(@""" />
</head>
    <body>
        <!-- Wrap all page content here -->
        <div id=""wrap"">

            <!-- Fixed navbar -->
            <div class=""navbar navbar-default navbar-static-top"">
                <div class=""container"">
                    <div class=""navbar-header"">
                        <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target="".navbar-collapse"">
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                            <span class=""icon-bar""></span>
                        </button>
                        <a class=""navbar-brand"" href=""");


            
            #line 28 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                                 Write(LinkTo("/"));

            
            #line default
            #line hidden
WriteLiteral("\">Hangfire Dashboard</a>\r\n                    </div>\r\n                    <div cl" +
"ass=\"collapse navbar-collapse\">\r\n                        ");


            
            #line 31 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(RenderPartial(new Navigation()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <ul class=\"nav navbar-nav navbar-right\">\r\n             " +
"               <li>\r\n                                <a href=\"");


            
            #line 34 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                                    Write(AppPath);

            
            #line default
            #line hidden
WriteLiteral(@""">
                                    <span class=""glyphicon glyphicon-log-out""></span>
                                    Back to site
                                </a>
                            </li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>

            <!-- Begin page content -->
            <div class=""container"" style=""margin-bottom: 20px;"">
                ");


            
            #line 47 "..\..\Dashboard\Pages\LayoutPage.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral(@"
            </div>
        </div>

        <div id=""footer"">
            <div class=""container"">
                <ul class=""list-inline credit"">
                    <li>
                        <a href=""http://hangfire.io/"" target=""_blank"">Hangfire
");


            
            #line 56 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                              
                                var version = GetType().Assembly.GetName().Version;
                            

            
            #line default
            #line hidden
WriteLiteral("                            ");


            
            #line 59 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                       Write(String.Format("{0}.{1}.{2}", version.Major, version.Minor, version.Build));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n                    <l" +
"i>");


            
            #line 62 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                   Write(Storage);

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n                    <li>Time: ");


            
            #line 63 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                         Write(DateTime.UtcNow);

            
            #line default
            #line hidden
WriteLiteral(@" GMT
                    </li>
                </ul>
            </div>
        </div>
        
        <script>
            (function (hangFire) {
                hangFire.config = {
                    pollInterval: 2000,
                    pollUrl: '");


            
            #line 73 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                          Write(LinkTo("/stats"));

            
            #line default
            #line hidden
WriteLiteral("\'\r\n                };\r\n            })(window.Hangfire = window.Hangfire || {});\r\n" +
"        </script>\r\n        <script src=\"");


            
            #line 77 "..\..\Dashboard\Pages\LayoutPage.cshtml"
                Write(LinkTo("/js"));

            
            #line default
            #line hidden
WriteLiteral("\"></script>\r\n    </body>\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
