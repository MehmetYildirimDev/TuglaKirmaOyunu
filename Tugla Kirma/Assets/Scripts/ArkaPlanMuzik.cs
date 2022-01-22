using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaPlanMuzik : MonoBehaviour
{
    static bool SahnedeMuzikVar = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!SahnedeMuzikVar)
        {
            SahnedeMuzikVar = true;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        //sahneler arasý geçiþte bu objeyi yok etme diyoruz
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
