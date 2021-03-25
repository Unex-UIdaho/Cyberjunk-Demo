using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class KOPlay
    {
        // A Test behaves as an ordinary method
        [OneTimeSetUp]
        public void LoadScene()
        {
            // Use the Assert class to test conditions
            SceneManager.LoadScene("TestScene");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator GunsLoad()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return 50;
            GameObject gun = GameObject.FindWithTag("Weapon");
            Assert.True(gun.activeInHierarchy);
        }
    }
}
