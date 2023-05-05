using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedConditionals : MonoBehaviour
{
    [SerializeField] GameObject _cube;
    [SerializeField] Rigidbody _cubeRig;
    [SerializeField] BoxCollider _cubeBox;

    [SerializeField] GameObject _sphere;
    [SerializeField] Rigidbody _spheRig;

    [SerializeField] GameObject _capsule;
    [SerializeField] Rigidbody _capRig;

    [SerializeField] GameObject _cylinder;
    [SerializeField] Rigidbody _cylRig;

    [SerializeField] string _texxt;
    [SerializeField] float _numberr;
    [SerializeField] bool _checc;
    // Start is called before the first frame update
    void Start()
    {
        _cubeBox = _cube.GetComponent<BoxCollider>();
        if(_cubeBox != null)
        {
            _cubeBox.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(_checc == true && _numberr == 1)
        {
            _cube.SetActive(true);
            _cubeRig.useGravity = false;
            _cubeRig.isKinematic = true;
        }
        else if (_checc == true && _numberr == 2)
        {
            _cube.SetActive(false);
            _sphere.SetActive(true);
            _capsule.SetActive(false);
            _cylinder.SetActive(false);
        }
    }
}
