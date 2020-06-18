using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{

    CharacterController character;
    // Start is called before the first frame update
    void Start()
    {
        character = gameObject.GetComponent<CharacterController>() ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            character.height = 0.25f;
        }else
        {
            character.height = 2f;
        }
    }
}
