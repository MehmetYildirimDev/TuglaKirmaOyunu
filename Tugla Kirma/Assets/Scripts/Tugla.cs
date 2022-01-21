using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public static int ToplanTuglaSayisi;
    public Sprite[] tuglaSprites;
    private int maxCarpmaSayisi;
    private int CarpmaSayisi=0;
    // Start is called before the first frame update
    void Start()
    {
        maxCarpmaSayisi = tuglaSprites.Length+1;//+1 sebebi 0 sprite olanýn 1 o yüzden 
        ToplanTuglaSayisi++;//Her script çalýþtýrýlýrken sayýmýzý artýrýyoruz ki kaç tane tugla var öðrenelim
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D diger)  
    {
        if (diger.gameObject.name.Equals("top"))
        {
           
            CarpmaSayisi++;
            ///neden direk eþitlemiyoruz ?- ielrde gelecen özeliklerde mesala top sayýsý artabilir o zaman daha büyük olabilir
            if (CarpmaSayisi>=maxCarpmaSayisi)                
            {
                ToplanTuglaSayisi--;
                Debug.Log(ToplanTuglaSayisi.ToString());
                if (ToplanTuglaSayisi<=0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                    //OyunKontrol scriptinin baðlý oldugu objeyi bul ve OyunKontrol compenentindeki fonksiyonu bul
                    
                }
                Destroy(this.gameObject);
            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = tuglaSprites[CarpmaSayisi - 1];
            }
        }

    }
}
