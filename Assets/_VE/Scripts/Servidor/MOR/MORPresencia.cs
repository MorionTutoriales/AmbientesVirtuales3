using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MORPresencia : MonoBehaviour
{
    public MORIdentificador[] identificadores;
	public IDIdenfificadores idsIdentificadores;
    public bool isOwner;

    public void InicializarPropio()
	{
		isOwner = true;
		idsIdentificadores.ids = new string[identificadores.Length];
		for (int i = 0; i < identificadores.Length; i++)
		{
			idsIdentificadores.ids[i] = identificadores[i].Inicializar(isOwner);
		}
	}

	public void InicializarAgeno(IDIdenfificadores ids)
	{
		isOwner = false;
		idsIdentificadores = ids;
		for (int i = 0; i < identificadores.Length; i++)
		{
			identificadores[i].Inicializar(isOwner);
		}
	}
	public void BuscarIdentificadores()
	{
        identificadores = GetComponentsInChildren<MORIdentificador>();
	}
}

[System.Serializable]
public class IDIdenfificadores
{
	public string[] ids;
}