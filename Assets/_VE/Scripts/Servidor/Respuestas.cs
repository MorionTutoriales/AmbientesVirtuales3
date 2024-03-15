using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respuestas : MonoBehaviour
{

}

public enum Plataformas
{
	movil = 0,
	windows = 1,
	VR = 2
}

[System.Serializable]
public class Presentacion
{
	public string	id_con;
	public string	id_uss;
	public int		plataforma;
	public Vector3	posicion;
	public Vector3	rotacion;
}

[System.Serializable]
public class Posicion0
{
	public string id_con;
	public Vector3 posicion;
	public Vector3 rotacion;
}


