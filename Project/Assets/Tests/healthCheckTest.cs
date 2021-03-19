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
            var health = new GameObject().AddComponent<health>();
            Assert.Throws<ArgumentOutOfRangeException>(() => health.DealDamage(new DamageData(-10, null, null)));
        }

        [Test]
        public void healthNegativeValueExceptionTwo()
        {
            var health = new GameObject().AddComponent<health>();
            Assert.Throws<ArgumentOutOfRangeException>(() => health.Heal(-10));
        }
    }
}
