﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;
using UnityEngine.SceneManagement;

public class EndMenuScrypt : MonoBehaviour
{
    public void restartGame(){
        SceneManager.LoadScene(0);
    }
}
