﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{



	void Start ()
    {
	
        

	}

	void Update ()
    {
		


	}

    public void ToGameScene()
    {

        SceneManager.LoadScene("GameScene");

    }
}
