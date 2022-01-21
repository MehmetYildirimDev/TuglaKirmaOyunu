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
        maxCarpmaSayisi = tuglaSprites.Length+1;//+1 sebebi 0 sprite olan�n 1 o y�zden 
        ToplanTuglaSayisi++;//Her script �al��t�r�l�rken say�m�z� art�r�yoruz ki ka� tane tugla var ��renelim
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
            ///neden direk e�itlemiyoruz ?- ielrde gelecen �zeliklerde mesala top say�s� artabilir o zaman daha b�y�k olabilir
            if (CarpmaSayisi>=maxCarpmaSayisi)                
            {
                ToplanTuglaSayisi--;
                Debug.Log(ToplanTuglaSayisi.ToString());
                if (ToplanTuglaSayisi<=0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                    //OyunKontrol scriptinin ba�l� oldugu objeyi bul ve OyunKontrol compenentindeki fonksiyonu bul
                    
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
