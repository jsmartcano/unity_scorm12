using UnityEngine;
using System.Collections;

public class quemarse : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name=="monster") {
			GameObject.Find("monster").GetComponent<Seguimiento>().depurar("Fuego!!!!!!!");
		}
	}
}
