﻿using System.Reflection;

namespace Better.Internal.Core.Runtime
{
    public class Defines
    {
        public const string Editor = "UNITY_EDITOR";
        public const BindingFlags MethodFlags = BindingFlags.Public | BindingFlags.NonPublic |
                                                BindingFlags.Static | BindingFlags.Instance |
                                                BindingFlags.DeclaredOnly;

        public const BindingFlags FieldsFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;
        
        public const BindingFlags ConstructorFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
    }
}