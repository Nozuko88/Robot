using System;
using System.Collection.Generic;

namespace RobotMovementApp
{

    // Abstract class representing any shape a robot can move in 
    abstract class Shape 
    {

        // Abstract method to be implemented by each specific shape 
        public abstract void Move();
    }

    // Class representing a Square shape 
    class Square : Shape
    {

        private int size; // side length of the square 

        // Constructor to initialize the size
        public Square(int size)
        {
            this.size = size;
        }

        // Method to move the robot in a square
        public override void Move()
        {
            int degrees = 90;
            Console.WriteLine($"Moving in a square of size{size}");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"* Move Forward {size}");
                Console.WriteLine($" * Turn Right{degrees} degrees");

            }
        }
    }

    // Class representing a rectangle shape
    class Rectangle : Shape
    {
        private int length;
        private int width;

        // Constructor to initialize the length and width of the rectangle
        public Rectangle(int length, int width)
        {

            this.length = length;
            this.width = width;
        }
    }

    // Method to move the robot in a rectangle 
    public override void Move()
        {
            int degrees = 90;
            Console.WriteLine
        }
    }