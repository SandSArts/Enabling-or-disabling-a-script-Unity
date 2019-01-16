//Programmed by Shashank.S - creator of SandS Arts , Mail me at sandsarts.developer@gmail.com
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabling_or_Disabling_a_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       this.GetComponent<ScriptName>().enabled=false;    //disables a script attached to this object
       this.GetComponent<ScriptName>().enabled=true;     //enables a script attached to this object
       this.GetComponent<BoxCollider>().enabled=false;   //disables a box collider attached to this object
       this.enabled=false;                               //disables this script 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
