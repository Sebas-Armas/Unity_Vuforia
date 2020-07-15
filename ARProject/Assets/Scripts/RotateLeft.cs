using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RotateLeft : MonoBehaviour
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
            transform.Rotate(new Vector3(0, 0, 5.0f));
            
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

    

/*

public void TogglePressed(bool value)
    {
        ispressed = value;
        if (ispressed)
        {
            transform.Rotate(new Vector3(0, 0, 5.0f));

            // DO SOMETHING HERE
            Debug.Log("Pressed Left");
        }
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
    */
}
