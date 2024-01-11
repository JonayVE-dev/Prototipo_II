using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_movement : MonoBehaviour
{
    private bool isMovementActive = false;
    private float time = 0f;
    private float limit_time = 1.5f;
    private GameObject[] Targets;
    private Vector3[] initialPositions;
    // Start is called before the first frame update
    void Start()
    {
        GameObject targetParent = GameObject.Find("Targets");
        Targets = new GameObject[targetParent.transform.childCount];
        initialPositions = new Vector3[targetParent.transform.childCount];
        for (int i = 0; i < targetParent.transform.childCount; i++)
        {
            Targets[i] = targetParent.transform.GetChild(i).gameObject;
            initialPositions[i] = Targets[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isMovementActive)
        {
            time += Time.deltaTime;
            if (time >= limit_time)
            {
                time = 0f;
                for (int i = 0; i < Targets.Length; i++)
                {
                    Target_movement script = Targets[i].GetComponent<Target_movement>();

                    if (script != null)
                    {
                        script.enabled = !script.enabled;
                        if (!script.enabled)
                        {
                            Targets[i].transform.position = initialPositions[i];
                        }
                    }
                }
                
            }
        }
    }

    void OnPointerEnter()
    {
        isMovementActive = true;
    }

    void OnPointerExit()
    {
        isMovementActive = false;
        time = 0f;
    }
}
