using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCarControlScript : MonoBehaviour
{
        bool fail = false;
        bool start = false;

        private Rigidbody truckRigidbody;
        public AudioSource AudioSourceSiren;
        public AudioSource AudioSourceEngine;
        public GameObject HowToPlay;
        public GameObject ScoreBoard;

        public float speed = 10.0f;

        void Start()
        {
            HowToPlay = GameObject.Find("HowToPlay");
            ScoreBoard = GameObject.Find("ScoreBoard");
            ScoreBoard.SetActive(false);
            truckRigidbody = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKey(KeyCode.W) || start == true)
            {
                ScoreBoard.SetActive(true);
                HowToPlay.SetActive(false);
                start = true;
                truckRigidbody.velocity = Vector3.left * speed;
                AudioSourceSiren.mute = false;
                AudioSourceEngine.mute = true;
            }

            //if (Input.GetKey(KeyCode.Escape))
            //{
            //    SceneManager.LoadScene("GameMenu");
            //}




            if (Input.GetKey(KeyCode.D) && transform.position.z < -1.0)

            {
                transform.Translate(10 * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.A) && transform.position.z > -15.0)

            {
                transform.Translate(-10 * Time.deltaTime, 0, 0);
            }
        }

        //private void OnCollisionEnter(Collision collision)
        //{
        //    if (collision.transform.tag == "Engel")
        //    {
        //        Invoke("restart", 1f);
        //        fail = true;
        //    }
        //}



        //private void restart()
        //{
        //    SceneManager.LoadScene("RetryMenu");
        //    fail = false;
        //}
}
