using UnityEngine;

public class aim : MonoBehaviour
{
    [SerializeField]
    float verticalMouseSensitivity = 1;
    [SerializeField]
    bool invertAim = false;
    Rigidbody rigidB;
    [SerializeField]
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody>();
        cam = GetComponentInChildren<Camera>();
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void Update()
    {
        AimLogic();
    }

    void AimLogic()
    {
        int _aimModifier = -1;
        if(invertAim)
        {
            _aimModifier = 1;
        }
        float _leftRightValue = Input.GetAxisRaw("Mouse X");
        float _upDownValue = Input.GetAxisRaw("Mouse Y");
        Vector3 _rotationX = new Vector3(_upDownValue, 0, 0);
        Vector3 _rotationY = new Vector3(0, _leftRightValue, 0);
        rigidB.MoveRotation(rigidB.rotation * Quaternion.Euler(_rotationY));
        cam.transform.Rotate(_rotationX / verticalMouseSensitivity);
    }
}
