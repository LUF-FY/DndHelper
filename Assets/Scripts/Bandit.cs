using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class Bandit : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Ýðèê ÏÈÄÎÐ")]
    public GameObject sv;
    public Button button;
    void Start()
    {
         //bandit = GameObject.Find("Bandit");
         //bandit = GameObject.Find("Bandit");
         

    }

   

    public void OnClick()
    {
        Debug.Log(button.name);
        if (sv.activeSelf)
            sv.SetActive(false);
        else
            sv.SetActive(true);    
    
        
    }
}
