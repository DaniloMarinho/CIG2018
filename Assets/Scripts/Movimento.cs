using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour {

    public float velocidade;

	// Use this for initialization
	void Start () {
        float x = Random.value;
        if(velocidade == 1.5) velocidade += 2 * x;
        if(velocidade == -1.5) velocidade -= 2 * x;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 direcao = new Vector3(1, 0, 0);

        GameObject referencia = GameObject.Find("Sphere");


        if (this.transform.position.z - referencia.transform.position.z < 10)
        GetComponent<Rigidbody>().velocity = velocidade * direcao;

        //if(Time.timeSinceLevelLoad % 1 < 1 && Time.timeSinceLevelLoad % 3 > 0.9) Destroy(this.gameObject);
    }
}
