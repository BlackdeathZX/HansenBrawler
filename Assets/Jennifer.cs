using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jennifer : Player
{
    //field 
    public Foot leftFoot;
    public Foot rightFoot;
    public Hand leftHand;
    public Hand rightHand;
    public Body mainbody;
    
    // Start is called before the first frame update

    public Jennifer(){




    }
    void Start()
    {
        
    }

    //update method 
    // bind animation trigger
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            kick();
        }
    }
    //animation method
    public void kick(){
        Animator anim = GetComponent<Animator>();
        // stop the current animation
        anim.SetTrigger("kick");
    }
}
