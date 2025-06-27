using UnityEngine;

public class Nonagon : IShape
{
    int numberOfSides = 9;
    float sideLength = 4f;

    public void CalculateArea()
    {
        float area = (9f / 4f) * sideLength * sideLength * (1f / Mathf.Tan(Mathf.PI / 9f));
        Debug.Log("Nonagon Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("Nonagon Perimeter: " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}
