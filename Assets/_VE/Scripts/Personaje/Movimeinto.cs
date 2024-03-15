using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SRVPersonaje))]
[RequireComponent(typeof(SRVActualizarTransdformacion))]
public class Movimeinto : MonoBehaviour
{
    public float velocidad;
    public float velRotacion;

    SRVPersonaje srvPersonaje;
	SRVActualizarTransdformacion srvActTrans;
	float rh;
	float rv;

	private void Awake()
	{
        srvPersonaje = GetComponent<SRVPersonaje>();
		srvActTrans = GetComponent<SRVActualizarTransdformacion>();
	}
	private IEnumerator Start()
	{
		yield return new WaitUntil(() => srvPersonaje.conectado);
		yield return new WaitForSeconds(0.2f);
		srvActTrans.id_conn = srvPersonaje.identificador.id_con;
		srvActTrans.isOwner = srvPersonaje.identificador.isOwner;
	}
	void Update()
    {
		if (!srvPersonaje.identificador.isOwner || !srvPersonaje.conectado)
		{
            return;
		}
        transform.Translate(0, 0, velocidad * Time.deltaTime * (Input.GetAxis("Vertical") + InputMovil.iV));
        transform.Rotate(0, velRotacion * Time.deltaTime * (Input.GetAxis("Horizontal") + InputMovil.iH), 0);
    }

	public void CambiarHorizontal(float n)
	{
		rh = n;
	}
	public void CambiarVertical(float n)
	{
		rv = n;
	}
}
