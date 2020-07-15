using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UP_DOWN : MonoBehaviour
{
    private bool pressed, banUP = false, banDOWN=false;
    private int cont=0, op;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {
            if (banUP)
            {

                transform.Rotate(new Vector3(-5f, 0, 0));
                cont = cont + 5;
                if (cont == 90)
                {
                    pressed = false;
                    banUP = false;
                }
            }
            if (banDOWN)
            {
                transform.Rotate(new Vector3(5f,0,0));
                cont = cont - 5;
                if (cont == 0)
                {
                    pressed = false;
                    banDOWN = false;
                }
            }
        }
    }

    public void onPressUPDOWN()
    {
        pressed = true;
        if(cont == 0)
        {
            banUP = true;
        }
        if (cont == 90)
        {
            banDOWN = true;
        }
    }
}
