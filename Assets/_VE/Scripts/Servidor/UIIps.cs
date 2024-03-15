using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIIps : MonoBehaviour
{
    public InputField inIP;
    public InputField inPuerto;

    public string url = "ws://127.0.0.1:8080";
    public Servidor servidor;

    public void CambiarIP(string i)
    {
        url = "ws://" + i + ":" + inPuerto.text;
    }

    public void CambiarPuerto(string i)
    {
        url = "ws://" + inIP.text + ":" + i;
    }

    public void Conectar()
	{
        servidor.url = url;
        servidor.Conectar();
        ControlUsuario.singleton.CrearJugador();
	}
}
