using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkerscript : MonoBehaviour
{

    public Animator frogwalking;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("Vertical") || (Input.GetButton("Horizontal")))
        {
            frogwalking.SetBool("walking", true);
        }

        if (Input.GetButtonDown("Vertical") || (Input.GetButtonDown("Horizontal")))
        {
            frogwalking.SetBool("walking", true);
        }



        if ((!Input.GetButton("Vertical")) && (!Input.GetButton("Horizontal")))
        {
            frogwalking.SetBool("walking", false);
        }




    }
}
