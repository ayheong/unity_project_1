using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField]
    private float xAxis, yAxis, zAxis;


    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + xAxis, player.transform.position.y + yAxis, player.transform.position.z + zAxis);
    }
}
