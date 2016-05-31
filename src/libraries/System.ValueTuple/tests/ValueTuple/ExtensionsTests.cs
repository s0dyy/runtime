﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Text;
using Xunit;
using static ValueTupleTests;

public class ExtensionsTests
{
    #region Deconstruct
    [Fact]
    public void Deconstruct1()
    {
        var tuple = Tuple.Create(1);
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1);
        Assert.Equal("1", h.ToString());
    }

    [Fact]
    public void Deconstruct2()
    {
        var tuple = Tuple.Create(1, 2);
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2);
        Assert.Equal("1 2", h.ToString());
    }

    [Fact]
    public void Deconstruct3()
    {
        var tuple = Tuple.Create(1, 2, 3);
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3);
        Assert.Equal("1 2 3", h.ToString());
    }

    [Fact]
    public void Deconstruct4()
    {
        var tuple = Tuple.Create(1, 2, 3, 4);
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4);
        Assert.Equal("1 2 3 4", h.ToString());
    }

    [Fact]
    public void Deconstruct5()
    {
        var tuple = Tuple.Create(1, 2, 3, 4, 5);
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5);
        Assert.Equal("1 2 3 4 5", h.ToString());
    }

    [Fact]
    public void Deconstruct6()
    {
        var tuple = Tuple.Create(1, 2, 3, 4, 5, 6);
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6);
        Assert.Equal("1 2 3 4 5 6", h.ToString());
    }

    [Fact]
    public void Deconstruct7()
    {
        var tuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7);
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7);
        Assert.Equal("1 2 3 4 5 6 7", h.ToString());
    }

    [Fact]
    public void Deconstruct8()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8);
        Assert.Equal("1 2 3 4 5 6 7 8", h.ToString());
    }

    [Fact]
    public void Deconstruct9()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9);
        Assert.Equal("1 2 3 4 5 6 7 8 9", h.ToString());
    }

    [Fact]
    public void Deconstruct10()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10", h.ToString());
    }

    [Fact]
    public void Deconstruct11()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11", h.ToString());
    }

    [Fact]
    public void Deconstruct12()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12", h.ToString());
    }

    [Fact]
    public void Deconstruct13()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13", h.ToString());
    }

    [Fact]
    public void Deconstruct14()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14", h.ToString());
    }

    [Fact]
    public void Deconstruct15()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15)));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14, out h.x15);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15", h.ToString());
    }

    [Fact]
    public void Deconstruct16()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16)));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14, out h.x15, out h.x16);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16", h.ToString());
    }

    [Fact]
    public void Deconstruct17()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17)));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14, out h.x15, out h.x16, out h.x17);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17", h.ToString());
    }

    [Fact]
    public void Deconstruct18()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18)));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14, out h.x15, out h.x16, out h.x17, out h.x18);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18", h.ToString());
    }

    [Fact]
    public void Deconstruct19()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19)));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14, out h.x15, out h.x16, out h.x17, out h.x18, out h.x19);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19", h.ToString());
    }

    [Fact]
    public void Deconstruct20()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19, 20)));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14, out h.x15, out h.x16, out h.x17, out h.x18, out h.x19, out h.x20);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20", h.ToString());
    }

    [Fact]
    public void Deconstruct21()
    {
        var tuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19, 20, 21)));
        var h = new IntHolder();

        tuple.Deconstruct(out h.x1, out h.x2, out h.x3, out h.x4, out h.x5, out h.x6, out h.x7, out h.x8, out h.x9, out h.x10, out h.x11, out h.x12, out h.x13, out h.x14, out h.x15, out h.x16, out h.x17, out h.x18, out h.x19, out h.x20, out h.x21);
        Assert.Equal("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21", h.ToString());
    }
    #endregion


    [Fact]
    public void ConvertToRef21()
    {
        var refTuple = CreateLongRef(-1, -1, -1, -1, -1, -1, -1, CreateLongRef(-1, -1, -1, -1, -1, -1, -1, Tuple.Create(-1, -1, -1, -1, -1, -1, -1)));
        var valueTuple = CreateLong(1, 2, 3, 4, 5, 6, 7, CreateLong(8, 9, 10, 11, 12, 13, 14, ValueTuple.Create(15, 16, 17, 18, 19, 20, 21)));

        refTuple = valueTuple.ToRefTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21)", refTuple.ToString());
    }

    #region ToValue

    [Fact]
    public void ConvertToValue1()
    {
        var valueTuple = ValueTuple.Create(-1);
        var refTuple = Tuple.Create(1);

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue2()
    {
        var valueTuple = ValueTuple.Create(-1, -1);
        var refTuple = Tuple.Create(1, 2);

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue3()
    {
        var valueTuple = ValueTuple.Create(-1, -1, -1);
        var refTuple = Tuple.Create(1, 2, 3);

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue4()
    {
        var valueTuple = ValueTuple.Create(-1, -1, -1, -1);
        var refTuple = Tuple.Create(1, 2, 3, 4);

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue5()
    {
        var valueTuple = ValueTuple.Create(-1, -1, -1, -1, -1);
        var refTuple = Tuple.Create(1, 2, 3, 4, 5);

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue6()
    {
        var valueTuple = ValueTuple.Create(-1, -1, -1, -1, -1, -1);
        var refTuple = Tuple.Create(1, 2, 3, 4, 5, 6);

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue7()
    {
        var valueTuple = ValueTuple.Create(-1, -1, -1, -1, -1, -1, -1);
        var refTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7);

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue8()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue9()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue10()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue11()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue12()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1, -1));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue13()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1, -1, -1));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue14()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1, -1, -1, -1));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, 14));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue15()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1)));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15)));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue16()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1)));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16)));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue17()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1)));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17)));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue18()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1)));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18)));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue19()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1, -1)));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19)));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue20()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1, -1, -1)));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19, 20)));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)", valueTuple.ToString());
    }

    [Fact]
    public void ConvertToValue21()
    {
        var valueTuple = CreateLong(-1, -1, -1, -1, -1, -1, -1, CreateLong(-1, -1, -1, -1, -1, -1, -1, ValueTuple.Create(-1, -1, -1, -1, -1, -1, -1)));
        var refTuple = CreateLongRef(1, 2, 3, 4, 5, 6, 7, CreateLongRef(8, 9, 10, 11, 12, 13, 14, Tuple.Create(15, 16, 17, 18, 19, 20, 21)));

        valueTuple = refTuple.ToValueTuple();
        Assert.Equal("(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21)", valueTuple.ToString());
    }
    #endregion

    // Holds 21 int values
    private struct IntHolder
    {
        public int x1;
        public int x2;
        public int x3;
        public int x4;
        public int x5;
        public int x6;
        public int x7;
        public int x8;
        public int x9;
        public int x10;
        public int x11;
        public int x12;
        public int x13;
        public int x14;
        public int x15;
        public int x16;
        public int x17;
        public int x18;
        public int x19;
        public int x20;
        public int x21;

        public override string ToString()
        {
            var builder = new StringBuilder();
            if (x1 > 0) { builder.Append($"{x1}"); }
            if (x2 > 0) { builder.Append($" {x2}"); }
            if (x3 > 0) { builder.Append($" {x3}"); }
            if (x4 > 0) { builder.Append($" {x4}"); }
            if (x5 > 0) { builder.Append($" {x5}"); }
            if (x6 > 0) { builder.Append($" {x6}"); }
            if (x7 > 0) { builder.Append($" {x7}"); }
            if (x8 > 0) { builder.Append($" {x8}"); }
            if (x9 > 0) { builder.Append($" {x9}"); }
            if (x10 > 0) { builder.Append($" {x10}"); }
            if (x11 > 0) { builder.Append($" {x11}"); }
            if (x12 > 0) { builder.Append($" {x12}"); }
            if (x13 > 0) { builder.Append($" {x13}"); }
            if (x14 > 0) { builder.Append($" {x14}"); }
            if (x15 > 0) { builder.Append($" {x15}"); }
            if (x16 > 0) { builder.Append($" {x16}"); }
            if (x17 > 0) { builder.Append($" {x17}"); }
            if (x18 > 0) { builder.Append($" {x18}"); }
            if (x19 > 0) { builder.Append($" {x19}"); }
            if (x20 > 0) { builder.Append($" {x20}"); }
            if (x21 > 0) { builder.Append($" {x21}"); }

            return builder.ToString();
        }
    }
}