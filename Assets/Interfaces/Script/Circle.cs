using UnityEngine;

public class Circle :  IShape
{
    float radius = 6f;
    const float PI = Mathf.PI;

    public void CalculateArea()
    {
        float area = PI * radius * radius;
        Debug.Log("Circle Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * PI * radius;
        Debug.Log("Circle Circumference: " + perimeter);
    }

    public void CalculateRadius()
    {
        Debug.Log("Radius of the Circle is: " + radius);
    }
}