using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class kontrol : MonoBehaviour
{
    public Image healthbar;
    public Text kalanSayiText;
    public int kalanSayiDeger;
    public Text NavMeshSayiText;
    public int NavMeshSayiDeger;
    public GameObject olusacakEngel;
    public GameObject NavMeshEngel;
    private float can;
    public GameObject[] engeller;
    //public GameObject[] NavMeshengeller;
    public Button[] butonlar;
    public Button[] NavMeshbutonlar;
    public GameObject gameoverpanel;
    
    
    void Start()
    {
        can = 100;
        kalanSayiDeger = 20;
        NavMeshSayiDeger = 5;
        kalanSayiText.text = kalanSayiDeger.ToString();
        NavMeshSayiText.text = NavMeshSayiDeger.ToString();
        // healthbar.fillAmount -= .1f;
    }
     void ButonlarinKontrolu()
    {
        if (kalanSayiDeger==0) 
        {
            foreach (var gelenler in butonlar) 
            { 
                gelenler.interactable = false;
            }
        }
    }
    void NavMeshButonlarinKontrolu()
    {
        if (NavMeshSayiDeger == 0)
        {
            foreach (var gelenler in NavMeshbutonlar)
            {
                gelenler.interactable = false;
            }
        }
    }
    public void CanDusur(float darbe)
    {
        can -= darbe;
        healthbar.fillAmount = can/100;
        CanKontrolEt();
    }

    void CanKontrolEt()
    {
        if(can<=0)
        {
            gameoverpanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void engelButonlari(int indisdeger)
    {
        kalanSayiDeger--;
        kalanSayiText.text = kalanSayiDeger.ToString();
       // engeller[indisdeger].GetComponent<MeshRenderer>().enabled = false;
        Instantiate(olusacakEngel, engeller[indisdeger].transform.position, Quaternion.identity);
        Debug.Log(indisdeger);
        ButonlarinKontrolu();
    }
    public void NavMeshButonlari(int indisdeger)
    {
        NavMeshSayiDeger--;
        NavMeshSayiText.text = NavMeshSayiDeger.ToString();
        // engeller[indisdeger].GetComponent<MeshRenderer>().enabled = false;
        Instantiate(NavMeshEngel, engeller[indisdeger].transform.position, Quaternion.identity);
        Debug.Log(indisdeger);
        NavMeshButonlarinKontrolu();
    }

}
