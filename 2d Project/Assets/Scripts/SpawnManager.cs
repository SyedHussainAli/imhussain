using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPF;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Instanstiate", 1, Random.Range(4,8));
    }

 private void Instanstiate()
    {
        Instantiate(ballPF, ballPF.transform.position, ballPF.transform.rotation);
    }
}
