using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfSysDCAA.Core.FTP
{
    /// <summary>
    /// Работа с FTP
    /// </summary>
    public class FTP
    {
        /// <summary>
        /// Хост подключения
        /// </summary>
        private string Host
        {
            get { return _host; }
            set { _host = value; }
        }

        /// <summary>
        /// Пользователь
        /// </summary>
        private string User
        {
            get { return _user; }
            set { _user = value; }            
        }

        /// <summary>
        /// Пароль
        /// </summary>
        private string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _host = null;
        private string _user = null;
        private string _password = null;

        /// <summary>
        /// Фтп-запрос
        /// </summary>
        private FtpWebRequest ftpRequest = null;

        /// <summary>
        /// Фтп-ответ
        /// </summary>
        private FtpWebResponse ftpResponse = null;

        /// <summary>
        /// поток
        /// </summary>
        private Stream ftpStream = null;

        /// <summary>
        /// Размер буфера
        /// </summary>
        //private int bufferSize = 32768;
        private int bufferSize = 2048;

        /// <summary>
        /// Конструктор класса FTP. 
        /// </summary>
        /// <param name="host">String - хост соединения</param>
        /// <param name="user">String - логин пользователя</param>
        /// <param name="password">String - Пароль пользователя</param>
        public FTP(string host, string user, string password)
        {
            Host = @"ftp://" + host;
            User = user;
            Password = password;
        }

        /// <summary>
        /// Тест соединения
        /// </summary>
        /// <returns></returns>
        public bool Test()
        {
            try
            {
                FtpWebRequest testRequest = (FtpWebRequest)WebRequest.Create(Host + "/");
                testRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                testRequest.Credentials = new NetworkCredential(User, Password);
                testRequest.GetResponse();
            }
            catch (WebException ex)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// Загружаем файл С FTP-сервера
        /// </summary>
        /// <param name="remoteFile">Адрес файла на стороне FTP-сервера</param>
        /// <param name="localFile">Адрес файла на локальной машине</param>
        public void Download(string remoteFile, string localFile)
        {
            try
            {
                /* Создать FTP-запрос */
                ftpRequest = (FtpWebRequest) FtpWebRequest.Create(Host + "/" + remoteFile);
                /* Войти на сервер с именем пользователя и паролем*/
                ftpRequest.Credentials = new NetworkCredential(User, Password);
                /* В случае сомнений использовать параметры: */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Тип FTP-запроса */
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                /* Установить обратную связь с FTP-сервером */
                ftpResponse = (FtpWebResponse) ftpRequest.GetResponse();
                /* Получить ответ в виде потока с FTP-сервера */
                ftpStream = ftpResponse.GetResponseStream();
                /* Открыть File Stream что бы записать загружаемый файл */
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                /* Буфер для загруженных данных */
                byte[] byteBuffer = new byte[bufferSize];
                int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                /* Скачивать файл путём записи буферезированных данных пока передача не завершена  */
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);

                        bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "При загрузке данных произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /* Очистка ресурсов */
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "При подключении к FTP-серверу произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        /// <summary>
        /// Выгружаем файл на FTP-сервер
        /// </summary>
        /// <param name="remoteFile">Адрес файла на стороне FTP-сервера</param>
        /// <param name="localFile">Адрес файла на локальной машине</param>
        public void upload(string remoteFile, string localFile)
        {
            try
            {
                /* Создать FTP-запрос */
                ftpRequest = (FtpWebRequest) FtpWebRequest.Create(Host + "/" + remoteFile);
                /* Войти на сервер с именем пользователя и паролем*/
                ftpRequest.Credentials = new NetworkCredential(User, Password);
                /* В случае сомнений использовать параметры: */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Тип FTP-запроса */
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                /* Установить обратную связь с FTP-сервером */
                ftpStream = ftpRequest.GetRequestStream();
                /* Открыть File Stream для чтения файла для выгрузки на FTP-сервер*/
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                /* Буфер для выгружаемых данных */
                byte[] byteBuffer = new byte[bufferSize];
                int bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                /* Выгрузка буферизированных данных, пока передача не завершена */
                try
                {
                    while (bytesSent != 0)
                    {
                        ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "При загрузке данных произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                /* Очищаем ресурсы */
                localFileStream.Close();
                ftpStream.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "При подключении к FTP-серверу произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }
    }
}
