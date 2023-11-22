
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.io;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    public Inputfield username;
    public Inputfield password;
    public Button registerButton;
    public Button goTologInButton;

    Arraylist credentials;


    // Start is called before the first frame update
    void Start()
    {
        credentials = new Arraylist(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
