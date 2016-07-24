using UnityEngine;
using System.Collections;

public class LandingAreaCheck : MonoBehaviour
{
    public static bool clearToLand = false;
   

    [SerializeField]
    private Chopper chopper;
    

  
    private float timeSinceLastTrigger = 0f;

    private int counter = 0;
    


  


    void Update()
    {
        timeSinceLastTrigger += Time.deltaTime; // when colliding with something time ++
        if (timeSinceLastTrigger > 1f)
        {
            if (counter == 0)   //make sure only one call to function
            {
                counter++;
                SendMessageUpwards("OnFindClearArea");
                chopper.ChopperCalled();
                
            }
            
        }
    }


    public void OnTriggerStay(Collider other)
    {
        timeSinceLastTrigger = 0f;
    }
}