using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedalharaket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    Vector3 MousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1f));
        ///Faremizden aldığımız değerlieri sahnemize uyarlıyacağız bunun için kullanıyruz bu fonksiyonu
        ///z değerini 0 vermediğimiz sürece sorun yok(nedenini anlamadım)
        ///her ne kadar 2d olsada 3d bi nokta oluşturuyoruz aslında hepsi 3d bi ortamda geliştiriliyor 
        transform.position = new Vector3(MousePos.x, transform.position.y, transform.position.z);
        ///sadece x değerini değiştireceğiz o yüzden 

        


    }
}
