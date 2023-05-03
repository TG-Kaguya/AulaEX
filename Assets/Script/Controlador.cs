using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] GameObject _sphere;
    [SerializeField] GameObject _capsule;
    [SerializeField] GameObject _cylinder;
    [SerializeField] bool _checkCube;

    // Start is called before the first frame update
    void Start()
    {
        if(_checkCube == false)
        {
            _cube.SetActive(false);

        }
        else
        {
            _cube.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
