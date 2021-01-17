using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour {
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
   
    public int contadorDestruidos;//para saber cuantos se destruyeron
   

    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    //cuando se elimine el elemento, se llama al sgt, cuando se llama al sgt, se cambian los valores, y si estuvo corrcto se sumo el puntaje,sino se resto
    //con cada correcta aumenta la velocidad
    void Update () {
        if(transform.position.x < ((screenBounds.x * -2)/2)){
        	
        	if(this.gameObject != null){

        		Destroy(this.gameObject);
        		var contA = (GameObject.Find("creador").GetComponent<deployAsteroids>().contador);
	        	GameObject.Find("creador").GetComponent<deployAsteroids>().contadorDestroyed = contA;
	        	Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        
    			var contadorClicks2 =  (GameObject.Find("creador").GetComponent<deployAsteroids>().contadorClicks);
    			if(contA > contadorClicks2){
    				(GameObject.Find("creador").GetComponent<deployAsteroids>().contadorClicks) = (GameObject.Find("creador").GetComponent<deployAsteroids>().contadorClicks) + 1;
    				Debug.Log("Activando protocolo CTM HDASDKAS");
    			}
        	}
            
        }
    }
    void OnMouseDown()	
    {
        // Destroy the gameObject after clicking on it
     	// Debug.Log(GameObject.Find("creador").GetComponent<deployAsteroids>().texto);

        // Debug.Log((GameObject.Find("creador").GetComponent<deployAsteroids>().opcion1).GetComponentInChildren<TextMesh>().text);
        // Debug.Log((GameObject.Find("creador").GetComponent<deployAsteroids>().opcion2).GetComponentInChildren<TextMesh>().text);
        // Debug.Log((GameObject.Find("creador").GetComponent<deployAsteroids>().opcion3).GetComponentInChildren<TextMesh>().text);
        // Destroy(GameObject.Find("creador").GetComponent<deployAsteroids>().opcion1);
        // Debug.Log(GameObject.Find("creador").GetComponent<deployAsteroids>().opcion2);
        // Debug.Log(GameObject.Find("creador").GetComponent<deployAsteroids>().opcion3);
        var contC = (GameObject.Find("creador").GetComponent<deployAsteroids>().contador);
        
    	var contadorClicks2 =  (GameObject.Find("creador").GetComponent<deployAsteroids>().contadorClicks);
    	
		Debug.Log("QQQQQQQQQQQQQQQQQ" + contC);
    	Debug.Log("EEEEEEEEEEEEEEEEE" + contadorClicks2);
    	if(contadorClicks2 + 1 == contC){// && contadorClicks2 == contadorDestroyed
    		// var contB = (GameObject.Find("creador").GetComponent<deployAsteroids>().contador);
        	(GameObject.Find("creador").GetComponent<deployAsteroids>().contadorClicks) = ((GameObject.Find("creador").GetComponent<deployAsteroids>().contadorClicks) + 1);
			var contadorDestroyed2 =  (GameObject.Find("creador").GetComponent<deployAsteroids>().contadorDestroyed);
			// if(contB == 0){
			// 	//primera 0, luego se resta -1
			// }else{
			// 	var array = (GameObject.Find("creador").GetComponent<deployAsteroids>().objetosCreados);
	  //       	// Debug.Log(array[contB].GetComponentInChildren<TextMesh>().text);
			// }
			Debug.Log(gameObject.GetComponentInChildren<TextMesh>().text + "   ???????????????");
			//alg para encontrar si el click es correcto, 
			//si es correcto elimnar toda la col necesaria, cambiar los datos perm, y cambiar el puntaje el % o la vida(FALTA barra de vida o %)
			//1° encontrar donde se hizo click y si esta correcto
			//encontrar valor correcto 
			var valorCorrecto = (GameObject.Find("creador").GetComponent<deployAsteroids>().resultadoAux);
			// Debug.Log("valor correcto es: ");
			Debug.Log("?????????????  " + valorCorrecto);
			if(gameObject.GetComponentInChildren<TextMesh>().text  == valorCorrecto.ToString()){
				Debug.Log("correcto");

				var puntajeActual = int.Parse((GameObject.Find("creador").GetComponent<deployAsteroids>().puntaje).GetComponentInChildren<TextMesh>().text);
				((GameObject.Find("creador").GetComponent<deployAsteroids>().puntaje).GetComponentInChildren<TextMesh>().text) = (puntajeActual + 2).ToString();
				speed = speed + 1;
			}else{
				Debug.Log("incorrecto");
				var vidaRestante = int.Parse((GameObject.Find("creador").GetComponent<deployAsteroids>().vida).GetComponentInChildren<TextMesh>().text);
				((GameObject.Find("creador").GetComponent<deployAsteroids>().vida).GetComponentInChildren<TextMesh>().text) = (vidaRestante - 5).ToString();
			
			}	
    	}else{
    		Debug.Log("BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB");
    	}
        
		//FALTA cambiar los textos en la pantalla, los permantnes

		// var texto1 = (GameObject.Find("creador").GetComponent<deployAsteroids>().numeroActual);
		// var texto2 = (GameObject.Find("creador").GetComponent<deployAsteroids>().operacion);
		// var texto3 = (GameObject.Find("creador").GetComponent<deployAsteroids>().numeroNuevo);

  //       texto1.GetComponentInChildren<TextMesh>().text = valorCorrecto;
  //       if(op == 0){
  //   	 	texto2.GetComponentInChildren<TextMesh>().text = "+";
  //   	}else{
		//  	texto2.GetComponentInChildren<TextMesh>().text = "-";
  //   	}
       
  //       texto3.GetComponentInChildren<TextMesh>().text = num2.ToString();

		//siempre se eliminan los otros valores(FALTA sacarlos de la lista para que no sea tan gigante)
		//gameObject.GetComponentInChildren<TextMesh>().text 
    }
}

