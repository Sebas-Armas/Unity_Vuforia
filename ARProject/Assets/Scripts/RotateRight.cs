using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotateRight : MonoBehaviour
{

    private bool ispressed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ispressed)
        {
            transform.Rotate(new Vector3(0, 0, -5.0f));

            
        }


    }

    public void onPress()
    {
        ispressed = true;
    }

    public void onRelease()
    {
        ispressed = false;
    }

}
