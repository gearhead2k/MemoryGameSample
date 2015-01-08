namespace MemoryGame.Engine.List
{
    using System;
    using System.Collections.Generic;

    public static class ListUtilities
    {
        /// <summary>
        /// RandomNumber Generator
        /// </summary>
        public static readonly Random RandomGen = new Random();

        /// <summary>
        /// Shuffle List
        /// </summary>
        /// <param name="list">
        /// The list to shuffle.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        public static void Shuffle<T>(this IList<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list","The list cannot be null");
            }

            if (list.Count == 0)
            {
                return;
            }

            var position = list.Count;
            while (position > 1)
            {
                position--;
                var randPosition = RandomGen.Next(position + 1);
                var value = list[randPosition];
                list[randPosition] = list[position];
                list[position] = value;
            }
        }
    }
}
