using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerView : MonoBehaviour 
{
    private Camera playerCamera;
    private float defaultFOV;
    
    //private Player player;



    // Use this for initialization
    void Start () 
	{
        playerCamera = GetComponent<Camera>();
        defaultFOV = playerCamera.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetButton("Zoom")) // zolang knop is ingedrukt
        {
            playerCamera.fieldOfView = defaultFOV / 1.5f;//30f; //defaultFOV * 0.015f;
        }
        else
        {
           playerCamera.fieldOfView = defaultFOV;
        }

       
	}
}