using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{

    [SerializeField]
    public AudioClip callSound;

    private bool called = false;

    void Update()
    {
        if (Input.GetButtonDown("CallHeli"))
        {
            called = true;
            // Play a sound.
        }
    }

    // Instantiate Heli
    
}
