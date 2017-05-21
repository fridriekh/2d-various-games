using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Arkanoid
{
    public class LevelController : MonoBehaviour
    {

        public static LevelController Instance { get; protected set; }
        public GameObject brick;

        // Use this for initialization
        void Start()
        {
            if (Instance != null)
            {
                Debug.LogError("Две копии WorldController");
            }
            Instance = this;

            for (int x = 0; x < 16; x += 2)
            {
                for (int y = 0; y < 10; y++)
                {
                    Instantiate(brick, new Vector3(x, y + 1, 0), Quaternion.identity).transform.parent = this.transform;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}