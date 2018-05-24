using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour {

    public Rigidbody pessoa1, pessoa2, pessoa3, alien1, alien2, alien3;
    public float taxa;
    bool prepara = false;

    // Use this for initialization
    void Start () {
        /*Rigidbody clone;
        for (int i = 0; i <= 2; i++)
        {
            Vector3 pos1 = new Vector3(this.transform.position.x - 3.8f, this.transform.position.y - 0.35f, this.transform.position.z + 20 * i);
            Vector3 pos2 = new Vector3(this.transform.position.x + 3.8f, this.transform.position.y - 0.35f, this.transform.position.z + 20 * i);
            float x = Random.value;
            if (x <= 0.4)
            {
                clone = Instantiate(pessoa1, pos1, Quaternion.Euler(0, 0, 0)) as Rigidbody;
            }
            else if (x > 0.4 && x <= 0.8)
            {
                clone = Instantiate(pessoa2, pos2, Quaternion.Euler(0, 0, 0)) as Rigidbody;
            }
            else if (x > 0.8 && x <= 0.9)
            {
                clone = Instantiate(alien1, pos1, Quaternion.Euler(0, 0, 0)) as Rigidbody;
            }
            else
            {
                clone = Instantiate(alien2, pos2, Quaternion.Euler(0, 0, 0)) as Rigidbody;
            }
        }*/
        taxa = 2;
    }
	
	// Update is called once per frame
	void Update () {
        if (taxa <= 10) taxa = 2 + 0.05f * Time.timeSinceLevelLoad;
        //float timecounter = 0;
        if (taxa*Time.timeSinceLevelLoad % 2 < 1)
        {
            prepara = true;
        }
        if (taxa*Time.timeSinceLevelLoad % 2 > 1 && prepara == true)
        {
            Rigidbody clone;
            Vector3 direcao = new Vector3(1, 0, 0);
            //for (int i = -2; i <= 2; i++)
            //{
            float d = Random.value;
                Vector3 pos1 = new Vector3(-4 + 0.5f*d, -0.35f, this.transform.position.z + 15);
                Vector3 pos2 = new Vector3(4 - 0.5f * d, -0.35f, this.transform.position.z + 15);
                Vector3 pos3 = new Vector3(8*(0.5f-d), -0.35f, this.transform.position.z + 15);
                //Vector3 pos4 = new Vector3(2.7f, -0.35f, this.transform.position.z + 7);
                //Vector3 pos5 = new Vector3(-2.7f, -0.35f, this.transform.position.z + 7);
            float x = 10*Random.value;
            switch ((int)x % 20)
            {
                case 0:
                case 11:
                case 12:
                case 19:
                    clone = Instantiate(pessoa1, pos1, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                case 1:
                case 13:
                case 14:
                case 10:
                    clone = Instantiate(pessoa2, pos2, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                case 2:
                case 15:
                case 16:
                    clone = Instantiate(alien1, pos1, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                case 3:
                case 17:
                case 18:
                    clone = Instantiate(alien2, pos2, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                case 4:
                case 5:
                case 6:
                    clone = Instantiate(pessoa3, pos3, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                /*case 5:
                    clone = Instantiate(pessoa3, pos4, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                case 6:
                    clone = Instantiate(pessoa3, pos5, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;*/
                case 7:
                case 8:
                case 9:
                    clone = Instantiate(alien3, pos3, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                /*case 8:
                    clone = Instantiate(alien3, pos4, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;
                case 9:
                    clone = Instantiate(alien3, pos5, Quaternion.Euler(0, 0, 0)) as Rigidbody;
                    break;*/
                default: break;
            }
            prepara = false;
        }
    }

}
