using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Chopper : MonoBehaviour 
{

    //call chopter code
   
    private float timeInbound = 300;
    [SerializeField]
    private Text textInbound;

    private Animator anim;
    private Rigidbody rigidBody;

    private int countHeliCalls = 0;

    // Use this for initialization
    void Start () 
	{
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (countHeliCalls == 1)
        {
            timeInbound -= Time.deltaTime;
            textInbound.text = timeInbound.ToString("0");
        }
    }

   

   public void ChopperCalled()
    {
        countHeliCalls++;

        if (countHeliCalls == 1)
        {
            //Debug.Log("Chopper called");
            rigidBody.velocity = new Vector3(0, 0, 50f);
            //a few hours later, I found Vector3.MoveTowards(start, end, speed)..
        }

    }
}