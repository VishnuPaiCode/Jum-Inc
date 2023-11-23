using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class displaycoinstitlescreen : MonoBehaviour
{
    public GameObject coindisplayobject;
    // Start is called before the first frame update
    void Start()
    {
        TMP_Text coindisplay = coindisplayobject.GetComponent<TMP_Text>();
        coindisplay.text = ($"Coins: {createvariables.coins}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
