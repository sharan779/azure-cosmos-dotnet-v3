﻿//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Cosmos
{
    using System;

    /// <summary>
    /// Metadata used by Azure Key Vault to wrap (encrypt) and unwrap (decrypt) keys.
    /// </summary>
    public class AzureKeyVaultKeyWrapMetadata : KeyWrapMetadata
    {
        internal static string TypeConstant = "akv";

        /// <summary>
        /// Creates a new instance of metadata that the Azure Key Vault can use to wrap and unwrap keys.
        /// </summary>
        /// <param name="masterKeyUri">Key Vault URL of the master key to be used for wrapping and unwrapping keys.</param>
        public AzureKeyVaultKeyWrapMetadata(Uri masterKeyUri)
            : base(masterKeyUri.AbsoluteUri)
        {
            this.Type = TypeConstant;
        }
    }
}
