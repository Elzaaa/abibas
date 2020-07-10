using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Camera player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
