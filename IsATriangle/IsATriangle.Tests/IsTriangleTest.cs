// <copyright file="IsTriangleTest.cs">Copyright ©  2016</copyright>

using System;
using IsATriangle;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IsATriangle.Tests
{
    [TestClass]
    [PexClass(typeof(IsTriangle))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsTriangleTest
    {

        [PexMethod]
        public IsTriangle.TriangleType IsATiangle(
            int a,
            int b,
            int c
        )
        {
            IsTriangle.TriangleType result = IsTriangle.IsATiangle(a, b, c);
            return result;
            // TODO: add assertions to method IsTriangleTest.IsATiangle(Int32, Int32, Int32)
        }
    }
}
