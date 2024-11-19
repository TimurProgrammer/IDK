using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class CreateAndDestroy : MonoBehaviour
{
    [SerializeField] private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = Vector3.right * 2;
        DestroyObject(cube, 3);
        SteveSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DestroyObject(GameObject objectToDestroy, int delay)
    {
        Destroy(objectToDestroy, delay);
    }
    
    private void SteveSpawn()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0); //Ноги
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1, 0); // Рука1
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 1, 0); // Рука2
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0); // Плече2
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0); // Плече1
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 3, 0); // Голова
    }
}
