using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSysDCAA.Core.Validation
{
    public static class FormChecker
    {
        private static Type _classType;
        private static Form _newForm;
        private static Type ClassType
        {
            get { return _classType; }
            set { _classType = value; }
        }
        private static readonly Dictionary<string, string> FormNamePresenter = new Dictionary<string, string>()
        {
            {"AboutOfSystem", "О системе"},
            {"SetingsApps", "Настройки системы"},
            {"Auth","Авторизация"}
        };

        private static string _nameOldForm;

        /// <summary>
        /// CreatedNewObjectByClassName - создает и возвращает экземпляр указанного типа, используя конструктор, 
        /// заданный для этого типа по умолчанию.
        /// </summary>
        /// <param name="className">Type - Имя класса</param>
        /// <remarks>Аргумент указывать в виде typeof(ClassName);</remarks>
        /// <returns>claaName object</returns>
        private static Object CreatedNewObjectByClassName(Type className)
        {
            return Activator.CreateInstance(className);
        }

        /// <summary>
        /// CreatedNewObjectByClassName - создает и возвращает экземпляр указанного типа, используя конструктор, 
        /// заданный для этого типа по умолчанию.
        /// </summary>
        /// <param name="className">Type - Имя класса</param>
        /// <param name="args">Аргументы для конструктора className </param>
        /// <returns></returns>
        private static Object CreatedNewObjectByClassName(Type className, object args)
        {
            return Activator.CreateInstance(className, args);
        }

        /// <summary>
        /// Осуществляет контроль открытых форм
        /// </summary>
        /// <param name="className">Имя класса формы</param>
        public static void ControlOpenedForm(Type className)
        {
            if (ClassType == null)
            {
                ClassType = className;
                _newForm = (Form)CreatedNewObjectByClassName(className);
                _nameOldForm = className.Name.ToString();
                _newForm.FormClosed += FormCloseFunction;
                _newForm.Show();
            }
            else
            {
                if (ClassType != className)
                {
                    MessageBox.Show(Convert.ToString("Что бы открыть форму \"" + GetNameForm(className.Name.ToString()) + "\" необходимо закрыть форму \"" + GetNameForm(_nameOldForm) + "\"\r\n"), "Ошибка открытия новой формы", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                _newForm.TopLevel = true;
                _newForm.TopMost = true;
                _newForm.WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Перегрузка контроля открытых форм - используем аргументы
        /// </summary>
        /// <param name="className">Имя класса формы</param>
        /// <param name="form">Форма</param>
        /// <param name="formControls">Массив Control'ов</param>
        public static void ControlOpenedForm(Type className, Form form, List<Control> formControls)
        {
            _newForm = (Form)CreatedNewObjectByClassName(className, formControls);
            _newForm.FormClosed += FormCloseFunctionExit;
            _newForm.Show();
            _newForm.TopLevel = true;
            _newForm.TopMost = true;
        }

        /// <summary>
        /// GetNameForm - позволяет получить "читаемое" имя формы.
        /// </summary>
        /// <param name="nameFormAsIs">String - имя формы "как есть"</param>
        /// <returns>"Читаемое" имя формы</returns>
        private static string GetNameForm(string difficultNameForm)
        {
            string easyNameForm = "";
            foreach (KeyValuePair<string, string> formName in FormNamePresenter)
            {
                if (difficultNameForm == formName.Key.ToString())
                {
                    easyNameForm = formName.Value.ToString();
                }
            }
            return easyNameForm;
        }

        /// <summary>
        /// SysinfoClose - Обработчик закрытия формы.
        /// Производит за'null'ение экземпляра формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void FormCloseFunction(object sender, FormClosedEventArgs e)
        {
            ClassType = null;
        }

        private static void FormCloseFunctionExit(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
