﻿using System.Collections.Generic;
using Glimpse.Core2.Extensibility;

namespace Glimpse.Test.Core2.TestDoubles
{
    [SerializationConverter]
    public class DummySerializationConverterOfT:SerializationConverter<DummyObjectContext>
    {
        public override IDictionary<string, object> Convert(object obj)
        {
            throw new System.NotImplementedException();
        }
    }
}