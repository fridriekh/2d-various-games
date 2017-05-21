using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Arkanoid
{
    public class Player : MonoBehaviour
    {
        public float speed;
        public GameObject ball;
        // Use this for initialization
        void Start()
        {
            Instantiate(ball, new Vector3(transform.position.x, transform.position.y+1, 0), Quaternion.identity).transform.parent = this.transform;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move * speed * Time.deltaTime;
        }
    }
}