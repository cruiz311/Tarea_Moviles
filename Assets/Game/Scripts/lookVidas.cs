using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lookVidas : MonoBehaviour
{
    public Text text;
    public VidaSO vida;

    // Update is called once per frame
    void Update()
    {
        text.text = "VIDAS " + vida.vidas.ToString();
    }
}
