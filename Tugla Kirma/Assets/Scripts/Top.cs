using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    private GameObject pedal;
    private bool OyunBasladi = false;

    // Start is called before the first frame update
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedalharaket>().gameObject;
        //Hangi oyun objemiz üzerinde Pedalharaket scripti varsa o objeyi buluyor

    }

    // Update is called once per frame
    void Update()
    {
        if (!OyunBasladi)
        {

        transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
            ///sadece x deðerini aldýgýmýza dikkat edelim 
            
        }
        if (Input.GetMouseButtonDown(0)&&!OyunBasladi)
        {
            OyunBasladi = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);  
        }

        

    }
}
