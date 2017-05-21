using UnityEngine;
using System.Collections;
using System;

namespace Arkanoid
{
    public class Block : MonoBehaviour
    {

        public int hitsToDestroy;
        private int numberOfHits;

        void Start()
        {
            numberOfHits = 0;
        }

        void Update()
        {

        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Ball")
            {
                numberOfHits++;

                if (numberOfHits == hitsToDestroy)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }
}