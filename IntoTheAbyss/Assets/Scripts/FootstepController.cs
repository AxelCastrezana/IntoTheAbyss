using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepController : MonoBehaviour
{
    public AudioClip footstepSound;
    public float footstepInterval = 0.5f; // Adjust this to control the time between footsteps

    private float nextFootstepTime;

    private void Update()
    {
        // Check if the character is moving and if it's time for another footstep
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            if (Time.time >= nextFootstepTime)
            {
                PlayFootstepSound();
                nextFootstepTime = Time.time + footstepInterval;
            }
        }
    }

    void PlayFootstepSound()
    {
        // Play the footstep sound
        if (footstepSound != null)
        {
            GetComponent<AudioSource>().PlayOneShot(footstepSound);
        }
    }
}

