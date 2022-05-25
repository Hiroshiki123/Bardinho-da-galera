using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    Ray ray;
    RaycastHit hitData;
    Vector3 point;
    //private Camera _camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (UnityEngine.Input.GetKey(KeyCode.E))
        {
    
            ray = new Ray(transform.position, transform.forward);

            RaycastHit hitData;

            if (Physics.Raycast(ray, out hitData) && hitData.transform.tag == "inimigo")
            {

                

                Vector3 hitPosition = hitData.point;
                float hitDistance = hitData.distance;
                string tag = hitData.collider.tag;
                GameObject hitObject = hitData.transform.gameObject;
                StartCoroutine(SphereIndicator(hitPosition));


            }
        }
    }
    private IEnumerator SphereIndicator(Vector3 pos)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = pos;
        yield return new WaitForSeconds(1);
        Destroy(sphere);
    }

    void OnDrawGizmosSelected()
    {
        // Draws a 5 unit long red line in front of the object
        Gizmos.color = Color.red;
        
        Gizmos.DrawRay(ray);
    }
}
