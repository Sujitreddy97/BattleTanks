using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoBehaviour
{

    public GameObject tankPrefab;

    void Start()
    {
        GameObject.Instantiate(tankPrefab, tankPrefab.transform.position, Quaternion.identity);
    }

}
