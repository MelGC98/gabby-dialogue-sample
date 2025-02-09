using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamillaFootstepSound : MonoBehaviour
{

    public AudioSource
    camillaFootstepAudioSource;

    public AudioClip
    camillaFootstepAudioClip;

    public void PlayCamillaFootstepSound()
    {
        if (camillaFootstepAudioSource != null && camillaFootstepAudioClip != null)
            {
                camillaFootstepAudioSource.PlayOneShot(camillaFootstepAudioClip);
            }
        else
        {
            Debug.LogWarning("Camilla footstep audio source or clip missing");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
