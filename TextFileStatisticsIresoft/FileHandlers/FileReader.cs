using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TextFileStatisticsIresoft
{
    public class FileReader : INotifyPropertyChanged
    {
        private int _progress = 0;

        public int Progress
        {
            get { return _progress; }
            set
            {
                _progress = value;
                OnPropertyChanged("Progress");
            }
        }


        private string _inputFilePath = "";

        public string InputFilePath
        {
            get { return _inputFilePath; }
            set
            {
                _inputFilePath = value;
                OnPropertyChanged("InputFilePath");
            }
        }


        private int _numberOfChars = 0;

        public int NumberOfChars
        {
            get { return _numberOfChars; }
            set
            {
                _numberOfChars = value;
                OnPropertyChanged("NumberOfChars");
            }
        }

        private int _numberOfWords = 0;

        public int NumberOfWords
        {
            get { return _numberOfWords; }
            set
            {
                _numberOfWords = value;
                OnPropertyChanged("NumberOfWords");
            }
        }

        private int _numberOfSentences = 0;

        public int NumberOfSentences
        {
            get { return _numberOfSentences; }
            set
            {
                _numberOfSentences = value;
                OnPropertyChanged("NumberOfSentences");
            }
        }

        private int _numberOfLines = 0;

        public int NumberOfLines
        {
            get { return _numberOfLines; }
            set
            {
                _numberOfLines = value;
                OnPropertyChanged("NumberOfLines");
            }
        }

        public FileReader() { }

        public void LoadFileStats()
        {
            if (!File.Exists(InputFilePath))
            {
                return;
            }

            using (var stream = OpenFile())
                while (!stream.EndOfStream)
                {
                    var line = stream.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    NumberOfLines++;

                    NumberOfChars += line.Length;

                    NumberOfSentences += line.Split(new char[] { '.', '!', '?' }).Where(x => x != ".").Count();

                    NumberOfWords += line.Split(new char[] { ',', ' ', '.' }).Count();
                }
        }

        public IEnumerable<string> ReadLineByLine()
        {
            int actuallLine = 0;
            ; if (!File.Exists(InputFilePath))
            {
                yield break;
            }

            using (var stream = OpenFile())
                while (!stream.EndOfStream)
                {
                    var line = stream.ReadLine();

                    if (line == null)
                    {
                        break;
                    }
                    actuallLine++;
                    Progress = (actuallLine * 100) / NumberOfLines;
                    yield return line;
                }
        }

        public StreamReader OpenFile() => new StreamReader(InputFilePath);

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
