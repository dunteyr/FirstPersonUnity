using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonRagdoll : MonoBehaviour
{
    public List<GameObject> limbs;

    public GameObject pelvis;
    public GameObject leftHips;
    public GameObject leftKnee;
    public GameObject leftFoot;
    public GameObject rightHips;
    public GameObject rightKnee;
    public GameObject rightFoot;
    public GameObject leftArm;
    public GameObject leftElbow;
    public GameObject rightArm;
    public GameObject rightElbow;
    public GameObject middleSpine;
    public GameObject head;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(pelvis);

        AddLimbsToList();

        TurnOffRagdoll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddLimbsToList()
    {
        limbs.Add(pelvis);
        limbs.Add(leftHips);
        limbs.Add(leftKnee);
        limbs.Add(leftFoot);
        limbs.Add(rightHips);
        limbs.Add(rightKnee);
        limbs.Add(rightFoot);
        limbs.Add(leftArm);
        limbs.Add(leftElbow);
        limbs.Add(rightArm);
        limbs.Add(rightElbow);
        limbs.Add(middleSpine);
        limbs.Add(head);
    }

    private void TurnOffRagdoll()
    {
        foreach (GameObject limb in limbs)
        {
            //if a rigidbody exists
            if(GetComponent<Rigidbody>() != null)
            {
                Rigidbody limbRB = GetComponent<Rigidbody>();
                limbRB.useGravity = false;
            } else { Debug.LogError("A limb in the ragdoll is missing a rigidbody."); }


            //if a collider exists
            if(GetComponent<Collider>() != null)
            {
                Collider limbCol = GetComponent<Collider>();
                limbCol.enabled = false;
            } else { Debug.LogError("A limb in the ragdoll is missing a collider."); }
        }
    }
}
