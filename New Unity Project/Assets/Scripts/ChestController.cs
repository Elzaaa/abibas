﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;
    public GameObject obj;
    public void OpenChest()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Chest  has Oppened");
            animator.SetBool("IsOpen", true);
            obj.SetActive(true);
        }

    }
}