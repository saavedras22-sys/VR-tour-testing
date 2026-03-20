using UnityEngine;

public class SpawnInView : MonoBehaviour
{
    public float distance = 2.0f; // Distance from the camera
    private bool positioned = false;
    /*private GameObject mainMenu;
    private GameObject map;
    private GameObject guide;*/
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        // Get the camera's position and forward direction
        Transform camTransform = Camera.main.transform;
        
        // Calculate the target position in front of the camera (ignores Y)
        Vector3 forwardFixed = camTransform.forward;
        forwardFixed.y = 0; 
        Vector3 targetPosition = camTransform.position + (forwardFixed.normalized * distance);

        // Instant snap to view
        transform.position = targetPosition;

        transform.LookAt(camTransform);
        transform.Rotate(0, 180, 0); // LookAt points at the back of the menu
    }

    // Update is called once per frame
    void Update()
    {/*
        if(!positioned)
        {
            // Get the camera's position and forward direction
            Transform camTransform = Camera.main.transform;
            
            // Calculate the target position in front of the camera (ignores Y)
            Vector3 forwardFixed = camTransform.forward;
            forwardFixed.y = 0; 
            Vector3 targetPosition = camTransform.position + (forwardFixed.normalized * distance);

            // Instant snap to view
            transform.position = targetPosition;

            transform.LookAt(camTransform);
            transform.Rotate(0, 180, 0); // LookAt points at the back of the menu
            positioned = true;
        }*/
    }
    public void position()
    {/*
        mainMenu = GameObject.Find("MainMenu");
        mainMenu.transform.GetChild(0).gameObject.SetActive(true);
        map = GameObject.Find("Menu_Map");
        guide = GameObject.Find("Guide");

        Transform camTransform = Camera.main.transform;
        
        // Calculate the target position in front of the camera (ignores Y)
        Vector3 forwardFixed = camTransform.forward;
        forwardFixed.y = 0; 
        Vector3 targetPosition = camTransform.position + (forwardFixed.normalized * distance);

        // Instant snap to view
        mainMenu.transform.position = targetPosition;
        mainMenu.transform.LookAt(camTransform);
        mainMenu.transform.Rotate(0, 180, 0);

        map.transform.position = targetPosition;
        map.transform.LookAt(camTransform);
        map.transform.Rotate(0, 180, 0);

        guide.transform.position = targetPosition;
        guide.transform.LookAt(camTransform);
        guide.transform.Rotate(0, 180, 0);*/
    }
}
