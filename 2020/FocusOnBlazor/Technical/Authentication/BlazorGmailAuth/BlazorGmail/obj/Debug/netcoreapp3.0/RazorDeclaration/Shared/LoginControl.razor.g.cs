#pragma checksum "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Shared\LoginControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89b894a7d28b2254c87062ae2c489216ab595f09"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorGmail.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using BlazorGmail;

#line default
#line hidden
#line 9 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\_Imports.razor"
using BlazorGmail.Shared;

#line default
#line hidden
#line 1 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Shared\LoginControl.razor"
using System.Security.Claims;

#line default
#line hidden
#line 2 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Shared\LoginControl.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    public class LoginControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 22 "C:\Users\Michael\Documents\Visual Studio 2019\Projects\BlazorGmailAuth\BlazorGmail\Shared\LoginControl.razor"
            
    private ClaimsPrincipal User;
    private string GivenName;
    private string Surname;
    private string Avatar;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        try
        {
            // Set the user to determine if they are logged in
            User = _httpContextAccessor.HttpContext.User;

            // Try to get the GivenName
            var givenName =
                _httpContextAccessor.HttpContext.User
                .FindFirst(ClaimTypes.GivenName);

            if (givenName != null)
            {
                GivenName = givenName.Value;
            }
            else
            {
                GivenName = User.Identity.Name;
            }

            // Try to get the Surname
            var surname =
                _httpContextAccessor.HttpContext.User
                .FindFirst(ClaimTypes.Surname);

            if (surname != null)
            {
                Surname = surname.Value;
            }
            else
            {
                Surname = "";
            }

            // Try to get Avatar
            var avatar =
            _httpContextAccessor.HttpContext.User
            .FindFirst("urn:google:image");

            if (avatar != null)
            {
                Avatar = avatar.Value;
            }
            else
            {
                Avatar = "";
            }
        }
        catch { }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor _httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
