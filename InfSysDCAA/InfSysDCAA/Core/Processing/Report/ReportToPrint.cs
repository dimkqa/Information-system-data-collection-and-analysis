using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace InfSysDCAA.Core.Processing.Report
{
    /// <summary>
    /// Печать документа 
    /// </summary>
    public class ReportToPrint
    {
        /// <summary>
        /// Путь до файла, который необходимо вывести на печать
        /// TODO:Установка получения файла
        /// </summary>
        public string PathFileToPrint { get; set; }

        /// <summary>
        /// Word-приложение
        /// </summary>
        private Word.Application WordApp = new Word.Application {Visible = false};

        /// <summary>
        /// Документ
        /// </summary>
        private Word.Document WordDoc;
         
        /// <summary>
        /// Передача пути ффайла для печати
        /// </summary>
        /// <param name="path">Путь до файла</param>
        public ReportToPrint(string path)
        {
            PathFileToPrint = path;
            OpenDoc();
            ReportPrinting();
        }

        /// <summary>
        /// Печать документа
        /// </summary>
        public void ReportPrinting()
        {
            WordDoc.PrintOut();
        }

        /// <summary>
        /// Открытие документа
        /// </summary>
        private void OpenDoc()
        {
            object readOnly = false;
            object isVisible = false;
            WordDoc = WordApp.Documents.Open(PathFileToPrint, ReadOnly: readOnly, Visible: isVisible);
        }
    }
}
