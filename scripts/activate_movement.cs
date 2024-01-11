using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate_movement : MonoBehaviour
{
    private bool isMovementActive = false;
    private float time = 0f;
    private float limit_time = 1.5f;
    private GameObject[] Targets;
    // Start is called before the first frame update
    void Start()
    {
        GameObject targetParent = GameObject.Find("Targets");
        Targets = new GameObject[targetParent.transform.childCount];
        for (int i = 0; i < targetParent.transform.childCount; i++)
        {
            Targets[i] = targetParent.transform.GetChild(i).gameObject;
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
