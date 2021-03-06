using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public GameObject kirilmaEfekti;
    public AudioClip[] SesEfekti;
    public static int ToplanTuglaSayisi;
    public Sprite[] tuglaSprites;
    private int maxCarpmaSayisi;
    private int CarpmaSayisi=0;
    private Puan puanScript;
    // Start is called before the first frame update
    void Start()
    {
        maxCarpmaSayisi = tuglaSprites.Length+1;//+1 sebebi 0 sprite olan?n 1 o y?zden 
        ToplanTuglaSayisi++;//Her script ?al??t?r?l?rken say?m?z? art?r?yoruz ki ka? tane tugla var ??renelim
        puanScript = GameObject.FindObjectOfType<Puan>().GetComponent<Puan>();//?zerinde Puan scripti bulunan objenin puan scriptini e?itle diyoruz
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
            ///neden direk e?itlemiyoruz ?- ielrde gelecen ?zeliklerde mesala top say?s? artabilir o zaman daha b?y?k olabilir
            if (CarpmaSayisi>=maxCarpmaSayisi)                
            {
                Vector3 pos = diger.contacts[0].point;///burada ilk ?arpma noktas?n? al?yoruz
                GameObject go = Instantiate(kirilmaEfekti, pos, Quaternion.identity) as GameObject;
                Color TuglaRengi = GetComponent<SpriteRenderer>().color;
                go.GetComponent<ParticleSystemRenderer>().material.color = TuglaRengi;
                Destroy(go, 1f);

                ToplanTuglaSayisi--;
                //               Debug.Log(ToplanTuglaSayisi.ToString());
                puanScript.puanArtir();
                if (ToplanTuglaSayisi<=0)
                {
                    GameObject.FindObjectOfType<OyunKontrol>().GetComponent<OyunKontrol>().BirSonrakiSahne();
                    //OyunKontrol scriptinin ba?l? oldugu objeyi bul ve OyunKontrol compenentindeki fonksiyonu bul
                    
                }
                AudioSource.PlayClipAtPoint(SesEfekti[1], transform.position);
                Destroy(this.gameObject);
            }
            else
            {
                AudioSource.PlayClipAtPoint(SesEfekti[0], transform.position);
                GetComponent<SpriteRenderer>().sprite = tuglaSprites[CarpmaSayisi - 1];
            }
        }

    }
}
