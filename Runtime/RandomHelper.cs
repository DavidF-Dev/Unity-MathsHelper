﻿// File: RandomHelper.cs
// Purpose: Various static helper methods to do with randomness
// Created by: DavidFDev

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using UnityEngine;

namespace DavidFDev.Maths
{
    /// <summary>
    ///     Collection of static helper methods to do with randomness.
    /// </summary>
    public static class RandomHelper
    {
        #region Static fields and constants

        /// <summary>
        ///     Random number generator used by the helper methods.
        /// </summary>
        public static System.Random RNG { get; private set; } = null;

        /// <summary>
        ///     Seed used by the random number generator instance.
        ///     Setting a new seed will initialise a new random number generator.
        /// </summary>
        public static int Seed
        {
            get
            {
                return _seed;
            }
            set
            {
                _seed = value;
                RNG = new System.Random(_seed);
            }
        }

        private static int _seed = 0;

        private const float PI_2 = Mathf.PI * 2f;

        #endregion

        #region Static constructor

        static RandomHelper()
        {
            Seed = Environment.TickCount;
        }

        #endregion

        #region Static methods

        /// <summary>
        ///     Retrieve a random bool value.
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static bool NextBool()
        {
            return RNG.Next(1) == 0;
        }

        /// <summary>
        ///     Retrieve a random float value between 0 [inclusive] and 1 [exclusive].
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static float NextFloat()
        {
            return (float)RNG.NextDouble();
        }

        /// <summary>
        ///     Retrieve a random float between 0 [inclusive] and a max value [exclusive].
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        [Pure]
        public static float NextFloat(float max)
        {
            return NextFloat() * max;
        }

        /// <summary>
        ///     Retrieve a random int between 0 [inclusive] and a max value [exclusive].
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        [Pure]
        public static int NextInt(int max)
        {
            return RNG.Next(max);
        }

        /// <summary>
        ///     Retrieve a random angle between 0 and 2 PI (radians).
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static float NextAngle()
        {
            return NextFloat(PI_2);
        }

        /// <summary>
        ///     Retrieve a colour with random component values (rgb).
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static Color NextColour()
        {
            return new Color(NextFloat(), NextFloat(), NextFloat());
        }

        /// <summary>
        ///     Retrieve a random unit vector.
        /// </summary>
        /// <param name="magnitude"></param>
        /// <returns></returns>
        [Pure]
        public static Vector2 NextVector2(float magnitude = 1f)
        {
            return MathsHelper.GetDirection(NextAngle() * Mathf.Rad2Deg) * magnitude;
        }

        /// <summary>
        ///     Retrive a random unit vector.
        /// </summary>
        /// <param name="magnitude"></param>
        /// <returns></returns>
        [Pure]
        public static Vector3 NextVector3(float magnitude = 1f)
        {
            return MathsHelper.GetDirection(NextAngle() * Mathf.Rad2Deg) * magnitude;
        }

        /// <summary>
        ///     Retrieve a random float between a min value [inclusive] and a max value [exclusive].
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        [Pure]
        public static float Range(float min, float max)
        {
            return min + NextFloat(max - min);
        }

        /// <summary>
        ///     Retrieve a random vector with components between a min value [inclusive] and a max value [exclusive].
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        [Pure]
        public static Vector2 Range(Vector2 min, Vector2 max)
        {
            return min + new Vector2(NextFloat(max.x - min.x), NextFloat(max.y - min.y));
        }

        /// <summary>
        ///     Retrieve a random vector with components between a min value [inclusive] and a max value [exclusive].
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        [Pure]
        public static Vector3 Range(Vector3 min, Vector3 max)
        {
            return min + new Vector3(NextFloat(max.x - min.x), NextFloat(max.y - min.y), NextFloat(max.z - min.z));
        }

        /// <summary>
        ///     Retrieve a random float betwen -1 and 1.
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static float MinusOneToOne()
        {
            return NextFloat(2f) - 1f;
        }

        /// <summary>
        ///     Retrieve a random integer, either -1 or 1.
        /// </summary>
        /// <returns></returns>
        [Pure]
        public static int MinusOneOrOne()
        {
            return NextBool() ? -1 : 1;
        }

        /// <summary>
        ///     Roll a random chance.
        /// </summary>
        /// <param name="percent">0.0 - 1.0.</param>
        /// <returns></returns>
        [Pure]
        public static bool Chance(float percent)
        {
            return NextFloat() < percent;
        }

        /// <summary>
        ///     Roll a random chance.
        /// </summary>
        /// <param name="percent">0 - 100.</param>
        /// <returns></returns>
        [Pure]
        public static bool Chance(int percent)
        {
            return NextInt(100) < percent;
        }

        /// <summary>
        ///     Retrieve a random element from a collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        [Pure]
        public static T Choose<T>(this IReadOnlyCollection<T> collection)
        {
            return collection.ElementAt(NextInt(collection.Count));
        }

        #endregion
    }
}
