using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class PlayerAim : MonoBehaviour
{
    private Transform aimTransform;

    private void Awake()
    {
        aimTransform = transform.Find("Aim");
    }

    private void Update()
    {
        AimHandling();
    }

    private void AimHandling()
    {
        Vector3 mousePosition = UtilsClass.GetMouseWorldPosition(); //Screen to world point conversion
        Vector3 aimDirection = (mousePosition - transform.position).normalized;//Unit vector of direction to mouse
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg; //Convert rad->deg
        aimTransform.eulerAngles = new Vector3(0, 0, angle); //Rotation in Unity is a Vector3, recall we only want roation about the Z
        //Debug.Log(angle);
    }
}
