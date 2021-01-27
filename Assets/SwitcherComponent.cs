using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherComponent : MonoBehaviour
{
    public Animator kermit;
    public bool initialState = false;
    public GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SwitchAnimation()
    {
        if(initialState == true)
        {
            initialState = false;
        } 
        else
        {
            initialState = true;
        }
        kermit.SetBool("dancing", initialState);
    }

    public void ShowUI()
    {
        button.SetActive(true);
    }

    public void HideUI()
    {
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
