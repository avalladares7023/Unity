using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour
{
    public GameObject vbButtonObject;
    public GameObject spaceship;

    // Start is called before the first frame update
    void Start()
    {
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(Pressed);
        vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(Released);
    }

    public void Pressed (VirtualButtonBehaviour vb)
    {
        Debug.Log("Button Down");
        spaceship.GetComponent<Animator>().SetBool("begin", true);
    }

    public void Released (VirtualButtonBehaviour vb)
    {
        spaceship.GetComponent<Animator>().SetBool("begin", false);
    }
}
