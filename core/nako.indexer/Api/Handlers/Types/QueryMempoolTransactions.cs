﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryTransaction.cs" company="SoftChains">
//   Copyright 2016 Dan Gershony
//   //  Licensed under the MIT license. See LICENSE file in the project root for full license information.
//   //  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
//   //  EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
//   //  OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nako.Api.Handlers.Types
{
    using System;
    using System.Collections.Generic;

    public class QueryMempoolTransaction
    {
        public string TransactionId { get; set; }
    }

    public class QueryMempoolTransactions
    {
        public string CoinTag { get; set; }

        public IEnumerable<QueryMempoolTransaction> Transactions { get; set; }
    }
}
