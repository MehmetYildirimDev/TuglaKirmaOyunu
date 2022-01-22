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
        ///Faremizden aldýðýmýz deðerlieri sahnemize uyarlýyacaðýz bunun için kullanýyruz bu fonksiyonu
        ///z deðerini 0 vermediðimiz sürece sorun yok(nedenini anlamadým)
        ///her ne kadar 2d olsada 3d bi nokta oluþturuyoruz aslýnda hepsi 3d bi ortamda geliþtiriliyor 
      transform.position = new Vector3(MousePos.x, transform.position.y, transform.position.z);
        ///sadece x deðerini deðiþtireceðiz o yüzden 

     //   transform.position = new Vector3(Top.transform.position.x, transform.position.y, transform.position.z);


    }
}
