#pragma checksum "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b26dee481a6cbfee42a3b1bb37275b71bf65ac6"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using WebApp.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transactions")]
    public partial class TransactionsReportComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "printarea");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-2");
            __builder.AddMarkupContent(6, "<label for=\"cashier\">Cashier Name</label>\r\n            ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "id", "cashier");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                              cashierName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cashierName = __value, cashierName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-3");
            __builder.AddMarkupContent(16, "<label for=\"startdate\">Start Date</label>\r\n            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "date");
            __builder.AddAttribute(19, "id", "startdate");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                                startDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => startDate = __value, startDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-3");
            __builder.AddMarkupContent(26, "<label for=\"enddate\">End Date</label>\r\n            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "date");
            __builder.AddAttribute(29, "id", "enddate");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                              endDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => endDate = __value, endDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-2");
            __builder.AddMarkupContent(36, "<label>&nbsp;</label>\r\n            ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-primary form-control");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                                 LoadTransactions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "col-2");
            __builder.AddMarkupContent(45, "<label>&nbsp;</label>\r\n            ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "btn btn-primary form-control");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                                                 PrintReport

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Print");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    <br>");
#nullable restore
#line 31 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
     if (transactions != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "table");
            __builder.AddAttribute(53, "class", "table");
            __builder.AddMarkupContent(54, @"<thead><tr><th>Date Time</th>
                    <th>Cashier Name</th>
                    <th>Product Name</th>
                    <th>Qty Before</th>
                    <th>Qty Sold</th>
                    <th>Qty After</th>
                    <th>Price</th>
                    <th>Sold Amt</th></tr></thead>
            ");
            __builder.OpenElement(55, "tbody");
#nullable restore
#line 47 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                 foreach (var tran in transactions)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "tr");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 50 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.TimeStamp.ToString("yyyy-MM-dd hh:mm")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, 
#nullable restore
#line 51 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.CashierName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 52 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 53 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.BeforeQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 54 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                             tran.SoldQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 55 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                              tran.BeforeQty - tran.SoldQty

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "style", "text-align:right");
            __builder.AddContent(77, 
#nullable restore
#line 56 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                       string.Format("{0:c}", tran.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "style", "text-align:right");
            __builder.AddContent(81, 
#nullable restore
#line 57 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                                                       string.Format("{0:c}", tran.SoldQty * tran.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n            ");
            __builder.OpenElement(83, "tfoot");
            __builder.OpenElement(84, "tr");
            __builder.AddMarkupContent(85, "<td colspan=\"6\">&nbsp;</td>\r\n                    ");
            __builder.AddMarkupContent(86, "<td style=\"text-align:right\"><b>Grand Total:</b></td>\r\n                    ");
            __builder.OpenElement(87, "td");
            __builder.AddAttribute(88, "style", "text-align:right");
            __builder.OpenElement(89, "b");
            __builder.AddContent(90, 
#nullable restore
#line 69 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
                              string.Format("{0:c}", transactions.Sum(x => x.Price * x.SoldQty))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Admin\Downloads\SupermarketManagement\WebApp\Pages\TransactionsReportComponent.razor"
       

    private string cashierName;
    private DateTime startDate;
    private DateTime endDate;
    private IEnumerable<Transaction> transactions;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        startDate = DateTime.Today;
        endDate = DateTime.Today;
    }

    private void LoadTransactions()
    {
        transactions = GetTransactionsUseCase.Execute(cashierName, startDate, endDate);
    }

    private void PrintReport()
    {
        JSRuntime.InvokeVoidAsync("print");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetTransactionsUseCase GetTransactionsUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
