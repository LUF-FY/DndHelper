using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextArea : MonoBehaviour
{
    // Start is called before the first frame update
    [TextArea] public string Nam�;
    public Text nameBandit;
    void Start()
    {
        nameBandit=GetComponent<Text>();
        nameBandit.text = Nam�;
    }

    // Update is called once per frame
   
}
