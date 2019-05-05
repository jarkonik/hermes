﻿using fbchat_sharp.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hermes
{
    public class FBClient : MessengerClient
    {
        protected override async Task DeleteCookiesAsync()
        {
            await Task.Yield();
        }

        protected override async Task<List<Cookie>> ReadCookiesFromDiskAsync()
        {
            await Task.Yield();
            return null;
        }

        protected override async Task WriteCookiesToDiskAsync(List<Cookie> cookieJar)
        {
            await Task.Yield();
        }
    }
}
