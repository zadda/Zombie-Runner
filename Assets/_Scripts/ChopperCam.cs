using UnityEngine;
using System.Collections;

public class ChopperCam : MonoBehaviour 
{
    [SerializeField]
    private Chopper chopper;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        transform.position = new Vector3(chopper.transform.position.x, 105f, chopper.transform.position.z);
	}
}