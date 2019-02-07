using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class animation_die_btn : MonoBehaviour, IVirtualButtonEventHandler{

    public GameObject vBtnObj;
    public Animator animModel;

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        animModel.Play("die");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        animModel.Play("idle");
    }

    // Use this for initialization
    void Start()
    {
        vBtnObj = GameObject.Find("mybtn_die");
        vBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        animModel.GetComponentInChildren<Animator>();
        animModel.Play("idle");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
