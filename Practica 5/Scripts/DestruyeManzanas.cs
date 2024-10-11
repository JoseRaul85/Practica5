using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruyeManzanas : MonoBehaviour
{
    [SerializeField] AudioSource quienEmiteElSonido;
    Transform spawm;
    
    public float volumen = 1f;
    private void Awake(){
        spawm = GameObject.Find("SpawnEquis").transform;
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Manzanas")){
            GameObject obj = other.gameObject;
            obj.transform.position = spawm.position;
            quienEmiteElSonido.PlayOneShot(quienEmiteElSonido.clip, volumen);
            Debug.Log("jaaaa");
            

        }
         
    }
    

    

}
