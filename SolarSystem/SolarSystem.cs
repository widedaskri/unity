using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    public GameObject soleil; // Le Soleil
    public GameObject terre;  // La Terre (Parent)
    public GameObject lune;   // La Lune (Parent)

    public float vitesseRotationSoleil = 10f;  // Vitesse de rotation du Soleil
    public float vitesseOrbitTerre = 30f;      // Vitesse de l'orbite de la Terre
    public float vitesseRotationTerre = 50f;  // Vitesse de rotation de la Terre sur elle-même
    public float vitesseOrbitLune = 60f;      // Vitesse de l'orbite de la Lune

    void Update()
    {
        // ✅ Rotation du Soleil sur lui-même
        soleil.transform.Rotate(Vector3.up * vitesseRotationSoleil * Time.deltaTime, Space.Self);

        // ✅ Orbite de la Terre autour du Soleil
        terre.transform.RotateAround(soleil.transform.position, Vector3.up, vitesseOrbitTerre * Time.deltaTime);
        
        // ✅ La Terre regarde le Soleil
        terre.transform.LookAt(soleil.transform);

        // ✅ Rotation de la Terre sur elle-même
        terre.transform.GetChild(0).transform.Rotate(Vector3.up * vitesseRotationTerre * Time.deltaTime, Space.Self);

        // ✅ Orbite de la Lune autour de la Terre
        lune.transform.RotateAround(terre.transform.position, Vector3.up, vitesseOrbitLune * Time.deltaTime);
        
        // ✅ La Lune regarde la Terre
        lune.transform.LookAt(terre.transform);
    }
}
