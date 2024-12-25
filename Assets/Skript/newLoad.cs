using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class newLoad : MonoBehaviour
{
    public class sdata{
        public float x, y, z, xr, yr, zr;
        public byte r, g, b;
    }

    public GameObject Cube;
    public sdata data;

    public void WrapLoading()
    {
        data = JsonUtility.FromJson<data>(File.ReadAllText(Application.streamingAssetsPath + "/data.json"));
    }

    public void WrapSaving()
    {
        data.x = Cube.transform.pozition.x;
        data.y = Cube.transform.pozition.y;
        data.z = Cube.transform.pozition.z;
        data.xt = Cube.transform.rotation.x;
        data.yt = Cube.transform.rotation.y;
        data.zt = Cube.transform.rotation.z;
        data.r = (byte)Cube.GetComponent<Renderer>.material.color.r;
        data.g = (byte)Cube.GetComponent<Renderer>.material.color.g;
        data.b = (byte)Cube.GetComponent<Renderer>.material.color.b;
        File.WriteAllText(Application.streamingAssetsPath + "/data.json", JsonUtility.ToJson(data));

    }

    public void Start
    {
        Cube.GetComponent<Renderer>().material.color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
        data.x = Cube.transform.pozition.x;
        data.y = Cube.transform.pozition.y;
        data.z = Cube.transform.pozition.z;
        data.xt = Cube.transform.rotation.x;
        data.yt = Cube.transform.rotation.y;
        data.zt = Cube.transform.rotation.z;
        data.r = (byte)Cube.GetComponent<Renderer>.material.color.r;
        data.g = (byte)Cube.GetComponent<Renderer>.material.color.g;
        data.b = (byte)Cube.GetComponent<Renderer>.material.color.b;
        File.WriteAllText(Application.streamingAssetsPath + "/data.json", JsonUtility.ToJson(data));
    }
    

}
