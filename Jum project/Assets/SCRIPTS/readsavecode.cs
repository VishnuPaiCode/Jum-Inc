using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class readsavecode : MonoBehaviour
{
    public GameObject savecode;
   
    public void Readsavecode()
    {
        var savecodecomponent = savecode.GetComponent<TMP_InputField>();
        int lengthofcoins = savecodecomponent.text.IndexOf(";");
        createvariables.coins = int.Parse(savecodecomponent.text.Substring(0, lengthofcoins));
        SceneManager.LoadScene(1);
    }
}
