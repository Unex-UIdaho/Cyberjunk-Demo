using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class HazardAnimationTest
    {
        // A Test behaves as an ordinary method
        [OneTimeSetUp]
        public void LoadScene()
        {
            SceneManager.LoadScene("TestScene");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator ManyExplosionTestFPS()
        {
            //FPS Check With many barrels, put them all next to eachother 6 seconds to complete.
            yield return 10;
            for (int i = 0; i < 360; i++)
            {
                Assert.That(Time.deltaTime <= .1);
                yield return null;
            }
        }
       // [UnityTest]

        //public IEnumerator AnimationSpawn()
        //{
          //  for (int i = 0; i < 300; i++)
           // {
             //   yield return null;
             //   GameObject explosion = GameObject.FindGameObjectWithTag("Hazard");

              //  Assert.IsNull(explosion);
           // }
       // }
    }
}
