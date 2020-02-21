using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Vertical") > 0 ){
        transform.rotation = Quaternion.Euler(0, 0, 90*Input.GetAxis("Horizontal")+180*Input.GetAxis("Vertical"));;
        }
        //switch
        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
