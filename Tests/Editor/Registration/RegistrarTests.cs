using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using TravisRFrench.Common.Runtime.Registration;
using UnityEngine;

namespace TravisRFrench.Common.Tests.Editor.Registration
{
    [TestFixture]
    [Category(EditorTestCategories.UnitTests)]
    public class RegistrarTests
    {
        private IRegistrar<object> registrar;

        [SetUp]
        public void Setup()
        {
            this.registrar = new Registrar<object>();
        }
        
        #region Constructor
        [Test]
        public void GivenNewRegistrar_WhenConstructed_ItShouldNotHaveNullEntities()
        {
            // ARRANGE

            // ACT

            // ASSERT
            Assert.IsNotNull(this.registrar.Entities);
        }
        #endregion
        #region Register()
        [Test]
        [TestCaseSource(nameof(RegistrarTests.GetEntities))]
        public void GivenNewRegistrar_WhenEntityIsRegistered_ItShouldBeInEntitiesEnumerable(object entity)
        {
            // ARRANGE
            
            
            // ACT
            this.registrar.Register(entity);
            
            // ASSERT
            Assert.True(this.registrar.Entities.Contains(entity));
        }
        
        [Test]
        public void GivenNewRegistrar_WhenEntityIsRegisteredMultipleTimes_ItShouldBeInEntitiesEnumerableExactlyOnce()
        {
            // ARRANGE
            var entity = "foo";
            
            // ACT
            this.registrar.Register(entity);
            this.registrar.Register(entity);
            
            // ASSERT
            var count = this.registrar.Entities.Count(e => e.Equals(entity));
            var message = $"Entity was found {count} times.";
            Assert.True(count == 1, message);
        }

        [Test]
        public void GivenNewRegistrar_WhenNullEntityIsRegistered_ItShouldThrowAnArgumentNullException()
        {
            // ARRANGE
            
            
            // ACT
            void Callback()
            {
                this.registrar.Register(null);
            }
            
            // ASSERT
            Assert.Throws<ArgumentNullException>(Callback);
        }
        #endregion
        #region Deregister()
        [Test]
        [TestCaseSource(nameof(RegistrarTests.GetEntities))]
        public void GivenRegistrarContainingEntity_WhenEntityIsDeregistered_ItShouldNotBeInEntitiesEnumerable(object entity)
        {
            // ARRANGE
            this.registrar.Register(entity);
            
            // ACT
            this.registrar.Deregister(entity);
            
            // ASSERT
            Assert.False(this.registrar.Entities.Contains(entity));
        }

        [Test]
        public void GivenNewRegistrar_WhenNullEntityIsDeregistered_ItShouldThrowAnArgumentNullException()
        {
            // ARRANGE
            
            
            // ACT
            void Callback()
            {
                this.registrar.Deregister(null);
            }
            
            // ASSERT
            Assert.Throws<ArgumentNullException>(Callback);
        }
        #endregion
        
        private static IEnumerable<object> GetEntities()
        {
            return new object[]
            {
                new(),
                "foo",
                12,
                new UnityEngine.GameObject(),
                new Vector3(12, 15),
                new Tuple<string, string>("foo", "bar"),
            };
        }
    }
}
