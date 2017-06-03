﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

#pragma warning disable RCS1081, RCS1169

namespace Roslynator.CSharp.Analyzers.Test
{
    public class MarkFieldAsConst
    {
        private const bool BoolConst = false;
        private const char CharConst = '\0';
        private const int IntConst = 0;
        private const ulong ULongConst = 0;
        private const string StringConst = null;

        private readonly bool _f2 = false;
        private readonly bool _f3 = BoolConst;
        private readonly char _ch2 = '\0';
        private readonly char _ch3 = CharConst;
        private readonly int _i2 = 0;
        private readonly int _i3 = IntConst;
        private readonly ulong _l2 = 0;
        private readonly ulong _l3 = ULongConst;
        private readonly string _s2 = null;
        private readonly string _s3 = default(string);
        private readonly string _s4 = StringConst;
        private readonly sbyte _sb = (sbyte)0;
        private readonly byte _be = (byte)0;
        private readonly short _st = (short)0;
        private readonly ushort _us = (ushort)0;
        private readonly int _ii = (int)0;
        private readonly uint _ui = (uint)0;
        private readonly long _lg = (long)0;
        private readonly ulong _ul = (ulong)0;
        private readonly float _ft = (float)0;
        private readonly double _de = (double)0;
        private readonly decimal _dl = (decimal)0;

        // n

        private string _s = "";

        private readonly string _ss;

        private readonly string _sss = GetValue();

        private readonly object _o = null;

        private readonly string _f = null, _ff;

        private static string GetValue() => null;
    }
}