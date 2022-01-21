using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AltDuvar : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D diger)
    {
        if (diger.gameObject.name.Equals("top"))
        {
            SceneManager.LoadScene("Kaybettiniz");
        }
    }
}
