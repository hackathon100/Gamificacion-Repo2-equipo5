using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juego : MonoBehaviour
{
	public GameObject numeroActual;
	public GameObject operacion;
	public GameObject nuevoNumero;

	string[] operaciones = {"+", "-", "x", "%"};
    // Start is called before the first frame update
    void Start()
    {
        // // Debug.Log(numeroActual.GetComponent<Text>);
        // GameObject prefab = Instantiate(numeroActual);
        // prefab.GetComponentInChildren<TextMesh>().text = "0";
        // GameObject prefab2 = Instantiate(operacion);
        // prefab2.GetComponentInChildren<TextMesh>().text = "+";
        // GameObject prefab3 = Instantiate(nuevoNumero);
        // prefab3.GetComponentInChildren<TextMesh>().text = "7";

		int num1  = (Random.Range(1, 12));
		int op   =  (Random.Range(0, 1));
		int num2   =  (Random.Range(1, 17));

        GameObject prefab = Instantiate(numeroActual);
        prefab.GetComponentInChildren<TextMesh>().text = num1.ToString();
        GameObject prefab2 = Instantiate(operacion);
        prefab2.GetComponentInChildren<TextMesh>().text = operaciones[op];
        GameObject prefab3 = Instantiate(nuevoNumero);
        prefab3.GetComponentInChildren<TextMesh>().text = num2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
