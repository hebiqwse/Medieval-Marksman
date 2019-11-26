using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField]
    bool invertedAim = true;
    Rigidbody RB;
    [SerializeField]
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
        Cursor.visible = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        BowAim();
        
    }

    void BowAim()
    {
        int _ModifiedAim = -1;
        if (invertedAim)
            _ModifiedAim = 1;
        float _leftRightValue = Input.GetAxisRaw("Mouse X");
        float _upDownValue = _ModifiedAim * Input.GetAxisRaw("Mouse Y");
        Vector3 _rotationX = new Vector3(_upDownValue, 0, 0);
        Vector3 _rotationY = new Vector3(0, _leftRightValue, 0);

        RB.MoveRotation(RB.rotation * Quaternion.Euler(_rotationY));
        cam.transform.Rotate(_rotationX / 3);

    }
}
