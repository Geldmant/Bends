using UnityEngine;

public class InventorySys : MonoBehaviour
{
    [SerializeField]private Camera cam;
    [SerializeField]private LayerMask layerMask;


    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit, 100f, layerMask))
        {
            transform.position = hit.point;
        }
    }
}