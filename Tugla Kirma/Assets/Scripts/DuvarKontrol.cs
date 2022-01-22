using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarKontrol : MonoBehaviour
{ 
    public GameObject carpma;
    public AudioClip SesEfekti;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D diger)
    {
        AudioSource.PlayClipAtPoint(SesEfekti, transform.position);
        Vector3 pos = diger.contacts[0].point;///burada ilk çarpma noktasýný alýyoruz
        GameObject go = Instantiate(carpma,pos,Quaternion.identity)as GameObject;
        Destroy(go, 1f);
    }
}
