using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayMode1
    {
        // A Test behaves as an ordinary method
        [Test]
        public void FastTest()
        {
            // Use the Assert class to test conditions
            Debug.Log("FastTest!");
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator SlowTest()
        {
            int count = 0;
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            for (int i = 0; i < 1000; i++)
            {
                Assert.IsTrue(true, "True");
                count++;
                
                yield return null;
            }

            Debug.Log($"Ran {count} iters");
        }
    }
}
