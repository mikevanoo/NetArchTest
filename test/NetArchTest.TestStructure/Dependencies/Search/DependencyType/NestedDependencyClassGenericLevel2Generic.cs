﻿namespace NetArchTest.TestStructure.Dependencies.Search.DependencyType
{
    using NetArchTest.TestStructure.Dependencies.Examples;

    /// <summary>
    /// Example class that includes a dependency in a nested class from difrent class.    
    /// </summary>
    public class NestedDependencyClassGenericLevel2Generic
    {
        private void ExampleMethod()
        {
#pragma warning disable 219
            NestedDependencyTree.NestedLevel1.NestedLevel2<int>.NestedDependency<int> foo = null;
#pragma warning restore 219
        }
    }    
}