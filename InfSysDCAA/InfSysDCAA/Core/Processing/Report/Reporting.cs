using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfSysDCAA.Core.Directory;
using InfSysDCAA.Core.Processing.Devices;
using InfSysDCAA.Core.Processing.Test;
using System.Reflection;
using DocumentFormat.OpenXml.Drawing;
using Word = Microsoft.Office.Interop.Word;

namespace InfSysDCAA.Core.Processing.Report
{
    /// <summary>
    /// Формирование отчёта
    /// </summary>
    public class Reporting
    {
        /// <summary>
        /// Создание приложения Word
        /// </summary>
        private Word._Application WordApp = new Word.Application();
        
        /// <summary>
        /// Содержит результаты тестов
        /// </summary>
        TestDataStructure.TestDataStruct[] ResultDataStructure { get; set; }

        /// <summary>
        /// Содержит количество всех страниц
        /// </summary>
        private int CountAllPages { get; set; }

        /// <summary>
        /// Число страниц на одно устройство
        /// </summary>
        private const int CountPagesOneDevices = 4;

        /// <summary>
        /// Конструктор класса отчётов
        /// </summary>
        /// <param name="ResultData">Входные параметры теста, кортеж</param>
        public Reporting(TestDataStructure.TestDataStruct[] ResultData)
        {
            ResultDataStructure = ResultData;
            CreateWordFile();
        }

        /// <summary>
        /// Генерация отчёта
        /// </summary>
        public void ReportGeneration()
        {

        }

        private string GetDocumentPath()
        {
            string path = DirectoryList.DefaultPathList[2] + "\\reports.dotx";

            return path;
        }

        private string GetDocumentSavePath()
        {
            string path = DirectoryList.DefaultPathList[2];

            return path;
        }

        private void CreateWordFile()
        {
            WordApp.Visible = false;

            object missing = System.Reflection.Missing.Value;
            var WordDoc = WordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            CreateHeader(WordDoc);
            CreateFooter(WordDoc);
            for (int i =0; i < 10; i++)
            {
                CreateTable(1, 2, WordDoc);
            }

            WordDoc.SaveAs(GetTimeStamp() + ".docx");
            WordApp.Visible = true;
        }

        private void CreateHeader(Word.Document wordDocument)
        {
            foreach (Word.Section section in wordDocument.Sections)
            {
                Word.Range headerRange =
                section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = Word.WdColorIndex.wdBlack;
                headerRange.Font.Name = "Times new Roman";
                headerRange.Font.Size = 14;
                headerRange.Text = "АО ЦКБА";
            }
        }

        private void CreateFooter(Word.Document wordDocument)
        {
            //Добавление нижнего колонтитула
            foreach (Microsoft.Office.Interop.Word.Section wordSection in wordDocument.Sections)
            {
               Word.Range footerRange = wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                //Установка цвета текста
                footerRange.Font.ColorIndex = Word.WdColorIndex.wdBlack;
                //Размер
                footerRange.Font.Size = 14;
                //Установка расположения по центру
                footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                //Установка текста для вывода в нижнем колонтитуле
                footerRange.Text = "Информационная система сбора, анализа и обработки результатов " +
                                   Environment.NewLine +
                                   "встроенной системы контроля автоматизированной" +
                                   Environment.NewLine + "контрольно -испытательной аппаратуры";
            }
        }

        private void CreateTable(int rows, int columns, Word.Document wordDocument)
        {
            Word.Paragraph wordParag, wordParag2;
            Word.Table wordTable;

            wordParag = wordDocument.Paragraphs.Add(Type.Missing);


            wordTable = wordDocument.Tables.Add(wordParag.Range, rows, columns, Word.WdDefaultTableBehavior.wdWord9TableBehavior);
            Word.Range rngPic1 = wordDocument.Tables[1].Cell(1, 1).Range;
            Word.Range Text1 = wordDocument.Tables[1].Cell(1, 1).Range;
            object missing = System.Reflection.Missing.Value;

            rngPic1.InlineShapes.AddPicture(@"C:\Users\shamr\Desktop\ckba_logo.bmp", ref missing, ref missing, ref missing);
            wordParag2 = wordDocument.Tables[1].Cell(1, 1).Range.Paragraphs.Add(Type.Missing);
            wordParag2.Range.Text = "Центральное" + Environment.NewLine + "Конструкторское" + Environment.NewLine + "Бюро" + Environment.NewLine + "Автоматики";

            //Word.Cell cellRange = wordTable.Tables[1].Cell(1, 1);
            //cellRange.Range.InlineShapes.AddPicture(Properties.Resources.ckba_logo.ToString(), Type.Missing,
            //    Type.Missing, Type.Missing);
            //wordTable.Tables[1].Cell(1,1).Range.InlineShapes.AddPicture(@"C:\Users\shamr\Desktop\ckba_logo.bmp", Type.Missing, Type.Missing, Type.Missing);
            //foreach (Word.Row row in wordTable.Rows)
            //{
            //    foreach (Word.Cell cell in row.Cells)
            //    {
            //        if (row.Index == 1 && cell.RowIndex == 0)
            //        {
            //            cell.Range.InlineShapes.AddPicture(@"C:\Users\shamr\Desktop\ckba_logo.bmp", Type.Missing, Type.Missing, Type.Missing);
            //        }
            //    }
            //}
        }

        private void InsertLogoCKBAImage(Word.Table wordTable, Word.Document wordDocument)
        {
            Word.Range cellRange = wordTable.Tables[1].Cell(1, 1).Range;
            cellRange.InlineShapes.AddPicture(Properties.Resources.ckba_logo.ToString(), Type.Missing, Type.Missing, Type.Missing);
            //2.2

        }

        /// <summary>
        /// Получить штамп текущей даты и текущего времени
        /// </summary>
        /// <returns>String, штамп текущей даты и текущего времени</returns>
        private string GetTimeStamp()
        {
            string timeStamp;
            timeStamp = DateTime.Now.ToString();
            timeStamp = timeStamp.Replace(":", "-");
            timeStamp = timeStamp.Replace(".", "-");
            timeStamp = timeStamp.Replace(" ", "_");
            return timeStamp;
        }
    }
}
