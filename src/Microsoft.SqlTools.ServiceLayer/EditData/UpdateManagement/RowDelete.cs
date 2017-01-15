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
    public sealed class RowDelete : RowUpdateBase
    {
        public override string GetScript()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This method should not be called on 
        /// </summary>
        /// <param name="columnId"></param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        public override string UpdateCell(int columnId, string newValue)
        {
            // @TODO: Move to constants file
            throw new InvalidOperationException("A delete is pending for this row, a cell update cannot be applied.");
        }
    }
}