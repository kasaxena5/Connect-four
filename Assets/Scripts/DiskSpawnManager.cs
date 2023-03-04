using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskSpawnManager : MonoBehaviour
{
    [SerializeField]
    private Disk diskPrefab;

    private void OnMouseDown()
    {
        Vector3 mouse = Input.mousePosition;
        Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(mouse);
        InstantiateDisk(mouseWorldPoint);
    }

    private void InstantiateDisk(Vector3 position)
    {
        Disk disk = Instantiate(diskPrefab);
        disk.transform.position = new Vector3(position.x, position.y, 0);
    }

}
