using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ajanlar : MonoBehaviour
{

    NavMeshAgent agent;
    public GameObject hedef;
    public string ajanturu;
    private int carpmasayisi;
    private float darbeGucu;
    public GameObject kontrol;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   
        agent.SetDestination(hedef.transform.position);

        switch (ajanturu)
        {
            case "mavi":
                carpmasayisi = 5;
                darbeGucu = 8f;
               
                break;

            case "sari":
                carpmasayisi= 3;
                darbeGucu = 10f;
                break;
            
            case "yesil":
                carpmasayisi = 1;
                darbeGucu = 15f;
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(hedef.transform.position);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
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
        if (other.gameObject.CompareTag("anahedef"))
        {
            kontrol.GetComponent<kontrol>().CanDusur(darbeGucu);
                Destroy(gameObject);
            
        }
    }

}
