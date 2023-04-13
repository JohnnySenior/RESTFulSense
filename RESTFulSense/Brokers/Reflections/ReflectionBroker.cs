﻿// ---------------------------------------------------------------------------------- 
// Copyright (c) The Standard Organization, a coalition of the Good-Hearted Engineers 
// ----------------------------------------------------------------------------------

using System.Reflection;
using System;

namespace RESTFulSense.Brokers.Reflections
{
    internal partial class ReflectionBroker : IReflectionBroker
    {
        public TAttribute GetCustomAttribute<TAttribute>(PropertyInfo property)
            where TAttribute : Attribute =>
            property.GetCustomAttribute<TAttribute>();
    }
}
