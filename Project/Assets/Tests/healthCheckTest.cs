using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
namespace Tests
{
    public class healthCheckTest : MonoBehaviour
    {
        [Test]
        public void healthNegativeValueException()
        {
            var healthy = new GameObject().AddComponent<health>();
            Assert.Throws<ArgumentOutOfRangeException>(() => healthy.TakeDamage(10));
        }

        [Test]
        public void healthNegativeValueExceptionTwo()
        {
            var healthy = new GameObject().AddComponent<health>();
            Assert.Throws<ArgumentOutOfRangeException>(() => healthy.TakeDamage(-10));
        }
    }
}
