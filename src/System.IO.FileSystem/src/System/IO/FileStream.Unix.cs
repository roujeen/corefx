// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;

namespace System.IO
{
    public partial class FileStream : Stream
    {
        public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize) :
            this(handle, access, bufferSize, handle.IsAsync ?? false)
        {
        }

        public FileStream(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync)
        {
            this._innerStream = new UnixFileStream(handle, access, bufferSize, isAsync, this);
        }
    }
}