﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace XRTK.Utilities.Gltf.Schema
{
    [Serializable]
    public class GltfTextureInfo : GltfProperty
    {
        /// <summary>
        /// The index of the texture.
        /// </summary>
        public int index = -1;

        /// <summary>
        /// This integer value is used to construct a string in the format
        /// TEXCOORD_&lt;set index&gt; which is a reference to a key in
        /// mesh.primitives.attributes (e.g. A value of 0 corresponds to TEXCOORD_0).
        /// </summary>
        public int textCoord = 0;
    }
}