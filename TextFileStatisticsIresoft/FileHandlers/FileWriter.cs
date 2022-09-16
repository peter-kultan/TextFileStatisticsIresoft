using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TextFileStatisticsIresoft
{
    public class FileWriter : INotifyPropertyChanged
    {
        private string _outputFilePath = "";

        public string OutputFilePath
        {
            get { return _outputFilePath; }
            set
            {
                _outputFilePath = value;
                OnPropertyChanged("OutputFilePath");
            }
        }

        public FileWriter() { }

        public void WriteLine(string text)
        {
            using (var stream = OpenFileOnAppend())
                stream.WriteLine(text);
        }

        public void CreateFile()
        {
            using (var stream =new StreamWriter(OutputFilePath))
            {
                stream.Write("");
            }
        }

        private StreamWriter OpenFileOnAppend() => new StreamWriter(OutputFilePath, true);

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
