using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.ParticleSystemJobs;

public class finishline : MonoBehaviour
{
    [SerializeField] float Delay = 1f;
    [SerializeField] ParticleSystem particles;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // Debug.Log("You Finished");
            Invoke("ReloadScene", Delay);
            particles.Play();

        }

    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }

}
