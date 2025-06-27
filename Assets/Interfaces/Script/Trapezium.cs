using UnityEngine;

public class Trapezium : IShape
{
    float base1 = 10f;
    float base2 = 5f;
    float height = 4f;
    float side1 = 2f;
    float side2 = 4f;

    public void CalculateArea()
    {
        float area = 0.5f * (base1 + base2) * height;
        Debug.Log("Trapezium Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = base1 + base2 + side1 + side2;
        Debug.Log("Trapezium Perimeter: " + perimeter);
    }
}
