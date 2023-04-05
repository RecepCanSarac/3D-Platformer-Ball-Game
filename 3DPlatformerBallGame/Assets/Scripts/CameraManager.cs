using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform _Target;
    [SerializeField] private Vector3 _Offset;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = _Target.position + _Offset;
    }
}
