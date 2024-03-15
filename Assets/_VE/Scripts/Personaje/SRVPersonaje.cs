using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MORIdentificador))]
public class SRVPersonaje : MonoBehaviour
{
	[HideInInspector]
    public MORIdentificador identificador;
    public string id_uss;
	public bool conectado = false;
	public Color[] colores;

	private void Awake()
	{
		if(identificador == null) identificador = GetComponent<MORIdentificador>();
	}
	public void Inicializar(string _id_con, string _id_uss, bool _isOwner)
	{
		if (identificador == null) identificador = GetComponent<MORIdentificador>();
		identificador.id_con = _id_con;
		id_uss = _id_uss;
		identificador.isOwner = _isOwner;
	}

    void Start()
    {
		if (identificador.isOwner)
		{
            Servidor.singleton.EventoConectado += OnConnectedToServer;
		}
		else
		{
			int k = int.Parse(id_uss.Substring(0, 1));
			GetComponent<MeshRenderer>().material.SetColor("_BaseColor", colores[k]);
		}
    }

	public void OnConnectedToServer()
	{
		conectado = true;
		//id_con = ControlUsuario.singleton.id_con;
		//id_uss = ControlUsuario.singleton.id_uss;
		int k = int.Parse(id_uss.Substring(0, 1));
		GetComponent<MeshRenderer>().material.SetColor("_BaseColor", colores[k]);
	}

	private void OnDestroy()
	{
		if (identificador.isOwner)
		{
			Servidor.singleton.EventoConectado -= OnConnectedToServer;
		}
	}
}
