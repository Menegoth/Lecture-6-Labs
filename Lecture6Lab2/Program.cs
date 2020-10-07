using System;
using System.Runtime.CompilerServices;

/// Week 6		Lab 2
/// File Name: Program.cs
/// @author: Antonio Monteiro
/// Date:  October 5th 2020

namespace Lecture6Lab2 {

    //fraction class
    class Fraction {

        //instance variables
        private int nominator;
        private int denominator;

        //constructor methods
        public Fraction() {

        }
        public Fraction(int nominator, int denominator) {

            this.nominator = nominator;
            this.denominator = denominator;

        }

        //get and set nominator

        public int GetNominator() {
            return nominator;
        }
        public void SetNominator(int nominator) {
            this.nominator = nominator;
        }

        //get and set denominator
        public int GetDenominator() {
            return denominator;
        }

        public void SetDenominator(int denominator) {
            this.denominator = denominator;
        } 

        //division method
        public double Divide() {
            return Convert.ToDouble(nominator) / Convert.ToDouble(denominator);
        }

        //lowest common denominator method
        public String LowestCommonDenominator() {
            int lowest = 0;

            //loop through every number at nominator value and below checking for divisible by 0
            for (int i = nominator; i > 1; i--) {

                if (nominator % i == 0 && denominator % i == 0) {
                    lowest = i;
                    break;
                }

            }

            if (lowest == 0) {
                return "The fraction " + nominator + "/" + denominator + " is already simplified.";
            } else {
                return nominator + "/" + denominator + " = " + nominator / lowest + "/" + denominator / lowest;
            }
            
        }

        //ToString and Equals
        public override String ToString() {
            return nominator + "/" + denominator;
        }

        public bool Equals(Fraction other) {
            return nominator == other.nominator && denominator == other.denominator;
        }

    }

    class Program {
        static void Main(string[] args) {

            //test fractions
            Fraction testFraction = new Fraction(75, 150);
            Fraction testFraction2 = new Fraction();

            //testing set functions
            testFraction2.SetNominator(1);
            testFraction2.SetDenominator(2);

            //testing get functions
            Console.WriteLine(testFraction.GetNominator());
            Console.WriteLine(testFraction.GetDenominator());

            //testing tostring and equals functions
            Console.WriteLine(testFraction.ToString());
            Console.WriteLine(testFraction.Equals(testFraction2));

            //testing math functions
            Console.WriteLine(testFraction.Divide());
            Console.WriteLine(testFraction.LowestCommonDenominator());

        }
    }
}
