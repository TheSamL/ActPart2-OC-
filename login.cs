using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MotDePasse : MonoBehaviour {
	
	public InputField id;
	public InputField password;
    public Text texte;

	void Update(){

		if (id.text == "Admin" && password.text == "admin" && Input.GetKeyDown (KeyCode.Return)) {

			Application.LoadLevel("Menu");

		}
        else {

            texte="Erreur: Identifiant ou Mot de passe incorrect."
            texte.color=red;
            
        }

	}
}
