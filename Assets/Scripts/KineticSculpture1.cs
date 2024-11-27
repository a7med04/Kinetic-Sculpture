using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace KineticSculpture
{
    public class KineticSculpture : MonoBehaviour
    {
        public GameObject[] cubes;

        void Start()
        {

        }

        void Update()
        {
            float displacement = 0;     
            foreach (GameObject cube in cubes)
            {
                float yRot = Mathf.Sin(Time.time );
                cube.transform.rotation = Quaternion.Euler(new Vector3(0, yRot * 180f + displacement, 0));
                displacement += 5f;
            }
        }
    }
}