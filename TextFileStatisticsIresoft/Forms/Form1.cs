namespace TextFileStatisticsIresoft
{
    public partial class Form1 : Form
    {

        public OpenFileDialog OpenFileDialog { get; private set; } = new OpenFileDialog();

        public SaveFileDialog SaveFileDialog { get; private set; } = new SaveFileDialog();

        public FileReader reader = new FileReader();

        public FileWriter writer = new FileWriter();

        public Form1()
        {
            InitializeComponent();
            formatProgressBar.Minimum = 0;
            formatProgressBar.Maximum = 100;
            formatProgressBar.Step = 1;
            numberOfLinesLabel.DataBindings.Add(new Binding("Text", reader, "NumberOfLines"));
            numberOfWordsLabel.DataBindings.Add(new Binding("Text", reader, "NumberOfWords"));
            numberOfSentencesLabel.DataBindings.Add(new Binding("Text", reader, "NumberOfSentences"));
            numberOfCharsLabel.DataBindings.Add(new Binding("Text", reader, "NumberOfChars"));
            inputFileTextBox.DataBindings.Add(new Binding("Text", reader, "InputFilePath"));
            outputFileTextBox.DataBindings.Add(new Binding("Text", writer, "OutputFilePath"));
            formatProgressBar.DataBindings.Add(new Binding("Value", reader, "Progress"));
            startFormatButton.Enabled = false;
        }

        private void inputFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFileDialog.FilterIndex = 1;
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                reader.InputFilePath = OpenFileDialog.FileName;
                startFormatButton.Enabled = reader.InputFilePath != "" && writer.OutputFilePath != "";
            }
        }

        private void outputFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog.FilterIndex = 1;
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                writer.OutputFilePath = SaveFileDialog.FileName;
                startFormatButton.Enabled = reader.InputFilePath != "" && writer.OutputFilePath != "";
            }
        }

        private void reloadStatsButton_Click(object sender, EventArgs e)
        {
            reader.LoadFileStats();
        }

        private void startFormatButton_Click(object sender, EventArgs e)
        {
            if (reader.NumberOfLines == 0)
            {
                reader.LoadFileStats();
            }
            Utils.FormatTextFile(writer, reader);
        }
    }
}