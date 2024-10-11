using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrutinaSpawnManzanas : MonoBehaviour
{
   
    //float tiempo_en_Trigger;
    Transform spawm;
    
    [SerializeField] List<GameObject> lista_manzanas;
    int contador_manzana_actual;
    void Awake(){
        spawm = GameObject.Find("SpawnManzanas").transform;
        
    }
    void Start()
    {
        contador_manzana_actual = 0;
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other){

       // tiempo_en_Trigger+= Time.deltaTime;
        //if(tiempo_en_Trigger > tiempo_para_nueva_manzana)
            lista_manzanas[contador_manzana_actual].transform.position = spawm.position;
            contador_manzana_actual++;
            contador_manzana_actual %= contador_manzana_actual;
            //tiempo_en_Trigger = 0;
        


    }




     
}
