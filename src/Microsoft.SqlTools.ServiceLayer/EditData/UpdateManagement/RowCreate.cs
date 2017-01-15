﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.SqlTools.ServiceLayer.EditData.UpdateManagement
{
    public sealed class RowCreate : RowUpdateBase
    {
        private List<CellUpdate> newCells;

        public RowCreate()
        {
            newCells = new List<CellUpdate>();
        }

        public override string GetScript()
        {
            throw new NotImplementedException();
        }

        public override string UpdateCell(int columnId, string newValue)
        {
            throw new NotImplementedException();
        }
    }
}
