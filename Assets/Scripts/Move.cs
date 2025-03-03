using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

//using System.Numerics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    struct VectorXYZ {
        public float x;
        public float y;
        public float z;
        public VectorXYZ(float x, float y, float z){
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Length_Vector(float x, float y, float z){
            return Math.Sqrt(x*x + y*y + z*z);
        }
        public VectorXYZ Edin(float x, float y, float z){
            double a = Math.Sqrt(x*x + y*y + z*z);
            return new VectorXYZ(Convert.ToSingle(x/a), Convert.ToSingle(y/a), Convert.ToSingle(z/a));
        }
        public double DotScal(float x, float y, float z){
            return this.x*x + this.y*y + this.z*z;
        }
        public VectorXYZ DotVect(float x, float y, float z){
            return new VectorXYZ(Convert.ToSingle(this.y*z - this.z*y), Convert.ToSingle(this.z*x - this.x*z), Convert.ToSingle(this.x*y - this.y*x));;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        VectorXYZ vec1 = new VectorXYZ(3f, 3f, 3f);
        Vector3 vec2 = new Vector3(3, 3, 3);
        Debug.Log("Вектор Unity:");
        Debug.Log("Длина: " + vec2.magnitude);
        Debug.Log("Единичный сонаправленный вектор: " + vec2.normalized);
        Debug.Log("Скалярное произведение: " + Vector3.Dot(vec2, new Vector3(1, 2, 3)));
        Debug.Log("Векторное произведение: " + Vector3.Cross(vec2, new Vector3(1, 2, 3)));

        Debug.Log("Наш вектор:");
        Debug.Log("Длина: " + vec1.Length_Vector(vec1.x, vec1.y, vec1.z));
        Debug.Log("Единичный сонаправленный вектор: " + vec1.Edin(vec1.x, vec1.y, vec1.z).x + " " +
                                                        vec1.Edin(vec1.x, vec1.y, vec1.z).y + " " +
                                                        vec1.Edin(vec1.x, vec1.y, vec1.z).z);
        Debug.Log("Скалярное произведение: " + vec1.DotScal(1f, 2f, 3f));
        Debug.Log("Векторное произведение: " + vec1.DotVect(1f, 2f, 3f).x + " " +
                                               vec1.DotVect(1f, 2f, 3f).y + " " +
                                               vec1.DotVect(1f, 2f, 3f).z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
