using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Trail : MonoBehaviour
{
    // [SerializeField] ParticleSystem trailparticles;
    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.tag == "Ground")
    //     {
    //         // Debug.Log("You Finished");

    //         trailparticles.Play();

    //     }

    // }

    // void OnCollisionExit2D(Collision2D other)
    // {
    //     trailparticles.Stop();
    // }



//code for particles to play if it touches the ground
    [SerializeField] ParticleSystem trailparticles;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            // Debug.Log("You Finished");

            trailparticles.Play();
            // Debug.Log("Touching Ground");

        }

    }

    void OnCollisionExit2D(Collision2D other)
    {
        trailparticles.Stop();
        // Debug.Log("not touching ground");
    }

}




