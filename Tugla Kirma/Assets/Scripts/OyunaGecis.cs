using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunaGecis : MonoBehaviour
{
    // Start is called before the first frame update
  public void SahneGecis()
    {   ///static deðiþken kullandýgýmýz içib buradan sýfýrladýk
        Tugla.ToplanTuglaSayisi = 0;
        GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().puanSifirla();
        SceneManager.LoadScene("Bolum1");
    }
}
