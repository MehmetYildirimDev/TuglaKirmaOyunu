using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedalharaket : MonoBehaviour
{
    GameObject Top;
    // Start is called before the first frame update
    void Start()
    {
        Top = GameObject.Find("top");
    }

    // Update is called once per frame
    void Update()
    {

    Vector3 MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
        ///Faremizden ald���m�z de�erlieri sahnemize uyarl�yaca��z bunun i�in kullan�yruz bu fonksiyonu
        ///z de�erini 0 vermedi�imiz s�rece sorun yok(nedenini anlamad�m)
        ///her ne kadar 2d olsada 3d bi nokta olu�turuyoruz asl�nda hepsi 3d bi ortamda geli�tiriliyor 
      transform.position = new Vector3(MousePos.x, transform.position.y, transform.position.z);
        ///sadece x de�erini de�i�tirece�iz o y�zden 

     //   transform.position = new Vector3(Top.transform.position.x, transform.position.y, transform.position.z);


    }
}
