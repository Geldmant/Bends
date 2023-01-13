using UnityEngine;

public class InventorySys : MonoBehaviour
{
    [SerializeField]private Camera cam;
    [SerializeField]private LayerMask layerMask;
    [SerializeField]public Iteminv Ii;


    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out RaycastHit hit, 100f, layerMask))
        {
            if(Input.GetKeyDown(keycode.Mouse0) && !Ii.isGrab)
            {   
                Ii.PickUP();
            }

            if(Input.GetKeyDown(keycode.Mouse0) && Ii.isGrab)
            {   
                Ii.Method();
            }

        }
    }
}