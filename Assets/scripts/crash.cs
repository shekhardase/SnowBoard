using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crash : MonoBehaviour
{
    [SerializeField] float laudu = 1f;
    [SerializeField] ParticleSystem particles; 
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="ground")
        {
            FindObjectOfType<PlayerControl>().DisabledControl();
            // Debug.Log("Hit my Head");
            Invoke("Reload" , laudu);
            particles.Play();
        }
    }

    void Reload()
    {
        SceneManager.LoadScene(0);
    }

}
