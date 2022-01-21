using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagCam : MonoBehaviour
{

    public GameObject cam;
    public GameObject hips;
    public CharacterController controller;

    private Vector3 camDefPos;
    public bool _camActivate;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("CinemachineTarget");
        hips = GameObject.FindGameObjectWithTag("Hips");
        controller = GetComponent<CharacterController>();
        camDefPos = cam.transform.position;
        _camActivate = false;
    }

    // Update is called once per frame
    void Update()
    {
        UseRagCam();
    }

    public void UseRagCam()
    {
        if (_camActivate)
        {
            cam.transform.position = hips.transform.position + camDefPos;

            controller.center = hips.transform.position;
        }

        else
        {

        }
    }
}
