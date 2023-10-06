using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 10, player.transform.position.z - 18);

    }
}
