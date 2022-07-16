using System;
using UnityEngine;

namespace RedPanda.Utils
{
    public static class MathUtils
    {
        /// <summary>
        /// Type max value firstly, if min value is not assigned, it will be 0.
        /// </summary>
        public static int Randomize(int maxValue, int minValue = 0) => UnityEngine.Random.Range(minValue, maxValue);
        /// <summary>
        /// Type max value firstly, if min value is not assigned, it will be 0.
        /// </summary>
        public static float Randomize(float maxValue, float minValue = 0f) => UnityEngine.Random.Range(minValue, maxValue);
        /// <summary>
        /// Spawns a gameobject and directs it according to between two points. 
        /// </summary>
        public static void SpawnObjectBetweenTwoPoints(GameObject objectToSpawn, Vector3 firstPoint, Vector3 secondPoint)
        {
            Vector3 middlePoint = (firstPoint + secondPoint) / 2;
            Vector3 angle = new Vector3(0, AngleBetweenTwoVectors(firstPoint, secondPoint), 0);
            objectToSpawn.transform.SetPositionAndRotation(middlePoint, Quaternion.Euler(angle));
        }
        /// <summary>
        /// Returns angle value as degree.
        /// </summary>
        public static float AngleBetweenTwoVectors(Vector3 from, Vector3 to)
        {
            float angle = Vector3.Angle(Vector3.forward, to - from);

            if (from.x > to.x)
            {
                angle = 360 - angle;
            }

            return angle;
        }
        public static Vector3 GetMousePosition_Y(Camera camera, Vector3 mousePosition)
        {
            Vector3 mouseWorld = camera.WorldToScreenPoint(mousePosition);
            mouseWorld.x = 0f;
            mouseWorld.z = 0f;

            return mouseWorld;
        }
        public static double AreaCalculation(double[,] coordinates)
        {
            double sum = 0;

            for (int i = 0, queue = 0; i < coordinates.GetLength(0); i++)
            {
                double x1, x2;
                double Y = coordinates[i, 1];

                if (queue == 0)
                {
                    x1 = coordinates[i + 1, 0];
                    x2 = coordinates[coordinates.GetLength(0) - 1, 0];
                }
                else if (queue == coordinates.GetLength(0) - 1)
                {
                    x1 = coordinates[0, 0];
                    x2 = coordinates[i - 1, 0];
                }
                else
                {
                    x1 = coordinates[i + 1, 0];
                    x2 = coordinates[i - 1, 0];
                }

                sum += Y * (x1 - x2);

                queue++;
            }

            return Math.Abs(sum / 2);
        }
    }
}