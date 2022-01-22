using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraAnimasyon : MonoBehaviour
{
    private Vector3 ilkPos;
    // Start is called before the first frame update
    void Start()
    {
        ilkPos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(ilkPos.x, ilkPos.y - 6f,ilkPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, ilkPos, 2f * Time.deltaTime);
    }
}
