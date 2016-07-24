using UnityEngine;
using System.Collections;

public class DayCycle : MonoBehaviour 
{
    [SerializeField]
    private float timeScale = 60f;
    [SerializeField]
    private Light directionalLight;

    //private Quaternion startRotation;


	// Use this for initialization
	void Start () 
	{
   
	}
	
    void ChangeLight()
    {
    }

    void Update()
    {
        if (timeScale >= 0)
        {
            directionalLight.intensity -= 0.00020f; // verander licht sterkte duurt ongeveer 1 minuut
            timeScale -= Time.deltaTime;
        }
    }
}