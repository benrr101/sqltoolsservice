﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;
using Microsoft.SqlTools.ServiceLayer.ObjectExplorer.Nodes;

namespace Microsoft.SqlTools.ServiceLayer.ObjectExplorer
{
    /// <summary>
    /// Utility class for Object Explorer related operations
    /// </summary>
    public static class ObjectExplorerUtils
    {
        /// <summary>
        /// Visitor that walks all nodes from the child to the root node, unless the 
        /// <paramref name="visitor"/> function indicates that this should stop traversing
        /// </summary>
        /// <param name="child">node to start traversing at</param>
        /// <param name="visitor">Predicate function that accesses the tree and
        /// determines whether to stop going further up the tree</param>
        /// <returns>
        /// boolean - true to continue navigating up the tree, false to end the loop
        /// and return early
        /// </returns>
        public static bool VisitChildAndParents(TreeNode child, Predicate<TreeNode> visitor)
        {
            if (child == null)
            {
                // End case: all nodes have been visited
                return true;
            }

            // Visit the child first, then go up the parents
            if (!visitor(child))
            {
                return false;
            }
            return VisitChildAndParents(child.Parent, visitor);
        }
    }
}