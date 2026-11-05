using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class ColorByHeight : MonoBehaviour
{
    private Renderer objectRenderer;

    [Header("Ustawienia wysokoœci")]
    public float minY = 0;
    public float maxY = 100;

    [Header("Kolory")]
    public UnityEngine.Color lowColor;
    public UnityEngine.Color highColor;

    void Start()
    {
        // Pobieramy komponent Renderer obiektu
        objectRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Pobieramy aktualn¹ pozycjê Y obiektu
        float terazY = transform.position.y;

        // Obliczamy wspó³czynnik (od 0 do 1) na podstawie pozycji Y
        float t = Mathf.InverseLerp(minY, maxY, terazY);

        // Interpolujemy kolor pomiêdzy lowColor a highColor
        UnityEngine.Color finalColor = UnityEngine.Color.Lerp(lowColor, highColor, t);

        // Przypisujemy nowy kolor do materia³u obiektu
        objectRenderer.material.color = finalColor;
    }
}