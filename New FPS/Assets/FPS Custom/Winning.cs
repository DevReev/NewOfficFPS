using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{

    public GameObject completeUI;

    private void OnTriggerEnter(Collider other)
    {
        completeUI.SetActive(true);
    }



}
