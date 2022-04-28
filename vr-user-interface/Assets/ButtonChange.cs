
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChange : MonoBehaviour
{
    public Text buttonTitle;
    public bool toggleButton = true;
    /* Start is called before the first frame update
    void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    public void stuff()
    {
        toggleButton = !toggleButton;
        buttonTitle.gameObject.SetActive(toggleButton);
    }
}
