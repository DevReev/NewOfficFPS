using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject endUI;

    public float dieY = -2;

    private void Update()
    {
        if (transform.position.y <= dieY)
        {
            endUI.SetActive(true);
        }
    }
}
