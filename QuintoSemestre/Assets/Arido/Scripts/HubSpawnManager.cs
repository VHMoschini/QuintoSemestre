﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubSpawnManager : MonoBehaviour
{
    public static string TUTORIALKEY = "TUTORIALKEY";
    public static string ISLAMICOKEY = "ISLAMICOKEY";
    public static string CRISTAOKEY = "CRISTAOKEY";
    public static string HINDUKEY = "HINDUKEY";

    public static string BANCOKEY = "SPAWN";

    //public Transform tutorial, islamico, hindu, cristao;

    bool check = true;

        public static HubSpawnManager Instance;

        void Awake()
        {
        atual = tutorial;

        if (Instance == null)
            {
                DontDestroyOnLoad(gameObject);
                Instance = this;
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
            }
        }

    public static Vector3 tutorial = new Vector3(2.98f,4.08f,-32.03f);
    public static Vector3 islamismo = new Vector3(-30.93f, 18.5f, 0f);
    public static Vector3 cristao = new Vector3(3.6f, 18.5f, 34.8f);

    public static Vector3 atual;



    /*private void Start()
    {
        //PlayerPrefs.SetString(BANCOKEY, TUTORIALKEY);

        Debug.Log(PlayerPrefs.GetString(BANCOKEY));

        //PlayerPrefs.Save();

    }
    private void Update()
    {
        if (check)
        {
            if (PlayerPrefs.GetString(BANCOKEY) == TUTORIALKEY)
            {
                transform.position = tutorial.position;
                if (transform.position == tutorial.position)
                    check = false;
            }
            else
           if (PlayerPrefs.GetString(BANCOKEY) == ISLAMICOKEY)
            {
                Debug.Log("Aqui");
                transform.position = islamico.position;
                if(transform.position == islamico.position)
                check = false;

            }
            else
           if (PlayerPrefs.GetString(BANCOKEY) == CRISTAOKEY)
            {
                transform.position = cristao.position;
                check = false;

            }
            else
           if (PlayerPrefs.GetString(BANCOKEY) == HINDUKEY)
            {
                transform.position = hindu.position;
                check = false;

            }



        }
    }*/
}
