using UnityEngine;
using System.Collections;

public class puntuar : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		//Debug.Log("Colision");
		//GameObject.Find("monster").GetComponent<Seguimiento>().depurar("1");
		if (other.gameObject.name=="monster") {
			GameObject.Find("monster").GetComponent<Seguimiento>().depurar("Has recogido el objeto "+this.name);
			GameObject.Find("monster").GetComponent<Seguimiento>().puntos++;
			Destroy(this.gameObject);
			int localPuntos = GameObject.Find("monster").GetComponent<Seguimiento>().puntos;
			GameObject.Find("monster").GetComponent<Seguimiento>().depurar("Guardando seguimiento... PUNTOS: "+localPuntos);
			Application.ExternalCall( "setScorm", localPuntos );

	
		}
	}
}
