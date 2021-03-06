﻿using System;
using Ploeh.AutoFixture.Kernel;
using Xunit;

namespace Ploeh.AutoFixtureUnitTest.Kernel
{
    public class NoSpecimenTest
    {
        [Fact]
        public void DefaultConstructorWillSetRequestToNull()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            // Exercise system
            var result = sut.Request;
            // Verify outcome
            Assert.Null(result);
            // Teardown
        }

        [Fact]
        public void CreateWithNullRequestWillSetCorrectRequest()
        {
            // Fixture setup
            // Exercise system
            var sut = new NoSpecimen(null);
            // Verify outcome
            Assert.Null(sut.Request);
            // Teardown
        }

        [Fact]
        public void RequestWillMatchContructorArgument()
        {
            // Fixture setup
            var expectedRequest = new object();
            var sut = new NoSpecimen(expectedRequest);
            // Exercise system
            var result = sut.Request;
            // Verify outcome
            Assert.Equal(expectedRequest, result);
            // Teardown
        }

        [Fact]
        public void SutIsEquatable()
        {
            // Fixture setup
            // Exercise system
            var sut = new NoSpecimen();
            // Verify outcome
            Assert.IsAssignableFrom<IEquatable<NoSpecimen>>(sut);
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualNullObject()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            object other = null;
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualNullSut()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            NoSpecimen other = null;
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualAnonymousObject()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            var anonymousObject = new object();
            // Exercise system
            var result = sut.Equals(anonymousObject);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualOtherObjectWhenSutRequestIsNull()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            object other = new NoSpecimen(new object());
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualOtherSutWhenSutRequestIsNull()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            var other = new NoSpecimen(new object());
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualOtherObjectWhenOtherRequestIsNull()
        {
            // Fixture setup
            var sut = new NoSpecimen(new object());
            object other = new NoSpecimen();
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualOtherSutWhenOtherRequestIsNull()
        {
            // Fixture setup
            var sut = new NoSpecimen(new object());
            var other = new NoSpecimen();
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualOtherObjectWhenRequestsDiffer()
        {
            // Fixture setup
            var sut = new NoSpecimen(new object());
            object other = new NoSpecimen(new object());
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutDoesNotEqualOtherSutWhenRequestsDiffer()
        {
            // Fixture setup
            var sut = new NoSpecimen(new object());
            var other = new NoSpecimen(new object());
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.False(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutEqualsOtherObjectWhenBothRequestsAreNull()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            object other = new NoSpecimen();
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.True(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutEqualsOtherSutWhenBothRequestsAreNull()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            var other = new NoSpecimen();
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.True(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutEqualsOtherObjectWhenRequestsAreEqual()
        {
            // Fixture setup
            var request = new object();
            var sut = new NoSpecimen(request);
            object other = new NoSpecimen(request);
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.True(result, "Equals");
            // Teardown
        }

        [Fact]
        public void SutEqualsOtherSutWhenRequestsAreEqual()
        {
            // Fixture setup
            var request = new object();
            var sut = new NoSpecimen(request);
            var other = new NoSpecimen(request);
            // Exercise system
            var result = sut.Equals(other);
            // Verify outcome
            Assert.True(result, "Equals");
            // Teardown
        }

        [Fact]
        public void GetHashCodeWhenRequestIsNullWillReturnCorrectResult()
        {
            // Fixture setup
            var sut = new NoSpecimen();
            // Exercise system
            var result = sut.GetHashCode();
            // Verify outcome
            Assert.Equal(0, result);
            // Teardown
        }

        [Fact]
        public void GetHashCodeWhenRequestIsNotNullWillReturnCorrectResult()
        {
            // Fixture setup
            var request = new object();
            var sut = new NoSpecimen(request);
            // Exercise system
            var result = sut.GetHashCode();
            // Verify outcome
            var expectedHashCode = request.GetHashCode();
            Assert.Equal(expectedHashCode, result);
            // Teardown
        }
    }
}
