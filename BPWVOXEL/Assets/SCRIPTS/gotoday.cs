using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoday : MonoBehaviour
{

    public GameObject openText;




    public bool inReach;

    public Animator transistion;




    void Start()
    {
        inReach = false;

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
        }
    }





    void Update()
    {

        if (inReach && Input.GetButtonDown("Interact"))
        {
            StartCoroutine(NextScene());
        }



        IEnumerator NextScene()
        {
            transistion.SetTrigger("start");
            yield return new WaitForSeconds(1f);
            SceneManager.LoadScene("global");


        }

    }



}