using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// This class handles all the user interaction. This includes the user loading
/// an input file as well as them clicking one of the buttons. The output is then printed
/// to the resulting text box (on the bottom).
/// </summary>

namespace Project3_starter
{
    public partial class UserInterface : Form
    {
        public MovieConnections connections { get; set; }

        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the input file that the user selects. This info is then used to
        /// fill connections as well as both of the list boxes.
        /// </summary>
        /// <param name="sender">A required button parameter</param>
        /// <param name="e">A required button parameter</param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uxResultTextBox.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            MovieConnections movieConnections = new MovieConnections();
            connections = movieConnections;

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                string text = File.ReadAllText(file);
                string[] temp1 = text.Split('\n');
                List<string> separatedText = new List<string>();

                foreach (string line in temp1)
                {
                    if (line.Length == 0)
                    {
                        uxResultTextBox.Text = "Please enter a proper file";
                        return;
                    }
                    string[] temp2 = line.Split(',');
                    connections.AddActorLine(temp2[0], temp2[1].Trim());

                    separatedText.Add(temp2[0]);
                }
                List<Actor> list = connections.PrintActors();

                foreach (Actor actor in list)
                {
                    listBox1.Items.Add(actor.Name);
                    listBox2.Items.Add(actor.Name);
                }
            }
        }

        /// <summary>
        /// This method gets all of the movies from the actor selected in the left list box
        /// and prints them out.
        /// </summary>
        /// <param name="sender">A required button parameter</param>
        /// <param name="e">A required button parameter</param>
        private void uxFindMovies_Click(object sender, EventArgs e)
        {
            uxResultTextBox.Clear();
            if (listBox1.Items.Count == 0)
            {
                uxResultTextBox.AppendText("Please load in a file");
                return;
            }
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
            {
                uxResultTextBox.AppendText("Please select two different actors");
                return;
            }

            string s1 = listBox1.SelectedItem.ToString();
            List<Actor> list = connections.GetActors();

            foreach (Actor a in list)
            {
                if (a.Name == s1)
                {
                    foreach (string s in a.Movies)
                    {
                        uxResultTextBox.AppendText(s);
                        uxResultTextBox.AppendText(Environment.NewLine);
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// This method finds the shortest path from the starting actor to the desired one.
        /// </summary>
        /// <param name="sender">A required button parameter</param>
        /// <param name="e">A required button parameter</param>
        private void uxFindPath_Click(object sender, EventArgs e)
        {
            uxResultTextBox.Clear();
            if (listBox1.Items.Count == 0)
            {
                uxResultTextBox.AppendText("Please load in a file");
                return;
            }
            if (listBox1.SelectedItem == null || listBox2.SelectedItem == null)
            {
                uxResultTextBox.AppendText("Please select two different actors");
                return;
            }
            string s1 = listBox1.SelectedItem.ToString();
            string s2 = listBox2.SelectedItem.ToString();
            if (s1 == s2)
            {
                uxResultTextBox.AppendText("Please select two different actors");
                return;
            }
            Actor one = new Actor(s1);
            Actor two = new Actor(s2);

            List<Actor> list = connections.GetActors();

            connections.ConnectCostars();
            foreach (Actor a in list)
            {
                if (a.Name == s1)
                {
                    one = a;
                }
                else if (a.Name == s2)
                {
                    two = a;
                }
            }
            string s = connections.GetConnection(one, two);
            uxResultTextBox.AppendText(s);
        }
    }
}
