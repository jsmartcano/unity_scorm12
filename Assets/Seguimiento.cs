using UnityEngine;
using System.Collections;



public class Seguimiento : MonoBehaviour {


	private string textoDebug="";
	private Vector2 scrollPosition;
	
	private bool hayDebug=true;
	private int contador=0;

	public int puntos=0;

	void Awake() {
		Application.ExternalCall( "getScorm", true );
	}

	public void depurar(string txt) {
		contador++;
		if (contador==30) {
			contador=0;
			//textoDebug="";
		}
		textoDebug=txt+"\n"+textoDebug;
		
	}

	void OnGUI() {

		GUI.Box(new Rect((Screen.width/2)-100, 0, 200, 20), "DEMO UNITY + SCORM");
		GUI.Box(new Rect((Screen.width/2)-100, 20, 200, 20), "Encontrar los 5 alimentos");
		GUI.Box(new Rect((Screen.width/2)-100, 40, 200, 20), "ENCONTRADOS: "+puntos);

		if (puntos>=5) {
			GUI.Box(new Rect((Screen.width/2)-200, 80, 400, 30), "ENORABUENA!! HAS FINALIZADO EL JUEGO");
		}

		hayDebug = GUI.Toggle(new Rect(0, 0, 150, 30), hayDebug, "Mostrar DEBUG");

		if (hayDebug==true) {

			
			GUILayout.BeginArea(new Rect(0,40,200, 500));
			
			scrollPosition = GUILayout.BeginScrollView(
			scrollPosition, GUILayout.Width(200), GUILayout.Height(500));
			
			GUILayout.Label(textoDebug);
			GUILayout.EndScrollView();
			GUILayout.EndArea();
		}

	}
}
