﻿using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace SIGA.Web.Security;

public class CookieHandler : DelegatingHandler
{
    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        request.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
        request.Headers.Add("X-Requested-With", ["XMLHttpRequest"]);
        //request.Headers.Add("X-Resqueted-With", ["asd"]);

        return base.SendAsync(request, cancellationToken);
    }
}