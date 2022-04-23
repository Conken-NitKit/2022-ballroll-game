using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class AnyKeyEventListner : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        if (!Input.anyKeyDown) return;
        switch (this.gameObject.name)
        {
            case "LogoCanvas":
                Destroy(this.gameObject);
                break;
            //case "TitleCanvas": 
        }
    }
}
