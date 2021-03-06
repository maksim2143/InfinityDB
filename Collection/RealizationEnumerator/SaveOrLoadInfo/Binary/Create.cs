﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Collection.RealizationEnumerator.SaveOrLoadInfo.Binary
{
    public class Create : Writer
    {
        protected override byte[] Read(long one, long two)
        {
            return base.Read(one, two);
        }
        protected IndexType WriteInfo(ref byte[] array)
        {
            var result = base.WriteNew(ref array);
            var x = new IndexType(result.one_position, result.two_position);
            index.Add(x);
            return x;
        }
        protected List<IndexType> index { private set; get; }
        protected Create(ObjType objType) : base(objType)
        {
            this.index = new List<IndexType>();
        }
    }
}
