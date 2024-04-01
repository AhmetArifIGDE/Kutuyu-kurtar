using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class olusacakobje : MonoBehaviour
{
    // Start is called before the first frame update
    private int carpmasayisi = 1;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ajan"))
        {
            if (carpmasayisi != 0)
            {
                carpmasayisi--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
    }

}
