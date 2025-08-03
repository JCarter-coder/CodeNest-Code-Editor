using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CodeNest_Code_Editor
{
    public partial class FormMain : Form
    {
        // Let's create a member of our class variable to keep track of the current file path
        private string m_currentFilePath = string.Empty;
        public FormMain()
        {
            // This will run the Visual Studio code that VS generated/wrote.
            InitializeComponent();

            // Let's set up our custom styling after the form is created
            SetupStyling();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // This is the constructor and it runs only once when the form is loaded
            // Let's set up our dialog box filters for text code files
            openFileDialogMain.Filter = "Text Files (*.txt)|*.txt|C Files (*.c)|*.c|C++ Files (*.cpp)|*.cpp|C# Files (*.cs)|*.cs|CSS Files (*.css)|*.css|HTML Files (*.html)|*.html|Java Files (*.java)|*.java|JavaScript Files (*.js)|*.js|Python Files (*.py)|*.py|All Files (*.*)|*.*";
            saveFileDialogMain.Filter = "Text Files (*.txt)|*.txt|C Files (*.c)|*.c|C++ Files (*.cpp)|*.cpp|C# Files (*.cs)|*.cs|CSS Files (*.css)|*.css|HTML Files (*.html)|*.html|Java Files (*.java)|*.java|JavaScript Files (*.js)|*.js|Python Files (*.py)|*.py|All Files (*.*)|*.*";

            richTextBoxEditor.Focus();
        }

        // This is our code to set up our custom styling after the form has been created
        private void SetupStyling()
        {
            // Let's give our form a darker theme for now
            this.BackColor = Color.DarkGray;
            //this.ForeColor = Color.FromArgb(200, 200, 200);
            // Let's style the menu strip
            menuStripMainMenus.BackColor = Color.SlateGray;
            menuStripMainMenus.ForeColor = Color.White;

            // Let's style the editor which is our rich text box
            richTextBoxEditor.BackColor = Color.Black;
            richTextBoxEditor.ForeColor = Color.White;
            richTextBoxEditor.Font = new Font("Consolas", 12);
            richTextBoxEditor.AcceptsTab = true;
            richTextBoxEditor.WordWrap = true;

            richTextBoxLineNumbers.BackColor = Color.Black;
            richTextBoxLineNumbers.ForeColor = Color.White;
            richTextBoxLineNumbers.Font = new Font("Consolas", 12);
            richTextBoxLineNumbers.AcceptsTab = true;
            richTextBoxLineNumbers.WordWrap = true;

            // Let's style the status strip
            statusStripMainStatus.BackColor = Color.Black;
            toolStripStatusLabelMain.BackColor = Color.Black;
            toolStripStatusLabelMain.ForeColor = Color.White;

            toolStripStatusLabelMain.Text = "Type your code in here...";

            // Let's expand the window title to set it to this
            // When we type in the word this, it means the code behind for the form we are in
            this.Text = "CodeNest Code Editor - Untitled";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // The user raised an event to start a new file
            // As developers, we need to handle this event
            // First let's clear all the text in the editor
            richTextBoxEditor.Clear();
            // Clear our current file path
            m_currentFilePath = string.Empty;
            // Now let's set the current title 
            this.Text = "CodeNest Code Editor - Untitled";
            // Let the user know what is going on
            toolStripStatusLabelMain.Text = "New file created";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Let's close the application at the user's request
            // The user raised the event to close the application
            // Here we handle the close event with our code
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This method will run when the user raises this click event by clicing on the open from our file menu
            // Let's give our user a dialog to choose a file to open
            if (openFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Now let's try to read the user selected file and put it in the editor
                    string fileContent = File.ReadAllText(openFileDialogMain.FileName);
                    richTextBoxEditor.Text = fileContent;
                    m_currentFilePath = openFileDialogMain.FileName;
                    this.Text = "CodeNest Code Editor - " + Path.GetFileName(openFileDialogMain.FileName);
                    toolStripStatusLabelMain.Text = "Opened file: " + Path.GetFileName(openFileDialogMain.FileName);
                }
                catch (Exception ex)
                {
                    // If trying to open an existing file fails, an event is raised and we handle it here
                    MessageBox.Show("Error opening file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This method will run when the user raises this click event by clicing on the save from our file menu
            // Now let's check where we can save the file, do we already have a file path from a previous save?
            if (string.IsNullOrEmpty(m_currentFilePath))
            {
                // Show a dialog to chosse where to save the current file
                if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
                {
                    m_currentFilePath = saveFileDialogMain.FileName;
                }
                else
                {
                    // If we are here, the user cancelled the save
                    // Do nothing
                    return;
                }
            }

            // Let's try to save the text in the editor to the file path
            try
            {
                File.WriteAllText(m_currentFilePath, richTextBoxEditor.Text);
                this.Text = "CodeNest Code Editor - " + Path.GetFileName(m_currentFilePath);
                toolStripStatusLabelMain.Text = "Saved file: " + Path.GetFileName(m_currentFilePath);
            }
            catch (Exception ex)
            {
                // Show an error box to the user if the file cannot be saved
                MessageBox.Show("Error saving file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Debug Save As method
            // This method will run when the user raises this click event by clicing on the save as from our file menu
            // Now let's show the user the save dialog box even if we already have another current file
            // in our editor that we could just press save to save
            // Show a dialog to chosse where to save the current file
            if (saveFileDialogMain.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Give user option to save the text file in a new or the same location
                    File.WriteAllText(saveFileDialogMain.FileName, richTextBoxEditor.Text);
                    m_currentFilePath = saveFileDialogMain.FileName;
                    this.Text = "CodeNest Code Editor - " + Path.GetFileName(m_currentFilePath);
                    toolStripStatusLabelMain.Text = "Saved file as: " + Path.GetFileName(m_currentFilePath);
                }
                catch (Exception ex)
                {
                    // If an error is raised, show it to the user via message box
                    MessageBox.Show("Error saving as file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //// First let's ask our user what text are you looking for?
            //string searchText = Microsoft.VisualBasic.Interaction.InputBox("Enter the text to find:", "Find", "");

            //// This checks if the user entred something to search for
            //if (!string.IsNullOrEmpty(searchText))
            //{
            //    // This searches for the text in the rich text box
            //    int index = richTextBoxEditor.Find(searchText, RichTextBoxFinds.None);

            //    if (index >= 0)
            //    {
            //        // Let's highlight the found text
            //        richTextBoxEditor.SelectionStart = index;
            //        richTextBoxEditor.SelectionLength = searchText.Length;
            //        richTextBoxEditor.Focus();
            //        richTextBoxEditor.Text = "Found: " + searchText;
            //    }
            //    else
            //    {
            //        // This tells the user if the text wasn't found
            //        toolStripStatusLabelMain.Text = "Text not found: " + searchText;
            //        MessageBox.Show("Text not found!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void richTextBoxEditor_TextChanged(object sender, EventArgs e)
        {
            // This method will run when any change in the rich text box changes
            // Let's count the number of lines in the code
            int lineCount = richTextBoxEditor.Lines.Length;

            // Let's count the number of characters
            int charCount = richTextBoxEditor.Text.Length;

            // Let's update the status strip to let our user know the counts
            toolStripStatusLabelMain.Text = $"Lines: {lineCount} | Characters: {charCount}";

            // Update the line numbers in the line numbers rich text box
            richTextBoxLineNumbers.Clear();
            for (int i = 1; i <= lineCount; i++)
            {
                // Append the line number to the line numbers rich text box
                richTextBoxLineNumbers.AppendText(i.ToString() + Environment.NewLine);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This is an informational modal about the program
            MessageBox.Show(
                "CodeNest is a code editor for your code editing needs. It can create, save, and update files of various formats. New features will be added in the future.", 
                "", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information
                );
        }
    }
}
