using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class SFUnitTests
    {
        public float testDamage;
        [Test]
        public void GivenDamage()
        {
            var go = new GameObject();
            go.AddComponent<BarrelScript>();
            testDamage = go.GetComponent<BarrelScript>().barrelDamage;
            // Debug.Log("Damage:" + testDamage);
            Assert.IsNotNull(testDamage);
        }
    }
}