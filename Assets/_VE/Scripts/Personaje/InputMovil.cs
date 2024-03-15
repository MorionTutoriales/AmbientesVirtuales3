using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMovil : MonoBehaviour
{
    public static float iH;
    public static float iV;

    public void CambiarIH(float cuanto)
    {
        iH = cuanto;
    }
    public void CambiarIV(float cuanto)
    {
        iV = cuanto;
    }
}
