using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class MyHelloAR : MonoBehaviour
{

    public Camera camera;


    public GameObject AndyPointPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Touch myTouch;
        if (Input.touchCount < 1 || (myTouch = Input.GetTouch(0)).phase != TouchPhase.Began)
        {
            return;
        }

        TrackableHit hit;
        TrackableHitFlags raycastFilter = TrackableHitFlags.PlaneWithinPolygon | TrackableHitFlags.FeaturePointWithSurfaceNormal;

        if(Frame.Raycast(myTouch.position.x, myTouch.position.y, raycastFilter, out hit))
        {
            GameObject prefeb;

            //if (hit.Trackable is FeaturePoint)
  
                prefeb = AndyPointPrefab;
            //}
            //else
            //{
            //    prefeb = AndyPlanePrefab;
            //}


            var andyObject = Instantiate(prefeb, hit.Pose.position, hit.Pose.rotation);

            andyObject.transform.Rotate(0, 180.0f, 0, Space.Self);

            var anchor = hit.Trackable.CreateAnchor(hit.Pose);

            andyObject.transform.parent = anchor.transform;
        }

    }
}
