using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnobControl : MonoBehaviour
{
    public GameObject Knob1;
    public GameObject Knob2;
    public GameObject Knob3;
    public GameObject Knob4;

    public SpriteRenderer K1;
    public SpriteRenderer K2;
    public SpriteRenderer K3;
    public SpriteRenderer K4;

    private bool Knob1Held;
    private bool Knob2Held;
    private bool Knob3Held;
    private bool Knob4Held;

    private bool Knob1Position;
    private bool Knob2Position;
    private bool Knob3Position;
    private bool Knob4Position;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Manage Knob Inputs
        if (Input.GetButton("Knob1"))
        {
            Knob1Held = true;
            K1.color = Color.red;
        }
        else
        {
            Knob1Held = false;
            K1.color = Color.white;
        }

        if (Input.GetButton("Knob2"))
        {
            Knob2Held = true;
            K2.color = Color.red;
        }
        else
        {
            Knob2Held = false;
            K2.color = Color.white;
        }

        if (Input.GetButton("Knob3"))
        {
            Knob3Held = true;
            K3.color = Color.red;
        }
        else
        {
            Knob3Held = false;
            K3.color = Color.white;
        }

        if (Input.GetButton("Knob4"))
        {
            Knob4Held = true;
            K4.color = Color.red;
        }
        else
        {
            Knob4Held = false;
            K4.color = Color.white;
        }

        //Track Switching Inputs
        if (Input.GetButton("Left"))
        {
            if (Knob1Held)
            {
                Knob1.transform.position = new Vector3(-3.38f, Knob1.transform.position.y, 0);
            }
            if (Knob2Held)
            {
                Knob2.transform.position = new Vector3(-1.4f, Knob2.transform.position.y, 0);
            }
            if (Knob3Held)
            {
                Knob3.transform.position = new Vector3(.56f, Knob3.transform.position.y, 0);
            }
            if (Knob4Held)
            {
                Knob4.transform.position = new Vector3(2.54f, Knob4.transform.position.y, 0);
            }
        }
        if (Input.GetButton("Right"))
        {
            if (Knob1Held)
            {
                Knob1.transform.position = new Vector3(-2.74f, Knob1.transform.position.y, 0);
            }
            if (Knob2Held)
            {
                Knob2.transform.position = new Vector3(-0.76f, Knob2.transform.position.y, 0);
            }
            if (Knob3Held)
            {
                Knob3.transform.position = new Vector3(1.2f, Knob3.transform.position.y, 0);
            }
            if (Knob4Held)
            {
                Knob4.transform.position = new Vector3(3.2f, Knob4.transform.position.y, 0);
            }
        }

        //Update Knob Position

    }
}
