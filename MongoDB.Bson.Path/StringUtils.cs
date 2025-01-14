﻿#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;

namespace MongoDB.Bson.Path
{
    internal static class StringUtils
    {
        public static string FormatWith(this string format, IFormatProvider provider, object? arg0)
        {
            return format.FormatWith(provider, new object?[] { arg0 });
        }

        public static string FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1)
        {
            return format.FormatWith(provider, new object?[] { arg0, arg1 });
        }

        public static string FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1, object? arg2)
        {
            return format.FormatWith(provider, new object?[] { arg0, arg1, arg2 });
        }

        public static string FormatWith(this string format, IFormatProvider provider, object? arg0, object? arg1, object? arg2, object? arg3)
        {
            return format.FormatWith(provider, new object?[] { arg0, arg1, arg2, arg3 });
        }

        private static string FormatWith(this string format, IFormatProvider provider, params object?[] args)
        {
            // leave this a private to force code to use an explicit overload
            // avoids stack memory being reserved for the object array
            ValidationUtils.ArgumentNotNull(format, nameof(format));

            return string.Format(provider, format, args);
        }
    }
}
