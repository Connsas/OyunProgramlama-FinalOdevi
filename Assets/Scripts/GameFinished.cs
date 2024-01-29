using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinished : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "finish")
        {
            SceneManager.LoadScene("GameEndScene", LoadSceneMode.Single);
        }

        if (collision.gameObject.tag == "Blockade")
        {
            SceneManager.LoadScene("FailedScene", LoadSceneMode.Single);
        }
    }
}
