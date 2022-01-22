using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    private int _puan=0;
    // Start is called before the first frame update
   public void puanArtir()
    {
        _puan++;
    }
    public int puanAl()
    {
        return _puan; 
    }
    public void puanSifirla()
    {
        _puan = 0;
    }
}
