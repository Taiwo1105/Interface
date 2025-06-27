using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IShape trapezium = new Trapezium();
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();

        IShape circle = new Circle();
        circle.CalculateArea();
        circle.CalculatePerimeter();

        IShape nonagon = new Nonagon();
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();

        // Cast to call shape-specific methods
        ((Circle)circle).CalculateRadius();
        int sides = ((Nonagon)nonagon).CalculateNumberOfSides();
        Debug.Log("Nonagon has " + sides + " sides.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
