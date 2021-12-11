using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.position = spawnPoint.position;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
