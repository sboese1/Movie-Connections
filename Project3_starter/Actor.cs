using System;
using System.Collections.Generic;

/// <summary>
/// This class holds each actor's info like their name and all of the
/// movies they've been in.
/// </summary>

namespace Project3_starter
{
    public class Actor : IComparable<Actor>
    {
        public string Name { get; private set; }
        public List<string> Movies { get; private set; }

        public Actor(string name)
        {
            Name = name;
            Movies = new List<string>();
        }

        /// <summary>
        /// Adds a movie to the Movies list.
        /// </summary>
        /// <param name="n">The name of the movie</param>
        public void AddMovie(string n)
        {
            if (!Movies.Contains(n))
            {
                Movies.Add(n);
            }
        }

        /// <summary>
        /// Returns the actor's name.
        /// </summary>
        /// <returns>The actor's name</returns>
        public override string ToString()
        {
            return this.Name;
        }

        /// <summary>
        /// Compares two actors to one another.
        /// </summary>
        /// <param name="other">The actor to be compared to</param>
        /// <returns>An integer depending on which one's name is greater (or equal)</returns>
        public int CompareTo(Actor other)
        {
            if (this.Name.Length > other.Name.Length)
            {
                for (int i = 0; i < other.Name.Length; i++)
                {
                    if (other.Name[i] > this.Name[i])
                    {
                        return -1;
                    }
                    else if (other.Name[i] < this.Name[i])
                    {
                        return 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < this.Name.Length; i++)
                {
                    if (other.Name[i] > this.Name[i])
                    {
                        return -1;
                    }
                    else if (other.Name[i] < this.Name[i])
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }
}
