using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;


namespace Tests
{
    public class MerryTest
    {
		[OneTimeSetUp]
		public void LoadScene()
		{
			SceneManager.LoadScene("TestScene");
		}

		// tests frame rate with ~100 enemies, goal is at least 10 fps for 5 seconds
		[UnityTest]
		public IEnumerator MStressTest()
		{
			for (int i = 0; i < 10; i++)
			{
				yield return null;
			}
			for (int i = 0; i < 300; i++)
			{
				Assert.That(Time.deltaTime <= .1);
				yield return null;
			}
			for (int i = 0; i < 10; i++)
			{
				yield return null;
			}
		}

		// test enemy pathing, must make it within 5 units of player within 5 seconds
		[UnityTest]
		public IEnumerator MTest1()
		{
			for (int i = 0; i < 300; i++)
			{
				yield return null;
			}
			GameObject TEnemy = GameObject.Find("Enemy(Clone)");
			GameObject Player = GameObject.Find("Player(Clone)");
			Assert.That(Vector3.Distance(TEnemy.transform.position, Player.transform.position) <= 5);
			yield return null;
		}

		// test to make sure gun gets spawned when enemy instantiated (edit mode)
		// Couldn't get this to work.

		//public GameObject EnemyPrefab;
		//[Test]
		//public IEnumerator MTest2() {
		//	GameObject TEnemy = Instantiate(EnemyPrefab) as GameObject;
		//	Assert.That(TEnemy.getComponent<EnemyScript>().Weapon != null);
		//	yield return null;
		//}
	}
}

