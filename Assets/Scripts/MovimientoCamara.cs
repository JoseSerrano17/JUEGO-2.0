using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{

    [SerializeField] private float velocidadCamara = 50f;
    private new Camera camera;
    private BoxCollider2D boxCollider;
    private float sizeX, sizeY, ratio;

    // Start is called before the first frame update
    void Start()
    {
        /*camera = GetComponent<Camera>();
        boxCollider = GetComponent<BoxCollider2D>();
        sizeY = camera.orthographicSize * 2;
        ratio = (float)Screen.width / (float)Screen.height;
        sizeX = sizeY * ratio;
        boxCollider.size = new Vector2(sizeX, sizeY);*/
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            transform.Translate(new Vector3(-velocidadCamara * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(velocidadCamara * Time.deltaTime, 0, 0));
        }
    }
    private void Awake()
    {
        AddColliderOnCamera();
    }

    public void AddColliderOnCamera()
    {
        if (Camera.main == null)
        {
            Debug.LogError("No camera found make sure you have tagged your camera with 'MainCamera'");
            return;
        }
        Camera cam = Camera.main;

        if (!cam.orthographic)
        {
            Debug.LogError("Make sure your camera is set to orthographic");
            return;
        }

        // Get or Add Edge Collider 2D component
        var edgeCollider = gameObject.GetComponent<EdgeCollider2D>() == null ? gameObject.AddComponent<EdgeCollider2D>() : gameObject.GetComponent<EdgeCollider2D>();

        // Making camera bounds
        var leftBottom = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
        var leftTop = (Vector2)cam.ScreenToWorldPoint(new Vector3(0, cam.pixelHeight, cam.nearClipPlane));
        var rightTop = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, cam.pixelHeight, cam.nearClipPlane));
        var rightBottom = (Vector2)cam.ScreenToWorldPoint(new Vector3(cam.pixelWidth, 0, cam.nearClipPlane));

        var edgePoints = new[] { leftBottom, leftTop, rightTop, rightBottom};

        // Adding edge points
        edgeCollider.points = edgePoints;
    }
}
