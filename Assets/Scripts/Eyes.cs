using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

    [SerializeField]
    private float zoomAmmount = 2;

    private Camera eyes;
    private float defaultZoom;
	
    
	void Start () {
        eyes = GetComponent<Camera>();
        defaultZoom = eyes.fieldOfView;
	}
    

    void Update()
    {
        if (Input.GetButtonDown("Zoom"))
        {
            eyes.fieldOfView = defaultZoom / zoomAmmount;
        }
        else if(Input.GetButtonUp("Zoom"))
        {
            eyes.fieldOfView = defaultZoom;
        }
    }
}
