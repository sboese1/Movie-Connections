using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// This class connects all of the actors together (hence the name) to try
/// to go from the starting actor to the desired one.
/// </summary>

namespace Project3_starter
{
    public class MovieConnections
    {
        private List<Actor> _actors = new List<Actor>();
        private Dictionary<Actor, List<Costar>> _costarsByActor = new Dictionary<Actor, List<Costar>>();
        private Dictionary<Actor, bool> _visited = new Dictionary<Actor, bool>();
        private Dictionary<Actor, KeyValuePair<Actor, string>> _connections = new Dictionary<Actor, KeyValuePair<Actor, string>>();

        /// <summary>
        /// Adds a movie to a certain actor or in some cases, creates an actor then
        /// adds it the _actors list.
        /// </summary>
        /// <param name="n">Actor name</param>
        /// <param name="movie">Movie actor is in</param>
        public void AddActorLine(string n, string movie)
        {
            var item = _actors.FirstOrDefault(f => f.Name == n);
            if (item != null)
            {
                item.AddMovie(movie);
            }
            else
            {
                Actor a = new Actor(n);
                a.AddMovie(movie);
                _actors.Add(a);
            }
        }

        /// <summary>
        /// Returns the list of actors.
        /// </summary>
        /// <returns>The list of actors</returns>
        public List<Actor> GetActors()
        {
            return _actors;

        }

        /// <summary>
        /// Connects actors together based on common movies both.
        /// have been in.
        /// </summary>
        public void ConnectCostars()
        {
            _costarsByActor.Clear();
            List<Costar> costars;
            foreach (var outerActor in _actors)
            {
                costars = new List<Costar>();
                foreach (var innerActor in _actors)
                {
                    if (outerActor != innerActor)
                    {
                        var Common = outerActor.Movies.Intersect(innerActor.Movies);
                        foreach (var i in Common)
                        {
                            Costar c = new Costar(outerActor, innerActor, i);
                            costars.Add(c);
                        }
                    }
                }
                _costarsByActor.Add(outerActor, costars);
            }
        }

        /// <summary>
        /// Finds the shortest path from the starting actor to the 
        /// desired actor.
        /// </summary>
        /// <param name="start">The starting actor (left list box)</param>
        /// <param name="stop">The desired actor (right list box)</param>
        /// <returns></returns>
        private bool FindPath(Actor start, Actor stop)
        {
            foreach (var actor in _actors)
            {
                _visited[actor] = false;
                _connections[actor] = default(KeyValuePair<Actor, string>);
            }

            Queue<Actor> queue = new Queue<Actor>();
            List<Actor> first = new List<Actor>();
            first.Add(start);
            queue.Enqueue(start);
            _visited[start] = true;

            while (queue.Count > 0)
            {
                Actor cur = queue.Dequeue();
                if (cur == stop)
                {
                    return true;
                }
                
                foreach (var actor in _costarsByActor[cur])
                {
                    if (!_visited[actor.SecondActor])
                    {
                        queue.Enqueue(actor.SecondActor);
                        _visited[actor.SecondActor] = true;
                        _connections[actor.SecondActor] = new KeyValuePair<Actor, string>(cur, actor.Movie);
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Finds the connection outlined by the method FindPath, and 
        /// returns it to be printed out.
        /// </summary>
        /// <param name="start">The starting actor (left list box)</param>
        /// <param name="stop">The desired actor (right list box)</param>
        /// <returns>The connection from the starting actor to the desired actor</returns>
        public string GetConnection(Actor start, Actor stop)
        {
            if (FindPath(start, stop))
            {
                StringBuilder sb1 = new StringBuilder();
                Actor actor = stop;
                while (actor != start)
                {
                    sb1.Insert(0, Environment.NewLine);
                    sb1.Insert(0, "->" + actor.Name + ": " + _connections[actor].Value);
                    sb1.Insert(0, _connections[actor].Key);
                    actor = _connections[actor].Key;
                }
                return sb1.ToString();
            }
            return "No connection found";
        }

        /// <summary>
        /// This method shifts around the actors' names a little bit to sort them
        /// alphabetically by last name (and then first name if they have the same last name).
        /// </summary>
        /// <returns>Returns a alphabetically sorted list of actors' names</returns>
        public List<Actor> PrintActors()
        {
            List<Actor> temp = new List<Actor>(_actors);
            List<Actor> list1 = new List<Actor>();
            List<Actor> list2 = new List<Actor>();
            StringBuilder sb = new StringBuilder();

            foreach (Actor a in temp)
            {
                string[] pieces = a.Name.Split(' ');
                for (int i = pieces.Length - 1; i >= 0; i--)
                {
                    sb.Append(pieces[i] + " ");
                }
                Actor a1 = new Actor(sb.ToString().Trim());
                foreach (string s in a.Movies)
                {
                    a1.AddMovie(s);
                }
                list1.Add(a1);
                sb.Clear();
            }
            list1.Sort();
            foreach (Actor a in list1)
            {
                string[] pieces = a.Name.Split(' ');
                for (int i = pieces.Length - 1; i >= 0; i--)
                {
                    sb.Append(pieces[i] + " ");
                }
                Actor a1 = new Actor(sb.ToString().Trim());
                foreach (string s in a.Movies)
                {
                    a1.AddMovie(s);
                }
                list2.Add(a1);
                sb.Clear();
            }
            return list2;
        }
    }
}
