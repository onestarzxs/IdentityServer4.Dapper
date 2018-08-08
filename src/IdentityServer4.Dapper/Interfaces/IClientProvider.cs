﻿using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using Microsoft.Extensions.Logging;
using IdentityServer4.Dapper.DefaultProviders;

namespace IdentityServer4.Dapper.Interfaces
{
    public interface IClientProvider
    {
        Client FindClientById(string clientid);
        void Add(Client client);
    }

   
}
