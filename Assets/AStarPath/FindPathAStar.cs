using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.Collections;
using System.IO.Compression;

public class PathMarker{
    public MapLocation location;
    public float G;
    public float H;
    public float F;
    public GameObject marker;
    public PathMarker parent;

    public PathMarker(MapLocation l, float g, float h, float f, GameObject marker, PathMarker p){
        location = l;
        G = g;
        H = h;
        F = f;
        this.marker = marker;
        parent = p;
    }

    public override bool Equals(object obj)
    {
        if ((obj == null) || !this.GetType().Equals(obj.GetType())){
            return false;
        }
        else{
            return location.Equals(((PathMarker) obj).location);
        }
    }

    public override int GetHashCode()
    {
        return 0;
    }

}

public class FindPathAStar : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
