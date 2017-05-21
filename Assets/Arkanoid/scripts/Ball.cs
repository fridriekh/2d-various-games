using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace Arkanoid
{
    public class Ball : MonoBehaviour
    {
        // Movement Speed
        private bool isLaunched = false;

        // Use this for initialization
        void Start()
        {
            
        }

        private void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (!isLaunched)
                {
                    isLaunched = true;
                    transform.parent = null;
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(100.0f, 500.0f));
                }
            }
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Floor")
            {
                SceneManager.LoadScene("arkanoid_test");
            }
        }
    }
}