using System.Text.RegularExpressions;

namespace UntilDawnRemakeSoftlockFixer
{
    public partial class Form1 : Form
    {
        MatchCollection Matches;
        string textData;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select SaveGame.sav File";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "All files|*.*|Save Files|*.sav";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != string.Empty)
            {
                SaveFilePath.Text = openFileDialog.FileName;
            }
            else
            {
                SaveFilePath.Text = string.Empty;
            }
        }

        private void SaveFilePath_TextChanged(object sender, EventArgs e)
        {
            LoadFileButton.Enabled = SaveFilePath.Text != string.Empty;
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new StreamReader(SaveFilePath.Text);
                textData = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();

                string pattern = @"Is Statemachine (\w+) done\?";
                Regex rg = new Regex(pattern);

                Matches = rg.Matches(textData);

                EventSelector.DataSource = Matches.Select(x => x.Groups[1].Value).Distinct().Prepend("Select the most recent event you completed").ToList();
                EventSelector.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Unable to open file, please check path, close any processes using this file, and try again", "Error");
            }
        }

        private void RevertButton_Click(object sender, EventArgs e)
        {
            try
            {
                var replaceVal = Matches[EventSelector.SelectedIndex - 1].Groups[0].Value;
                textData = ReplaceFirst(textData, replaceVal, string.Empty);
                File.WriteAllText(SaveFilePath.Text, textData);
                MessageBox.Show("Event reverted, see if your save file is fixed now. If not, restore your backup! You may close the application now.", "Success!");
            }
            catch
            {
                MessageBox.Show("Unable to open file, please check path, close any processes using this file, and try again", "Error");
            }
            
        }

        private void EventSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            RevertButton.Enabled = EventSelector.SelectedIndex != 0;
        }

        private string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

    }
}
