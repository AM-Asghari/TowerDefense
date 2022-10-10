using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    [SerializeField] GameObject pfTowerPrefab = null;
    private Camera cam = null;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        SpawnAtMousePos();
    }

    private void SpawnAtMousePos()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(pfTowerPrefab, new Vector3(hit.point.x, hit.point.y + pfTowerPrefab.transform.position.y, hit.point.z), Quaternion.identity);
            }
        }
    }
}
