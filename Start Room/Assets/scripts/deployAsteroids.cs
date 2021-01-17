﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deployAsteroids : MonoBehaviour {
    public GameObject asteroidPrefab;
    public float respawnTime = 5.0f;
    private Vector2 screenBounds;
    public GameObject numeroActual;
	public GameObject operacion;
	public GameObject nuevoNumero;
	public int numeroCorrecto;
	public GameObject opcion1;
	public GameObject opcion2;
	public GameObject opcion3;
	public GameObject prefab;
	public GameObject prefab2;
	public GameObject prefab3;
	public string texto;
	public int contador = 0;
	public int contadorDestroyed = 0;

	public string[] operaciones = {"+", "-", "x", "%"};
	public List<GameObject> objetosCreados = new List<GameObject>();
	public int resultadoAux;
	
	public int num2;
	public int num1;
	public int op;
	public int r1; 
	public int nuevoValor;
	public int comprobador = 0; //0 bien, 1 mal
 	public GameObject vida;
    public GameObject puntaje;
 	public int contadorClicks = 0;
 	
    // Use this for initialization
    void Start () {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());

        //aca crear valores random para luego aplciarlos a los textos, uno para cada uno
       	vida.GetComponentInChildren<TextMesh>().text = "100";
       	puntaje.GetComponentInChildren<TextMesh>().text = "1";
		num1  = (Random.Range(1, 12));
		op   =  (Random.Range(0, 1));
		num2   =  (Random.Range(1, 17));
		Debug.Log(op);

         prefab = Instantiate(numeroActual);
        prefab.GetComponentInChildren<TextMesh>().text = num1.ToString();
         prefab2 = Instantiate(operacion);
        prefab2.GetComponentInChildren<TextMesh>().text = operaciones[op];
         prefab3 = Instantiate(nuevoNumero);
        prefab3.GetComponentInChildren<TextMesh>().text = num2.ToString();
        texto = num2.ToString();
    }
    public void spawnEnemy(){
    	//estos valores deben llevar un valor, son textos tambien, si al clickear el texto con el texto que se deberia marcar es igual es correcto
    	//algoritmo para determinar numero a poner en las opcioens
	
				Debug.Log("---------_________--" + contador + "-------___________-------");
    			Debug.Log("---------_________--" + contadorDestroyed + "-------___________-------");
    			if(contador == contadorDestroyed){
    				
    				comprobador = 0;
				}else{
					comprobador = 1;
				}
		
    	if(comprobador == 0){ //creados igual a destruidos
    		
    		r1 =  (Random.Range(0, 2));
	    	Debug.Log(r1);
	    	if(contador == 0){
	    		if(op == 0){
	    		 	resultadoAux =  int.Parse((prefab.GetComponentInChildren<TextMesh>().text)) + int.Parse((prefab3.GetComponentInChildren<TextMesh>().text));
		    	}	
		    	else{
	    		 	resultadoAux =  int.Parse((prefab.GetComponentInChildren<TextMesh>().text)) - int.Parse((prefab3.GetComponentInChildren<TextMesh>().text));
		    	}
	    	}else{//contador mayor a 1
			numeroActual.GetComponentInChildren<TextMesh>().text = resultadoAux.ToString();//al comenzar la sgt ida, ya que sino seria facil
	    		if(contador == 1){
	    			Destroy(prefab);
	    			Destroy(prefab2);
	    			Destroy(prefab3);
	    		}
	    		nuevoValor   =  (Random.Range(1, 17));
	    		if(r1 == 0){
	    		 	resultadoAux =  resultadoAux + nuevoValor;
		    	}	
		    	else{
	    		 	resultadoAux =  resultadoAux - nuevoValor;
		    	}

	    	}
	    	
	    	Debug.Log(resultadoAux);

	    	int elegido =  (Random.Range(1, 3));
	    	//alg
	    	if(elegido == 1){
	    		
	    		int r3 =  (Random.Range(1, 7));
	    		int r4 =  (Random.Range(1, 3));
	    		int alpeo1, alpeo2;
	    		opcion1 = Instantiate(asteroidPrefab) as GameObject;
		        opcion1.transform.position = new Vector2(screenBounds.x * 2, (screenBounds.y/2) + screenBounds.y/4);
		     	opcion1.GetComponentInChildren<TextMesh>().text = resultadoAux.ToString();

	    		if(r1 == 0){
	    			alpeo1 = resultadoAux - r4;
	    			alpeo2 = resultadoAux + r3;
			        
				}
				else{
					alpeo1 = resultadoAux + r4;
	    			alpeo2 = resultadoAux - r3;
				}
				opcion2 = Instantiate(asteroidPrefab) as GameObject;
		        opcion2.transform.position = new Vector2(screenBounds.x * 2, 0);
		        opcion2.GetComponentInChildren<TextMesh>().text = alpeo1.ToString();
		  	 	opcion3 = Instantiate(asteroidPrefab) as GameObject;
		        opcion3.transform.position = new Vector2(screenBounds.x * 2, (-screenBounds.y/2) - screenBounds.y/4);
		        opcion3.GetComponentInChildren<TextMesh>().text = alpeo2.ToString();	
	    	}
	    	if(elegido == 2){
	    		opcion2 = Instantiate(asteroidPrefab) as GameObject;
		        opcion2.transform.position = new Vector2(screenBounds.x * 2, 0);
		        opcion2.GetComponentInChildren<TextMesh>().text = resultadoAux.ToString();
	    		int r1 =  (Random.Range(0, 1));
	    		int r3 =  (Random.Range(1, 7));
	    		int r4 =  (Random.Range(1, 3));
	    		int alpeo1, alpeo2;
	    		

	    		if(r1 == 0){
	    			alpeo1 = resultadoAux - r4;
	    			alpeo2 = resultadoAux + r3;
			        
				}
				else{
					alpeo1 = resultadoAux + r4;
	    			alpeo2 = resultadoAux - r3;
				}
				opcion1 = Instantiate(asteroidPrefab) as GameObject;
		        opcion1.transform.position = new Vector2(screenBounds.x * 2, (screenBounds.y/2) + screenBounds.y/4);
		     	opcion1.GetComponentInChildren<TextMesh>().text = alpeo1.ToString();
				
		  	 	opcion3 = Instantiate(asteroidPrefab) as GameObject;
		        opcion3.transform.position = new Vector2(screenBounds.x * 2, (-screenBounds.y/2) - screenBounds.y/4);
		        opcion3.GetComponentInChildren<TextMesh>().text = alpeo2.ToString();	
	    	}
	    	if(elegido == 3){
	    		opcion3 = Instantiate(asteroidPrefab) as GameObject;
		        opcion3.transform.position = new Vector2(screenBounds.x * 2, (-screenBounds.y/2) - screenBounds.y/4);
		        opcion3.GetComponentInChildren<TextMesh>().text = resultadoAux.ToString();
	    		int r1 =  (Random.Range(0, 1));
	    		int r3 =  (Random.Range(-1, -2));
	    		int r4 =  (Random.Range(1, 2));
	    		int alpeo1, alpeo2;
	    		

	    		if(r1 == 0){
	    			alpeo1 = resultadoAux - r4;
	    			alpeo2 = resultadoAux + r3;
			        
				}
				else{
					alpeo1 = resultadoAux + r4;
	    			alpeo2 = resultadoAux - r3;
				}
				opcion1 = Instantiate(asteroidPrefab) as GameObject;
		        opcion1.transform.position = new Vector2(screenBounds.x * 2, (screenBounds.y/2) + screenBounds.y/4);
		     	opcion1.GetComponentInChildren<TextMesh>().text = alpeo1.ToString();
				opcion2 = Instantiate(asteroidPrefab) as GameObject;
		        opcion2.transform.position = new Vector2(screenBounds.x * 2, 0);
		        opcion2.GetComponentInChildren<TextMesh>().text = alpeo2.ToString();
		  	 		
	    	}


	        
	        
	        objetosCreados.Add(opcion1);
	        objetosCreados.Add(opcion2);
	        objetosCreados.Add(opcion3);

	        //FALTA cambiar los textos en la pantalla, los permantnes
	        if(contador > 0){
	        	
		        if(r1 == 0){
		    	 	operacion.GetComponentInChildren<TextMesh>().text = "+";
		    	}else{
				 	operacion.GetComponentInChildren<TextMesh>().text = "-";
		    	}
		       
		        nuevoNumero.GetComponentInChildren<TextMesh>().text = nuevoValor.ToString();
	        }
        	contador = contador + 1;


	   //      if(contador > 1){//porque se le dieron 2 espacios
	   //      	// objetosCreados.Resize(ref objetosCreados, (contador+1));
	   //      	// arrayAux = {opcion1,opcion2,opcion3};

				// objetosCreados[contador] = arrayAux;
	   //      }
	   //      else{
	   //      	// arrayAux = {opcion1,opcion2,opcion3};
	   //      	objetosCreados[contador] = arrayAux;
	   //      }	
	        
	        //without this line we'd get a exception
			
	  //       Debug.Log("A");
	  //       Debug.Log((screenBounds.y));
			// Debug.Log((screenBounds.x));
			// 
    	}else{
    		Debug.Log("A tomarse la leche");
    	}
    	// Debug.Log((screenBounds.y);
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
    
}