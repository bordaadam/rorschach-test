using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSpawner : MonoBehaviour
{

    private readonly int layerMask = 1 << 8;
    [SerializeField] private GameObject doorPrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            SpawnDoor();
        }
    }

    private void SpawnDoor()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity, layerMask, QueryTriggerInteraction.Ignore))
        {
            GameObject door = Instantiate(doorPrefab);
            Vector3 hp = hit.point;
            door.transform.position = new Vector3(hp.x, 1.5f, hp.z);

            if(Mathf.Abs(hit.transform.eulerAngles.y) == 90)
            {
                door.transform.eulerAngles = new Vector3(0, 0, 0);
            } else if(hit.transform.eulerAngles.y == 0)
            {
                door.transform.eulerAngles = new Vector3(0, -90f, 0);
            }

        } else {
            Debug.Log("There are no walls!");
        }

    }
}
