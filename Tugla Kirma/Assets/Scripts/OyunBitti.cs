using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunBitti : MonoBehaviour
{
    public Text Puan;
    private Puan PuanScript;
    // Start is called before the first frame update
    void Start()
    {


        PuanScript = GameObject.FindObjectOfType<Puan>();
        Puan.text = "Puaniniz: " + PuanScript.GetComponent<Puan>().puanAl();
       

        ///Yerine -- audio source ulaþmak içn alttakini off yaptýk

///      Puan.text = "Puaniniz: " + GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().puanAl();

    }

    public void AnaSahneyeGec()
    {
        SceneManager.LoadScene(0);
    }
}
